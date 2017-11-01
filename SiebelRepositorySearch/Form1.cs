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
            var strRepId = Properties.Settings.Default.RepId;
            string strSrch = txtSearch.Text;
            string strSrchType = strSearchTyp.SelectedItem.ToString();
            string Wildsrch = "Wildcard Search";
            if (strSrchType == Wildsrch)
            strSrch = "%"+ strSrch + "%";
            string connstr = "DSN=" + txtCN + ";Uid=" + txtUN + ";Pwd=" + txtPW + "";
            //OdbcConnection conn = new OdbcConnection("DSN=SSD Local Db default instance;Uid=SADMIN;Pwd=SADMIN");
            conn = new OdbcConnection(connstr);
            conn.Open();
            AppletSearchSpec(strRepId,strSrch);
//            AppletBS(strRepId, strSrch);
            conn.Close();
        }

        private void AppletBS(string strRepId, string strSrch)
        {
            throw new NotImplementedException();
        }

        private void AppletSearchSpec(string strRepId, string strSrch)
        {
            OdbcCommand dbCmd = conn.CreateCommand();
            dbCmd.CommandText = "select S_REPOSITORY.NAME as REP_NAME, S_APPLET.NAME as NAME1,S_APPLET.SRCHSPEC as VALUE from siebel.S_APPLET,siebel.S_REPOSITORY where S_APPLET.REPOSITORY_ID = S_REPOSITORY.ROW_ID AND S_REPOSITORY.ROW_ID = '"+ strRepId + "' AND S_APPLET.SRCHSPEC like '"+ strSrch + "'";
            OdbcDataReader dbReader = dbCmd.ExecuteReader();
            while(dbReader.Read())
            {
                var A = dbReader[1].ToString();
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
