using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 设备管理系统
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void 文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 数据维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tsmEquipment_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MainFrm
            // 
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Name = "MainFrm";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.ResumeLayout(false);

        }

        private void MainFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
