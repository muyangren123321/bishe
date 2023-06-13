using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text= "我的第一个Windows程序";
            Label lblshow = new Label();
            lblshow.Location = new Point(50, 30);
            lblshow.AutoSize = true;
            lblshow.Text = "本程序由张健设计，欢迎您使用！";
            this.Controls.Add(lblshow);

        }
    }
}
