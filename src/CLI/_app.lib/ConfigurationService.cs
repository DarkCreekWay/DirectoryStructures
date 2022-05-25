namespace DarkCreekWay.DirectoryStructures.CLI {

    public class ConfigurationService {

        public ConfigurationService() {

            UserConfigBasePath = Environment.GetFolderPath( Environment.SpecialFolder.LocalApplicationData );
            AppUserConfigBasePath = Path.Combine( UserConfigBasePath, Constants.s_CompanyDirectoryName, Constants.s_ProductDirectoryName );
            CapturedStructuresBasePath = Path.Combine( AppUserConfigBasePath, Constants.s_CapturedStructuresDirectoryName );
            CapturedStructuresDefaultPath = Path.Combine( CapturedStructuresBasePath, Constants.s_DefaultCapturedStructuresFilename );
        }

        public string UserConfigBasePath { get; private set; }

        public string AppUserConfigBasePath { get; private set; }

        public string CapturedStructuresBasePath { get; private set; }

        public string CapturedStructuresDefaultPath { get; private set; }
    }
}
