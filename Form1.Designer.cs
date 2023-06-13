namespace Test4
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtsNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChinese = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaths = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblShow = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.btnCount_Click = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号：";
            // 
            // txtsNo
            // 
            this.txtsNo.Location = new System.Drawing.Point(154, 63);
            this.txtsNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtsNo.Name = "txtsNo";
            this.txtsNo.Size = new System.Drawing.Size(148, 28);
            this.txtsNo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "姓名：";
            // 
            // txtsName
            // 
            this.txtsName.Location = new System.Drawing.Point(154, 104);
            this.txtsName.Margin = new System.Windows.Forms.Padding(4);
            this.txtsName.Name = "txtsName";
            this.txtsName.Size = new System.Drawing.Size(148, 28);
            this.txtsName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "语文成绩：";
            // 
            // txtChinese
            // 
            this.txtChinese.Location = new System.Drawing.Point(154, 144);
            this.txtChinese.Margin = new System.Windows.Forms.Padding(4);
            this.txtChinese.Name = "txtChinese";
            this.txtChinese.Size = new System.Drawing.Size(148, 28);
            this.txtChinese.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 184);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "数学成绩：";
            // 
            // txtMaths
            // 
            this.txtMaths.Location = new System.Drawing.Point(154, 184);
            this.txtMaths.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaths.Name = "txtMaths";
            this.txtMaths.Size = new System.Drawing.Size(148, 28);
            this.txtMaths.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 225);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "英语成绩：";
            // 
            // txtEnglish
            // 
            this.txtEnglish.Location = new System.Drawing.Point(154, 225);
            this.txtEnglish.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(148, 28);
            this.txtEnglish.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(46, 324);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 34);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(584, 324);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(112, 34);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Location = new System.Drawing.Point(444, 457);
            this.lblShow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(80, 18);
            this.lblShow.TabIndex = 4;
            this.lblShow.Text = "显示结果";
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(154, 282);
            this.txtGrade.Margin = new System.Windows.Forms.Padding(4);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(148, 28);
            this.txtGrade.TabIndex = 6;
            // 
            // btnCount_Click
            // 
            this.btnCount_Click.Location = new System.Drawing.Point(294, 324);
            this.btnCount_Click.Margin = new System.Windows.Forms.Padding(4);
            this.btnCount_Click.Name = "btnCount_Click";
            this.btnCount_Click.Size = new System.Drawing.Size(112, 34);
            this.btnCount_Click.TabIndex = 7;
            this.btnCount_Click.Text = "完成";
            this.btnCount_Click.UseVisualStyleBackColor = true;
            this.btnCount_Click.Click += new System.EventHandler(this.btnCount_Click_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 282);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "总成绩：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 648);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCount_Click);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMaths);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtChinese);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsNo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtChinese;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaths;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Button btnCount_Click;
        private System.Windows.Forms.Label label6;
    }
}

