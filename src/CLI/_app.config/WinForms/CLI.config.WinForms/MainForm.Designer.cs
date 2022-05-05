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
            this._unregisterContextMenuButton.Location = new System.Drawing.Point(466, 57);
            this._unregisterContextMenuButton.Margin = new System.Windows.Forms.Padding(0);
            this._unregisterContextMenuButton.Name = "_unregisterContextMenuButton";
            this._unregisterContextMenuButton.Size = new System.Drawing.Size(154, 43);
            this._unregisterContextMenuButton.TabIndex = 2;
            this._unregisterContextMenuButton.Text = "Unregister";
            this._unregisterContextMenuButton.UseVisualStyleBackColor = true;
            this._unregisterContextMenuButton.Click += new System.EventHandler(this.UnregisterContextMenuButton_Click);
            // 
            // _deleteLocalDataButton
            // 
            this._deleteLocalDataButton.Location = new System.Drawing.Point(466, 114);
            this._deleteLocalDataButton.Margin = new System.Windows.Forms.Padding(0);
            this._deleteLocalDataButton.Name = "_deleteLocalDataButton";
            this._deleteLocalDataButton.Size = new System.Drawing.Size(154, 43);
            this._deleteLocalDataButton.TabIndex = 3;
            this._deleteLocalDataButton.Text = "Delete";
            this._deleteLocalDataButton.UseVisualStyleBackColor = true;
            this._deleteLocalDataButton.Click += new System.EventHandler(this.DeleteLocalDataButton_Click);
            // 
            // _closeButton
            // 
            this._closeButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._closeButton.Location = new System.Drawing.Point(480, 14);
            this._closeButton.Margin = new System.Windows.Forms.Padding(0);
            this._closeButton.Name = "_closeButton";
            this._closeButton.Size = new System.Drawing.Size(154, 49);
            this._closeButton.TabIndex = 4;
            this._closeButton.Text = "Close";
            this._closeButton.UseVisualStyleBackColor = true;
            this._closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // _headlineLabel
            // 
            this._headlineLabel.AutoSize = true;
            this._headlineLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._headlineLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this._headlineLabel.Location = new System.Drawing.Point(12, 18);
            this._headlineLabel.Margin = new System.Windows.Forms.Padding(0);
            this._headlineLabel.Name = "_headlineLabel";
            this._headlineLabel.Size = new System.Drawing.Size(568, 38);
            this._headlineLabel.TabIndex = 6;
            this._headlineLabel.Text = "DarkCreekway\'s Tool for Directory Structures";
            // 
            // _copyrightLabel
            // 
            this._copyrightLabel.AutoSize = true;
            this._copyrightLabel.Location = new System.Drawing.Point(14, 23);
            this._copyrightLabel.Name = "_copyrightLabel";
            this._copyrightLabel.Size = new System.Drawing.Size(350, 30);
            this._copyrightLabel.TabIndex = 7;
            this._copyrightLabel.Text = "Copyright (c) 2017 by DarkCreekWay";
            // 
            // _gitHubProfileLinkLabel
            // 
            this._gitHubProfileLinkLabel.AutoSize = true;
            this._gitHubProfileLinkLabel.Location = new System.Drawing.Point(0, 35);
            this._gitHubProfileLinkLabel.Margin = new System.Windows.Forms.Padding(0);
            this._gitHubProfileLinkLabel.Name = "_gitHubProfileLinkLabel";
            this._gitHubProfileLinkLabel.Size = new System.Drawing.Size(105, 30);
            this._gitHubProfileLinkLabel.TabIndex = 8;
            this._gitHubProfileLinkLabel.TabStop = true;
            this._gitHubProfileLinkLabel.Tag = "https://github.com/DarkCreekway";
            this._gitHubProfileLinkLabel.Text = "on Github";
            this._gitHubProfileLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GitHubProfileLinkLabel_LinkClicked);
            // 
            // _dialogControlsPanel
            // 
            this._dialogControlsPanel.Controls.Add(this._closeButton);
            this._dialogControlsPanel.Controls.Add(this._copyrightLabel);
            this._dialogControlsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._dialogControlsPanel.Location = new System.Drawing.Point(0, 364);
            this._dialogControlsPanel.Margin = new System.Windows.Forms.Padding(0);
            this._dialogControlsPanel.Name = "_dialogControlsPanel";
            this._dialogControlsPanel.Size = new System.Drawing.Size(648, 77);
            this._dialogControlsPanel.TabIndex = 9;
            // 
            // _headlinePanel
            // 
            this._headlinePanel.BackColor = System.Drawing.SystemColors.Window;
            this._headlinePanel.Controls.Add(this._headlineLabel);
            this._headlinePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this._headlinePanel.Location = new System.Drawing.Point(0, 0);
            this._headlinePanel.Name = "_headlinePanel";
            this._headlinePanel.Size = new System.Drawing.Size(648, 77);
            this._headlinePanel.TabIndex = 10;
            // 
            // _contentPanel
            // 
            this._contentPanel.Controls.Add(this._contentTTableLayoutPanel);
            this._contentPanel.Controls.Add(this._commercialPanel);
            this._contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._contentPanel.Location = new System.Drawing.Point(14, 14);
            this._contentPanel.Margin = new System.Windows.Forms.Padding(0);
            this._contentPanel.Name = "_contentPanel";
            this._contentPanel.Size = new System.Drawing.Size(620, 273);
            this._contentPanel.TabIndex = 11;
            // 
            // _contentTTableLayoutPanel
            // 
            this._contentTTableLayoutPanel.ColumnCount = 4;
            this._contentTTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 452F));
            this._contentTTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this._contentTTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this._contentTTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._contentTTableLayoutPanel.Controls.Add(this._deleteLocalDataLabel, 0, 4);
            this._contentTTableLayoutPanel.Controls.Add(this._deleteLocalDataButton, 2, 4);
            this._contentTTableLayoutPanel.Controls.Add(this._unregisterContextMenuButton, 2, 2);
            this._contentTTableLayoutPanel.Controls.Add(this._registerContextMenuButton, 2, 0);
            this._contentTTableLayoutPanel.Controls.Add(this.label2, 0, 0);
            this._contentTTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._contentTTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._contentTTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this._contentTTableLayoutPanel.Name = "_contentTTableLayoutPanel";
            this._contentTTableLayoutPanel.RowCount = 6;
            this._contentTTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this._contentTTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this._contentTTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this._contentTTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this._contentTTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this._contentTTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._contentTTableLayoutPanel.Size = new System.Drawing.Size(620, 196);
            this._contentTTableLayoutPanel.TabIndex = 5;
            // 
            // _deleteLocalDataLabel
            // 
            this._deleteLocalDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._deleteLocalDataLabel.AutoSize = true;
            this._deleteLocalDataLabel.Location = new System.Drawing.Point(0, 114);
            this._deleteLocalDataLabel.Margin = new System.Windows.Forms.Padding(0);
            this._deleteLocalDataLabel.Name = "_deleteLocalDataLabel";
            this._deleteLocalDataLabel.Size = new System.Drawing.Size(169, 43);
            this._deleteLocalDataLabel.TabIndex = 5;
            this._deleteLocalDataLabel.Text = "Delete local data";
            this._deleteLocalDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _registerContextMenuButton
            // 
            this._registerContextMenuButton.Location = new System.Drawing.Point(466, 0);
            this._registerContextMenuButton.Margin = new System.Windows.Forms.Padding(0);
            this._registerContextMenuButton.Name = "_registerContextMenuButton";
            this._registerContextMenuButton.Size = new System.Drawing.Size(154, 43);
            this._registerContextMenuButton.TabIndex = 1;
            this._registerContextMenuButton.Text = "Register";
            this._registerContextMenuButton.UseVisualStyleBackColor = true;
            this._registerContextMenuButton.Click += new System.EventHandler(this.RegisterContextMenuButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(408, 43);
            this.label2.TabIndex = 7;
            this.label2.Text = "Integrate with Microsoft Windows Explorer";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _commercialPanel
            // 
            this._commercialPanel.Controls.Add(this._visitUsLabel);
            this._commercialPanel.Controls.Add(this._gitHubProfileLinkLabel);
            this._commercialPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._commercialPanel.Location = new System.Drawing.Point(0, 196);
            this._commercialPanel.Margin = new System.Windows.Forms.Padding(0);
            this._commercialPanel.Name = "_commercialPanel";
            this._commercialPanel.Size = new System.Drawing.Size(620, 77);
            this._commercialPanel.TabIndex = 12;
            // 
            // _visitUsLabel
            // 
            this._visitUsLabel.AutoSize = true;
            this._visitUsLabel.Location = new System.Drawing.Point(0, 4);
            this._visitUsLabel.Margin = new System.Windows.Forms.Padding(0);
            this._visitUsLabel.Name = "_visitUsLabel";
            this._visitUsLabel.Size = new System.Drawing.Size(79, 30);
            this._visitUsLabel.TabIndex = 9;
            this._visitUsLabel.Text = "Visit us";
            // 
            // _contentLayoutPanel
            // 
            this._contentLayoutPanel.Controls.Add(this._contentPanel);
            this._contentLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._contentLayoutPanel.Location = new System.Drawing.Point(0, 77);
            this._contentLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this._contentLayoutPanel.Name = "_contentLayoutPanel";
            this._contentLayoutPanel.Padding = new System.Windows.Forms.Padding(14, 14, 14, 0);
            this._contentLayoutPanel.Size = new System.Drawing.Size(648, 287);
            this._contentLayoutPanel.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AcceptButton = this._closeButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(648, 441);
            this.Controls.Add(this._contentLayoutPanel);
            this.Controls.Add(this._dialogControlsPanel);
            this.Controls.Add(this._headlinePanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(672, 505);
            this.MinimumSize = new System.Drawing.Size(672, 505);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configure DarkCreekWay\'s Tool for Directory Structures";
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
