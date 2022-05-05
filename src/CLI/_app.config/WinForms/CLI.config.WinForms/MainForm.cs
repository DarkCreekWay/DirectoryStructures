using System.Diagnostics;

namespace DarkCreekWay.DirectoryStructures.CLI;

public partial class MainForm : Form
{
    ConfigurationService _configurationService;
    MicrosoftWindowsIntegrationService _integrationService;

    public MainForm()
    {
        _configurationService = new ConfigurationService();
        _integrationService = new MicrosoftWindowsIntegrationService();

        InitializeComponent();
    }

    void GitHubProfileLinkLabel_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e ) {
        string target = (string)( (LinkLabel)sender ).Tag;

        // Check this issue for details
        // https://github.com/dotnet/corefx/issues/10361
        _ = Process.Start( new ProcessStartInfo( target ) { UseShellExecute = true } );
    }

    void CloseButton_Click( object sender, EventArgs e ) {
        Close();
    }

    void RegisterContextMenuButton_Click( object sender, EventArgs e ) {
        _integrationService.Register();
    }

    void UnregisterContextMenuButton_Click( object sender, EventArgs e ) {
        _integrationService.Unregister();
    }

    void DeleteLocalDataButton_Click( object sender, EventArgs e ) {

        if(!Directory.Exists( _configurationService.AppUserConfigBasePath)) {
            return;
        }

        Directory.Delete( _configurationService.AppUserConfigBasePath, true );
    }
}
