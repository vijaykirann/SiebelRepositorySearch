using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiebelRepositorySearch
{
    public partial class SettingsForm : Form
    {
        bool cansav = false;
        public SettingsForm()
        {
            InitializeComponent();
            txtCN.Text = Properties.Settings.Default.ConnectString;
            txtUN.Text = Properties.Settings.Default.Usr;
            txtPW.Text = Properties.Settings.Default.Pwd;
            txtDB.Text = Properties.Settings.Default.DBType;
            AppletSrchSpec.Checked= Properties.Settings.Default.AppletSearchSpec;
            AppletBS.Checked = Properties.Settings.Default.AppletBS;
            AppletSS.Checked = Properties.Settings.Default.AppletSS;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cansav == true)
            {
                Properties.Settings.Default.ConnectString = txtCN.Text;
                Properties.Settings.Default.Usr = txtUN.Text;
                Properties.Settings.Default.Pwd = txtPW.Text;
                Properties.Settings.Default.DBType = txtDB.Text;
            }
            else
            {
                MessageBox.Show("Test the Connection before Saving.");
            }
            Properties.Settings.Default.AppletSearchSpec = AppletSrchSpec.Checked;
            Properties.Settings.Default.AppletBS = AppletBS.Checked;
            Properties.Settings.Default.AppletSS = AppletSS.Checked;
            Properties.Settings.Default.Save();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var tstCN = txtCN.Text;
                var tstUN = txtUN.Text;
                var tstPW = txtPW.Text;
                var tstDB = txtDB.Text;
                string tstconnstr = "DSN=" + tstCN + ";Uid=" + tstUN + ";Pwd=" + tstPW + "";
                OdbcConnection tstconn = new OdbcConnection(tstconnstr);
                tstconn.Open();
                OdbcCommand tstdbCmd = tstconn.CreateCommand();
                tstdbCmd.CommandText = "SELECT ROW_ID FROM SIEBEL.S_REPOSITORY WHERE INACTIVE_FLG is null";
                OdbcDataReader tstdbReader = tstdbCmd.ExecuteReader();
                while(tstdbReader.Read())
                {
                    Properties.Settings.Default.RepId = tstdbReader[0].ToString();
                    Properties.Settings.Default.Save();
                }
                MessageBox.Show("Connextion Sucessful.Goahead and Save it !!");
                cansav = true;
            }
            catch
            {
                MessageBox.Show("Invalid Connextion");
            }
        }
    }
}
