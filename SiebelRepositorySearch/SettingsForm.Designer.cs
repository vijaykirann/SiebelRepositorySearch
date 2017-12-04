namespace SiebelRepositorySearch
{
    partial class SettingsForm
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
            this.AppletSrchSpec = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.txtUN = new System.Windows.Forms.TextBox();
            this.txtDB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AppletBS = new System.Windows.Forms.CheckBox();
            this.AppletSS = new System.Windows.Forms.CheckBox();
            this.AppletUPV = new System.Windows.Forms.CheckBox();
            this.AppletCUP = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AppletSrchSpec
            // 
            this.AppletSrchSpec.AutoSize = true;
            this.AppletSrchSpec.Location = new System.Drawing.Point(12, 167);
            this.AppletSrchSpec.Name = "AppletSrchSpec";
            this.AppletSrchSpec.Size = new System.Drawing.Size(115, 17);
            this.AppletSrchSpec.TabIndex = 0;
            this.AppletSrchSpec.Text = "AppletSearchSpec";
            this.AppletSrchSpec.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ConnectString";
            // 
            // txtCN
            // 
            this.txtCN.Location = new System.Drawing.Point(116, 20);
            this.txtCN.Name = "txtCN";
            this.txtCN.Size = new System.Drawing.Size(202, 20);
            this.txtCN.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Username";
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(116, 72);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(202, 20);
            this.txtPW.TabIndex = 7;
            // 
            // txtUN
            // 
            this.txtUN.Location = new System.Drawing.Point(116, 46);
            this.txtUN.Name = "txtUN";
            this.txtUN.Size = new System.Drawing.Size(202, 20);
            this.txtUN.TabIndex = 6;
            // 
            // txtDB
            // 
            this.txtDB.FormattingEnabled = true;
            this.txtDB.Items.AddRange(new object[] {
            "Oracle\\Local",
            "SQL"});
            this.txtDB.Location = new System.Drawing.Point(116, 98);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(122, 21);
            this.txtDB.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "DB Type";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtUN);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCN);
            this.groupBox1.Controls.Add(this.txtDB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPW);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 136);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection Information";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(451, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Test Connection";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(451, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Save \'n\' Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AppletBS
            // 
            this.AppletBS.AutoSize = true;
            this.AppletBS.Location = new System.Drawing.Point(153, 167);
            this.AppletBS.Name = "AppletBS";
            this.AppletBS.Size = new System.Drawing.Size(132, 17);
            this.AppletBS.TabIndex = 13;
            this.AppletBS.Text = "Applet Browser Scripts";
            this.AppletBS.UseVisualStyleBackColor = true;
            // 
            // AppletSS
            // 
            this.AppletSS.AutoSize = true;
            this.AppletSS.Location = new System.Drawing.Point(307, 167);
            this.AppletSS.Name = "AppletSS";
            this.AppletSS.Size = new System.Drawing.Size(120, 17);
            this.AppletSS.TabIndex = 14;
            this.AppletSS.Text = "Applet Server Script";
            this.AppletSS.UseVisualStyleBackColor = true;
            // 
            // AppletUPV
            // 
            this.AppletUPV.AutoSize = true;
            this.AppletUPV.Location = new System.Drawing.Point(445, 167);
            this.AppletUPV.Name = "AppletUPV";
            this.AppletUPV.Size = new System.Drawing.Size(136, 17);
            this.AppletUPV.TabIndex = 15;
            this.AppletUPV.Text = "Applet User Prop Value";
            this.AppletUPV.UseVisualStyleBackColor = true;
            // 
            // AppletCUP
            // 
            this.AppletCUP.AutoSize = true;
            this.AppletCUP.Location = new System.Drawing.Point(12, 191);
            this.AppletCUP.Name = "AppletCUP";
            this.AppletCUP.Size = new System.Drawing.Size(142, 17);
            this.AppletCUP.TabIndex = 16;
            this.AppletCUP.Text = "Applet Control User Prop";
            this.AppletCUP.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 298);
            this.Controls.Add(this.AppletCUP);
            this.Controls.Add(this.AppletUPV);
            this.Controls.Add(this.AppletSS);
            this.Controls.Add(this.AppletBS);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AppletSrchSpec);
            this.Name = "SettingsForm";
            this.Text = "d";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox AppletSrchSpec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.TextBox txtUN;
        private System.Windows.Forms.ComboBox txtDB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox AppletBS;
        private System.Windows.Forms.CheckBox AppletSS;
        private System.Windows.Forms.CheckBox AppletUPV;
        private System.Windows.Forms.CheckBox AppletCUP;
    }
}