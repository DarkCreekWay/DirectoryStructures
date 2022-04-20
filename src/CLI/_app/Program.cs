namespace DarkCreekWay.FileStructures.CLI {

    static class Program {

        public static void Main( string[] argv ) {

            if( argv.Length == 0 ) {
                Environment.Exit( 1 );
            }

            if( argv[0].ToLowerInvariant() == "capture" ) {

                if( argv.Length < 2 ) {
                    Environment.Exit( 1 );
                }

                Capture( argv[1] );

            }

        }

        static void Capture( string rootPath ) {

            if( false == Directory.Exists( rootPath ) ) {
                Environment.Exit( 1 );
            }

            Console.WriteLine( $"Capturing : {rootPath}" );
            Console.ReadLine();

            throw new NotImplementedException();
        }
    }
}
