using System.Diagnostics;

using Microsoft.Win32;

namespace DarkCreekWay.FileStructures.CLI {
    class MicrosoftWindowsIntegrationService {

        public void Register() {

            string executablePath = Process.GetCurrentProcess().MainModule.FileName;
            string captureCommandLine = string.Concat( "\"", executablePath, "\"", " ", "capture", " ", "\"%1\"" );
            string applyCommandLine = string.Concat( "\"", executablePath, "\"", " ", "apply", " ", "\"%1\"" );

            using( RegistryKey hkcu = RegistryKey.OpenBaseKey( RegistryHive.CurrentUser, RegistryView.Default ) ) {

                using( RegistryKey shell = hkcu.OpenSubKey( "SOFTWARE\\Classes\\Directory\\shell", true ) ) {
                    using( RegistryKey verb = shell.CreateSubKey( "DarkCreekWay.FolderStructures", true ) ) {

                        verb.SetValue( "MultiSelectModel", "Single", RegistryValueKind.String );
                        verb.SetValue( "MUIVerb", "DCW Folder Structure", RegistryValueKind.String );
                        verb.SetValue( "ExtendedSubCommandsKey", "Directory\\shell\\DarkCreekWay.FolderStructures", RegistryValueKind.String );

                        using( RegistryKey apply = verb.CreateSubKey( "shell\\Apply", true ) ) {
                            apply.SetValue( "MUIVerb", "Anwenden", RegistryValueKind.String );
                            using( RegistryKey applyCommand = apply.CreateSubKey( "command", true ) ) {
                                applyCommand.SetValue( "", applyCommandLine, RegistryValueKind.String );
                            }

                        }

                        using( RegistryKey capture = verb.CreateSubKey( "shell\\Capture", true ) ) {
                            capture.SetValue( "MUIVerb", "Merken", RegistryValueKind.String );
                            using( RegistryKey captureCommand = capture.CreateSubKey( "command", true ) ) {
                                captureCommand.SetValue( "", captureCommandLine, RegistryValueKind.String );
                            }
                        }
                    }
                }
            }
        }

        public void Unregister() {

            using( RegistryKey hkcu = RegistryKey.OpenBaseKey( RegistryHive.CurrentUser, RegistryView.Default ) ) {

                using( RegistryKey shell = hkcu.OpenSubKey( "SOFTWARE\\Classes\\Directory\\shell", true ) ) {

                    shell.DeleteSubKeyTree( "DarkCreekWay.FolderStructures", false );
                }
            }
        }
    }
}
