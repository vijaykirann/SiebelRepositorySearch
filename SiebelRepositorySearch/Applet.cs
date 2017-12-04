using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiebelRepositorySearch
{
    public class Applet
    {
        internal void AppletCUP(string strRepId, string strSrch)
        {
            OdbcCommand dbCmd = SiebelRepositorySearch.conn.CreateCommand();            
            dbCmd.CommandText = "select S_APPLET.NAME,S_CONTROL.NAME,S_CONTROL_UPROP.NAME,S_CONTROL_UPROP.VALUE from siebel.S_APPLET,siebel.S_CONTROL,siebel.S_CONTROL_UPROP,siebel.S_REPOSITORY where S_APPLET.REPOSITORY_ID = '" + strRepId + "' and S_APPLET.ROW_ID=S_CONTROL.APPLET_ID and S_CONTROL.ROW_ID=S_CONTROL_UPROP.CONTROL_ID and S_CONTROL_UPROP.VALUE like '" + strSrch + "'";
            OdbcDataReader dbReader = dbCmd.ExecuteReader();
            while (dbReader.Read())
            {
                SiebelRepositorySearch.resultlist.Add(new result("Applet Control User Property", dbReader[0].ToString(), dbReader[1].ToString(), dbReader[2].ToString(), dbReader[3].ToString(), ""));
            }
            dbReader.Close();
            dbCmd.Dispose();
        }

        internal void AppletDDDV(string strRepId, string strSrch)
        {
            OdbcCommand dbCmd = SiebelRepositorySearch.conn.CreateCommand();
            dbCmd.CommandText = "select S_APPLET.NAME,S_DDOWN_OBJECT.NAME,S_DDOWN_DYNDEST.NAME,S_DDOWN_DYNDEST.VALUE from siebel.S_APPLET,siebel.S_DDOWN_OBJECT,siebel.S_DDOWN_DYNDEST,siebel.S_REPOSITORY where S_APPLET.REPOSITORY_ID='" + strRepId + "' and S_APPLET.ROW_ID=S_DDOWN_OBJECT.APPLET_ID and S_DDOWN_OBJECT.ROW_ID=S_DDOWN_DYNDEST.DDOWN_OBJECT_ID and S_DDOWN_DYNDEST.VALUE like '" + strSrch + "'";
            OdbcDataReader dbReader = dbCmd.ExecuteReader();
            while (dbReader.Read())
            {
                SiebelRepositorySearch.resultlist.Add(new result("Applet Dynamic Drilldown Destination", dbReader[0].ToString(), dbReader[1].ToString(), dbReader[2].ToString(), dbReader[3].ToString(), ""));
            }
            dbReader.Close();
            dbCmd.Dispose();
        }
    }
}
