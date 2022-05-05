
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DarkCreekWay.DirectoryStructures.CLI {
    [TestClass]
    public class Capture_TestFixtures {

        [TestMethod]
        public void Capture_TDD() {

            Program.Capture( "C:\\temp" );
            //Program.Capture( "z:\\Plex" );

        }
    }
}
