using System.Diagnostics;

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

        static internal void Capture( string rootPath ) {

            if( false == Directory.Exists( rootPath ) ) {
                Environment.Exit( 1 );
            }

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

            // Possible improvements:
            //
            // Reduction of garbage collector preasure and memory usage
            // through pooling of queue instances.
            // -> Add stats to unpooled version and pooled version for
            // verification of the intended reduction.

            int maxStackSize = 0;

            int filledQueueCount = 0;
            int emptyQueueCount = 0;
            int queueSizeSum = 0;
            int maxQueueSize = 0;


            bool isRootPath = true;

            // current sub directory
            string current = rootPath;

            // queue of unvisited sibling nodes
            Queue<string> queue;

            // stack of unvisited nodes
            Stack<Queue<string>> stack = new Stack<Queue<string>>();

            do {

                // Visit current node

                if( false == isRootPath ) {

                    //Console.WriteLine( current.Substring( rootPath.Length + 1 ) );

                }
                else {
                    //Console.WriteLine( current );
                    isRootPath = false;
                }

                // Get sub directories from current as unvisited nodes.
                queue = new Queue<string>( Directory.EnumerateDirectories( current ) );

                if(queue.Count > 0) filledQueueCount++;
                if(queue.Count == 0) emptyQueueCount++;

                queueSizeSum += queue.Count;

                if( queue.Count > maxQueueSize ) maxQueueSize = queue.Count;

                // current has no child nodes
                // find next unvisited node
                if(queue.Count == 0) {

                    // no more unvisited nodes on the stack.
                    // Tree traversal completed
                    if(stack.Count == 0) {
                        break;
                    }

                    // Unvisited nodes on the stack.
                    // Continue tree traversal
                    queue = stack.Pop();
                }

                // Use next unvisted node from current as new current
                current = queue.Dequeue();

                // store remaining unvisited nodes on the stack.
                if(queue.Count > 0) {
                    stack.Push( queue );
                    if(stack.Count > maxStackSize) {
                        maxStackSize = stack.Count;
                    }
                }

            } while( true );

            Debug.WriteLine( $"Max. Stack Size    : {maxStackSize}" );
            Debug.WriteLine( $"Filled Queue Count : {filledQueueCount}" );
            Debug.WriteLine( $"Empty Queue Count  : {emptyQueueCount}" );
            Debug.WriteLine( $"Queue Size (Sum)   : {queueSizeSum}" );
            Debug.WriteLine( $"Queue Size (Avg)   : {(decimal)queueSizeSum / filledQueueCount}" );
            Debug.WriteLine( $"Max. Queue Size    : {maxQueueSize}" );
        }
    }
}
