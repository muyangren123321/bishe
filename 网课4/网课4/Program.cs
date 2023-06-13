using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 网课4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string inputA = "";
            //while (inputA =="")
            //{
            //    Console.WriteLine("请输入用户名，输入内容不能为空");
            //    inputA =Console.ReadLine();
            //}
  
            //string inputB = "";
            //Console.WriteLine("请输入用户名，不能为空且不能与A相同");
            //inputB = Console.ReadLine();
            //while (inputB == "" || inputB == inputA)
            //{
            //    if (inputB == "")
            //    {
            //        Console.WriteLine("输入内容不能为空，请重新输入");
            //        inputB = Console.ReadLine();
            //    }
            //    else
            //    {
            //        Console.WriteLine("输入内容不能与A相同，请重新输入");
            //        inputB = Console.ReadLine();
            //    }
            //}
            //Console.ReadKey();
            //double a = 800000;
            //int year = 2020;
            //while (a < 20000000)
            //{
            //    a *= 1.25;
            //    year++;
            //}
            //Console.WriteLine("到第{0}年学员人数将达到2000000",year);
            //Console.ReadKey();
            //    string answer = "";
            //    int i = 0;
            //    while (answer != "yes" || i <= 10)
            //    {
            //        Console.WriteLine("你会了吗");
            //        answer = Console.ReadLine();
            //        if (answer == "yes")
            //        {
            //            Console.WriteLine("好的，放学了，回家吧");
            //            break;
            //        }
            //        i++;

            //    }

            //Console.ReadKey();


            //Console.WriteLine("请输入班级人数");
            //int count = Convert.ToInt32(Console.ReadLine());
            //int i = 1;
            //int sum = 0;
            //while (i <= count)
            //{
            //    Console.WriteLine("请输入第{0}个同学的成绩",i);
            //    int score = Convert.ToInt32(Console.ReadLine());
            //    sum += score;
            //    i++;
            //}
            //Console.WriteLine("全班总成绩为{0}，平均成绩为{1}",sum,sum/count);
            //Console.ReadKey();
            //string userName = "";
            //string password = "";
            //while(userName !="admin"|| password !="888888")
            //    {
            //    Console.WriteLine("请输入用户名");
            //    userName = Console.ReadLine();
            //    Console.WriteLine("请输入密码");
            //    password = Console.ReadLine();
            //}
            //Console.WriteLine("登陆成功");
            //Console.ReadKey();
            //int sum = 0;
            //int i = 2;
            //while (i <= 100)
            //{
            //    sum = sum + i;
            //    i+=2;
            //}
            //Console.WriteLine(sum);
            //Console.ReadKey();
            //int i = 0;
            //while (i < 100)
            //{
            //    Console.WriteLine("下次考试一定细心\t{0}",i);
            //    i++;
            //}
            //Console.ReadKey();
            //让用户输入姓名,然后显示出这个人上辈子是什么职业。
            //Console.WriteLine("请输入一个姓名，我们将显示出来这个人上辈子的职业");      //string name = Console.ReadLine();
            ////老杨、老苏、老马、老蒋、老牛、老虎、老赵
            //Console.WriteLine("请输入姓名");
            //string name = Console.ReadLine(); ;
            //switch (name)
            //{
            //    case "张健":Console.WriteLine("上辈子是一个大帅哥");
            //        break;
            //    case "老马":Console.WriteLine("上辈子是一个救苦救难的活菩萨");
            //        break;
            //    default:Console.WriteLine("查无此人");
            //        break;
            //}
            //Console.ReadKey();
            //Console.Write("请输入一个年份");
            //try
            //{
            //    int years = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("请输入一个月份");
            //    try
            //    {
            //        int months = Convert.ToInt32(Console.ReadLine());
            //        if (months >= 1 && months <= 12)
            //        {
            //            int days = 0;
            //            switch (months)
            //            {
            //                case 1:
            //                case 3:
            //                case 5:
            //                case 7:
            //                case 8:
            //                case 10:
            //                case 12:
            //                    days = 31;
            //                    break;
            //                case 2:
            //                    if ((years % 400 == 0) || (years % 4 == 0 && years % 100 != 0))
            //                    {
            //                        days = 28;
            //                    }
            //                    else
            //                    {

            //                        days = 27;
            //                    }
            //                    break;
            //                default:
            //                    days = 30;
            //                    break;
            //            }
            //            Console.WriteLine("{0}年{1}月有{2}天", years, months, days);
            //        }
            //        else
            //        {
            //            Console.WriteLine("输入的月份不符合要求，程序退出");
            //        }
            //    }
            //    catch 
            //    {
            //        Console.WriteLine("输入的月份有误，程序退出");
            //    }
            //}
            //catch {
            //    Console.WriteLine("输入的年份有误，程序退出");
            //}
            //Console.ReadKey();
            //李四的年终工作评定,如果定为A级,则工资涨500元,如果定为B级,
            //则工资涨200元,如果定为C级,工资不变,如果定为D级工资降200元,
            //如果定为E级工资降500元.
            //设李四的原工资为5000,请用户输入李四的评级,然后显示李四来年的工资
            //int salary = 5000;
            //bool b = true;
            //Console.WriteLine("请输入李四的年终判定：");
            //string level = Convert.ToString(Console.ReadLine());
            //switch (level)
            //{
            //    case "A":
            //        salary += 500;
            //        break;
            //    case "B":
            //        salary += 200;
            //        break;
            //    case "C":
            //        break;
            //    case "E":
            //        salary -= 500;
            //        break;
            //    default:
            //        Console.WriteLine("收入的内容有误，程序退出");
            //        b = false;
            //        break;
            //}
            //if (b) Console.WriteLine("李四的工资为{0}！",salary );
            //Console.ReadKey();
            //bool b=true;
            //int number = 0;
            //Console.WriteLine("请输入一个数字");
            //try
            //{ 
            //    number = Convert.ToInt32(Console.ReadLine());
            //}
            //catch 
            //{ 
            //    Console.WriteLine("您输入的内容不能转换为数字");
            //    b= false;
            //}
            //if (b) Console.WriteLine("您输入的数字为{0}", number);
            //Console.ReadKey();
        }
    }
}
