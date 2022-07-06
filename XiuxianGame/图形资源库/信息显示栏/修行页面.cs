using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XiuxianGame.图形资源库.信息显示栏
{
    public partial class 修行页面 : UserControl
    {
        public 修行页面()
        {
            InitializeComponent();
        }

        public void setExp(int cur,int max)
        {
            this.progressBar1.Maximum = max;
            this.progressBar1.Value = cur;
        }
    }
}
