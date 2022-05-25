using System.Text;
using System.Resources;

namespace DarkCreekWay.DirectoryStructures.CLI {

    public static class Program {

        static Program() {
            _ = new ResourceAssemblResolver();
        }

        public static void Main( string[] argv ) {

            Commands.OutputHelpAction = WriteHelp;
            Commands.OutputMessageAction = ShowMessage;
            Commands.ProcessArgs( argv );

        }

        static void WriteHelp() {
            ShowMessage( Constants.s_L10n_HelpCaptionText, Constants.s_L10n_HelpMessageText );
        }

        static void ShowMessage( string captionResourceKey, string textResourceKey ) {

            ResourceManager rm = new ResourceManager( $"{typeof( Commands ).Namespace}.{Constants.s_L10n_Namespace}.{Constants.s_L10n_ResourceName}", typeof( Commands ).Assembly );

            _ = Application.SetHighDpiMode( HighDpiMode.SystemAware );

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault( false );

            _ = MessageBox.Show( rm.GetString( textResourceKey ), rm.GetString( captionResourceKey ) );

        }
    }
}
