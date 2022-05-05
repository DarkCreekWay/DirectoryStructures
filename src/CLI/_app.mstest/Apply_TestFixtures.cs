using System.IO;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DarkCreekWay.DirectoryStructures.CLI {

    [TestClass]
    public class Apply_TestFixtures {

        [TestMethod]
        public void Apply_TDD() {

            string targetPath = "c:\\temp\\FSTestTarget";
            _ = Directory.CreateDirectory( targetPath );

            Program.Apply( targetPath );

        }
    }
}
