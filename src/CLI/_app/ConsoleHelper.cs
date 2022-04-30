using System.ComponentModel;
using System.Runtime.InteropServices;

using Microsoft.Win32.SafeHandles;

namespace DarkCreekWay.FileStructures.CLI {
    static class ConsoleHelper {

        private const int STD_OUTPUT_HANDLE = -11;

        [DllImport( "kernel32.dll", EntryPoint = "AllocConsole", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall )]
        public static extern bool AllocConsole();

        [DllImport( "kernel32.dll", EntryPoint = "GetStdHandle", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall )]
        public static extern IntPtr GetStdHandle( int nStdHandle );
        [DllImport( "kernel32.dll" )]
        static extern bool AttachConsole( uint dwProcessId );

        internal static void AttachConsole() {

            if( !AttachConsole( 0xFFFFFFFF ) ) {
                if( !AllocConsole() ) {
                    throw new Win32Exception();
                }
            }

            IntPtr stdHandle = GetStdHandle( STD_OUTPUT_HANDLE );
            SafeFileHandle safeFileHandle = new Microsoft.Win32.SafeHandles.SafeFileHandle( stdHandle, true );
            FileStream fileStream = new FileStream( safeFileHandle, FileAccess.Write );
            StreamWriter standardOutput = new StreamWriter( fileStream );
            standardOutput.AutoFlush = true;
            Console.SetOut( standardOutput );
        }

        [DllImport( "kernel32.dll", SetLastError = true )]
        internal static extern bool FreeConsole();

        public static void ClearLine() {
            //Console.SetCursorPosition( 0, top );
            Console.CursorLeft = 0;
            //Console.Write( "\r" );
            Console.Write( new string( ' ', Console.BufferWidth ) );
            //Console.Write( "\r" );
            //Console.SetCursorPosition( 0, top );
            Console.CursorLeft = 0;
            //Console.WriteLine( "0x1b[1M" );
        }
    }
}