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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmFile;
        private ToolStripMenuItem tsmExit;
        private ToolStripMenuItem tsmEquipment;
        private ToolStripMenuItem tsmSelectName;
        private ToolStripMenuItem tsmSelectPrice;
        private ToolStripMenuItem tsmDataMaint;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbSelectName;
        private ToolStripButton tsbSelectPrice;
        private ToolStripButton tsbDataMaint;
        private ToolStrip toolStrip2;
        private ToolStripLabel tssStatus;
        private ToolStripLabel tssDate;
        private ToolStripMenuItem 数据维护ToolStripMenuItem1;

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
            tssDa
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEquipment = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSelectName = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSelectPrice = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDataMaint = new System.Windows.Forms.ToolStripMenuItem();
            this.数据维护ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSelectName = new System.Windows.Forms.ToolStripButton();
            this.tsbSelectPrice = new System.Windows.Forms.ToolStripButton();
            this.tsbDataMaint = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tssStatus = new System.Windows.Forms.ToolStripLabel();
            this.tssDate = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFile,
            this.tsmEquipment,
            this.tsmDataMaint});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(728, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmFile
            // 
            this.tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmExit});
            this.tsmFile.Name = "tsmFile";
            this.tsmFile.Size = new System.Drawing.Size(108, 28);
            this.tsmFile.Text = "文件（&F）";
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.Size = new System.Drawing.Size(270, 34);
            this.tsmExit.Text = "退出（&X）";
            // 
            // tsmEquipment
            // 
            this.tsmEquipment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSelectName,
            this.tsmSelectPrice});
            this.tsmEquipment.Name = "tsmEquipment";
            this.tsmEquipment.Size = new System.Drawing.Size(144, 28);
            this.tsmEquipment.Text = "设备查询（&S）";
            this.tsmEquipment.Click += new System.EventHandler(this.tsmEquipment_Click_1);
            // 
            // tsmSelectName
            // 
            this.tsmSelectName.Name = "tsmSelectName";
            this.tsmSelectName.Size = new System.Drawing.Size(270, 34);
            this.tsmSelectName.Text = "按名称查询（&N）";
            // 
            // tsmSelectPrice
            // 
            this.tsmSelectPrice.Name = "tsmSelectPrice";
            this.tsmSelectPrice.Size = new System.Drawing.Size(270, 34);
            this.tsmSelectPrice.Text = "按单价查询（&P）";
            // 
            // tsmDataMaint
            // 
            this.tsmDataMaint.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.数据维护ToolStripMenuItem1});
            this.tsmDataMaint.Name = "tsmDataMaint";
            this.tsmDataMaint.Size = new System.Drawing.Size(148, 28);
            this.tsmDataMaint.Text = "数据维护（&D）";
            // 
            // 数据维护ToolStripMenuItem1
            // 
            this.数据维护ToolStripMenuItem1.Name = "数据维护ToolStripMenuItem1";
            this.数据维护ToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.数据维护ToolStripMenuItem1.Text = "数据维护";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSelectName,
            this.tsbSelectPrice,
            this.tsbDataMaint});
            this.toolStrip1.Location = new System.Drawing.Point(0, 32);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(728, 33);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbSelectName
            // 
            this.tsbSelectName.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSelectName.Image = ((System.Drawing.Image)(resources.GetObject("tsbSelectName.Image")));
            this.tsbSelectName.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSelectName.Name = "tsbSelectName";
            this.tsbSelectName.Size = new System.Drawing.Size(34, 28);
            this.tsbSelectName.Text = "按名称查询";
            // 
            // tsbSelectPrice
            // 
            this.tsbSelectPrice.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSelectPrice.Image = ((System.Drawing.Image)(resources.GetObject("tsbSelectPrice.Image")));
            this.tsbSelectPrice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSelectPrice.Name = "tsbSelectPrice";
            this.tsbSelectPrice.Size = new System.Drawing.Size(34, 28);
            this.tsbSelectPrice.Text = "按单价查询";
            // 
            // tsbDataMaint
            // 
            this.tsbDataMaint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDataMaint.Image = ((System.Drawing.Image)(resources.GetObject("tsbDataMaint.Image")));
            this.tsbDataMaint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDataMaint.Name = "tsbDataMaint";
            this.tsbDataMaint.Size = new System.Drawing.Size(34, 28);
            this.tsbDataMaint.Text = "数据维护";
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStatus,
            this.tssDate});
            this.toolStrip2.Location = new System.Drawing.Point(0, 65);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(728, 29);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tssStatus
            // 
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.Size = new System.Drawing.Size(82, 24);
            this.tssStatus.Text = "准备就绪";
            // 
            // tssDate
            // 
            this.tssDate.Name = "tssDate";
            this.tssDate.Size = new System.Drawing.Size(24, 24);
            this.tssDate.Text = "“”";
            // 
            // MainFrm
            // 
            this.ClientSize = new System.Drawing.Size(728, 470);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFrm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void MainFrm_Load(object sender, EventArgs e)
        {

        }

        private void tsmEquipment_Click_1(object sender, EventArgs e)
        {

        }
    }
}
