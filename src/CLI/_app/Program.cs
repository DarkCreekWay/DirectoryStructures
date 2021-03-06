using System.Resources;

namespace DarkCreekWay.DirectoryStructures.CLI {

    static partial class Program {

        static Program() {
            _= new ResourceAssemblResolver();
        }

        public static void Main( string[] argv ) {

            Commands.OutputHelpAction = WriteHelp;
            Commands.OutputMessageAction = ShowMessage;
            Commands.ProcessArgs( argv );

        }

        static void WriteHelp() {
            ShowMessage( Constants.s_L10n_HelpCaptionText, Constants.s_L10n_HelpMessageText );
        }

        static void ShowMessage( string captionResourceKey, string textResourceKey) {

            ResourceManager rm = new ResourceManager( $"{typeof( Commands ).Namespace}.{Constants.s_L10n_Namespace}.{Constants.s_L10n_ResourceName}", typeof( Commands ).Assembly );

            Console.WriteLine( rm.GetString( captionResourceKey ) );
            Console.WriteLine( rm.GetString( textResourceKey ) );

        }
    }
}
