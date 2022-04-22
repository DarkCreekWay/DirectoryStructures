using System.IO;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DarkCreekWay.FileStructures.CLI {

    [TestClass]
    public class Apply_TestFixtures {

        [TestMethod]
        public void Apply_TDD() {

            string targetPath = "c:\\temp\\FSTestTarget";
            Directory.CreateDirectory( targetPath );

            Program.Apply( targetPath );

        }

    }
}
