namespace DarkCreekWay.DirectoryStructures.CLI;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._unregisterContextMenuButton = new System.Windows.Forms.Button();
            this._deleteLocalDataButton = new System.Windows.Forms.Button();
            this._closeButton = new System.Windows.Forms.Button();
            this._headlineLabel = new System.Windows.Forms.Label();
            this._copyrightLabel = new System.Windows.Forms.Label();
            this._gitHubProfileLinkLabel = new System.Windows.Forms.LinkLabel();
            this._dialogControlsPanel = new System.Windows.Forms.Panel();
            this._headlinePanel = new System.Windows.Forms.Panel();
            this._contentPanel = new System.Windows.Forms.Panel();
            this._contentTTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._deleteLocalDataLabel = new System.Windows.Forms.Label();
            this._registerContextMenuButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this._commercialPanel = new System.Windows.Forms.Panel();
            this._visitUsLabel = new System.Windows.Forms.Label();
            this._contentLayoutPanel = new System.Windows.Forms.Panel();
            this._dialogControlsPanel.SuspendLayout();
            this._headlinePanel.SuspendLayout();
            this._contentPanel.SuspendLayout();
            this._contentTTableLayoutPanel.SuspendLayout();
            this._commercialPanel.SuspendLayout();
            this._contentLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _unregisterContextMenuButton
            // 
            resources.ApplyResources(this._unregisterContextMenuButton, "_unregisterContextMenuButton");
            this._unregisterContextMenuButton.Name = "_unregisterContextMenuButton";
            this._unregisterContextMenuButton.UseVisualStyleBackColor = true;
            this._unregisterContextMenuButton.Click += new System.EventHandler(this.UnregisterContextMenuButton_Click);
            // 
            // _deleteLocalDataButton
            // 
            resources.ApplyResources(this._deleteLocalDataButton, "_deleteLocalDataButton");
            this._deleteLocalDataButton.Name = "_deleteLocalDataButton";
            this._deleteLocalDataButton.UseVisualStyleBackColor = true;
            this._deleteLocalDataButton.Click += new System.EventHandler(this.DeleteLocalDataButton_Click);
            // 
            // _closeButton
            // 
            this._closeButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this._closeButton, "_closeButton");
            this._closeButton.Name = "_closeButton";
            this._closeButton.UseVisualStyleBackColor = true;
            this._closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // _headlineLabel
            // 
            resources.ApplyResources(this._headlineLabel, "_headlineLabel");
            this._headlineLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this._headlineLabel.Name = "_headlineLabel";
            this._headlineLabel.DoubleClick += new System.EventHandler(this.HeadlineLabel_DoubleClick);
            // 
            // _copyrightLabel
            // 
            resources.ApplyResources(this._copyrightLabel, "_copyrightLabel");
            this._copyrightLabel.Name = "_copyrightLabel";
            // 
            // _gitHubProfileLinkLabel
            // 
            resources.ApplyResources(this._gitHubProfileLinkLabel, "_gitHubProfileLinkLabel");
            this._gitHubProfileLinkLabel.Name = "_gitHubProfileLinkLabel";
            this._gitHubProfileLinkLabel.TabStop = true;
            this._gitHubProfileLinkLabel.Tag = "";
            this._gitHubProfileLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GitHubProfileLinkLabel_LinkClicked);
            // 
            // _dialogControlsPanel
            // 
            this._dialogControlsPanel.Controls.Add(this._closeButton);
            this._dialogControlsPanel.Controls.Add(this._copyrightLabel);
            resources.ApplyResources(this._dialogControlsPanel, "_dialogControlsPanel");
            this._dialogControlsPanel.Name = "_dialogControlsPanel";
            // 
            // _headlinePanel
            // 
            this._headlinePanel.BackColor = System.Drawing.SystemColors.Window;
            this._headlinePanel.Controls.Add(this._headlineLabel);
            resources.ApplyResources(this._headlinePanel, "_headlinePanel");
            this._headlinePanel.Name = "_headlinePanel";
            // 
            // _contentPanel
            // 
            this._contentPanel.Controls.Add(this._contentTTableLayoutPanel);
            this._contentPanel.Controls.Add(this._commercialPanel);
            resources.ApplyResources(this._contentPanel, "_contentPanel");
            this._contentPanel.Name = "_contentPanel";
            // 
            // _contentTTableLayoutPanel
            // 
            resources.ApplyResources(this._contentTTableLayoutPanel, "_contentTTableLayoutPanel");
            this._contentTTableLayoutPanel.Controls.Add(this._deleteLocalDataLabel, 0, 4);
            this._contentTTableLayoutPanel.Controls.Add(this._deleteLocalDataButton, 2, 4);
            this._contentTTableLayoutPanel.Controls.Add(this._unregisterContextMenuButton, 2, 2);
            this._contentTTableLayoutPanel.Controls.Add(this._registerContextMenuButton, 2, 0);
            this._contentTTableLayoutPanel.Controls.Add(this.label2, 0, 0);
            this._contentTTableLayoutPanel.Name = "_contentTTableLayoutPanel";
            // 
            // _deleteLocalDataLabel
            // 
            resources.ApplyResources(this._deleteLocalDataLabel, "_deleteLocalDataLabel");
            this._deleteLocalDataLabel.Name = "_deleteLocalDataLabel";
            // 
            // _registerContextMenuButton
            // 
            resources.ApplyResources(this._registerContextMenuButton, "_registerContextMenuButton");
            this._registerContextMenuButton.Name = "_registerContextMenuButton";
            this._registerContextMenuButton.UseVisualStyleBackColor = true;
            this._registerContextMenuButton.Click += new System.EventHandler(this.RegisterContextMenuButton_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // _commercialPanel
            // 
            this._commercialPanel.Controls.Add(this._visitUsLabel);
            this._commercialPanel.Controls.Add(this._gitHubProfileLinkLabel);
            resources.ApplyResources(this._commercialPanel, "_commercialPanel");
            this._commercialPanel.Name = "_commercialPanel";
            // 
            // _visitUsLabel
            // 
            resources.ApplyResources(this._visitUsLabel, "_visitUsLabel");
            this._visitUsLabel.Name = "_visitUsLabel";
            // 
            // _contentLayoutPanel
            // 
            this._contentLayoutPanel.Controls.Add(this._contentPanel);
            resources.ApplyResources(this._contentLayoutPanel, "_contentLayoutPanel");
            this._contentLayoutPanel.Name = "_contentLayoutPanel";
            // 
            // MainForm
            // 
            this.AcceptButton = this._closeButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this._contentLayoutPanel);
            this.Controls.Add(this._dialogControlsPanel);
            this.Controls.Add(this._headlinePanel);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this._dialogControlsPanel.ResumeLayout(false);
            this._dialogControlsPanel.PerformLayout();
            this._headlinePanel.ResumeLayout(false);
            this._headlinePanel.PerformLayout();
            this._contentPanel.ResumeLayout(false);
            this._contentTTableLayoutPanel.ResumeLayout(false);
            this._contentTTableLayoutPanel.PerformLayout();
            this._commercialPanel.ResumeLayout(false);
            this._commercialPanel.PerformLayout();
            this._contentLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion
    private Button _unregisterContextMenuButton;
    private Button _deleteLocalDataButton;
    private Button _closeButton;
    private Label _headlineLabel;
    private Label _copyrightLabel;
    private LinkLabel _gitHubProfileLinkLabel;
    private Panel _dialogControlsPanel;
    private Panel _headlinePanel;
    private Panel _contentPanel;
    private Panel _contentLayoutPanel;
    private TableLayoutPanel _contentTTableLayoutPanel;
    private Label _deleteLocalDataLabel;
    private Button _registerContextMenuButton;
    private Label label2;
    private Panel _commercialPanel;
    private Label _visitUsLabel;
}
