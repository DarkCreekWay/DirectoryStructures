﻿#define POOLING

using System.Text;

namespace DarkCreekWay.FileStructures.CLI {

    static class Program {

        static ConfigurationService s_ConfigurationService;

        static Program() {
            s_ConfigurationService = new ConfigurationService();
        }

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

            if( argv[0].ToLowerInvariant() == "apply") {
                if( argv.Length < 2) {
                    Environment.Exit( 1 );
                }

                Apply( argv[1] );
            }
        }

        static internal void Apply( string basePath ) {

            if( false == Directory.Exists( basePath ) ) {
                Environment.Exit( 1 );
            }

            if(false == File.Exists( s_ConfigurationService.CapturedStructuresDefaultPath ) ) {
                Environment.Exit( 1 );
            }

            ReadOnlySpan<char> normalizedBasePath = string.Concat( basePath.AsSpan(), Path.DirectorySeparatorChar.ToString().AsSpan() );

            using( FileStream fs = File.OpenRead( s_ConfigurationService.CapturedStructuresDefaultPath ) ) {

                using( StreamReader reader = new StreamReader( fs )) {

                    while(!reader.EndOfStream ) {
                        ReadOnlySpan<char> path = reader.ReadLine().AsSpan();
                        Directory.CreateDirectory( string.Concat( normalizedBasePath, path ) );
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

            string tempFileName = Path.GetTempFileName();

            using( FileStream fs = File.OpenWrite( tempFileName ) ) {

                using( StreamWriter writer = new StreamWriter( fs, Encoding.Unicode ) ) {
                    Capture( rootPath, writer );
                }
            }

            if(!Directory.Exists( s_ConfigurationService.CapturedStructuresBasePath)) {
                _ = Directory.CreateDirectory( s_ConfigurationService.CapturedStructuresBasePath );
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
