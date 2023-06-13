namespace 设备
{
    partial class MainFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(987, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmFile
            // 
            this.tsmFile.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmExit});
            this.tsmFile.Name = "tsmFile";
            this.tsmFile.Size = new System.Drawing.Size(108, 28);
            this.tsmFile.Text = "文件（&F）";
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.Size = new System.Drawing.Size(194, 34);
            this.tsmExit.Text = "退出（&X）";
            this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // tsmEquipment
            // 
            this.tsmEquipment.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tsmEquipment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSelectName,
            this.tsmSelectPrice});
            this.tsmEquipment.Name = "tsmEquipment";
            this.tsmEquipment.Size = new System.Drawing.Size(144, 28);
            this.tsmEquipment.Text = "设备查询（&S）";
            // 
            // tsmSelectName
            // 
            this.tsmSelectName.Name = "tsmSelectName";
            this.tsmSelectName.Size = new System.Drawing.Size(251, 34);
            this.tsmSelectName.Text = "按名称查询（&N）";
            this.tsmSelectName.Click += new System.EventHandler(this.tsmSelectName_Click);
            // 
            // tsmSelectPrice
            // 
            this.tsmSelectPrice.Name = "tsmSelectPrice";
            this.tsmSelectPrice.Size = new System.Drawing.Size(251, 34);
            this.tsmSelectPrice.Text = "按单价查询（&P）";
            this.tsmSelectPrice.Click += new System.EventHandler(this.tsmSelectPrice_Click);
            // 
            // tsmDataMaint
            // 
            this.tsmDataMaint.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tsmDataMaint.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.数据维护ToolStripMenuItem1});
            this.tsmDataMaint.Name = "tsmDataMaint";
            this.tsmDataMaint.Size = new System.Drawing.Size(148, 28);
            this.tsmDataMaint.Text = "数据维护（&D）";
            this.tsmDataMaint.Click += new System.EventHandler(this.tsmDataMaint_Click);
            // 
            // 数据维护ToolStripMenuItem1
            // 
            this.数据维护ToolStripMenuItem1.Name = "数据维护ToolStripMenuItem1";
            this.数据维护ToolStripMenuItem1.Size = new System.Drawing.Size(182, 34);
            this.数据维护ToolStripMenuItem1.Text = "数据维护";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSelectName,
            this.tsbSelectPrice,
            this.tsbDataMaint});
            this.toolStrip1.Location = new System.Drawing.Point(0, 36);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(987, 38);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbSelectName
            // 
            this.tsbSelectName.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSelectName.Image = ((System.Drawing.Image)(resources.GetObject("tsbSelectName.Image")));
            this.tsbSelectName.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSelectName.Name = "tsbSelectName";
            this.tsbSelectName.Size = new System.Drawing.Size(34, 33);
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
            this.toolStrip2.Location = new System.Drawing.Point(0, 74);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(987, 38);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssStatus,
            this.tssDate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 681);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(987, 31);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssStatus
            // 
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.Size = new System.Drawing.Size(463, 24);
            this.tssStatus.Spring = true;
            this.tssStatus.Text = "准备就绪";
            // 
            // tssDate
            // 
            this.tssDate.AutoToolTip = true;
            this.tssDate.Name = "tssDate";
            this.tssDate.Size = new System.Drawing.Size(463, 24);
            this.tssDate.Spring = true;
            this.tssDate.Text = "\"\"";
            this.tssDate.Click += new System.EventHandler(this.tssDate_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(987, 712);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFrm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmFile;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.ToolStripMenuItem tsmEquipment;
        private System.Windows.Forms.ToolStripMenuItem tsmSelectName;
        private System.Windows.Forms.ToolStripMenuItem tsmSelectPrice;
        private System.Windows.Forms.ToolStripMenuItem tsmDataMaint;
        private System.Windows.Forms.ToolStripMenuItem 数据维护ToolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSelectName;
        private System.Windows.Forms.ToolStripButton tsbSelectPrice;
        private System.Windows.Forms.ToolStripButton tsbDataMaint;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssStatus;
        private System.Windows.Forms.ToolStripStatusLabel tssDate;
        private System.Windows.Forms.Timer timer1;
    }
}

