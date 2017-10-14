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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OdbcConnection conn = new OdbcConnection("DSN=SSD Local Db default instance;Uid=SADMIN;Pwd=SADMIN");
           // conn.ConnectionString = "Driver={Oracle ODBC Driver};Dbq=SSD Local Db default instance;Uid=SADMIN;Pwd=SADMIN;";
            conn.Open();
            OdbcCommand dbCmd = conn.CreateCommand();
            dbCmd.CommandText = "SELECT * FROM SIEBEL.S_ORG_EXT";
            OdbcDataReader dbReader = dbCmd.ExecuteReader();
            int fCount = dbReader.FieldCount;
            Console.Write(":");
            for (int i = 0; i < fCount; i++)
            {
                String fName = dbReader.GetName(i);
                Console.Write(fName + ":");
            }
            Console.WriteLine();

        }
    }
}
