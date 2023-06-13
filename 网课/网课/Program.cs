using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 网课
{/// <summary>
/// 这个类用来描述一个人的信息，包括姓名，性别年龄
/// </summary>
/// 
    public class person
    {
        public string name
        {
            get;
            set;
        }
        public int age
        {
            get;
            set;
        }
        public char gender
        {
            set;
            get;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //int n1 = 10;
            //int n2 = 3;
            //double d = n1 * 1.0 / n2;
            //Console.WriteLine("{0:0.0000}", d);
            //Console.ReadKey();
            int a = 10;
            int b = 3;
            double c = a * 1.0 / b;
            Console.WriteLine("{0:0.0000}", c);
            Console.ReadKey();
        }
    }
}
