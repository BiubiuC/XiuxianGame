using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XiuxianGame.图形资源库.信息显示栏
{
    public partial class 背包 : UserControl
    {
        public 背包()
        {
            InitializeComponent();
        }

        public void setData(DataTable dt)
        {
            this.dataGridView1.DataSource = dt;
            /*for(int i = 0; i < dt.Rows.Count; i++)
            {
                dataGridView1.Rows.Add(dt.Rows[i]);
            }
            dataGridView1.Refresh();*/
        }
    }
}
