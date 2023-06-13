using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 课本练习2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Calculate
        {
            public double sum(int a, int b)
            {
                return a + b;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
       Calculate calc = new Calculate();
            label1.Text = Convert.ToString(calc.sum(20,50));
    }
    
    
    }
}
