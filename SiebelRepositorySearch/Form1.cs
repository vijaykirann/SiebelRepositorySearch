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
            this.SetupGeneralListViewEvents();
        }

        private void SetupGeneralListViewEvents()
        {
            if (this.ResultListView == null )
                return;
            this.ResultListView.HotItemChanged += delegate (object sender, HotItemChangedEventArgs args) {
                this.HandleHotItemChanged(sender, args);
            };
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
                        Aplt.AppletSearchSpec(strRepId, strSrch);
                    }
                    if (Properties.Settings.Default.AppletBS == true)
                    {
                        toolStripStatusLabel1.Text = "Applet Browser Script";
                        statusStrip1.Refresh();
                        Aplt.AppletBS(strRepId, strSrch);
                    }
                    if (Properties.Settings.Default.AppletSS == true)
                    {
                        toolStripStatusLabel1.Text = "Applet Server Scripts";
                        statusStrip1.Refresh();
                        Aplt.AppletSS(strRepId, strSrch);
                    }
                    if (Properties.Settings.Default.AppletUPV == true)
                    {
                        toolStripStatusLabel1.Text = "Applet User Property Values";
                        statusStrip1.Refresh();
                        Aplt.AppletUPV(strRepId, strSrch);
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


                //    foreach (OLVColumn col in this.ResultListView.Columns)
                //    {
                //        object GrpKey = col.GetGroupKey(this.ResultListView.Groups);
                //        col.MakeGroupies(
                //new object[] { "Applet Control User Property", "Applet User Property Value", "Applet Server Script", "Applet Search Spec" },
                //new string[] { "a", "b", "c", "d", "e" },
                //new string[] { "", "hamburger", "toast", "beef", "chef" },
                //new string[] {
                //    "Pay good money -- or flee the house -- rather than eat their home-cooked food",
                //    "Offer to buy takeaway rather than risk what may appear on your plate",
                //    "Neither spectacular nor dangerous",
                //    "Try to visit at dinner time to wrangle an invitation to dinner",
                //    "Do whatever is necessary to procure their services"
                //},
                //new string[] { "Call 911", "Phone PizzaHut", "", "Open calendar", "Check bank balance" }
                //            );
                //    }
            
                    this.ResultListView.SetObjects(resultlist);
                    this.collapseGroup();

                    HotItemStyle hotItemStyle = new HotItemStyle();
                    hotItemStyle.ForeColor = Color.White;
                    hotItemStyle.BackColor = Color.FromArgb(255, 64, 64, 64);
                    ResultListView.HotItemStyle = hotItemStyle;
                    HotItemChangedEventArgs HotItemChanged = new HotItemChangedEventArgs();

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
        public void HandleHotItemChanged(object sender, HotItemChangedEventArgs e)
        {
            if (sender == null)
            {
                toolStripStatusLabel1.Text = "Nothing";
                return;
            }

            if (e.HotGroup != null)
            {
                this.ResultListView.Columns[0].Text = e.HotGroup.Header.ToString();
                this.ResultListView.Columns[1].Text="TEST1";
                toolStripStatusLabel1.Text = String.Format("Over group '{0}', {1}", e.HotGroup.Header, e.HotCellHitLocationEx);
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
