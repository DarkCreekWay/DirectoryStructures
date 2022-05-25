using System.Resources;

namespace DarkCreekWay.DirectoryStructures.CLI {
    static partial class Program {

        static void WriteHelp() {

            ResourceManager rm = new ResourceManager( $"{typeof( Program ).Namespace}.{Constants.s_L10n_Namespace}.{Constants.s_L10n_ResourceName}", typeof( Program ).Assembly );

            _ = Application.SetHighDpiMode( HighDpiMode.SystemAware );
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault( false );

            _ = MessageBox.Show( rm.GetString( Constants.s_L10n_HelpMessageText ), rm.GetString( Constants.s_L10n_HelpCaptionText ) );
        }
    }
}
