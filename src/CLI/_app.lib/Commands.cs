#define POOLING

using System.Text;

namespace DarkCreekWay.DirectoryStructures.CLI {

    public static class Commands {

        static ConfigurationService s_ConfigurationService;

        static Commands() {
            s_ConfigurationService = new ConfigurationService();
        }

        public static Action? OutputHelpAction { get; set; }
        public static Action<string, string>? OutputMessageAction { get; set; }

        public static void ProcessArgs( string[] argv ) {

            if( argv.Length == 0 ) {
                Environment.Exit( Constants.s_ExitCode_ParameterCountIsUnsufficient );
            }

            string command = argv[0].ToLowerInvariant();

            switch( command ) {

                case Constants.s_CaptureCommandName: {

                    if( argv.Length < 2 ) {
                        Environment.ExitCode = Constants.s_ExitCode_CaptureDirectoryParameterMissing;
                        Environment.Exit( Constants.s_ExitCode_CaptureDirectoryParameterMissing );
                    }

                    Capture( argv[1] );

                    break;
                }

                case Constants.s_ApplyCommandName: {

                    if( argv.Length < 2 ) {
                        Environment.Exit( Constants.s_ExitCode_ApplyDirectoryParameterMissing );
                    }

                    Apply( argv[1] );

                    break;
                }

                case Constants.s_HelpCommandName:
                case Constants.s_HelpLongOption:
                case Constants.s_HelpLongQMarkOption:
                case Constants.s_HelpShortOption:
                case Constants.s_HelpShortQMarkOption:
                case Constants.s_HelpLongWindowsOption:
                case Constants.s_HelpQMarkWindowsOption:
                case Constants.s_HelpShortWindowsOption: {

                    OutputHelpAction?.Invoke();
                    Environment.Exit( Constants.s_ExitCode_Success );
                    break;
                }

                default:
                    OutputHelpAction?.Invoke();
                    Environment.Exit( Constants.s_ExitCode_CommandIsUnknown );
                    break;
            }
        }

        static internal void Apply( string basePath ) {

            if( false == Directory.Exists( basePath ) ) {

                Environment.Exit( Constants.s_ExitCode_DirectoryDoesNotExist );
            }

            if( false == File.Exists( s_ConfigurationService.CapturedStructuresDefaultPath ) ) {

                OutputMessageAction?.Invoke( Constants.s_L10n_CapturedDirectoryStructureNotFoundCaption, Constants.s_L10n_CapturedDirectoryStructureNotFoundText );

                Environment.Exit( Constants.s_ExitCode_CapturedDirectoryStructureNotFound );
            }

            ReadOnlySpan<char> normalizedBasePath = string.Concat( basePath.AsSpan(), Path.DirectorySeparatorChar.ToString().AsSpan() );

            using( FileStream fs = File.OpenRead( s_ConfigurationService.CapturedStructuresDefaultPath ) ) {

                using( StreamReader reader = new StreamReader( fs ) ) {

                    while( !reader.EndOfStream ) {
                        ReadOnlySpan<char> path = reader.ReadLine().AsSpan();
                        _ = Directory.CreateDirectory( string.Concat( normalizedBasePath, path ) );
                    }
                }
            }
        }

        
        const int s_StackSize = 8;
#if POOLING
        const int s_QueueSize = 32;
        const int s_PoolSize = 8;

#endif

        static internal void Capture( string rootPath ) {

            if( !Directory.Exists( s_ConfigurationService.CapturedStructuresBasePath ) ) {
                _ = Directory.CreateDirectory( s_ConfigurationService.CapturedStructuresBasePath );
            }

            string tempFileName = Path.GetTempFileName();

            using( FileStream fs = File.OpenWrite( tempFileName ) ) {

                using( StreamWriter writer = new StreamWriter( fs, Encoding.Unicode ) ) {
                    Capture( rootPath, writer );
                }
            }

            File.Move( tempFileName, s_ConfigurationService.CapturedStructuresDefaultPath, true );
        }

        static internal void Capture( string rootPath, TextWriter writer ) {

            if( false == Directory.Exists( rootPath ) ) {
                Environment.Exit( 1 );
            }

            int pathOffset = rootPath.Length + 1;

            // Pre-order tree traversal of n-ary tree
            //
            // Points of interest:
            //
            // - The child nodes of the current node are not known in advance.
            //     -> Number of child nodes is unknown
            //     -> Child nodes are retrieved, as needed.
            //     -> Eliminates the requirement to load or build the full tree first.
            //        -> Suitable to process large trees.
            // - Iterative processing
            //
            // Improvements:
            //
            // Reduction of garbage collector preasure and memory usage
            // through pooling of queue instances, which reduces queue object
            // creations

#if POOLING

            // Create pool of queue objects
            Stack<Queue<string>> pool = new Stack<Queue<string>>( s_PoolSize );

            for( int i = 0; i < s_PoolSize; i++ ) {
                pool.Push( new Queue<string>( s_QueueSize ) );
            }
#endif
            // Init tree traversal
            string current = rootPath; // set current node to root node
            bool isRoot = true;     // track special case of root node

            // stack of unvisited nodes
            Stack<Queue<string>> stack = new Stack<Queue<string>>( s_StackSize );

            // current queue of unvisited nodes (siblings)
            Queue<string> queue;

            // Traverse tree
            do {

                // Visit current node

                if( false == isRoot ) {

                    //Console.WriteLine( current.Substring( rootPath.Length + 1 ) );
                    writer.WriteLine( current.AsSpan( pathOffset ) );

                }
                else {
                    //Console.WriteLine( current );
                    isRoot = false;
                }

                // Get and store child nodes of current node as unvisited nodes.
#if POOLING
                if( pool.Count != 0 ) {
                    queue = pool.Pop();

                    foreach( string path in Directory.EnumerateDirectories( current ) ) {
                        queue.Enqueue( path );
                    }
                }
                else {
                    queue = new Queue<string>( Directory.EnumerateDirectories( current ) );
                }
#else
                queue = new Queue<string>( Directory.EnumerateDirectories( current ) );
#endif

                // current node has no child nodes
                // find next unvisited node
                if( queue.Count == 0 ) {

                    // no more unvisited nodes on the stack.
                    // Tree traversal completed
                    if( stack.Count == 0 ) {
                        break;
                    }
#if POOLING
                    pool.Push( queue );
#endif
                    // Unvisited nodes on the stack.
                    // Continue tree traversal
                    queue = stack.Pop();
                }

                // Use next unvisted node from current as new current
                current = queue.Dequeue();

                // store remaining unvisited nodes on the stack.
                if( queue.Count > 0 ) {
                    stack.Push( queue );
                }
                else {
#if POOLING
                    pool.Push( queue );
#endif
                }
            } while( true );
        }
    }
}
