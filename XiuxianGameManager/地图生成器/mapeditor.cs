using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using XiuxianGameManager.地图生成器;

namespace XiuxianGameManager
{
    public partial class mapeditor : Form
    {
        public mapeditor()
        {
            InitializeComponent();
        }

        //变量定义
        MapUnit[,] map;
        

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mapeditor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            createmaponpanel(panel1);
        }

        private void createmaponpanel(Panel panel1)
        {

            string maparea = this.textBox1.Text; 

            int x = int.Parse(comboBox1.Text);
            int y = int.Parse(comboBox2.Text);

            map = new MapUnit[x,y];

            int X = panel1.Width;
            int Y = panel1.Height;

            //按钮大小
            int bx = X / x;
            int by = Y / y;

            for(int a = 0; a < x; a++)
            {
                for(int b = 0; b < y; b++)
                {
                    Button button = new Button();
                    button.Text = a + "," + b;

                    MapUnit unit = new MapUnit(this.textBox1.Text, new Point(a, b));

                    map[a,b] = unit;

                    button.Tag = unit;
                    button.Size = new Size(bx, by);
                    button.Location = new Point(bx*a, by*b);
                    button.Click += mapunit_Click;
                    panel1.Controls.Add(button);

                }
            }
        }

        private void mapunit_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            MapUnit unit = (MapUnit)b.Tag;
            mapuniteditor m = new mapuniteditor();
            m.Text = unit.Maparea + ":" + unit.Point;
            m.Mapunit = unit;
            m.Superbutton = b;
            m.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            map = null;
            while(this.panel1.Controls.Count != 0) {
                foreach (Control c in this.panel1.Controls)
                {
                    c.Dispose();
                }
            }
            panel1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.saveFileDialog1.FileName = this.textBox1.Text;
            this.saveFileDialog1.Filter  = "txt文件|*.txt|所有文件|*.*";
            int x = int.Parse(comboBox1.Text);
            int y = int.Parse(comboBox2.Text);
            string result = this.textBox1.Text+":"+x+","+y+"\n";
            DialogResult dr = this.saveFileDialog1.ShowDialog();
            
            if (dr == DialogResult.OK && map.Length!=0)
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                //this.saveFileDialog1.Dispose();
                for(int i = 0; i < x; i++)
                {
                    for(int j = 0; j < y; j++)
                    {
                        result += map[i,j].ToString();
                    }
                }
                byte[] data = new UTF8Encoding().GetBytes(result);
                //开始写入
                fs.Write(data, 0, data.Length);
                //清空缓冲区、关闭流
                fs.Flush();
                fs.Close();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            button2_Click(sender,e);
            DialogResult dr = this.openFileDialog1.ShowDialog();
            if(dr == DialogResult.OK)
            {
                int maxx = 0;
                int maxy = 0;
                
                using (StreamReader sr = File.OpenText(openFileDialog1.FileName))
                {
                    string nextLine;
                    //地图头信息
                    nextLine = sr.ReadLine();
                    string[] fileds = nextLine.Split(":");
                    string maparea = this.textBox1.Text = fileds[0];
                    string sx = fileds[1].Split(",")[0];
                    string sy = fileds[1].Split(",")[1];
                    this.comboBox1.Text = sx;
                    this.comboBox2.Text = sy;
                    maxx = int.Parse(sx);
                    maxy = int.Parse(sy);

                    map = new MapUnit[maxx, maxy];

                    while ((nextLine = sr.ReadLine()) != null)
                    {
                        if (nextLine.Equals("[UNIT_BEGIN]"))
                        {
                            MapUnit mapunit = new MapUnit();
                            while ((nextLine = sr.ReadLine()) != null)
                            {
                                if (nextLine.Equals("[UNIT_END]"))
                                {
                                    map[mapunit.Point.X, mapunit.Point.Y] = mapunit;
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
                                            mapunit.Yeshengguaijibie = int.Parse(val);  break;
                                        case "isSafe":
                                            mapunit.IsSafe = Boolean.Parse(val); break;
                                        case "jinruquanxian":
                                            mapunit.Jinruquanxian = int.Parse(val);  break;
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
                //end fileread

                int x = maxx;
                int y = maxy;

                int X = panel1.Width;
                int Y = panel1.Height;

                //按钮大小
                int bx = X / x;
                int by = Y / y;

                for (int a = 0; a < x; a++)
                {
                    for (int b = 0; b < y; b++)
                    {
                        Button button = new Button();
                        button.Text = (map[a,b].Name != null && map[a, b].Name != "")?(map[a, b].Name) :(a + "," + b);
                        button.Tag = map[a, b];
                        button.Size = new Size(bx, by);
                        button.Location = new Point(bx * a, by * b);
                        button.Click += mapunit_Click;
                        panel1.Controls.Add(button);

                    }
                }

            }
        }
    }
}
