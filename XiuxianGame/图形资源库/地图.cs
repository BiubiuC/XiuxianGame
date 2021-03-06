using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using XiuxianGame.地图资源;

namespace XiuxianGame.图形资源库.GroupBox
{
    public partial class 地图 : UserControl
    {
        public 地图()
        {
            InitializeComponent();
        }

        MapUnit[,] map;
        Point point;

        public void set(MapUnit[,] map,Point point)
        {
            this.map = map;
            location(point);
        }
        
        public void location(Point point)
        {
            this.point = point;
            /*this.本地.Text   = map[point.X, point.Y].Name;
            this.左上.Text   = map[point.X-1, point.Y-1].Name;
            this.上.Text     = map[point.X, point.Y-1].Name;
            this.右上.Text   = map[point.X+1, point.Y-1].Name;
            this.左.Text     = map[point.X-1, point.Y].Name;
            this.右.Text     = map[point.X+1, point.Y].Name;
            this.左下.Text   = map[point.X-1, point.Y+1].Name;
            this.下.Text     = map[point.X, point.Y+1].Name;
            this.右下.Text   = map[point.X+1, point.Y+1].Name;*/
            this.本地.Text = map[point.X, point.Y].Name;
            this.左上.Text = (point.X - 1 < 0 || point.Y - 1 < 0) ? "-" : map[point.X - 1, point.Y - 1].Name;
            this.上.Text = (point.Y - 1 < 0) ? "-" : map[point.X, point.Y - 1].Name;
            this.右上.Text = (point.X > map.GetLength(0) || point.Y - 1 < 0) ? "-" : map[point.X + 1, point.Y - 1].Name;
            this.左.Text = (point.X - 1 < 0) ? "-" : map[point.X - 1, point.Y].Name;
            this.右.Text = (point.X > map.GetLength(0)) ? "-" : map[point.X + 1, point.Y].Name;
            this.左下.Text = (point.X - 1 < 0 || point.Y > map.GetLength(1)) ? "-" : map[point.X - 1, point.Y + 1].Name;
            this.下.Text = (point.Y > map.GetLength(1)) ? "-" : map[point.X, point.Y + 1].Name;
            this.右下.Text = (point.X > map.GetLength(0) || point.Y > map.GetLength(1)) ? "-" : map[point.X + 1, point.Y + 1].Name;

            this.本地.Visible = true;
            this.左上.Visible = true;
            this.上.Visible = true;
            this.右上.Visible = true;
            this.左.Visible = true;
            this.右.Visible = true;
            this.左下.Visible = true;
            this.下.Visible = true;
            this.右下.Visible = true;

            if (this.本地.Text == null || this.本地.Text.Equals("-") || this.本地.Text.Equals("")) { this.本地.Visible = false; }
            if (this.左上.Text == null || this.左上.Text.Equals("-") || this.左上.Text.Equals("")) { this.左上.Visible = false; }
            if (this.上.Text == null || this.上.Text.Equals("-") || this.上.Text.Equals("")) { this.上.Visible = false; }
            if (this.右上.Text == null || this.右上.Text.Equals("-") || this.右上.Text.Equals("")) { this.右上.Visible = false; }
            if (this.左.Text == null || this.左.Text.Equals("-") || this.左.Text.Equals("")) { this.左.Visible = false; }
            if (this.右.Text == null || this.右.Text.Equals("-") || this.右.Text.Equals("")) { this.右.Visible = false; }
            if (this.左下.Text == null || this.左下.Text.Equals("-") || this.左下.Text.Equals("")) { this.左下.Visible = false; }
            if (this.下.Text == null || this.下.Text.Equals("-") || this.下.Text.Equals("")) { this.下.Visible = false; }
            if (this.右下.Text == null || this.右下.Text.Equals("-") || this.右下.Text.Equals("")) { this.右下.Visible = false; }
        }

        private void calcPoint(int x,int y)
        {
            this.point.X += x;
            this.point.Y += y;
        }

        private void click(object sender, EventArgs e)
        {

        }

        private void 左上_Click(object sender, EventArgs e)
        {
            calcPoint(-1,-1);
            location(point);
        }

        private void 上_Click(object sender, EventArgs e)
        {
            calcPoint(0, -1);
            location(point);
        }

        private void 右上_Click(object sender, EventArgs e)
        {
            calcPoint(1, -1);
            location(point);
        }

        private void 左_Click(object sender, EventArgs e)
        {
            calcPoint(-1, 0);
            location(point);
        }

        private void 右_Click(object sender, EventArgs e)
        {
            calcPoint(1, 0); 
            location(point);
        }

        private void 左下_Click(object sender, EventArgs e)
        {
            calcPoint(-1, 1);
            location(point);
        }

        private void 下_Click(object sender, EventArgs e)
        {
            calcPoint(0, 1);
            location(point);
        }

        private void 右下_Click(object sender, EventArgs e)
        {
            calcPoint(1,1);
            location(point);
        }

        private void 地图_Load(object sender, EventArgs e)
        {

        }
    }
}
