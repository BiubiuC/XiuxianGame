using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using XiuxianGameManager.地图生成器;

namespace XiuxianGameManager
{
    public partial class mapuniteditor : Form
    {
        public mapuniteditor()
        {
            InitializeComponent();
        }

        Button superbutton;
        MapUnit mapunit;

        internal MapUnit Mapunit { get => mapunit; set => mapunit = value; }
        public Button Superbutton { get => superbutton; set => superbutton = value; }

        private void mapuniteditor_Load(object sender, EventArgs e)
        {
            if (mapunit != null)
            {

                this.地名.Text = mapunit.Name;
                this.最大容纳人数.Text = mapunit.Maxplayer.ToString();
                this.资源丰富度.SelectedIndex = mapunit.Ziyuanfengfudu;
                this.资源级别.SelectedIndex = mapunit.Ziyuanjibie;
                this.野生怪级别.SelectedIndex = mapunit.Yeshengguaijibie;
                this.是否安全区.SelectedIndex = mapunit.IsSafe?0:1;
                this.进入权限.SelectedIndex = mapunit.Jinruquanxian;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(mapunit == null || Superbutton == null)
            {
                MessageBox.Show("未找到地图单元或按钮");
                return;
            }
            mapunit.Name = this.地名.Text;
            mapunit.Maxplayer = int.Parse(this.最大容纳人数.Text);
            mapunit.Ziyuanfengfudu = this.资源丰富度.SelectedIndex;
            mapunit.Ziyuanjibie = this.资源级别.SelectedIndex;
            mapunit.Yeshengguaijibie = this.野生怪级别.SelectedIndex;
            mapunit.IsSafe = this.是否安全区.SelectedIndex == 0 ? true : false;
            mapunit.Jinruquanxian = this.进入权限.SelectedIndex;
            MessageBox.Show("保存成功");
            Superbutton.Text = mapunit.Name;
            this.Dispose();
        }
    }
}
