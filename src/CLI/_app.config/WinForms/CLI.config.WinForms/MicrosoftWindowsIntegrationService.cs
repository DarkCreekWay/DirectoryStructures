using System.Diagnostics.CodeAnalysis;
using System.Resources;

using Microsoft.Win32;

namespace DarkCreekWay.DirectoryStructures.CLI {

    class MicrosoftWindowsIntegrationService {

        const string s_ClassesRegKeyPath = "SOFTWARE\\Classes";
        const string s_ProgIdRegKeyName = "Directory\\shell";

        const string s_ShellCommandRegKeyName = "command";

        const string s_MuiVerbRegValName = "MUIVerb";

        const string s_MultiSelectModelRegValName = "MultiSelectModel";
        const string s_MultiSelectModelRegValData = "Single";

        const string s_ExtendedSubCommandsKeyRegValName = "ExtendedSubCommandsKey";
        const string s_ExtendedSubCommandsKeyRegValData = s_ProgIdRegKeyName + "\\" + s_VerbRegKeyName;

        const string s_VerbBaseRegKeyPath = s_ClassesRegKeyPath + "\\" + s_ProgIdRegKeyName;

        const string s_VerbRegKeyName = $"{Constants.s_CompanyIdentifier}.{Constants.s_ProductIdentifier}";
        const string s_CaptureVerbRegKeyPath = "shell\\Capture";
        const string s_ApplyVerbRegKeyPath = "shell\\Apply";

        [SuppressMessage( "Performance", "CA1822:Mark members as static", Justification = "A future factory shall create this type when run on Windows and so needs to be an instance member" )]
        public void Register() {

            string executablePath = GetExecutablePath();

            if( !File.Exists( executablePath ) ) {
                throw new FileNotFoundException();
            }

            ResourceManager rm = new ResourceManager( $"{typeof( Constants ).Namespace}.{Constants.s_L10n_Namespace}.{Constants.s_L10n_ResourceName}", typeof( Constants ).Assembly );

            string captureCommandLine = string.Concat( "\"", executablePath, "\"", " ", Constants.s_CaptureCommandName, " ", "\"%1\"" );
            string applyCommandLine = string.Concat( "\"", executablePath, "\"", " ", Constants.s_ApplyCommandName, " ", "\"%1\"" );

            using( RegistryKey? hkcu = RegistryKey.OpenBaseKey( RegistryHive.CurrentUser, RegistryView.Default ) ) {

                using( RegistryKey? shell = hkcu.OpenSubKey( s_VerbBaseRegKeyPath, true ) ) {

                    if( shell == null ) {
                        throw new NullReferenceException();
                    }

                    using( RegistryKey verb = shell.CreateSubKey( s_VerbRegKeyName, true ) ) {

                        verb.SetValue( s_MultiSelectModelRegValName, s_MultiSelectModelRegValData, RegistryValueKind.String );
                        verb.SetValue( s_MuiVerbRegValName, rm.GetString( Constants.s_L10n_ContextMenuText )!, RegistryValueKind.String );
                        verb.SetValue( s_ExtendedSubCommandsKeyRegValName, s_ExtendedSubCommandsKeyRegValData, RegistryValueKind.String );

                        using( RegistryKey apply = verb.CreateSubKey( s_ApplyVerbRegKeyPath, true ) ) {

                            apply.SetValue( s_MuiVerbRegValName, rm.GetString( Constants.s_L10n_ApplyCommandText )!, RegistryValueKind.String );

                            using( RegistryKey applyCommand = apply.CreateSubKey( s_ShellCommandRegKeyName, true ) ) {

                                applyCommand.SetValue( "", applyCommandLine, RegistryValueKind.String );
                            }
                        }

                        using( RegistryKey capture = verb.CreateSubKey( s_CaptureVerbRegKeyPath, true ) ) {

                            capture.SetValue( s_MuiVerbRegValName, rm.GetString( Constants.s_L10n_CaptureCommandText )!, RegistryValueKind.String );

                            using( RegistryKey captureCommand = capture.CreateSubKey( s_ShellCommandRegKeyName, true ) ) {

                                captureCommand.SetValue( "", captureCommandLine, RegistryValueKind.String );
                            }
                        }
                    }
                }
            }
        }

        [SuppressMessage( "Performance", "CA1822:Mark members as static", Justification = "A future factory shall create this type when run on Windows and needs to be an instance member" )]
        public void Unregister() {

            using( RegistryKey? hkcu = RegistryKey.OpenBaseKey( RegistryHive.CurrentUser, RegistryView.Default ) ) {

                using( RegistryKey? shell = hkcu.OpenSubKey( s_VerbBaseRegKeyPath, true ) ) {

                    if( null == shell ) {
                        throw new NullReferenceException();
                    }

                    shell.DeleteSubKeyTree( s_VerbRegKeyName, false );
                }
            }
        }

        static string GetExecutablePath() {

#if NET6_0_OR_GREATER
            string? executablePath = Environment.ProcessPath;
#else
            string? executablePath = Process.GetCurrentProcess().MainModule.FileName;
#endif
            if( string.IsNullOrEmpty( executablePath ) ) throw new NullReferenceException();

            string? basePath = Path.GetDirectoryName( executablePath );
            return Path.Combine( basePath!, "ds.shell.exe" );

        }
    }
}
