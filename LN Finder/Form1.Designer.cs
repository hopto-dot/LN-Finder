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
            this.components = new System.ComponentModel.Container();
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyTitleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.copyLinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToLinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.resizeHeadersToFitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.clearListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNyaa = new System.Windows.Forms.CheckBox();
            this.cbDLRaw = new System.Windows.Forms.CheckBox();
            this.cbAll = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProgramFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSettingsFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.resetSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeDiscordTokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.changeResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.copyTitleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyLinkOfSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkScraperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkInternetConnectivityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bigGUIScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.browseVisualNovelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVN = new System.Windows.Forms.Button();
            this.btnLN = new System.Windows.Forms.Button();
            this.cbRyuu = new System.Windows.Forms.CheckBox();
            this.cbGGB = new System.Windows.Forms.CheckBox();
            this.cbCrane = new System.Windows.Forms.CheckBox();
            this.cbMiko = new System.Windows.Forms.CheckBox();
            this.cbAnimeSharing = new System.Windows.Forms.CheckBox();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.goToMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
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
            this.tbxSearch.Size = new System.Drawing.Size(839, 30);
            this.tbxSearch.TabIndex = 0;
            this.tbxSearch.Text = "お隣の天使様にいつの間にか駄目人間にされていた件";
            this.tbxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSearch_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(12, 38);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(79, 30);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbDiscord
            // 
            this.cbDiscord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDiscord.AutoSize = true;
            this.cbDiscord.Location = new System.Drawing.Point(952, 64);
            this.cbDiscord.Name = "cbDiscord";
            this.cbDiscord.Size = new System.Drawing.Size(76, 20);
            this.cbDiscord.TabIndex = 5;
            this.cbDiscord.Text = "Discord";
            this.cbDiscord.UseVisualStyleBackColor = true;
            this.cbDiscord.CheckedChanged += new System.EventHandler(this.cbDiscord_CheckedChanged);
            this.cbDiscord.Click += new System.EventHandler(this.cbAnyLN);
            // 
            // cbBoroboro
            // 
            this.cbBoroboro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBoroboro.AutoSize = true;
            this.cbBoroboro.Location = new System.Drawing.Point(953, 90);
            this.cbBoroboro.Name = "cbBoroboro";
            this.cbBoroboro.Size = new System.Drawing.Size(86, 20);
            this.cbBoroboro.TabIndex = 6;
            this.cbBoroboro.Text = "Boroboro";
            this.cbBoroboro.UseVisualStyleBackColor = true;
            this.cbBoroboro.Click += new System.EventHandler(this.cbAnyLN);
            // 
            // cbItazuraneko
            // 
            this.cbItazuraneko.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbItazuraneko.AutoSize = true;
            this.cbItazuraneko.Location = new System.Drawing.Point(955, 116);
            this.cbItazuraneko.Name = "cbItazuraneko";
            this.cbItazuraneko.Size = new System.Drawing.Size(98, 20);
            this.cbItazuraneko.TabIndex = 7;
            this.cbItazuraneko.Text = "Itazuraneko";
            this.cbItazuraneko.UseVisualStyleBackColor = true;
            this.cbItazuraneko.Click += new System.EventHandler(this.cbAnyLN);
            // 
            // cbZLib
            // 
            this.cbZLib.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbZLib.AutoSize = true;
            this.cbZLib.Location = new System.Drawing.Point(953, 142);
            this.cbZLib.Name = "cbZLib";
            this.cbZLib.Size = new System.Drawing.Size(59, 20);
            this.cbZLib.TabIndex = 8;
            this.cbZLib.Text = "Z-Lib";
            this.cbZLib.UseVisualStyleBackColor = true;
            this.cbZLib.Click += new System.EventHandler(this.cbAnyLN);
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
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.AutoArrange = false;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnID,
            this.collumnType,
            this.columnTitle,
            this.columnLink});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 74);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(924, 423);
            this.listView1.TabIndex = 3;
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyTitleToolStripMenuItem1,
            this.copyLinkToolStripMenuItem,
            this.toolStripSeparator7,
            this.goToLinkToolStripMenuItem,
            this.goToMessageToolStripMenuItem,
            this.toolStripSeparator4,
            this.resizeHeadersToFitToolStripMenuItem,
            this.toolStripSeparator3,
            this.clearListToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(213, 194);
            this.contextMenuStrip1.Opened += new System.EventHandler(this.contextMenuStrip1_Opened);
            // 
            // copyTitleToolStripMenuItem1
            // 
            this.copyTitleToolStripMenuItem1.Name = "copyTitleToolStripMenuItem1";
            this.copyTitleToolStripMenuItem1.Size = new System.Drawing.Size(212, 24);
            this.copyTitleToolStripMenuItem1.Text = "Copy title";
            this.copyTitleToolStripMenuItem1.Click += new System.EventHandler(this.copyTitleToolStripMenuItem1_Click);
            // 
            // copyLinkToolStripMenuItem
            // 
            this.copyLinkToolStripMenuItem.Name = "copyLinkToolStripMenuItem";
            this.copyLinkToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.copyLinkToolStripMenuItem.Text = "Copy link";
            this.copyLinkToolStripMenuItem.Click += new System.EventHandler(this.copyLinkToolStripMenuItem_Click);
            // 
            // goToLinkToolStripMenuItem
            // 
            this.goToLinkToolStripMenuItem.Name = "goToLinkToolStripMenuItem";
            this.goToLinkToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.goToLinkToolStripMenuItem.Text = "Go to download";
            this.goToLinkToolStripMenuItem.Click += new System.EventHandler(this.goToLinkToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(209, 6);
            // 
            // resizeHeadersToFitToolStripMenuItem
            // 
            this.resizeHeadersToFitToolStripMenuItem.Name = "resizeHeadersToFitToolStripMenuItem";
            this.resizeHeadersToFitToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.resizeHeadersToFitToolStripMenuItem.Text = "Resize headers to fit";
            this.resizeHeadersToFitToolStripMenuItem.Click += new System.EventHandler(this.resizeHeadersToFitToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(209, 6);
            // 
            // clearListToolStripMenuItem
            // 
            this.clearListToolStripMenuItem.Name = "clearListToolStripMenuItem";
            this.clearListToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.clearListToolStripMenuItem.Text = "Clear list";
            this.clearListToolStripMenuItem.Click += new System.EventHandler(this.clearListToolStripMenuItem_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(948, 254);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(101, 28);
            this.numericUpDown1.TabIndex = 11;
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
            this.label1.Location = new System.Drawing.Point(944, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Results Size";
            // 
            // cbNyaa
            // 
            this.cbNyaa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbNyaa.AutoSize = true;
            this.cbNyaa.Location = new System.Drawing.Point(950, 168);
            this.cbNyaa.Name = "cbNyaa";
            this.cbNyaa.Size = new System.Drawing.Size(62, 20);
            this.cbNyaa.TabIndex = 9;
            this.cbNyaa.Text = "Nyaa";
            this.cbNyaa.UseVisualStyleBackColor = true;
            this.cbNyaa.Click += new System.EventHandler(this.cbAnyLN);
            // 
            // cbDLRaw
            // 
            this.cbDLRaw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDLRaw.AutoSize = true;
            this.cbDLRaw.Location = new System.Drawing.Point(951, 194);
            this.cbDLRaw.Name = "cbDLRaw";
            this.cbDLRaw.Size = new System.Drawing.Size(73, 20);
            this.cbDLRaw.TabIndex = 10;
            this.cbDLRaw.Text = "DLRaw";
            this.cbDLRaw.UseVisualStyleBackColor = true;
            this.cbDLRaw.Click += new System.EventHandler(this.cbAnyLN);
            // 
            // cbAll
            // 
            this.cbAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAll.AutoSize = true;
            this.cbAll.Location = new System.Drawing.Point(953, 38);
            this.cbAll.Name = "cbAll";
            this.cbAll.Size = new System.Drawing.Size(85, 20);
            this.cbAll.TabIndex = 4;
            this.cbAll.Text = "Select All";
            this.cbAll.UseVisualStyleBackColor = true;
            this.cbAll.Click += new System.EventHandler(this.cbAll_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(1071, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openProgramFolderToolStripMenuItem,
            this.openSettingsFileToolStripMenuItem,
            this.toolStripSeparator5,
            this.resetSettingsToolStripMenuItem,
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
            this.openProgramFolderToolStripMenuItem.Click += new System.EventHandler(this.openProgramFolderToolStripMenuItem_Click);
            // 
            // openSettingsFileToolStripMenuItem
            // 
            this.openSettingsFileToolStripMenuItem.Name = "openSettingsFileToolStripMenuItem";
            this.openSettingsFileToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.openSettingsFileToolStripMenuItem.Text = "Open settings file";
            this.openSettingsFileToolStripMenuItem.ToolTipText = "Open settings.json";
            this.openSettingsFileToolStripMenuItem.Click += new System.EventHandler(this.openSettingsFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(231, 6);
            // 
            // resetSettingsToolStripMenuItem
            // 
            this.resetSettingsToolStripMenuItem.Name = "resetSettingsToolStripMenuItem";
            this.resetSettingsToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.resetSettingsToolStripMenuItem.Text = "Reset settings";
            this.resetSettingsToolStripMenuItem.Click += new System.EventHandler(this.resetSettingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(231, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.ToolTipText = "Close the application";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeDiscordTokenToolStripMenuItem,
            this.changeResultsToolStripMenuItem,
            this.toolStripSeparator2,
            this.copyTitleToolStripMenuItem,
            this.copyLinkOfSelectedToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // changeDiscordTokenToolStripMenuItem
            // 
            this.changeDiscordTokenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.changeDiscordTokenToolStripMenuItem.Name = "changeDiscordTokenToolStripMenuItem";
            this.changeDiscordTokenToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.changeDiscordTokenToolStripMenuItem.Text = "Change Discord token";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBox1_KeyPress);
            // 
            // changeResultsToolStripMenuItem
            // 
            this.changeResultsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox2});
            this.changeResultsToolStripMenuItem.Name = "changeResultsToolStripMenuItem";
            this.changeResultsToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.changeResultsToolStripMenuItem.Text = "Change results size";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox2.Text = "11";
            this.toolStripTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBox2_KeyPress);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(235, 6);
            // 
            // copyTitleToolStripMenuItem
            // 
            this.copyTitleToolStripMenuItem.Enabled = false;
            this.copyTitleToolStripMenuItem.Name = "copyTitleToolStripMenuItem";
            this.copyTitleToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.copyTitleToolStripMenuItem.Text = "Copy title of selected";
            this.copyTitleToolStripMenuItem.Click += new System.EventHandler(this.copyTitleToolStripMenuItem_Click);
            // 
            // copyLinkOfSelectedToolStripMenuItem
            // 
            this.copyLinkOfSelectedToolStripMenuItem.Enabled = false;
            this.copyLinkOfSelectedToolStripMenuItem.Name = "copyLinkOfSelectedToolStripMenuItem";
            this.copyLinkOfSelectedToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.copyLinkOfSelectedToolStripMenuItem.Text = "Copy link of selected";
            this.copyLinkOfSelectedToolStripMenuItem.Click += new System.EventHandler(this.copyLinkOfSelectedToolStripMenuItem_Click);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkScraperToolStripMenuItem,
            this.checkInternetConnectivityToolStripMenuItem,
            this.bigGUIScaleToolStripMenuItem,
            this.toolStripSeparator6,
            this.browseVisualNovelsToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // checkScraperToolStripMenuItem
            // 
            this.checkScraperToolStripMenuItem.Name = "checkScraperToolStripMenuItem";
            this.checkScraperToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.checkScraperToolStripMenuItem.Text = "Check scraper functionality";
            this.checkScraperToolStripMenuItem.ToolTipText = "Test to make sure the scrapers are working";
            this.checkScraperToolStripMenuItem.Click += new System.EventHandler(this.checkScraperToolStripMenuItem_Click);
            // 
            // checkInternetConnectivityToolStripMenuItem
            // 
            this.checkInternetConnectivityToolStripMenuItem.Name = "checkInternetConnectivityToolStripMenuItem";
            this.checkInternetConnectivityToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.checkInternetConnectivityToolStripMenuItem.Text = "Check internet connection";
            this.checkInternetConnectivityToolStripMenuItem.ToolTipText = "Check if you are connected to the internet";
            this.checkInternetConnectivityToolStripMenuItem.Click += new System.EventHandler(this.checkInternetConnectivityToolStripMenuItem_Click);
            // 
            // bigGUIScaleToolStripMenuItem
            // 
            this.bigGUIScaleToolStripMenuItem.Name = "bigGUIScaleToolStripMenuItem";
            this.bigGUIScaleToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.bigGUIScaleToolStripMenuItem.Text = "Increase GUI scale";
            this.bigGUIScaleToolStripMenuItem.Click += new System.EventHandler(this.bigGUIScaleToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(266, 6);
            // 
            // browseVisualNovelsToolStripMenuItem
            // 
            this.browseVisualNovelsToolStripMenuItem.Name = "browseVisualNovelsToolStripMenuItem";
            this.browseVisualNovelsToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.browseVisualNovelsToolStripMenuItem.Text = "Browse visual novels";
            this.browseVisualNovelsToolStripMenuItem.Click += new System.EventHandler(this.browseVisualNovelsToolStripMenuItem_Click);
            // 
            // btnVN
            // 
            this.btnVN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVN.Location = new System.Drawing.Point(948, 327);
            this.btnVN.Name = "btnVN";
            this.btnVN.Size = new System.Drawing.Size(102, 25);
            this.btnVN.TabIndex = 14;
            this.btnVN.Text = "Visual novels";
            this.btnVN.UseVisualStyleBackColor = true;
            this.btnVN.Click += new System.EventHandler(this.changeMedium);
            // 
            // btnLN
            // 
            this.btnLN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLN.Enabled = false;
            this.btnLN.Location = new System.Drawing.Point(948, 297);
            this.btnLN.Name = "btnLN";
            this.btnLN.Size = new System.Drawing.Size(102, 25);
            this.btnLN.TabIndex = 15;
            this.btnLN.Text = "Light novels";
            this.btnLN.UseVisualStyleBackColor = true;
            this.btnLN.Click += new System.EventHandler(this.changeMedium);
            // 
            // cbRyuu
            // 
            this.cbRyuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRyuu.AutoSize = true;
            this.cbRyuu.Location = new System.Drawing.Point(953, 376);
            this.cbRyuu.Name = "cbRyuu";
            this.cbRyuu.Size = new System.Drawing.Size(102, 20);
            this.cbRyuu.TabIndex = 16;
            this.cbRyuu.Text = "Ryuugames";
            this.cbRyuu.UseVisualStyleBackColor = true;
            this.cbRyuu.Visible = false;
            this.cbRyuu.Click += new System.EventHandler(this.cbAnyVN);
            // 
            // cbGGB
            // 
            this.cbGGB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbGGB.AutoSize = true;
            this.cbGGB.Location = new System.Drawing.Point(952, 428);
            this.cbGGB.Name = "cbGGB";
            this.cbGGB.Size = new System.Drawing.Size(88, 20);
            this.cbGGB.TabIndex = 17;
            this.cbGGB.Text = "GGBases";
            this.cbGGB.UseVisualStyleBackColor = true;
            this.cbGGB.Visible = false;
            this.cbGGB.Click += new System.EventHandler(this.cbAnyVN);
            // 
            // cbCrane
            // 
            this.cbCrane.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCrane.AutoSize = true;
            this.cbCrane.Location = new System.Drawing.Point(955, 402);
            this.cbCrane.Name = "cbCrane";
            this.cbCrane.Size = new System.Drawing.Size(106, 20);
            this.cbCrane.TabIndex = 17;
            this.cbCrane.Text = "Crane Anime";
            this.cbCrane.UseVisualStyleBackColor = true;
            this.cbCrane.Visible = false;
            this.cbCrane.Click += new System.EventHandler(this.cbAnyVN);
            // 
            // cbMiko
            // 
            this.cbMiko.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMiko.AutoSize = true;
            this.cbMiko.Location = new System.Drawing.Point(950, 480);
            this.cbMiko.Name = "cbMiko";
            this.cbMiko.Size = new System.Drawing.Size(58, 20);
            this.cbMiko.TabIndex = 17;
            this.cbMiko.Text = "Miko";
            this.cbMiko.UseVisualStyleBackColor = true;
            this.cbMiko.Visible = false;
            this.cbMiko.Click += new System.EventHandler(this.cbAnyVN);
            // 
            // cbAnimeSharing
            // 
            this.cbAnimeSharing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAnimeSharing.AutoSize = true;
            this.cbAnimeSharing.Location = new System.Drawing.Point(954, 454);
            this.cbAnimeSharing.Name = "cbAnimeSharing";
            this.cbAnimeSharing.Size = new System.Drawing.Size(113, 20);
            this.cbAnimeSharing.TabIndex = 17;
            this.cbAnimeSharing.Text = "AnimeSharing";
            this.cbAnimeSharing.UseVisualStyleBackColor = true;
            this.cbAnimeSharing.Visible = false;
            this.cbAnimeSharing.Click += new System.EventHandler(this.cbAnyVN);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(209, 6);
            // 
            // goToMessageToolStripMenuItem
            // 
            this.goToMessageToolStripMenuItem.Name = "goToMessageToolStripMenuItem";
            this.goToMessageToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.goToMessageToolStripMenuItem.Text = "Go to message";
            this.goToMessageToolStripMenuItem.Click += new System.EventHandler(this.goToMessageToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 509);
            this.Controls.Add(this.cbAnimeSharing);
            this.Controls.Add(this.cbMiko);
            this.Controls.Add(this.cbGGB);
            this.Controls.Add(this.cbRyuu);
            this.Controls.Add(this.btnVN);
            this.Controls.Add(this.btnLN);
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
            this.Controls.Add(this.cbCrane);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 410);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "LN Finder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem checkInternetConnectivityToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripMenuItem resetSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem copyTitleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyLinkOfSelectedToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyTitleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copyLinkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToLinkToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem resizeHeadersToFitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem clearListToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.Button btnVN;
        private System.Windows.Forms.Button btnLN;
        private System.Windows.Forms.CheckBox cbRyuu;
        private System.Windows.Forms.CheckBox cbGGB;
        private System.Windows.Forms.CheckBox cbCrane;
        private System.Windows.Forms.CheckBox cbMiko;
        private System.Windows.Forms.CheckBox cbAnimeSharing;
        private System.Windows.Forms.ToolStripMenuItem bigGUIScaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem browseVisualNovelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem goToMessageToolStripMenuItem;
    }
}

