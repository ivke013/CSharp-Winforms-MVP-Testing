using System.Drawing;
using System.Windows.Forms;

namespace Asseco.UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {

          
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this._toolBar = new System.Windows.Forms.ToolStrip();
            this._artistToolbarButton = new System.Windows.Forms.ToolStripButton();
            this._artistSeparator = new System.Windows.Forms.ToolStripSeparator();
            this._libraryToolbarButton = new System.Windows.Forms.ToolStripButton();
            this._librarySeparator = new System.Windows.Forms.ToolStripSeparator();
            this._topListToolbarButton = new System.Windows.Forms.ToolStripButton();
            this._topListSeparator = new System.Windows.Forms.ToolStripSeparator();
            this._statusBar = new System.Windows.Forms.StatusStrip();
            this._statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this._statusDbLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this._toolBar.SuspendLayout();
            this._statusBar.SuspendLayout();
            this.SuspendLayout();

            // Main panel
            this.MainPanel.BackColor = Color.Silver;
            this.MainPanel.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(new Button());

            // 
            // _toolBar
            // 
            this._toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._artistToolbarButton,
            this._artistSeparator,
            this._libraryToolbarButton,
            this._librarySeparator,
            this._topListToolbarButton,
            this._topListSeparator});
            this._toolBar.Location = new System.Drawing.Point(0, 0);
            this._toolBar.Name = "_toolBar";
            this._toolBar.Size = new System.Drawing.Size(937, 70);
            this._toolBar.TabIndex = 0;
            this._toolBar.Text = "toolStrip1";
            // 
            // _artistToolbarButton
            // 
            this._artistToolbarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this._artistToolbarButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this._artistToolbarButton.Image = global::Asseco.Properties.Resources.user_groups;
            this._artistToolbarButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this._artistToolbarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._artistToolbarButton.Name = "_artistToolbarButton";
            this._artistToolbarButton.Size = new System.Drawing.Size(59, 67);
            this._artistToolbarButton.Text = "ARTISTS";
            this._artistToolbarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // _artistSeparator
            // 
            this._artistSeparator.Name = "_artistSeparator";
            this._artistSeparator.Size = new System.Drawing.Size(6, 70);
            // 
            // _libraryToolbarButton
            // 
            this._libraryToolbarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this._libraryToolbarButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this._libraryToolbarButton.Image = global::Asseco.Properties.Resources.music_note;
            this._libraryToolbarButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this._libraryToolbarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._libraryToolbarButton.Name = "_libraryToolbarButton";
            this._libraryToolbarButton.Size = new System.Drawing.Size(60, 67);
            this._libraryToolbarButton.Text = "LIBRARY";
            this._libraryToolbarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // _librarySeparator
            // 
            this._librarySeparator.Name = "_librarySeparator";
            this._librarySeparator.Size = new System.Drawing.Size(6, 70);
            // 
            // _topListToolbarButton
            // 
            this._topListToolbarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this._topListToolbarButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this._topListToolbarButton.Image = global::Asseco.Properties.Resources.star_rating_icon;
            this._topListToolbarButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this._topListToolbarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._topListToolbarButton.Name = "_topListToolbarButton";
            this._topListToolbarButton.Size = new System.Drawing.Size(61, 67);
            this._topListToolbarButton.Text = "TOP LIST";
            this._topListToolbarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // _topListSeparator
            // 
            this._topListSeparator.Name = "_topListSeparator";
            this._topListSeparator.Size = new System.Drawing.Size(6, 70);
            // 
            // _statusBar
            // 
            this._statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._statusLabel,
            this._statusDbLabel});
            this._statusBar.Location = new System.Drawing.Point(0, 402);
            this._statusBar.Name = "_statusBar";
            this._statusBar.Size = new System.Drawing.Size(937, 22);
            this._statusBar.TabIndex = 2;
            this._statusBar.Text = "statusStrip1";
            // 
            // _statusLabel
            // 
            this._statusLabel.Name = "_statusLabel";
            this._statusLabel.Size = new System.Drawing.Size(45, 17);
            this._statusLabel.Text = "Status: ";
            // 
            // _statusDbLabel
            // 
            this._statusDbLabel.Name = "_statusDbLabel";
            this._statusDbLabel.Size = new System.Drawing.Size(65, 17);
            this._statusDbLabel.Text = "Connected";
   
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 424);
            this.Controls.Add(this.MainPanel);

            this.Controls.Add(this._statusBar);
            this.Controls.Add(this._toolBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asseco - Top List";
            this.TopMost = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this._toolBar.ResumeLayout(false);
            this._toolBar.PerformLayout();
            this._statusBar.ResumeLayout(false);
            this._statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip _toolBar;
        private System.Windows.Forms.ToolStripButton _artistToolbarButton;
        private System.Windows.Forms.ToolStripButton _libraryToolbarButton;
        private System.Windows.Forms.ToolStripButton _topListToolbarButton;
        private System.Windows.Forms.ToolStripSeparator _artistSeparator;
        private System.Windows.Forms.ToolStripSeparator _librarySeparator;
        private System.Windows.Forms.ToolStripSeparator _topListSeparator;
        private System.Windows.Forms.StatusStrip _statusBar;
        private System.Windows.Forms.ToolStripStatusLabel _statusLabel;
        private System.Windows.Forms.ToolStripStatusLabel _statusDbLabel;

    }
}