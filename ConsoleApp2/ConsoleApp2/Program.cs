using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string name = "zhangjian";
            //char gender = '男';
            //int age = 30;
            //string email = "zhangjain@qq.com";
            //string address = "安徽省合肥市";
            //decimal money = 5000m;
            //Console.WriteLine("我叫{0}，性别是{1}，我的年龄是{2}，" +
            //    "我的邮箱是{3}，我的家庭住址是{4}，我的工资是{5}",
            //    name,gender,age,email,address,money);
            //Console.ReadKey();
            ////int a = 20;
            //int b = 20;
            //int c = 20;
            //Console.WriteLine("第一个数紫是{0}，第二个数字是{1}，第三个数字是{2}",a,b,c);
            //Console.ReadKey();
            Console.WriteLine("你喜欢吃什么水果");
            string fruit=Console.ReadLine();
            Console.WriteLine("这么巧，我也喜欢吃{0}",fruit);
            Console.ReadKey();
        }
    }
}
