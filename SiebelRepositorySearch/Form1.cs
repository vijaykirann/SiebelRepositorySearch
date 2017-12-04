using System;
using System.IO;
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

    public partial class SiebelRepositorySearch : Form
    {
 //       object[] objRow;
        public static OdbcConnection conn;
        public static List<result> resultlist = new List<result>();
        public SiebelRepositorySearch()
        {
            InitializeComponent();
            label1.Text = Properties.Settings.Default.ConnectString;
         }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public void button1_Click(object sender, EventArgs ex)
        {
            if (txtSearch.Text == "")
                MessageBox.Show("Did you miss something ?");
            else {
                var strRepId = "";
                string strSrch = "";
                try
                {
                    Applet Aplt = new Applet();
                    var txtCN = Properties.Settings.Default.ConnectString;
                    var txtUN = Properties.Settings.Default.Usr;
                    var txtPW = Properties.Settings.Default.Pwd;
                    var txtDB = Properties.Settings.Default.DBType;
                    strRepId = Properties.Settings.Default.RepId;
                    strSrch = txtSearch.Text;
                    string strSrchType = strSearchTyp.SelectedItem.ToString();
                    string Wildsrch = "Wildcard Search";
                    if (strSrchType == Wildsrch)
                        strSrch = "%" + strSrch + "%";
                    string connstr = "DSN=" + txtCN + ";Uid=" + txtUN + ";Pwd=" + txtPW + "";
                    conn = new OdbcConnection(connstr);
                    conn.Open();                    
                    if (Properties.Settings.Default.AppletSearchSpec == true)
                    {
                        toolStripStatusLabel1.Text = "Applet Serch Spec";
                        statusStrip1.Refresh();
                        AppletSearchSpec(strRepId, strSrch);
                    }
                    if (Properties.Settings.Default.AppletBS == true)
                    {
                        toolStripStatusLabel1.Text = "Applet Browser Script";
                        statusStrip1.Refresh();
                        AppletBS(strRepId, strSrch);
                    }
                    if (Properties.Settings.Default.AppletSS == true)
                    {
                        toolStripStatusLabel1.Text = "Applet Server Scripts";
                        statusStrip1.Refresh();
                        AppletSS(strRepId, strSrch);
                    }
                    if (Properties.Settings.Default.AppletUPV == true)
                    {
                        toolStripStatusLabel1.Text = "Applet User Property Values";
                        statusStrip1.Refresh();
                        AppletUPV(strRepId, strSrch);
                    }
                    if (Properties.Settings.Default.AppletCUP == true)
                    {
                        toolStripStatusLabel1.Text = "Applet Control User Property Values";
                        statusStrip1.Refresh();
                        Aplt.AppletCUP(strRepId, strSrch);
                    }
                    if (Properties.Settings.Default.AppletDDDV == true)
                    {
                        toolStripStatusLabel1.Text = "Applet Dynamic Drilldown Destination";
                        statusStrip1.Refresh();
                        Aplt.AppletDDDV(strRepId, strSrch);
                    }
                    //Closing Events from here//
                    conn.Close();
                    toolStripStatusLabel1.Text = "Done";
                    statusStrip1.Refresh();
                    this.ResultListView.SetObjects(resultlist);
                    this.collapseGroup();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                finally
                {
                    resultlist.Clear();
                    strRepId = "";
                    strSrch = "";
                }
            }        
        }

        private void collapseGroup()
        {
            for (int i = 0; i < ResultListView.OLVGroups.Count; i++)
            {
                OLVGroup grp = ResultListView.OLVGroups[i];
                grp.Collapsed = true;
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
        private void AppletSS(string strRepId, string strSrch)
        {
            OdbcCommand dbCmd = conn.CreateCommand();
            dbCmd.CommandText = "SELECT S_APPLET.NAME,S_APPL_WEBSCRPT.NAME FROM SIEBEL.S_APPLET,SIEBEL.S_APPL_WEBSCRPT,SIEBEL.S_REPOSITORY WHERE S_APPLET.REPOSITORY_ID = '"+ strRepId + "' and S_APPLET.ROW_ID = S_APPL_WEBSCRPT.APPLET_ID and S_APPL_WEBSCRPT.SCRIPT like '" + strSrch + "'";
            OdbcDataReader dbReader = dbCmd.ExecuteReader();
            while (dbReader.Read())
            {
                resultlist.Add(new result("Applet Server Script", dbReader[0].ToString(), dbReader[1].ToString(), "", "", ""));
            }
            dbReader.Close();
            dbCmd.Dispose();
        }
        private void AppletUPV(string strRepId, string strSrch)
        {
            OdbcCommand dbCmd = conn.CreateCommand();
            dbCmd.CommandText = "SELECT S_APPLET.NAME,S_APPLET_UPROP.NAME,S_APPLET_UPROP.VALUE FROM siebel.S_APPLET,siebel.S_APPLET_UPROP,siebel.S_REPOSITORY WHERE S_APPLET.REPOSITORY_ID = '" + strRepId + "' and S_APPLET.ROW_ID = S_APPLET_UPROP.APPLET_ID AND S_APPLET_UPROP.VALUE like '" + strSrch + "'";
            OdbcDataReader dbReader = dbCmd.ExecuteReader();
            while (dbReader.Read())
            {
                resultlist.Add(new result("Applet User Property Value", dbReader[0].ToString(), dbReader[1].ToString(), dbReader[2].ToString(), "", ""));
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
