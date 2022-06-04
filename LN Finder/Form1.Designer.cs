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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxSearch
            // 
            this.tbxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearch.Location = new System.Drawing.Point(97, 12);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(803, 30);
            this.tbxSearch.TabIndex = 0;
            this.tbxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSearch_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(12, 12);
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
            this.cbDiscord.Location = new System.Drawing.Point(913, 12);
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
            this.cbBoroboro.Location = new System.Drawing.Point(914, 38);
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
            this.cbItazuraneko.Location = new System.Drawing.Point(916, 64);
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
            this.cbZLib.Location = new System.Drawing.Point(914, 90);
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
            this.listView1.Location = new System.Drawing.Point(12, 64);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(888, 439);
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
            this.numericUpDown1.Location = new System.Drawing.Point(909, 202);
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
            this.label1.Location = new System.Drawing.Point(905, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Results Size:";
            // 
            // cbNyaa
            // 
            this.cbNyaa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbNyaa.AutoSize = true;
            this.cbNyaa.Location = new System.Drawing.Point(911, 116);
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
            this.cbDLRaw.Location = new System.Drawing.Point(912, 142);
            this.cbDLRaw.Name = "cbDLRaw";
            this.cbDLRaw.Size = new System.Drawing.Size(73, 20);
            this.cbDLRaw.TabIndex = 3;
            this.cbDLRaw.Text = "DLRaw";
            this.cbDLRaw.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.cbDiscord);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbxSearch);
            this.MinimumSize = new System.Drawing.Size(358, 184);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "LN Finder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
    }
}

