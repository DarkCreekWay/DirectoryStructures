using System.Resources;

namespace DarkCreekWay.DirectoryStructures.CLI {

    static partial class Program {
        
        static ConfigurationService s_ConfigurationService;
        // static ResourceAssemblResolver s_ResourceAssemblResolver;

        static Program() {

            _= new ResourceAssemblResolver();
            s_ConfigurationService = new ConfigurationService();
        }

        public static void Main( string[] argv ) {

            if( argv.Length == 0 ) {
                Environment.Exit( Constants.s_ExitCode_ParameterCountIsUnsufficient );
            }

            string command = argv[0].ToLowerInvariant();
            bool useUI = false;

            switch( command ) {

                case Constants.s_CaptureCommandName: {

                    if( argv.Length < 2 ) {
                        Environment.ExitCode = Constants.s_ExitCode_CaptureDirectoryParameterMissing;
                        Environment.Exit(Constants.s_ExitCode_CaptureDirectoryParameterMissing);
                    }

                    Capture( argv[1] );
                    break;
                }

                case Constants.s_ApplyCommandName: {

                    if( argv.Length < 2 ) {
                        Environment.Exit( Constants.s_ExitCode_ApplyDirectoryParameterMissing );
                    }

                    // Evaluate optional parameters

                    // * --UI:true
                    //
                    // The application was invoked from e.g. Windows Explorer ContextMenu
                    // and indicates to use Dialogs/MessageBox for providing feedback to the user

                    if( argv.Length > 2 ) {
                        if( argv[2] == Constants.s_UseUILongOption ) {
                            useUI = true;
                        }
                    }

                    Apply( argv[1] , useUI );

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

                    WriteHelp();
                    Environment.Exit( Constants.s_ExitCode_Success );
                    break;
                }

                default:
                    WriteHelp();
                    Environment.Exit( Constants.s_ExitCode_CommandIsUnknown);
                    break;
            }
        }

        static void WriteHelp() {
            ShowMessage( Constants.s_L10n_HelpCaptionText, Constants.s_L10n_HelpMessageText );
        }

        static void ShowMessage( string captionResourceKey, string textResourceKey) {

            ResourceManager rm = new ResourceManager( $"{typeof( Program ).Namespace}.{Constants.s_L10n_Namespace}.{Constants.s_L10n_ResourceName}", typeof( Program ).Assembly );

            _ = Application.SetHighDpiMode( HighDpiMode.SystemAware );

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault( false );

            _ = MessageBox.Show( rm.GetString( textResourceKey ), rm.GetString( captionResourceKey ) );

        }
    }
}
