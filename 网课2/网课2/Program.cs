
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 网课2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //练习1：提示用户输入密码，如果密码是“88888”则提示正确，否则要求再输入一次，
            //如果密码是“88888”则提示正确，否则提示错误,程序结束。
            Console.WriteLine("请输入密码");
            string password = Console.ReadLine();
            if (password == "8888")
            {
                Console.WriteLine("密码输入正确，登陆成功");
            }
            else
            {
                Console.WriteLine("请再输入一次");
                password = Console.ReadLine();
                if (password == "8888")
                {
                    Console.WriteLine("输入正确");
                }
                else {
                    Console.WriteLine("两次均输入错误，程序退出");
                }
                Console.ReadKey();
            }
        }
    }
}
