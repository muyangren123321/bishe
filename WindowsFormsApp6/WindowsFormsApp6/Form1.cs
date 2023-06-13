using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    //StringBuilder sb = new StringBuilder(); 
        //    //for (int i = 2; i <1000; i++)
        //    //{
        //    //    int sum = 0;
        //    //    for (int j = 1; j <= i/2; j++)
        //    //    {
        //    //        if (i % j == 0)
        //    //            sum += j;
        //    //    }
        //    //    if (sum == i)
        //    //    {
        //    //        sb.Append(i+"是一个完数："+i+"=1");
        //    //        for (int j =1; j <= i / 2; j++)
        //    //        {
        //    //            if (i % j == 0)
        //    //                sb.Append("+"+j);
        //    //        }
        //    //        sb.Append("\n");
        //    //    }
        //    //}
        //    //label2.Text = sb.ToString();    
        //    //try
        //    //{
        //    //    int input = Convert.ToInt32(textBox1.Text);
        //    //    if (input > 0)
        //    //    {
        //    //        int ge = input % 10;
        //    //        int qian = input / 1000;
        //    //        int bai = (input % 1000) / 100;
        //    //        int shi = (input % 100) / 10;
        //    //        string output1 = Convert.ToString(ge);
        //    //        string output2 = Convert.ToString(shi);
        //    //        string output3 = Convert.ToString(bai);
        //    //        string output4 = Convert.ToString(qian);
        //    //        if (output1 == "0")
        //    //        {
        //    //            string sum = output2 + output3 + output4;
        //    //            textBox2.Text = Convert.ToString(sum);
        //    //        }
        //    //        else
        //    //        {
        //    //            string sum = output1 + output2 + output3 + output4;
        //    //            textBox2.Text = Convert.ToString(sum);
        //    //        }
        //    //    }
        //    //    else
        //    //    {
        //    //        label3.Text = "输入内容为负数，请重新输入";
        //    //    }
        //    //}
        //    //catch
        //    //{
        //    //    label3.Text = "输入的内容不符合规范，请重新输入";
        //    //}
        //    //int output = 0;
        //    //if (input < 1)
        //    //{
        //    //    output = input;
        //    //}
        //    //else if (input >= 1 && input < 10)
        //    //{
        //    //    output = 2 * input - 1;
        //    //}
        //    //else
        //    //{
        //    //    output = 3 * input - 11;
        //    //}
        //    //textBox2.Text =Convert.ToString(output);
        //}
        #endregion
        public class book
        {
            public string title;
            public double price;
            public string GetMessage()
            {
                return string.Format("书名：{0}，价格：{1}元。",this.title,this.price); 
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            book book1 = new book();
            book1.title = "Visual c#.NET程序设计教程";
            book1.price = 32;
            string sremsg=book1.GetMessage();  
            label1.Text = sremsg;
        }
    }
}
