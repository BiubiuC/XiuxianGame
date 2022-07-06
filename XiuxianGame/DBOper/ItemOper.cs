using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Text;
using XiuxianGame.人物;
using XiuxianGame.物品材料;

namespace XiuxianGame.DBOper
{
    internal class ItemOper
    {
        public DataTable getPlayerPackage(DBConnection conn,int id)
        {
            Player player = new Player();
            String sql = "SELECT b.name as 名称,a.num as 数量,b.wtype as 类型,b.descript as 描述" +
                " FROM  [package$] a,[items$] b where a.wid = b.wid and a.id=" + id+";";
            //String sql = "SELECT * FROM  [player$] ;";
            OleDbDataAdapter OleDaExcel = new OleDbDataAdapter(sql, conn.OleConn);
            OleDbCommandBuilder cb = new OleDbCommandBuilder(OleDaExcel);
            /*OleDaExcel.InsertCommand = cb.GetInsertCommand();
            OleDaExcel.UpdateCommand = cb.GetUpdateCommand();
            OleDaExcel.DeleteCommand = cb.GetDeleteCommand();*/
            DataTable dt = new DataTable();
            OleDaExcel.Fill(dt);

            return dt;
        }
    }
}
