using System.Resources;

namespace DarkCreekWay.FileStructures.CLI {
    static partial class Program {

        static void WriteHelp() {

            ResourceManager rm = new ResourceManager( $"{typeof( MicrosoftWindowsIntegrationService ).Namespace}.{Constants.s_L10n_Namespace}.{Constants.s_L10n_ResourceName}", typeof( MicrosoftWindowsIntegrationService ).Assembly );

            Application.SetHighDpiMode( HighDpiMode.SystemAware );
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault( false );

            MessageBox.Show( rm.GetString( Constants.s_L10n_HelpMessageText ), rm.GetString( Constants.s_L10n_HelpCaptionText ) );
        }
    }
}
