﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XiuxianGame.人物;
using XiuxianGame.运行时资源;
using XiuxianGame.运行时资源.事件方法;

namespace XiuxianGame
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        Player player = new Player().load();
        CurMap map = new CurMap();

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void 人物属性ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //清理Panel内容ToolStripMenuItem_Click(sender,e);
            XiuxianGame.图形资源库.信息显示栏.人物属性 form = new XiuxianGame.图形资源库.信息显示栏.人物属性();
            form.Size = infopanel.Size;
            XiuxianGame.图形资源库.信息显示栏.人物属性 pinfo = new XiuxianGame.图形资源库.信息显示栏.人物属性();
            pinfo.load(new Player().load());
            this.infopanel.Controls.Add(pinfo);
            pinfo.BringToFront();

        }

        private void 清理Panel内容ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while(infopanel.Controls.Count > 0) { infopanel.Controls.RemoveAt(infopanel.Controls.Count - 1); }
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            // DEBUG时 D:\vsproject\XiuxianGame\XiuxianGame\bin\Debug\netcoreapp3.1\'.”
            map.initmap(StaticVal.RUN_PATH+ "\\..\\..\\..\\..\\地图文件\\测试2.txt");
            this.mapControl.set(map.Map, new Point(5,4));
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void infopanel_ControlRemoved(object sender, ControlEventArgs e)
        {

        }
    }
}
