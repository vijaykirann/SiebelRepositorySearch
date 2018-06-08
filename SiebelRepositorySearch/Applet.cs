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
        internal void AppletBS(string strRepId, string strSrch)
        {
            OdbcCommand dbCmd = SiebelRepositorySearch.conn.CreateCommand();
            dbCmd.CommandText = "SELECT S_APPLET.NAME,S_APLT_BRSSCRPT.NAME from siebel.S_APPLET,siebel.S_APLT_BRSSCRPT,siebel.S_REPOSITORY where S_APPLET.REPOSITORY_ID = '" + strRepId + "'  and S_APPLET.ROW_ID = S_APLT_BRSSCRPT.APPLET_ID and S_APLT_BRSSCRPT.SCRIPT like '" + strSrch + "'";
            OdbcDataReader dbReader = dbCmd.ExecuteReader();
            while (dbReader.Read())
            {
                SiebelRepositorySearch.resultlist.Add(new result("Applet Browser Script", dbReader[0].ToString(), dbReader[1].ToString(), "", "", ""));
            }
            dbReader.Close();
            dbCmd.Dispose();
        }
        internal void AppletSearchSpec(string strRepId, string strSrch)
        {
            OdbcCommand dbCmd = SiebelRepositorySearch.conn.CreateCommand();
            dbCmd.CommandText = "select S_APPLET.NAME,S_APPLET.SRCHSPEC from siebel.S_APPLET where S_APPLET.REPOSITORY_ID = '" + strRepId + "' AND S_APPLET.SRCHSPEC like '" + strSrch + "'";
            OdbcDataReader dbReader = dbCmd.ExecuteReader();
            while (dbReader.Read())
            {
                SiebelRepositorySearch.resultlist.Add(new result("Applet Search Spec", dbReader[0].ToString(), dbReader[1].ToString(), "", "", ""));
            }
            dbReader.Close();
            dbCmd.Dispose();
        }
        internal void AppletSS(string strRepId, string strSrch)
        {
            OdbcCommand dbCmd = SiebelRepositorySearch.conn.CreateCommand();
            dbCmd.CommandText = "SELECT S_APPLET.NAME,S_APPL_WEBSCRPT.NAME FROM SIEBEL.S_APPLET,SIEBEL.S_APPL_WEBSCRPT,SIEBEL.S_REPOSITORY WHERE S_APPLET.REPOSITORY_ID = '" + strRepId + "' and S_APPLET.ROW_ID = S_APPL_WEBSCRPT.APPLET_ID and S_APPL_WEBSCRPT.SCRIPT like '" + strSrch + "'";
            OdbcDataReader dbReader = dbCmd.ExecuteReader();
            while (dbReader.Read())
            {
                SiebelRepositorySearch.resultlist.Add(new result("Applet Server Script", dbReader[0].ToString(), dbReader[1].ToString(), "", "", ""));
            }
            dbReader.Close();
            dbCmd.Dispose();
        }
        internal void AppletUPV(string strRepId, string strSrch)
        {
            OdbcCommand dbCmd = SiebelRepositorySearch.conn.CreateCommand();
            dbCmd.CommandText = "SELECT S_APPLET.NAME,S_APPLET_UPROP.NAME,S_APPLET_UPROP.VALUE FROM siebel.S_APPLET,siebel.S_APPLET_UPROP,siebel.S_REPOSITORY WHERE S_APPLET.REPOSITORY_ID = '" + strRepId + "' and S_APPLET.ROW_ID = S_APPLET_UPROP.APPLET_ID AND S_APPLET_UPROP.VALUE like '" + strSrch + "'";
            OdbcDataReader dbReader = dbCmd.ExecuteReader();
            while (dbReader.Read())
            {
                SiebelRepositorySearch.resultlist.Add(new result("Applet User Property", dbReader[0].ToString(), dbReader[1].ToString(), dbReader[2].ToString(), "", ""));
            }
            dbReader.Close();
            dbCmd.Dispose();
        }
        internal void AppletLCUP(string strRepId, string strSrch)
        {
            OdbcCommand dbCmd = SiebelRepositorySearch.conn.CreateCommand();
            dbCmd.CommandText = "SELECT S_APPLET.NAME,S_LIST_COLUMN.NAME,S_LISTCOL_UPROP.NAME,S_LISTCOL_UPROP.VALUE from siebel.S_APPLET,siebel.S_LIST,siebel.S_LIST_COLUMN,siebel.S_LISTCOL_UPROP,siebel.S_REPOSITORY where S_APPLET.REPOSITORY_ID='" + strRepId + "' and S_APPLET.ROW_ID=S_LIST.APPLET_ID and S_LIST.ROW_ID=S_LIST_COLUMN.LIST_ID and S_LIST_COLUMN.ROW_ID=S_LISTCOL_UPROP.LIST_COLUMN_ID and S_LISTCOL_UPROP.NAME like '" + strSrch + "'";
            OdbcDataReader dbReader = dbCmd.ExecuteReader();
            while (dbReader.Read())
            {
                SiebelRepositorySearch.resultlist.Add(new result("Applet List Column User Property", dbReader[0].ToString(), dbReader[1].ToString(), dbReader[2].ToString(), dbReader[3].ToString(), ""));
            }
            dbReader.Close();
            dbCmd.Dispose();
        }
    }
}
