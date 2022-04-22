using System;
using System.Diagnostics;
using System.IO;
using System.Text;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DarkCreekWay.FileStructures.CLI {

    [TestClass]
    public class Config_TestFixtures {

        const string s_CompanyDirectoryName = "DarkCreekWay";
        const string s_ProductDirectoryName = "FileStructures";
        const string s_CapturedStructuresDirectoryName = "Captured";
        const string s_DefaultCapturedStructuresFilename = ".default";

        [TestMethod]
        public void BuildUserSpecificConfigPathes() {

            string userConfigBasePath = Environment.GetFolderPath( Environment.SpecialFolder.LocalApplicationData );

            string appUserConfigBasePath = Path.Combine( userConfigBasePath, s_CompanyDirectoryName, s_ProductDirectoryName );
            string capturedStructuresBasePath = Path.Combine( appUserConfigBasePath, s_CapturedStructuresDirectoryName );
            string capturedStructuresDefaultPath = Path.Combine( capturedStructuresBasePath, s_DefaultCapturedStructuresFilename );

            Debug.WriteLine( $"User Config Base Path            (D) : {userConfigBasePath}" );
            Debug.WriteLine( $"App User Config Base Path        (D) : {appUserConfigBasePath}" );
            Debug.WriteLine( $"Captured Structures Base Path    (D) : {capturedStructuresBasePath}" );
            Debug.WriteLine( $"Captured Structures Default Path (F) : {capturedStructuresDefaultPath}" );

        }

        [TestMethod]
        public void WriteFileUsingTempFile() {

            string tempFileName = Path.GetTempFileName();

            using( FileStream fs = File.OpenWrite( tempFileName ) ) {

                using( StreamWriter writer = new StreamWriter( fs , Encoding.Unicode) ) {
                    writer.WriteLine( "Hello World" );
                }
            }

            string targetFileName = Path.Combine( Environment.GetEnvironmentVariable( "temp" ), ".default" );
            File.Move( tempFileName, targetFileName, true );
            Assert.IsTrue( File.Exists( targetFileName ) );

        }
    }
}
