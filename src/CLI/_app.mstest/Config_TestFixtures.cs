using System;
using System.Diagnostics;
using System.IO;
using System.Text;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DarkCreekWay.DirectoryStructures.CLI {

    [TestClass]
    public class Config_TestFixtures {

        [TestMethod]
        public void GetUserSpecificConfigPathes() {

            ConfigurationService service = new ConfigurationService();

            Debug.WriteLine( $"User Config Base Path            (D) : {service.UserConfigBasePath}" );
            Debug.WriteLine( $"App User Config Base Path        (D) : {service.AppUserConfigBasePath}" );
            Debug.WriteLine( $"Captured Structures Base Path    (D) : {service.CapturedStructuresBasePath}" );
            Debug.WriteLine( $"Captured Structures Default Path (F) : {service.CapturedStructuresDefaultPath}" );

        }

        [TestMethod]
        public void WriteFileUsingTempFile() {

            string tempFileName = Path.GetTempFileName();

            using( FileStream fs = File.OpenWrite( tempFileName ) ) {

                using( StreamWriter writer = new StreamWriter( fs, Encoding.Unicode ) ) {
                    writer.WriteLine( "Hello World" );
                }
            }

            string targetFileName = Path.Combine( Environment.GetEnvironmentVariable( "temp" )!, ".default" );

            File.Move( tempFileName, targetFileName, true );
            Assert.IsTrue( File.Exists( targetFileName ) );

        }
    }
}
