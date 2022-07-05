using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XiuxianGame
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void 人物属性ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            清理Panel内容ToolStripMenuItem_Click(sender,e);
            XiuxianGame.图形资源库.GroupBox.人物属性 form = new XiuxianGame.图形资源库.GroupBox.人物属性();
            form.Size = infopanel.Size;
            this.infopanel.Controls.Add(new XiuxianGame.图形资源库.GroupBox.人物属性());
        }

        private void 清理Panel内容ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.infopanel.Controls)
            {
                c.Dispose();
            }
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
