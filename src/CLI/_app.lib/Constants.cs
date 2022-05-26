namespace DarkCreekWay.DirectoryStructures.CLI {
    public static partial class Constants {

        // I18n/L10n
        public const string s_L10n_Namespace = "L10n";
        public const string s_L10n_ResourceName = "Resources";

        public const string s_CompanyDirectoryName = "DarkCreekWay";
        public const string s_ProductDirectoryName = "DirectoryStructures";

        public const string s_CapturedStructuresDirectoryName = "Captured";
        public const string s_DefaultCapturedStructuresFilename = ".default";

        // Help command
        public const string s_HelpCommandName = "help";
        public const string s_HelpLongOption = "--help";
        public const string s_HelpLongQMarkOption = "--?";
        public const string s_HelpShortOption = "-h";
        public const string s_HelpShortQMarkOption = "-?";
        public const string s_HelpLongWindowsOption = "/help";
        public const string s_HelpQMarkWindowsOption = "/?";
        public const string s_HelpShortWindowsOption = "/h";

        public const string s_L10n_HelpCaptionText = "Help.Caption.Text";
        public const string s_L10n_HelpMessageText = "Help.Message.Text";

        // Context Menu
        public const string s_L10n_ContextMenuText = "ContextMenu.Text";

        // Capture command
        public const string s_CaptureCommandName = "capture";
        public const string s_L10n_CaptureCommandText = "CaptureCommand.Text";

        // Apply command
        public const string s_ApplyCommandName = "apply";
        public const string s_L10n_ApplyCommandText = "ApplyCommand.Text";
        public const string s_L10n_CapturedDirectoryStructureNotFoundCaption = "ApplyCommand.Messages.CapturedDirectoryStructureNotFound.Caption";
        public const string s_L10n_CapturedDirectoryStructureNotFoundText = "ApplyCommand.Messages.CapturedDirectoryStructureNotFound.Text";

        //! Application exit codes

        // Common exit codes
        internal static int s_ExitCode_Success = 0;
        internal static int s_ExitCode_ParameterCountIsUnsufficient = 1;
        internal static int s_ExitCode_CommandIsUnknown = 2;

        // Filesystem exit codes
        internal static int s_ExitCode_DirectoryDoesNotExist = 100;

        // Capture command exit codes
        internal static int s_ExitCode_CaptureDirectoryParameterMissing = 200;

        // Apply command exit codes
        internal static int s_ExitCode_ApplyDirectoryParameterMissing = 300;
        internal static int s_ExitCode_CapturedDirectoryStructureNotFound = 301;

    }
}
