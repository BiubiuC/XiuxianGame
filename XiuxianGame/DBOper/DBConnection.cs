using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace XiuxianGame.DBOper
{
    public class DBConnection
    {
        public static OleDbConnection conn;

        public OleDbConnection OleConn { get => conn; set => conn = value; }

        public static void conninit(string excelfilepath)
        {
            // "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excelfilepath + ";Extended Properties=Excel 12.0;";

            string strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                //"D:\\vsproject\\XiuxianGame\\DataBase\\XiuxianDB.xlsx" + 
                excelfilepath +
                ";Extended Properties='Excel 12.0;HDR=Yes;IMEX=2'";
            conn = new OleDbConnection(strConn);
            conn.Open();

        }
        public static void close()
        {
            if(conn != null)
            {
                conn.Close();
            }
        }

    }
}
