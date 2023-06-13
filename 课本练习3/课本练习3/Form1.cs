using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 课本练习3
{
    public class BOOK
    {
        public string title;
        public double price;
        //public BOOK()
        //{
        //    this.title = "Visual c#";
        //    this.price = "32";            
        //}
        //public void Change(ref string title, ref string price)
        //{

        //    string s = title;
        //    string b = price;
        //}


    }
    public partial class Form1 : Form
    {
        BOOK book;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            book = new BOOK();
            book.title = "visual c# 程序设计";
            book.price = 32;
            textBox1.Text = book.title;
            textBox2.Text = book.price.ToString();
        }
        //public string SWAP(ref int a, ref int b)
        //{
        //    string str = string.Format("\n\n被调方法交换前，a={0}，b={1}", a, b);
        //    int temp = a;
        //    a = b;
        //    b = temp;
        //    str += string.Format("\n\n被调方法交换之后，a={0}，b={1}", a, b);
        //    return str;
        //}
        public void MIdBook(BOOK newbook)
        {
            newbook.title = textBox3.Text;
            newbook.price = Convert.ToInt32(textBox4.Text);
        }
        public void SplitPath(string path, out string dir, out string filename)
        {
            int i;
            i = path.LastIndexOf('\\');
            dir = path.Substring(0, i);
            filename = path.Substring(i + 1);
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            MIdBook(book);
            textBox1.Text = book.title;
            textBox2.Text = book.price.ToString();
            //string title = textBox3.Text;
            //string price = textBox4.Text;
            //string path = textBox1.Text;
            //string dir, filename;
            //SplitPath(path,out dir,out filename);
            //textBox2.Text = dir;
            //textBox3.Text = filename;
            //int a = Convert.ToInt32(textBox1.Text);
            //int b = Convert.ToInt32(textBox2.Text);
            //label3.Text = string.Format("主调方法调用前a={0}，b={1}",a,b);
            //label3.Text += SWAP(ref a,ref b);
            //label3.Text += string.Format("\n\n主调方法调用后,a={0}，b={1}", a, b);
            //textBox1.Text = a.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
