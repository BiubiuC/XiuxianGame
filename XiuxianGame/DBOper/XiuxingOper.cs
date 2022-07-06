using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Text;
using XiuxianGame.人物;
using XiuxianGame.物品材料;

namespace XiuxianGame.DBOper
{
    internal class XiuxingOper
    {
        public int getNeexExp(int djingjie,int xjingjie)
        {
            Player player = new Player();
            String sql = "SELECT djingjie,xjingjie,needexp" +
                " FROM  [expdef$]  where djingjie=" + djingjie +" and xjingjie="+xjingjie+ ";";
            //String sql = "SELECT * FROM  [player$] ;";
            OleDbDataAdapter OleDaExcel = new OleDbDataAdapter(sql, DBConnection.conn);
            OleDbCommandBuilder cb = new OleDbCommandBuilder(OleDaExcel);
            /*OleDaExcel.InsertCommand = cb.GetInsertCommand();
            OleDaExcel.UpdateCommand = cb.GetUpdateCommand();
            OleDaExcel.DeleteCommand = cb.GetDeleteCommand();*/
            DataTable dt = new DataTable();
            OleDaExcel.Fill(dt);

            return ((int)((Double)dt.Rows[0]["needexp"]));
        }
    }
}
