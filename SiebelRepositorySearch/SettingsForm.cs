using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiebelRepositorySearch
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            txtCN.Text = Properties.Settings.Default.ConnectString;
            txtUN.Text = Properties.Settings.Default.Usr;
            txtPW.Text = Properties.Settings.Default.Pwd;
            txtDB.Text = Properties.Settings.Default.DBType;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ConnectString = txtCN.Text;
            Properties.Settings.Default.Usr = txtUN.Text;
            Properties.Settings.Default.Pwd = txtPW.Text;
            Properties.Settings.Default.DBType = txtDB.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
