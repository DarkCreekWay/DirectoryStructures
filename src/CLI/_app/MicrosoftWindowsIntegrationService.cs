using System.Diagnostics;

using Microsoft.Win32;

namespace DarkCreekWay.FileStructures.CLI {

    [System.Diagnostics.CodeAnalysis.SuppressMessage( "Interoperability", "CA1416:Validate platform compatibility", Justification = "<Ausstehend>" )]
    class MicrosoftWindowsIntegrationService {

        const string s_ClassesRegKeyPath = "SOFTWARE\\Classes";
        const string s_ProgIdRegKeyName = "Directory\\shell";

        const string s_ShellCommandRegKeyName     = "command";

        const string s_MuiVerbRegValName          = "MUIVerb";

        const string s_MultiSelectModelRegValName = "MultiSelectModel";
        const string s_MultiSelectModelRegValData = "Single";

        const string s_ExtendedSubCommandsKeyRegValName = "ExtendedSubCommandsKey";
        const string s_ExtendedSubCommandsKeyRegValData = s_ProgIdRegKeyName + "\\" + s_VerbRegKeyName;

        const string s_VerbBaseRegKeyPath = s_ClassesRegKeyPath + "\\" + s_ProgIdRegKeyName;

        const string s_VerbRegKeyName        = "DarkCreekWay.FolderStructures";
        const string s_CaptureVerbRegKeyPath = "shell\\Capture";
        const string s_ApplyVerbRegKeyPath   = "shell\\Apply";

        const string s_VerbText              = "Ordnerstruktur";
        const string s_CaptureVerbText       = "Merken";
        const string s_ApplyVerbText         = "Anwenden";

        public void Register() {

            string executablePath = Process.GetCurrentProcess().MainModule.FileName;
            string captureCommandLine = string.Concat( "\"", executablePath, "\"", " ", Constants.s_CaptureCommandName, " ", "\"%1\"" );
            string applyCommandLine = string.Concat( "\"", executablePath, "\"", " ", Constants.s_ApplyCommandName, " ", "\"%1\"" );

            using( RegistryKey hkcu = RegistryKey.OpenBaseKey( RegistryHive.CurrentUser, RegistryView.Default ) ) {

                using( RegistryKey shell = hkcu.OpenSubKey( s_VerbBaseRegKeyPath, true ) ) {

                    using( RegistryKey verb = shell.CreateSubKey( s_VerbRegKeyName, true ) ) {

                        verb.SetValue( s_MultiSelectModelRegValName, s_MultiSelectModelRegValData, RegistryValueKind.String );
                        verb.SetValue( s_MuiVerbRegValName, s_VerbText, RegistryValueKind.String );
                        verb.SetValue( s_ExtendedSubCommandsKeyRegValName, s_ExtendedSubCommandsKeyRegValData, RegistryValueKind.String );

                        using( RegistryKey apply = verb.CreateSubKey( s_ApplyVerbRegKeyPath, true ) ) {

                            apply.SetValue( s_MuiVerbRegValName, s_ApplyVerbText, RegistryValueKind.String );

                            using( RegistryKey applyCommand = apply.CreateSubKey( s_ShellCommandRegKeyName, true ) ) {
                                applyCommand.SetValue( "", applyCommandLine, RegistryValueKind.String );
                            }
                        }

                        using( RegistryKey capture = verb.CreateSubKey( s_CaptureVerbRegKeyPath, true ) ) {

                            capture.SetValue( s_MuiVerbRegValName, s_CaptureVerbText, RegistryValueKind.String );

                            using( RegistryKey captureCommand = capture.CreateSubKey( s_ShellCommandRegKeyName, true ) ) {

                                captureCommand.SetValue( "", captureCommandLine, RegistryValueKind.String );
                            }
                        }
                    }
                }
            }
        }

        public void Unregister() {

            using( RegistryKey hkcu = RegistryKey.OpenBaseKey( RegistryHive.CurrentUser, RegistryView.Default ) ) {

                using( RegistryKey shell = hkcu.OpenSubKey( s_VerbBaseRegKeyPath, true ) ) {

                    shell.DeleteSubKeyTree( s_VerbRegKeyName, false );
                }
            }
        }
    }
}
