using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Text;
using XiuxianGame.人物;

namespace XiuxianGame.DBOper
{
    internal class PlayerOper
    {
        public Player getPlayer(int id)
        {
            Player player = new Player();
            String sql = "SELECT * FROM  [player$] where id="+id+";";
            //String sql = "SELECT * FROM  [player$] ;";
            OleDbDataAdapter OleDaExcel = new OleDbDataAdapter(sql, DBConnection.conn);
            OleDbCommandBuilder cb = new OleDbCommandBuilder(OleDaExcel);
            /*OleDaExcel.InsertCommand = cb.GetInsertCommand();
            OleDaExcel.UpdateCommand = cb.GetUpdateCommand();
            OleDaExcel.DeleteCommand = cb.GetDeleteCommand();*/
            DataTable dt = new DataTable();
            OleDaExcel.Fill(dt);
            //DataSet OleDsExcel = new DataSet(); 
            //OleDaExcel.Fill(OleDsExcel, "表1"); 
            player.Id = ((int)((Double)dt.Rows[0]["id"]));
            player.Name = (string)dt.Rows[0]["name"];
            player.Sex = (string)dt.Rows[0]["sex"];
            player.Age = (int)(Double)dt.Rows[0]["age"];
            player.Maxage = (int)(Double)dt.Rows[0]["maxage"];
            player.Meili = (int)(Double)dt.Rows[0]["meili"];
            player.Djingjie = (int)(Double)dt.Rows[0]["djingjie"];
            player.Xjingjie = (int)(Double)dt.Rows[0]["xjingjie"];
            player.Jingyan = (int)(Double)dt.Rows[0]["jingyan"];
            player.Hp = (int)(Double)dt.Rows[0]["hp"];
            player.Maxhp = (int)(Double)dt.Rows[0]["maxhp"];
            player.Mp = (int)(Double)dt.Rows[0]["mp"];
            player.Maxmp = (int)(Double)dt.Rows[0]["maxmp"];
            player.Tp = (int)(Double)dt.Rows[0]["tp"];
            player.Maxtp = (int)(Double)dt.Rows[0]["maxtp"];
            player.Actnum = (int)(Double)dt.Rows[0]["actnum"];
            player.Defnum = (int)(Double)dt.Rows[0]["defnum"];
            player.Baolinum = (double)dt.Rows[0]["baolinum"];
            player.Baojiact = (double)dt.Rows[0]["baojiact"];
            player.Jin = (int)(Double)dt.Rows[0]["jin"];
            player.Mu = (int)(Double)dt.Rows[0]["mu"];
            player.Shui = (int)(Double)dt.Rows[0]["shui"];
            player.Huo = (int)(Double)dt.Rows[0]["huo"];
            player.Tu = (int)(Double)dt.Rows[0]["tu"];

            return player;
        }
    }
}
