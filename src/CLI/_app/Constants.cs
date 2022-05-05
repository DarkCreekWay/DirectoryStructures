namespace DarkCreekWay.DirectoryStructures.CLI {
    static partial class Constants {

        // I18n/L10n

        // Help command
        public const string s_HelpCommandName        = "help";
        public const string s_HelpLongOption         = "--help";
        public const string s_HelpLongQMarkOption    = "--?";
        public const string s_HelpShortOption        = "-h";
        public const string s_HelpShortQMarkOption   = "-?";
        public const string s_HelpLongWindowsOption  = "/help";
        public const string s_HelpQMarkWindowsOption = "/?";
        public const string s_HelpShortWindowsOption = "/h";

        public const string s_L10n_HelpCaptionText   = "Help.Caption.Text";
        public const string s_L10n_HelpMessageText   = "Help.Message.Text";

        // Common App Exit Codes
        internal static int s_ExitCode_Success                            = 0;
        internal static int s_ExitCode_ParameterCountIsUnsufficient       = 1;
        internal static int s_ExitCode_CommandIsUnknown                   = 2;

        // Common Filesystem Error Exit Codes
        internal static int s_ExitCode_DirectoryDoesNotExist              = 100;

        // Capture command Exit Codes
        internal static int s_ExitCode_CaptureDirectoryParameterMissing   = 200;

        // Apply command
        internal static int s_ExitCode_ApplyDirectoryParameterMissing     = 300;
        internal static int s_ExitCode_CapturedDirectoryStructureNotFound = 301;

    }
}
