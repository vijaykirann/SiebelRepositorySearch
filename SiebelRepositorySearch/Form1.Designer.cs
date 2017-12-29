namespace SiebelRepositorySearch
{
    partial class SiebelRepositorySearch
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.strSearchTyp = new System.Windows.Forms.ComboBox();
            this.ResultListView = new BrightIdeasSoftware.ObjectListView();
            this._ObjectName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._Name = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._SubObject = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._SubObject1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._SubObject2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._SubObject3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.ObjectName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultListView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(502, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(117, 41);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(295, 20);
            this.txtSearch.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Search String";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(589, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSettingsToolStripMenuItem});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingToolStripMenuItem.Text = "Settings";
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
            // 
            // openSettingsToolStripMenuItem
            // 
            this.openSettingsToolStripMenuItem.Name = "openSettingsToolStripMenuItem";
            this.openSettingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.openSettingsToolStripMenuItem.Text = "Settings";
            this.openSettingsToolStripMenuItem.Click += new System.EventHandler(this.openSettingsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ConnectionString";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Search Type";
            // 
            // strSearchTyp
            // 
            this.strSearchTyp.FormattingEnabled = true;
            this.strSearchTyp.Items.AddRange(new object[] {
            "Wildcard Search",
            "Exact Search"});
            this.strSearchTyp.Location = new System.Drawing.Point(117, 67);
            this.strSearchTyp.Name = "strSearchTyp";
            this.strSearchTyp.Size = new System.Drawing.Size(146, 21);
            this.strSearchTyp.TabIndex = 13;
            this.strSearchTyp.Text = "Wildcard Search";
            // 
            // ResultListView
            // 
            this.ResultListView.AllColumns.Add(this._ObjectName);
            this.ResultListView.AllColumns.Add(this._Name);
            this.ResultListView.AllColumns.Add(this._SubObject);
            this.ResultListView.AllColumns.Add(this._SubObject1);
            this.ResultListView.AllColumns.Add(this._SubObject2);
            this.ResultListView.AllColumns.Add(this._SubObject3);
            this.ResultListView.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ResultListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultListView.CellEditUseWholeCell = false;
            this.ResultListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._ObjectName,
            this._Name,
            this._SubObject,
            this._SubObject1,
            this._SubObject2,
            this._SubObject3});
            this.ResultListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.ResultListView.HeaderUsesThemes = true;
            this.ResultListView.Location = new System.Drawing.Point(0, 108);
            this.ResultListView.Name = "ResultListView";
            this.ResultListView.ShowItemToolTips = true;
            this.ResultListView.Size = new System.Drawing.Size(589, 154);
            this.ResultListView.TabIndex = 14;
            this.ResultListView.UseCompatibleStateImageBehavior = false;
            this.ResultListView.UseHotItem = true;
            this.ResultListView.View = System.Windows.Forms.View.Details;
            // 
            // _ObjectName
            // 
            this._ObjectName.AspectName = "ObjectName";
            this._ObjectName.Text = "ObjectName";
            this._ObjectName.Width = 120;
            // 
            // _Name
            // 
            this._Name.AspectName = "Name";
            this._Name.AspectToStringFormat = "";
            this._Name.Text = "Name";
            this._Name.Width = 300;
            // 
            // _SubObject
            // 
            this._SubObject.AspectName = "SubObject";
            this._SubObject.Text = "SubObject";
            this._SubObject.Width = 120;
            // 
            // _SubObject1
            // 
            this._SubObject1.AspectName = "SubObject1";
            this._SubObject1.Text = "SubObject1";
            this._SubObject1.Width = 120;
            // 
            // _SubObject2
            // 
            this._SubObject2.AspectName = "SubObject2";
            this._SubObject2.Text = "SubObject2";
            this._SubObject2.Width = 120;
            // 
            // _SubObject3
            // 
            this._SubObject3.AspectName = "SubObject3";
            this._SubObject3.Text = "SubObject3";
            this._SubObject3.Width = 120;
            // 
            // ObjectName
            // 
            this.ObjectName.DisplayIndex = 0;
            this.ObjectName.Width = 123;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 265);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(589, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "Progress";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // SiebelRepositorySearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 287);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ResultListView);
            this.Controls.Add(this.strSearchTyp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(605, 325);
            this.Name = "SiebelRepositorySearch";
            this.Text = "Siebel Repository Search";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultListView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox strSearchTyp;
        private BrightIdeasSoftware.OLVColumn ObjectName;
        private BrightIdeasSoftware.OLVColumn _Name;
        private BrightIdeasSoftware.OLVColumn _ObjectName;
        private BrightIdeasSoftware.OLVColumn _SubObject;
        private BrightIdeasSoftware.OLVColumn _SubObject1;
        private BrightIdeasSoftware.OLVColumn _SubObject2;
        private BrightIdeasSoftware.OLVColumn _SubObject3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public BrightIdeasSoftware.ObjectListView ResultListView;
    }
}

