using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using XiuxianGame.地图资源;

namespace XiuxianGame.运行时资源
{
    internal class CurMap
    {
        MapUnit[,] map;

        public MapUnit[,] Map { get => map; set => map = value; }

        public void initmap(string filepath)
        {
            // DEBUG时 D:\vsproject\XiuxianGame\XiuxianGame\bin\Debug\netcoreapp3.1\'.”
            using (StreamReader sr = File.OpenText(filepath))
            {
                string nextLine;
                //地图头信息
                nextLine = sr.ReadLine();
                string[] fileds = nextLine.Split(":");
                //string maparea = this.textBox1.Text = fileds[0];
                string sx = fileds[1].Split(",")[0];
                string sy = fileds[1].Split(",")[1];
                //this.comboBox1.Text = sx;
                //this.comboBox2.Text = sy;
                int maxx = int.Parse(sx);
                int maxy = int.Parse(sy);

                Map = new MapUnit[maxx, maxy];

                while ((nextLine = sr.ReadLine()) != null)
                {
                    if (nextLine.Equals("[UNIT_BEGIN]"))
                    {
                        MapUnit mapunit = new MapUnit();
                        while ((nextLine = sr.ReadLine()) != null)
                        {
                            if (nextLine.Equals("[UNIT_END]"))
                            {
                                Map[mapunit.Point.X, mapunit.Point.Y] = mapunit;
                                break;
                            }
                            else
                            {
                                string key = nextLine.Split(":")[0];
                                string val = nextLine.Split(":")[1];
                                switch (key)
                                {
                                    case "maparea":
                                        mapunit.Maparea = val; break;
                                    case "name":
                                        mapunit.Name = val; break;
                                    case "maxplayer":
                                        mapunit.Maxplayer = int.Parse(val); break;
                                    case "ziyuanjibie":
                                        mapunit.Ziyuanjibie = int.Parse(val); break;
                                    case "ziyuanfengfudu":
                                        mapunit.Ziyuanfengfudu = int.Parse(val); break;
                                    case "yeshengguaijibie":
                                        mapunit.Yeshengguaijibie = int.Parse(val); break;
                                    case "isSafe":
                                        mapunit.IsSafe = Boolean.Parse(val); break;
                                    case "jinruquanxian":
                                        mapunit.Jinruquanxian = int.Parse(val); break;
                                    case "point":
                                        int xx = int.Parse(val.Split(",")[0]);
                                        int yy = int.Parse(val.Split(",")[1]);
                                        mapunit.Point = new Point(xx, yy); break;
                                }
                            }
                        }

                    }
                }

            }
        }
    }
}
