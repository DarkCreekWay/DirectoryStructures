using System.Diagnostics;
using System.Resources;

namespace DarkCreekWay.FileStructures.CLI {
    static partial class Program {

        const string s_L10n_Namespace = "L10n";
        const string s_L10n_ResourceName = "Resources";

        static void WriteHelp() {

            Process p = Process.GetCurrentProcess();

            // how to get the parent process
            // https://github.com/QutEcoacoustics/audio-analysis/pull/304/files#diff-1c66a35265e23f97533d5bee1becfe759f4247578b5dbc319256aed292a6e670

            string moduleName = p.MainModule.ModuleName;
            ResourceManager rm = new ResourceManager( $"{typeof( MicrosoftWindowsIntegrationService ).Namespace}.{s_L10n_Namespace}.{s_L10n_ResourceName}", typeof( MicrosoftWindowsIntegrationService ).Assembly );

            //(int oldLeft,int oldTop) = Console.GetCursorPosition();

            bool isConsoleOutputRedirected = Console.IsOutputRedirected;

            Stream stream = Console.OpenStandardOutput();
            StreamWriter sw = new StreamWriter( stream );
            sw.AutoFlush = true;
            Console.SetOut( sw );

            ConsoleHelper.AttachConsole();
            // Clear command prompt since windows thinks we are a windowing app
            ConsoleHelper.ClearLine();
            Console.WriteLine( isConsoleOutputRedirected );
            //Console.WriteLine( oldLeft );
            //Console.WriteLine( oldTop );
            Console.WriteLine( moduleName );

            //Console.WriteLine();
            Console.WriteLine( rm.GetString( "Help.Text" ) );
            //Console.WriteLine( "\n" );
            //Console.WriteLine();

            //Console.WriteLine( "Line 1" );
            //Console.WriteLine( "Line 2" );

            //MessageBox.Show( "Hello from the Help" );
            //Application.DoEvents();

            (int newLeft, int newTop) = Console.GetCursorPosition();
            //Console.WriteLine( newLeft );
            //Console.WriteLine( newTop );
            Console.WriteLine(newTop);
            //Console.CursorTop = newTop;
            ConsoleHelper.FreeConsole();
            //Console.CursorTop = line;
            //SendKeys.SendWait( "\r\n\r\n\r\n" );
            SendKeys.SendWait( "{ENTER}" );
        }
    }
}
