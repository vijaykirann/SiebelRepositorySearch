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
using BrightIdeasSoftware;

namespace SiebelRepositorySearch
{

    public partial class Form1 : Form
    {
 //       object[] objRow;
        OdbcConnection conn;
        static internal List<result> resultlist = new List<result>();
        public Form1()
        {
            InitializeComponent();
            label1.Text = Properties.Settings.Default.ConnectString;
         }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            try {
                var txtCN = Properties.Settings.Default.ConnectString;
                var txtUN = Properties.Settings.Default.Usr;
                var txtPW = Properties.Settings.Default.Pwd;
                var txtDB = Properties.Settings.Default.DBType;
                var strRepId = Properties.Settings.Default.RepId;
                string strSrch = txtSearch.Text;
                string strSrchType = strSearchTyp.SelectedItem.ToString();
                string Wildsrch = "Wildcard Search";
                if (strSrchType == Wildsrch)
                    strSrch = "%" + strSrch + "%";
                string connstr = "DSN=" + txtCN + ";Uid=" + txtUN + ";Pwd=" + txtPW + "";
                conn = new OdbcConnection(connstr);
                conn.Open();
                if(Properties.Settings.Default.AppletSearchSpec == true)
                AppletSearchSpec(strRepId, strSrch);
                if(Properties.Settings.Default.AppletBS == true)
                AppletBS(strRepId, strSrch);
                conn.Close();
                
            }
            catch
                {
                    MessageBox.Show("Invalid Connextion");
                }
        }

        private void AppletBS(string strRepId, string strSrch)
        {
            OdbcCommand dbCmd = conn.CreateCommand();
            dbCmd.CommandText = "SELECT S_APPLET.NAME,S_APLT_BRSSCRPT.NAME from siebel.S_APPLET,siebel.S_APLT_BRSSCRPT,siebel.S_REPOSITORY where S_APPLET.REPOSITORY_ID = '" + strRepId + "'  and S_APPLET.ROW_ID = S_APLT_BRSSCRPT.APPLET_ID and S_APLT_BRSSCRPT.SCRIPT like '" + strSrch + "'";
            OdbcDataReader dbReader = dbCmd.ExecuteReader();
            while (dbReader.Read())
            {
                 resultlist.Add(new result("Applet Browser Script", dbReader[0].ToString(), dbReader[1].ToString(), "", "", ""));
            }
            dbReader.Close();
            dbCmd.Dispose();

        }

        private void AppletSearchSpec(string strRepId, string strSrch)
        {
            OdbcCommand dbCmd = conn.CreateCommand();
            dbCmd.CommandText = "select S_APPLET.NAME,S_APPLET.SRCHSPEC from siebel.S_APPLET where S_APPLET.REPOSITORY_ID = '"+ strRepId + "' AND S_APPLET.SRCHSPEC like '"+ strSrch + "'";
            OdbcDataReader dbReader = dbCmd.ExecuteReader();
            while(dbReader.Read())
            {
                resultlist.Add(new result("Applet Search Spec", dbReader[0].ToString(), dbReader[1].ToString(), "", "",""));
            }
            dbReader.Close();
            dbCmd.Dispose();
        }

        private void openSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm SF = new SettingsForm();
            SF.ShowDialog();
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
