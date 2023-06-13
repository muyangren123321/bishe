using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        private object lblshow;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            int a = 15, b, c, sum;
            b = c = 20;
            sum = a + b + c;
            lblshow.Text = "变量a、b、c之和为：" + sum;

        }
    }
}
