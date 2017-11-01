using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace SiebelRepositorySearch
{
    public partial class Form1 : Form
    {
        OdbcConnection conn;
        public Form1()
        {
            InitializeComponent();
            label1.Text = Properties.Settings.Default.ConnectString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var txtCN = Properties.Settings.Default.ConnectString;
            var txtUN = Properties.Settings.Default.Usr;
            var txtPW = Properties.Settings.Default.Pwd;
            var txtDB = Properties.Settings.Default.DBType;
            string connstr = "DSN=" + txtCN + ";Uid=" + txtUN + ";Pwd=" + txtPW + "";
            //OdbcConnection conn = new OdbcConnection("DSN=SSD Local Db default instance;Uid=SADMIN;Pwd=SADMIN");
            conn = new OdbcConnection(connstr);
            conn.Open();
            AppletSearchSpec();
            conn.Close();
        }

        private void AppletSearchSpec()
        {
            OdbcCommand dbCmd = conn.CreateCommand();
            dbCmd.CommandText = "SELECT * FROM SIEBEL.S_ORG_EXT";
            OdbcDataReader dbReader = dbCmd.ExecuteReader();
            while(dbReader.Read())
            {
                var A = dbReader[0].ToString();
            }
            dbReader.Close();
            dbCmd.Dispose();
        }

        private void openSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm SF = new SettingsForm();
            SF.ShowDialog();
        }
    }
}
