namespace LN_Finder
{
    partial class Form1
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
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbDiscord = new System.Windows.Forms.CheckBox();
            this.cbBoroboro = new System.Windows.Forms.CheckBox();
            this.cbItazuraneko = new System.Windows.Forms.CheckBox();
            this.cbZLib = new System.Windows.Forms.CheckBox();
            this.collumnType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLink = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.ColumnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNyaa = new System.Windows.Forms.CheckBox();
            this.cbDLRaw = new System.Windows.Forms.CheckBox();
            this.cbAll = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeDiscordTokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProgramFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openSettingsFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkScraperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.checkInternetConnectivityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxSearch
            // 
            this.tbxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearch.Location = new System.Drawing.Point(97, 38);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(803, 30);
            this.tbxSearch.TabIndex = 0;
            this.tbxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSearch_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(12, 38);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(79, 30);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbDiscord
            // 
            this.cbDiscord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDiscord.AutoSize = true;
            this.cbDiscord.Location = new System.Drawing.Point(912, 64);
            this.cbDiscord.Name = "cbDiscord";
            this.cbDiscord.Size = new System.Drawing.Size(76, 20);
            this.cbDiscord.TabIndex = 3;
            this.cbDiscord.Text = "Discord";
            this.cbDiscord.UseVisualStyleBackColor = true;
            this.cbDiscord.CheckedChanged += new System.EventHandler(this.cbDiscord_CheckedChanged);
            // 
            // cbBoroboro
            // 
            this.cbBoroboro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBoroboro.AutoSize = true;
            this.cbBoroboro.Checked = true;
            this.cbBoroboro.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBoroboro.Location = new System.Drawing.Point(913, 90);
            this.cbBoroboro.Name = "cbBoroboro";
            this.cbBoroboro.Size = new System.Drawing.Size(86, 20);
            this.cbBoroboro.TabIndex = 3;
            this.cbBoroboro.Text = "Boroboro";
            this.cbBoroboro.UseVisualStyleBackColor = true;
            // 
            // cbItazuraneko
            // 
            this.cbItazuraneko.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbItazuraneko.AutoSize = true;
            this.cbItazuraneko.Checked = true;
            this.cbItazuraneko.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbItazuraneko.Location = new System.Drawing.Point(915, 116);
            this.cbItazuraneko.Name = "cbItazuraneko";
            this.cbItazuraneko.Size = new System.Drawing.Size(98, 20);
            this.cbItazuraneko.TabIndex = 3;
            this.cbItazuraneko.Text = "Itazuraneko";
            this.cbItazuraneko.UseVisualStyleBackColor = true;
            // 
            // cbZLib
            // 
            this.cbZLib.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbZLib.AutoSize = true;
            this.cbZLib.Checked = true;
            this.cbZLib.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbZLib.Location = new System.Drawing.Point(913, 142);
            this.cbZLib.Name = "cbZLib";
            this.cbZLib.Size = new System.Drawing.Size(59, 20);
            this.cbZLib.TabIndex = 3;
            this.cbZLib.Text = "Z-Lib";
            this.cbZLib.UseVisualStyleBackColor = true;
            // 
            // collumnType
            // 
            this.collumnType.Text = "Type";
            this.collumnType.Width = 82;
            // 
            // columnTitle
            // 
            this.columnTitle.Text = "Title";
            // 
            // columnLink
            // 
            this.columnLink.Text = "Link";
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.AutoArrange = false;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnID,
            this.collumnType,
            this.columnTitle,
            this.columnLink});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 74);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(888, 413);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // ColumnID
            // 
            this.ColumnID.Text = "ID";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(908, 254);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(101, 28);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(904, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Results Size:";
            // 
            // cbNyaa
            // 
            this.cbNyaa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbNyaa.AutoSize = true;
            this.cbNyaa.Location = new System.Drawing.Point(910, 168);
            this.cbNyaa.Name = "cbNyaa";
            this.cbNyaa.Size = new System.Drawing.Size(62, 20);
            this.cbNyaa.TabIndex = 3;
            this.cbNyaa.Text = "Nyaa";
            this.cbNyaa.UseVisualStyleBackColor = true;
            // 
            // cbDLRaw
            // 
            this.cbDLRaw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDLRaw.AutoSize = true;
            this.cbDLRaw.Location = new System.Drawing.Point(911, 194);
            this.cbDLRaw.Name = "cbDLRaw";
            this.cbDLRaw.Size = new System.Drawing.Size(73, 20);
            this.cbDLRaw.TabIndex = 3;
            this.cbDLRaw.Text = "DLRaw";
            this.cbDLRaw.UseVisualStyleBackColor = true;
            // 
            // cbAll
            // 
            this.cbAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAll.AutoSize = true;
            this.cbAll.Location = new System.Drawing.Point(913, 38);
            this.cbAll.Name = "cbAll";
            this.cbAll.Size = new System.Drawing.Size(85, 20);
            this.cbAll.TabIndex = 3;
            this.cbAll.Text = "Select All";
            this.cbAll.UseVisualStyleBackColor = true;
            this.cbAll.CheckedChanged += new System.EventHandler(this.cbAll_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.debugToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1022, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeDiscordTokenToolStripMenuItem,
            this.changeResultsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // changeDiscordTokenToolStripMenuItem
            // 
            this.changeDiscordTokenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.changeDiscordTokenToolStripMenuItem.Name = "changeDiscordTokenToolStripMenuItem";
            this.changeDiscordTokenToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.changeDiscordTokenToolStripMenuItem.Text = "Change Discord token";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSettingsFileToolStripMenuItem,
            this.openProgramFolderToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openProgramFolderToolStripMenuItem
            // 
            this.openProgramFolderToolStripMenuItem.Name = "openProgramFolderToolStripMenuItem";
            this.openProgramFolderToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.openProgramFolderToolStripMenuItem.Text = "Open program folder";
            this.openProgramFolderToolStripMenuItem.ToolTipText = "Open the folder where the application is located";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.ToolTipText = "Close the application";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(231, 6);
            // 
            // openSettingsFileToolStripMenuItem
            // 
            this.openSettingsFileToolStripMenuItem.Name = "openSettingsFileToolStripMenuItem";
            this.openSettingsFileToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.openSettingsFileToolStripMenuItem.Text = "Open settings file";
            this.openSettingsFileToolStripMenuItem.ToolTipText = "Open settings.json";
            // 
            // changeResultsToolStripMenuItem
            // 
            this.changeResultsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox2});
            this.changeResultsToolStripMenuItem.Name = "changeResultsToolStripMenuItem";
            this.changeResultsToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.changeResultsToolStripMenuItem.Text = "Change results size";
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkScraperToolStripMenuItem,
            this.checkInternetConnectivityToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // checkScraperToolStripMenuItem
            // 
            this.checkScraperToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.checkScraperToolStripMenuItem.Name = "checkScraperToolStripMenuItem";
            this.checkScraperToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.checkScraperToolStripMenuItem.Text = "Check scraper functionality";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "All",
            "Discord",
            "Boroboro",
            "Itazuraneko",
            "Z-Library",
            "Nyaa",
            "DLRaw"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 28);
            this.toolStripComboBox1.Text = "All";
            // 
            // checkInternetConnectivityToolStripMenuItem
            // 
            this.checkInternetConnectivityToolStripMenuItem.Name = "checkInternetConnectivityToolStripMenuItem";
            this.checkInternetConnectivityToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.checkInternetConnectivityToolStripMenuItem.Text = "Check internet connection";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 27);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 515);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cbDLRaw);
            this.Controls.Add(this.cbNyaa);
            this.Controls.Add(this.cbZLib);
            this.Controls.Add(this.cbItazuraneko);
            this.Controls.Add(this.cbBoroboro);
            this.Controls.Add(this.cbAll);
            this.Controls.Add(this.cbDiscord);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(358, 184);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "LN Finder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox cbDiscord;
        private System.Windows.Forms.CheckBox cbBoroboro;
        private System.Windows.Forms.CheckBox cbItazuraneko;
        private System.Windows.Forms.CheckBox cbZLib;
        private System.Windows.Forms.ColumnHeader collumnType;
        private System.Windows.Forms.ColumnHeader columnTitle;
        private System.Windows.Forms.ColumnHeader columnLink;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader ColumnID;
        private System.Windows.Forms.CheckBox cbNyaa;
        private System.Windows.Forms.CheckBox cbDLRaw;
        private System.Windows.Forms.CheckBox cbAll;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openProgramFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeDiscordTokenToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem openSettingsFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem changeResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkScraperToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem checkInternetConnectivityToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
    }
}

