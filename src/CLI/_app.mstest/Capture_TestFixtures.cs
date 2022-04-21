using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DarkCreekWay.FileStructures.CLI
{
    [TestClass]
    public class Capture_TestFixtures
    {

        [TestMethod]
        public void Capture_TDD() {

            Program.Capture( "C:\\temp" );
            //Program.Capture( "z:\\Plex" );

            // No object pooling
            // Capture_TDD
            // Quelle: Capture_TestFixtures.cs Zeile 16
            // Dauer: 734 ms
            // Debug Trace:
            // Max.Stack Size     : 9
            // Filled Queue Count : 2355
            // Empty Queue Count  : 5884
            // Queue Size( Sum)   : 8238
            // Queue Size( Avg)   : 3,4980891719745222929936305732
            // Max.Queue Size     : 257
        }

    }
}
