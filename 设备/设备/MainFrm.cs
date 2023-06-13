using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 设备
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;//获取当前时间
            tssDate.Text = dt.ToLongDateString() + "" + dt.ToLongTimeString();
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmSelectName_Click(object sender, EventArgs e)
        {
            SelectName selectname = new SelectName();
            selectname.MdiParent = this;
            selectname.Show();
            tssStatus.Text = "按名称查询";
        }

        private void tsmSelectPrice_Click(object sender, EventArgs e)
        {
            SelectPrice selectprice = new SelectPrice(); 
            selectprice.MdiParent = this;
            selectprice.Show();
            tssStatus.Text = "按单价查询";
        }

        private void tsmDataMaint_Click(object sender, EventArgs e)
        {
            DataMaint dataMaint = new DataMaint();
            dataMaint.MdiParent = this;
            dataMaint.Show();
            tssStatus.Text = "数据维护";
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {

        }

        private void tssDate_Click(object sender, EventArgs e)
        {
            tssDate.Text = DateTime.Now.ToString("yyyy年MM月dd日hh时mm分ss秒");
        }
    }
}
