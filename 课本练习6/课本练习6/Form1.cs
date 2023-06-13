using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 课本练习6
{
    public partial class Form1 : Form
    {
        public static int TheMax(int a, int b)
        {
            int max = a > b ? a : b;
            return max;
        }
        public static int TheMax(int a, int b, int c)
        {
            int max = 0;
            int[] d = { a, b, c };
            for (int i = 0; i < d.Length; i++)
            {
                if (d[i] > max)
                {
                    max = d[i];
                }
            }
            return max;
        }
        public static double TheMax(double a, double b)
        {
            double max = a > b ? a : b;
            return max;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            label4.Text = string.Format("最大值为：{0}", TheMax(a, b));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            label4.Text = string.Format("最大值为：{0}", TheMax(a, b));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);
            label4.Text = string.Format("最大值为：{0}", TheMax(a, b, c));
        }
    }
}
