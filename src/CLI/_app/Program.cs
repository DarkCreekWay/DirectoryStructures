namespace DarkCreekWay.DirectoryStructures.CLI {

    static partial class Program {

        static ConfigurationService s_ConfigurationService;

        static Program() {

            s_ConfigurationService = new ConfigurationService();
        }

        public static void Main( string[] argv ) {

            if( argv.Length == 0 ) {
                Environment.Exit( Constants.s_ExitCode_ParameterCountIsUnsufficient );
            }

            string command = argv[0].ToLowerInvariant();

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
    }
}
