
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Win32;

namespace DarkCreekWay.FileStructures.CLI {

    [TestClass]
    public class Registry_TestFixtures {

        [TestMethod]
        public void Register_TDD() {

            using( RegistryKey hkcu = RegistryKey.OpenBaseKey( RegistryHive.CurrentUser, RegistryView.Default ) ) {

                using( RegistryKey shell = hkcu.OpenSubKey( "SOFTWARE\\Classes\\Directory\\shell", true ) ) {
                    using( RegistryKey verb = shell.CreateSubKey( "DarkCreekWay.FolderStructures", true ) ) {

                        verb.SetValue( "MultiSelectModel", "Single", RegistryValueKind.String );
                        verb.SetValue( "MUIVerb", "DCW Folder Structure", RegistryValueKind.String );
                        verb.SetValue( "ExtendedSubCommandsKey", "Directory\\shell\\DarkCreekWay.FolderStructures", RegistryValueKind.String );

                        using( RegistryKey apply = verb.CreateSubKey( "shell\\Apply", true ) ) {
                            apply.SetValue( "MUIVerb", "Anwenden", RegistryValueKind.String );
                            using( RegistryKey applyCommand = apply.CreateSubKey( "command", true ) ) {
                                applyCommand.SetValue( "", "p:\\FileStructures\\src\\CLI\\_app\\bin\\Debug\\net6.0\\fs.exe apply \"%1\"", RegistryValueKind.String );
                            }

                        }

                        using( RegistryKey capture = verb.CreateSubKey( "shell\\Capture", true ) ) {
                            capture.SetValue( "MUIVerb", "Merken", RegistryValueKind.String );
                            using( RegistryKey captureCommand = capture.CreateSubKey( "command", true ) ) {
                                captureCommand.SetValue( "", "p:\\FileStructures\\src\\CLI\\_app\\bin\\Debug\\net6.0\\fs.exe capture \"%1\"", RegistryValueKind.String );
                            }
                        }
                    }
                }
            }
        }

        [TestMethod]
        public void Unregister_TDD() {

            using( RegistryKey hkcu = RegistryKey.OpenBaseKey( RegistryHive.CurrentUser, RegistryView.Default ) ) {

                using( RegistryKey shell = hkcu.OpenSubKey( "SOFTWARE\\Classes\\Directory\\shell", true ) ) {

                    shell.DeleteSubKeyTree( "DarkCreekWay.FolderStructures", false );

                }
            }
        }
    }
}
