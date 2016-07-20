namespace Asseco.UI
{
    partial class ArtistForm
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
            this._artistToolbar = new System.Windows.Forms.ToolStrip();
            this._reloadArtistButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._deleteToolbarButton = new System.Windows.Forms.ToolStripButton();
            this._saveSeparator = new System.Windows.Forms.ToolStripSeparator();
            this._saveArtistButton = new System.Windows.Forms.ToolStripButton();
            this._newSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this._titleLabel = new System.Windows.Forms.ToolStripLabel();
            this._artistTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this._contentPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.nicknameTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fnameLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lnameLabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.nickLabel = new System.Windows.Forms.Label();
            this.newSave = new System.Windows.Forms.Button();
            this._artistToolbar.SuspendLayout();
            this._artistTableLayout.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _artistToolbar
            // 
            this._artistToolbar.BackColor = System.Drawing.SystemColors.ControlLight;
            this._artistToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._reloadArtistButton,
            this.toolStripSeparator1,
            this._deleteToolbarButton,
            this._saveSeparator,
            this._saveArtistButton,
            this._newSeparator,
            this.toolStripButton1,
            this._titleLabel});
            this._artistToolbar.Location = new System.Drawing.Point(0, 0);
            this._artistToolbar.Name = "_artistToolbar";
            this._artistToolbar.Size = new System.Drawing.Size(875, 70);
            this._artistToolbar.TabIndex = 0;
            // 
            // _reloadArtistButton
            // 
            this._reloadArtistButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this._reloadArtistButton.Image = global::Asseco.Properties.Resources.reload_icon;
            this._reloadArtistButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this._reloadArtistButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._reloadArtistButton.Name = "_reloadArtistButton";
            this._reloadArtistButton.Size = new System.Drawing.Size(52, 67);
            this._reloadArtistButton.Text = "Reload";
            this._reloadArtistButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 70);
            // 
            // _deleteToolbarButton
            // 
            this._deleteToolbarButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this._deleteToolbarButton.Enabled = false;
            this._deleteToolbarButton.Image = global::Asseco.Properties.Resources.delete;
            this._deleteToolbarButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this._deleteToolbarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._deleteToolbarButton.Name = "_deleteToolbarButton";
            this._deleteToolbarButton.Size = new System.Drawing.Size(52, 67);
            this._deleteToolbarButton.Text = "Delete";
            this._deleteToolbarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // _saveSeparator
            // 
            this._saveSeparator.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this._saveSeparator.Name = "_saveSeparator";
            this._saveSeparator.Size = new System.Drawing.Size(6, 70);
            // 
            // _saveArtistButton
            // 
            this._saveArtistButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this._saveArtistButton.Enabled = false;
            this._saveArtistButton.Image = global::Asseco.Properties.Resources.save;
            this._saveArtistButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this._saveArtistButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._saveArtistButton.Name = "_saveArtistButton";
            this._saveArtistButton.Size = new System.Drawing.Size(52, 67);
            this._saveArtistButton.Text = "Save";
            this._saveArtistButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // _newSeparator
            // 
            this._newSeparator.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this._newSeparator.Name = "_newSeparator";
            this._newSeparator.Size = new System.Drawing.Size(6, 70);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.Image = global::Asseco.Properties.Resources.new_file;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(52, 67);
            this.toolStripButton1.Text = "New";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // _titleLabel
            // 
            this._titleLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this._titleLabel.Image = global::Asseco.Properties.Resources.Group_icon;
            this._titleLabel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this._titleLabel.Name = "_titleLabel";
            this._titleLabel.Size = new System.Drawing.Size(120, 67);
            this._titleLabel.Text = "Artists";
            // 
            // _artistTableLayout
            // 
            this._artistTableLayout.ColumnCount = 2;
            this._artistTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.62857F));
            this._artistTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.37143F));
            this._artistTableLayout.Controls.Add(this._contentPanel, 1, 0);
            this._artistTableLayout.Controls.Add(this.panel1, 0, 0);
            this._artistTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this._artistTableLayout.Location = new System.Drawing.Point(0, 70);
            this._artistTableLayout.Name = "_artistTableLayout";
            this._artistTableLayout.RowCount = 1;
            this._artistTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._artistTableLayout.Size = new System.Drawing.Size(875, 343);
            this._artistTableLayout.TabIndex = 1;
            // 
            // _contentPanel
            // 
            this._contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._contentPanel.Location = new System.Drawing.Point(165, 3);
            this._contentPanel.Name = "_contentPanel";
            this._contentPanel.Size = new System.Drawing.Size(707, 337);
            this._contentPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.nicknameTextbox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lastnameTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.idTextbox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 337);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // nicknameTextbox
            // 
            this.nicknameTextbox.Location = new System.Drawing.Point(67, 147);
            this.nicknameTextbox.Name = "nicknameTextbox";
            this.nicknameTextbox.Size = new System.Drawing.Size(180, 20);
            this.nicknameTextbox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nickname :";
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.Location = new System.Drawing.Point(67, 112);
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(180, 20);
            this.lastnameTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lastname :";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(67, 75);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(180, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Firstname :";
            // 
            // idTextbox
            // 
            this.idTextbox.Enabled = false;
            this.idTextbox.Location = new System.Drawing.Point(67, 40);
            this.idTextbox.Name = "idTextbox";
            this.idTextbox.Size = new System.Drawing.Size(46, 20);
            this.idTextbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "#ID :";
            // 
            // fnameLabel
            // 
            this.fnameLabel.AutoSize = true;
            this.fnameLabel.Location = new System.Drawing.Point(27, 29);
            this.fnameLabel.Name = "fnameLabel";
            this.fnameLabel.Size = new System.Drawing.Size(52, 13);
            this.fnameLabel.TabIndex = 0;
            this.fnameLabel.Text = "Firstname";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(30, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(194, 20);
            this.textBox2.TabIndex = 3;
            // 
            // lnameLabel
            // 
            this.lnameLabel.AutoSize = true;
            this.lnameLabel.Location = new System.Drawing.Point(27, 81);
            this.lnameLabel.Name = "lnameLabel";
            this.lnameLabel.Size = new System.Drawing.Size(53, 13);
            this.lnameLabel.TabIndex = 2;
            this.lnameLabel.Text = "Lastname";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(30, 152);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(194, 20);
            this.textBox3.TabIndex = 5;
            // 
            // nickLabel
            // 
            this.nickLabel.AutoSize = true;
            this.nickLabel.Location = new System.Drawing.Point(27, 135);
            this.nickLabel.Name = "nickLabel";
            this.nickLabel.Size = new System.Drawing.Size(55, 13);
            this.nickLabel.TabIndex = 4;
            this.nickLabel.Text = "Nickname";
            // 
            // newSave
            // 
            this.newSave.Location = new System.Drawing.Point(149, 202);
            this.newSave.Name = "newSave";
            this.newSave.Size = new System.Drawing.Size(75, 34);
            this.newSave.TabIndex = 6;
            this.newSave.Text = "Save";
            this.newSave.UseVisualStyleBackColor = true;
            // 
            // ArtistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 413);
            this.ControlBox = false;
            this.Controls.Add(this._artistTableLayout);
            this.Controls.Add(this._artistToolbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ArtistForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ArtistForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this._artistToolbar.ResumeLayout(false);
            this._artistToolbar.PerformLayout();
            this._artistTableLayout.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip _artistToolbar;
        private System.Windows.Forms.ToolStripButton _reloadArtistButton;
        private System.Windows.Forms.ToolStripButton _saveArtistButton;
        private System.Windows.Forms.ToolStripSeparator _newSeparator;
        private System.Windows.Forms.ToolStripSeparator _saveSeparator;
        private System.Windows.Forms.ToolStripLabel _titleLabel;
        private System.Windows.Forms.TableLayoutPanel _artistTableLayout;
        private System.Windows.Forms.Panel _contentPanel;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton _deleteToolbarButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nicknameTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lastnameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fnameLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lnameLabel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label nickLabel;
        private System.Windows.Forms.Button newSave;
    }
}