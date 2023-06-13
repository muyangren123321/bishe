using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 课本练习4
{
    public class BOOK
    {
       
        private string title;
        private double price;
        public BOOK(string title, double price)
        {
            this.title = title;
            this.price = price;
        }
        public BOOK(string title) : this(title, 20)
        { }
        public BOOK() : this("无名",20)
        { }
        public string GetMessage()
        {
          return  string.Format("书名：{0}\n价格：{1}",title,price); 
        }
    }
    public partial class Form1 : Form
    {
        BOOK book;
        public Form1()
        {
            InitializeComponent();
        }

        //public int TheMax(int[] a)
        //{
        //    int max = a[0];
        //    for (int i = 0; i < a.Length; i++)
        //    {
        //        if (a[i] > a[0])
        //        {
        //            max = a[i];
        //        }
        //    }
        //    return max;
        //}
        //public int TheMax2(params int[] a)
        //{
        //    int max =a[0];
        //    for (int i = 0; i < a.Length; i++)
        //    {
        //        if (a[i] > max)
        //        {
        //            max = a[i];
        //        }
        //    }
        //    return max;
        //}
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                label3.Text = "调用无参构造函数（默认构造函数）";
                book = new BOOK();
            }
            else if (textBox2.Text == "")
            {
                label3.Text = "调用有一个参数的构造函数";
                book = new BOOK(textBox1.Text);
            }
            else
            {
                label3.Text = "调用有二个参数的构造函数";
                book = new BOOK(textBox1.Text,Convert.ToDouble(textBox2.Text));
            }
            label3.Text += "\n" + book.GetMessage();
            //int[] a = {1,2,3,4,5,1236,7,8,1119};
            //int max1 = TheMax(a);
            //int max2 = TheMax2(1, 2, 3, 4, 5, 6,12237, 8,129);
            //textBox1.Text = max1.ToString();
            //textBox2.Text = max2.ToString();
        }
    }
}
