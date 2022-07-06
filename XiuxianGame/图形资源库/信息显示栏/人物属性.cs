using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using XiuxianGame.人物;
using XiuxianGame.运行时资源.事件方法;

namespace XiuxianGame.图形资源库.信息显示栏
{
    public partial class 人物属性 : UserControl
    {
        public 人物属性()
        {
            InitializeComponent();
        }

        public void load(Player player)
        {
            this.姓名v.Text = player.Name;
            this.性别v.Text = player.Sex;
            this.寿命v.Text = player.Age + "/" + player.Maxage;
            this.魅力v.Text = player.Meili.ToString();
            this.境界v.Text = KeyToVal.JingJie(player.Djingjie, player.Djingjie);
            this.生命值v.Text = player.Hp + "/" + player.Maxhp;
            // 灵力TODO
            // 念力TODO
            this.攻击v.Text = player.Actnum.ToString();
            this.防御v.Text = player.Defnum.ToString();
            this.暴击率v.Text = Math.Round(player.Baolinum,2).ToString();
            this.暴击伤害v.Text = Math.Round(player.Baojiact,2).ToString();

            this.金v.Text = player.Jin.ToString();
            this.木v.Text = player.Mu.ToString();
            this.水v.Text = player.Shui.ToString();
            this.火v.Text = player.Huo.ToString();
            this.土v.Text = player.Tu.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void 人物属性_Load(object sender, EventArgs e)
        {
            
        }

        private void 人物属性_Click(object sender, EventArgs e)
        {
           
        }

        private void 人物属性_MouseDown(object sender, MouseEventArgs e)
        {
            //右键
            if(e.Button == MouseButtons.Right)
            {
                this.Dispose();
            }
        }
    }
}
