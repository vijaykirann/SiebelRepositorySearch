using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace SiebelRepositorySearch
{
    public class Appl
    {
        internal void ApplBS(string strRepId, string strSrch)
        {
            OdbcCommand dbCmd = SiebelRepositorySearch.conn.CreateCommand();
            dbCmd.CommandText = "select S_APPLICATION.NAME,S_APPL_BRSSCRPT.NAME,S_APPL_BRSSCRPT.SCRIPT from siebel.S_APPLICATION,siebel.S_APPL_BRSSCRPT,siebel.S_REPOSITORY where S_APPLICATION.REPOSITORY_ID='" + strRepId + "'  and S_APPLICATION.ROW_ID=S_APPL_BRSSCRPT.APPLICATION_ID AND S_APPL_BRSSCRPT.SCRIPT like '" + strSrch + "'";
            OdbcDataReader dbReader = dbCmd.ExecuteReader();
            while (dbReader.Read())
            {
                SiebelRepositorySearch.resultlist.Add(new result("Application Browser Script", dbReader[0].ToString(), dbReader[1].ToString(), dbReader[2].ToString(), dbReader[3].ToString(), ""));
            }
            dbReader.Close();
            dbCmd.Dispose();
        }
        internal void ApplSS(string strRepId, string strSrch)
        {
            OdbcCommand dbCmd = SiebelRepositorySearch.conn.CreateCommand();
            dbCmd.CommandText = "select S_APPLICATION.NAME,S_APPL_SCRIPT.NAME,S_APPL_SCRIPT.SCRIPT from siebel.S_APPLICATION,siebel.S_APPL_SCRIPT,siebel.S_REPOSITORY where S_APPLICATION.REPOSITORY_ID='" + strRepId + "' and S_APPLICATION.ROW_ID=S_APPL_SCRIPT.APPLICATION_ID AND S_APPL_SCRIPT.SCRIPT like '" + strSrch + "'";
            OdbcDataReader dbReader = dbCmd.ExecuteReader();
            while (dbReader.Read())
            {
                SiebelRepositorySearch.resultlist.Add(new result("Application Server Script", dbReader[0].ToString(), dbReader[1].ToString(), dbReader[2].ToString(), dbReader[3].ToString(), ""));
            }
            dbReader.Close();
            dbCmd.Dispose();
        }
    }
}
