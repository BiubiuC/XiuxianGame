using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using XiuxianGame.物品材料;

namespace XiuxianGame.地图资源
{
    // 修改同步修改地图生成器
    public class MapUnit
    {
        string maparea;//地图区域
        int maxplayer;//最大容纳人数
        int ziyuanjibie;//资源级别
        int ziyuanfengfudu;//资源丰富度
        int yeshengguaijibie;//野生怪级别
        Boolean isSafe;//是否安全区
        int jinruquanxian;//进入权限


        string[] players;//当前地点玩家
        string name; //地点名称
        Point point;//在大地图的位置

        public MapUnit()
        {

        }


        public MapUnit(string maparea, Point p)
        {
            this.maparea = maparea;

            if (this.point == null)
            {
                this.point = new Point();
            }
            this.point.X = p.X;
            this.point.Y = p.Y;
        }

        public string ToString()
        {

            return "[UNIT_BEGIN]\n" +
            "maparea" + ":" + maparea + "\n" +
            "name" + ":" + name + "\n" +
            "maxplayer" + ":" + maxplayer + "\n" +
            "ziyuanjibie" + ":" + ziyuanjibie + "\n" +
            "ziyuanfengfudu" + ":" + ziyuanfengfudu + "\n" +
            "yeshengguaijibie" + ":" + yeshengguaijibie + "\n" +
            "isSafe" + ":" + isSafe + "\n" +
            "jinruquanxian" + ":" + jinruquanxian + "\n" +
            "point" + ":" + point.X + "," + point.Y + "\n" +
            "[UNIT_END]\n"; ;
        }

        public string Maparea { get => maparea; set => maparea = value; }
        public int Maxplayer { get => maxplayer; set => maxplayer = value; }
        public int Ziyuanjibie { get => ziyuanjibie; set => ziyuanjibie = value; }
        public int Ziyuanfengfudu { get => ziyuanfengfudu; set => ziyuanfengfudu = value; }
        public int Yeshengguaijibie { get => yeshengguaijibie; set => yeshengguaijibie = value; }
        public bool IsSafe { get => isSafe; set => isSafe = value; }
        public int Jinruquanxian { get => jinruquanxian; set => jinruquanxian = value; }
        public string[] Players { get => players; set => players = value; }
        public string Name { get => name; set => name = value; }
        public Point Point { get => point; set => point = value; }
    }
}
