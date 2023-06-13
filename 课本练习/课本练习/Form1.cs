using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 课本练习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Book book1 = new Book();
            //Book book2 = new Book();
            //book1.Name = "Visual c#.Net 程序设计教程";
            //book1.Price = 32;
            //string a = book1.GetMessage();
            //book2.Name = "数据结构";
            //book2.Price = 20;
            //label1.Text = a + "\n\n" + book2.GetMessage();
        }
        public class Book
        {
            public string Name;
            public double Price;

            public string GetMessage()
            {
                return string.Format("书名：{0}，价格：{1}", this.Name, this.Price);
            }
        }
        public class GetArea
        {
            public const double pi = 3.1415926;
            private double r;
            public double R
            {
                get
                {
                    try
                    {
                        double ricle = Convert.ToDouble(r);
                        return ricle;
                    }
                    catch
                    {
                        return 0;
                    }
                }
                set
                {
                    if (value <= 0)
                    {
                        r = 0;
                    }
                    else
                    {
                        r = value;
                    }
                }
            }
            public double Area(double R)
            {
                return R * pi * R;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            GetArea area = new GetArea();
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                area.R = a;
                label3.Text = String.Format("您输入的半径是{0}", area.R);
            }
            catch
            {
                label3.Text = "输入半径不符合规范，请重新输入";
            }

            double mianji = area.Area(area.R);
            label2.Text = String.Format("半径为{0}的圆的面积是{1}", area.R, mianji);
        }
    }
}
