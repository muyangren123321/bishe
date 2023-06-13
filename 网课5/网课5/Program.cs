using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 网课5
{
    internal class Program
    {
        public enum Gender
        {
            man,
            woman
        }
        public enum Seasons
        {
            春,
            夏,
            秋,
            冬
        }
        public enum QQstate
        {
            Online = 1,
            Busy,
            Offline,
            Leave,
            Qme
        }
        public struct person
        {
            public string _name;
            public int _age;
            public Gender _gender;
        }
        public struct Mycolor
        {
            public int _red;
            public int _green;
            public int _blue;
        }
        public static int Getmax(int n1, int n2)
        {
            return n1 > n2 ? n1 : n2;
        }
        public static int Test(int a)
        {
            a += 5;
            return a;
        }
        public static bool IsRun(int year)
        {
            bool b = (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
            return b;
        }
        public static int GetNumber(string s)
        {
            while (true)
            {
                try
                {
                    int number = Convert.ToInt32(s);
                    return number;
                }
                catch
                {
                    Console.WriteLine("输入的内容不正确，请重新输入");
                    s = Console.ReadLine();
                }
            }
        }
        public static string Answer(string b)
        {
            if (b == "yes")
            {
                return "可以观看";
            }
            else if (b == "no")
            {
                return "不可以观看";
            }
            else
            {
                return "输入的内容不正确，程序退出";
            }
        }
        public static int sum = 0;
        public static int sumNum(int[] num)
        {

            for (int i = 0; i <= num.Length - 1; i++)
            {
                sum += num[i];
            }
            return sum;
        }
        public static int[] GetMaxMinSumAvg(int[] num, out string b, out bool c, out double d)
        {
            // 计算一个数组的最大值、最小值、总和、平均值
            int[] res = new int[4];
            res[0] = num[0];
            res[1] = num[1];
            res[2] = num[2];
            res[3] = num[3];
            for (int i = 0; i < num.Length - 1; i++)
            {
                if (num[i] > res[0])
                {
                    res[0] = num[i];
                }
                else if (num[i] < res[1])
                {
                    res[1] = num[i];
                }
                else
                {
                }
                res[2] += num[i];
            }
            res[3] = res[2] / num.Length;
            b = "zhangjian";
            c = false;
            d = 3.1415926;
            return res;
        }
        public static bool Answer(string admin, string password, out string a/*, out string b, out string c, out string d*/)
        {
            //a = "登陆成功";
            //b = "密码错误";
            //c = "登录名错误";
            //d = "登录名和密码均错误";
            if (admin == "zhangjian" && password == "888888")
            {
                //Console.WriteLine(a);
                a = "登陆成功";
                return true;
            }
            else if (admin == "zhangjian")
            {
                a = "密码错误";
                return false;
            }
            else if (password == "888888")
            {
                a = "登录名错误";
                return false;
            }
            else
            {
                a = "登录名和密码名均错误";
                return false;
            }
        }
        public static bool MyTryPhase(string s, out int resault)
        {

            try
            {
                int ans = Convert.ToInt32(s);
                resault = 1;
                return true;
            }
            catch
            {
                resault = 0;
                return false;
            }

        }
        public static void Jiangjin(ref double s)
        {
            s += 500;
        }
        public static void Temp(ref int a, ref int b)
        {
            int Temp = b;
            b = a;
            a = Temp;
        }
        public static void Answer(string name, int id, params int[] score)
        {
            int sum = 0;
            for (int i = 0; i <= score.Length - 1; i++)
            {
                sum += score[i];
            }
            Console.WriteLine("我的姓名是{0}，我的学生证号是{1}，我的总成绩是{2}", name, id, sum);

        }
        //public static void TellStory()
        //{
        //      int i = 0;
        //    Console.WriteLine("从前有座山");
        //    Console.WriteLine("山上有座庙");
        //    Console.WriteLine("庙里有个老和尚对小和尚说");
        //    i++;
        //    if (i >=2)
        //        return;
        //    TellStory();
        //}
        public static int i = 0;
        public static void TellStory()
        {
            //int i = 0;
            Console.WriteLine("从前有座山");
            Console.WriteLine("山里有座庙");
            Console.WriteLine("庙里有个老和尚和小和尚");
            Console.WriteLine("有一天，小和尚哭了，老和尚给小和尚讲了一个故事");
            i++;
            if (i >= 10)
            {
                return;
            }
            TellStory();
        }
        public static int theSum = 0;
        //public static int Sum(int a, int b)
        //{
        //    if (a < b)
        //    {
        //        for (int i = a; i <= b; i++)
        //        {

        //            theSum += i;
        //        }

        //    }
        //    return theSum;

        //}
        public static void GetNumber(string s, out int n)
        {
            while (true)
            {
                try
                {
                    n = Convert.ToInt32(s);
                    return;
                }
                catch
                {
                    Console.WriteLine("输入有误，请重新输入");
                    s = Console.ReadLine();
                    n = Convert.ToInt32(s);
                }
            }
        }
        public static void JudgeNmuber(ref int a, ref int b)
        {
            while (true)
            {
                if (a < b)
                { return; }
                else
                {
                    Console.WriteLine("输入的数字第一个不能大于第二个数字，请重新输入第一个数字");
                    string s1 = Console.ReadLine();
                    GetNumber(s1, out a);
                    Console.WriteLine("请输入第二个数字");
                    string s2 = Console.ReadLine();
                    GetNumber(s2, out b);
                }
            }

        }
        public static string theLongest(string[] s)
        {
            string max = s[0];
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Length > max.Length)
                {
                    max = s[i];
                }
            }
            return max;
        }
        public static double theAvg(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            double avg = (double)sum / a.Length;
            return avg;
        }
        public static int GetNmuber(string number)
        {
            while (true)
            {
                try
                {
                    int num = Convert.ToInt32(number);
                    return num;
                }
                catch
                {
                    Console.WriteLine("输入的内容不正确，请重新输入");
                    number = Console.ReadLine();
                }
            }
        }
        public static bool Judge(int num)
        {
            for (int i = 2; i < num; i++)
            {

                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        public static string GetLevel(int score)
        {
            string level = "";
            switch (score / 10)
            {
                case 10:
                case 9:
                    level = "优";
                    break;
                case 8:
                    level = "良";
                    break;
                case 7:
                    level = "中";
                    break;
                case 6:
                    level = "及格";
                    break;
                default:
                    level = "不及格";
                    break;
            }
            return level;
        }


        class OutSum
        {
            public int Sum(int a, int n)
            {

                int TheSum = 0;
                int[] num = new int[n];
                for (int i = 0; i < n; i++)
                {
                    int resault = PowerFunction(i);
                    num[i] = a * (resault - 1) / 9;
                }
                for (int q = 0; q < n; q++)
                {
                    TheSum += num[q];
                }
                return TheSum;
            }
        }
        public static int PowerFunction(int i)
        {
            int resault = 1;
            for (int j = 0; j <= i; j++)
            {
                const int rate = 10;
                resault *= rate;
            }
            return resault;
        }
        public class Person
        {
            private string _name;
            public string Name
            {
                get
                {
                    return _name;
                }
                set
                {
                    if (value != "张健")
                        value = "张健";
                    _name = value;
                }
            }
            private int _age;
            public int Age
            {
                get
                {
                    if (_age <= 0 || _age >= 150)
                        return 0;
                    return _age;
                }
                set
                {
                    _age = value;
                }
            }
            private char _gender;
            public char Gender
            {
                get
                {
                    return _gender;
                }
                set
                {
                    if (value != '男' && value != '女')
                    {
                        _gender = '否';
                    }
                   else
                    { 
                    _gender = value;
                    }
                }
            }
            public Person(string name, char gender, int age)
            {
                this.Name = name;
                this.Age = age;
                this.Gender = gender;
            }
            public void SayHello()
            {
                Console.WriteLine("{0},{1},{2}", this.Name, this.Gender, this.Age);
            }
        }
        static void Main(string[] args)
        {
            //Person person = new Person("孙权",'中',200);
            //person.SayHello();
            //Console.ReadKey();
            Console.WriteLine("请输入初始数值a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入位数n");
            int n = Convert.ToInt32(Console.ReadLine());
            OutSum theResault = new OutSum();
            int sum = theResault.Sum(a, n);
            Console.WriteLine(sum);
            Console.ReadKey();

            //Ticket t = new Ticket(90);
            //t.ShowTicket();
            //Console.ReadKey();
            //Console.WriteLine("请输入学生的考试成绩");
            //int score = Convert.ToInt32(Console.ReadLine());
            //string level = GetLevel(score);
            //Console.WriteLine(level);
            //Console.ReadKey();
            //while(true)
            //{ 
            //Console.WriteLine("请输入一个数字，我们将判断它是不是质数");
            //string input = Console.ReadLine();
            //int number = GetNmuber(input);
            //bool ans =Judge(number);
            //Console.WriteLine(ans);
            //Console.ReadKey();
            //}
            //int[] a = { 1, 2, 7 };
            //double Avg = theAvg(a);
            //Console.WriteLine("这个数组的平均值是{0:0.00}", Avg);
            //Console.ReadLine();
            //string[] s = { "aedadaada","sDadadddaadad","addwafdsvs","dwqwdefczxcdsdv"};
            //string Longest = theLongest(s);
            //Console.WriteLine(Longest);
            //Console.ReadKey();
            //            提示用户输入两个数字  计算这两个数字之间所有整数的和
            //1、用户只能输入数字
            //2、计算两个数字之间和
            //3、要求第一个数字必须比第二个数字小  就重新输入
            // Console.WriteLine("请输入第一个数字");
            //string s1 =Console.ReadLine();
            // int n1;
            // GetNumber(s1,out n1);
            // Console.WriteLine("请输入第二个数字");
            // string s2 = Console.ReadLine();
            // int n2;
            // GetNumber(s2, out n2);
            // JudgeNmuber(ref n1, ref n2);    
            // int sum= Program.Sum(n1, n2);
            // Console.WriteLine(sum);
            // Console.ReadKey();
            //TellStory();
            //Console.ReadKey();
            //Console.WriteLine("请输入您的名字");
            //string name =Console.ReadLine();
            //Answer(name, 2019211557, 1, 2, 3, 4, 5, 6);
            //Console.ReadKey();
            //使用方法来交换两个int类型的变量
            //Console.WriteLine("请输入第一个数");
            //int a1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第二个数");
            //int a2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("交换前的数值{0},{1}",a1,a2);
            //Temp(ref a1,ref a2);
            //Console.WriteLine("交换后的数值{0},{1}", a1,a2);
            //Console.ReadKey();
            //double Salary = 5000;
            //Jiangjin(ref Salary);
            //Console.WriteLine(Salary);
            //Console.ReadKey();
            //int resault;
            //Console.WriteLine("请输入一个字符，我们将它转换为整数型");
            //string input = Console.ReadLine();
            //bool ans = MyTryPhase(input, out resault);
            //Console.WriteLine(ans);
            //Console.WriteLine(resault);
            //Console.ReadKey();
            //分别的提示用户输入用户名和密码
            //你写一个方法来判断用户输入的是否正确
            //返回给用户一个登陆结果，并且还要单独的返回给用户一个登陆信息
            //如果用户名错误，除了返回登陆结果之外，还要返回一个 "用户名错误"
            //“密码错误”
            //Console.WriteLine("请输入用户名");
            //string admin = Console.ReadLine();
            //Console.WriteLine("请输入密码");
            //string password = Console.ReadLine();
            //string a;
            ////string b;
            ////string c;
            ////string d;
            //bool answer =Answer(admin,password,out a/*,out b,out c,out d */);
            //Console.WriteLine(answer);
            //Console.WriteLine(a);
            //Console.ReadKey();
            //int[] num = { 0,0,0,0,0,0,0,0,0,0};
            //Console.WriteLine("请输入一个数组");
            //for (int i = 0; i < 10; i++)
            //{
            // num = new int[10];
            //    num[i] = Convert.ToInt32(Console.ReadLine());

            //}

            //    int[] calculate = Program.GetMaxMinSumAvg(num);
            //Console.WriteLine(calculate);
            //Console.ReadKey();
            //string w;
            //bool r;
            //double t;
            //int[] q = { 12, 3, 445, 65, 7678, 90, 90, 34, 12, 34 };
            //int[] calculate = Program.GetMaxMinSumAvg(q, out w,out r ,out t);
            //Console.WriteLine("最大值为{0}，最小值为{1}，总和为{2}，平均值为{3},\t{4},\t{5},\t{6}", calculate[0], calculate[1], calculate[2], calculate[3],w,r,t);
            //Console.ReadKey();
            // 计算输入数组的和：int Sum(int[] values)
            //int[] a = { 1,1,2,3,4,5,6,7,8};
            //int theSum = sumNum(a);
            //Console.WriteLine(theSum);
            //Console.ReadKey();
            //int theSum = 0;
            //Console.WriteLine("请依次输入一个数组");
            //for (int i = 0; i < 10; i++)
            //{
            //    int[] nums = new int[10];
            //    nums[i] = Convert.ToInt32(Console.ReadLine()); 
            //    theSum = sumNum(nums);
            //}
            //Console.WriteLine(theSum);
            //Console.ReadKey();
            //while (true)
            //{
            //    Console.WriteLine("请输入一个数字，我们将将它打印出来");
            //    string s = Console.ReadLine();
            //    int number = GetNumber(s);
            //    Console.WriteLine(number);
            //    Console.ReadKey();
            //}
            //1 读取输入的整数
            //多次调用(如果用户输入的是数字,则返回,否则提示用户重新输入)
            //输入yes 看 输入no 不能看 
            //Console.WriteLine("请输入您的回答");
            //string ans = Console.ReadLine();
            //string attitude = Answer(ans);
            //Console.WriteLine(attitude);
            //Console.ReadKey();
            //bool b = IsRun(2002);
            //Console.WriteLine(b);
            //Console.ReadKey();
            //int b = 10;
            //int c = Test(b);
            //Console.WriteLine(c);
            //Console.ReadKey();
            //int max = Getmax(2, 3);
            //Console.WriteLine(max);
            //Console.ReadKey();
            //while (true)
            //{
            //    Console.WriteLine("hello word");
            //    Console.ReadKey();
            //    return;
            //}
            //Console.WriteLine("hello feature");
            //Console.ReadKey();
            ////冒泡排序
            //int []nums = {1,3,5,7,9,11 };
            //for (int i = 0; i < nums.Length-1; i++)
            //{
            //    for (int j = 0; j < nums.Length-1-i; j++)
            //    {
            //        if (nums[j] < nums[j + 1])
            //        { 
            //        int temp =nums[j];
            //            nums[j] = nums[j + 1];
            //            nums[j + 1] = temp; 
            //        }
            //    }
            //}
            //for (int i = 0; i < nums.Length-1; i++)
            //{
            //    Console.Write(nums[i]+" ");
            //}
            //Console.ReadKey();
            ////练习5：将一个字符串数组的元素的顺序进行反转。{“我”,“是”,”好人”} {“好人”,”是”,”我”}。
            ////第i个和第length-i-1个进行交换。
            //string[] str = { "我","是","好人"};
            //for (int i = 0; i < (str.Length/2); i++)
            //{
            //    string temp = str[i];
            //    str[i] = str[str.Length - 1 - i];
            //    str[str.Length - 1 - i]=temp;
            //}
            //for (int i = 0; i < str.Length; i++)
            //{
            //    Console.Write(str[i]);
            //}
            //Console.ReadKey();
            //练习4：将一个整数数组的每一个元素进行如下的处理：
            //如果元素是正数则将这个位置的元素的值加1，
            //如果元素是负数则将这个位置的元素的值减1,如果元素是0,则不变。
            //int [] nums = { 0,1,2,3,4,5,6,7,8,9};
            // for (int i = 0; i <nums.Length; i++)
            // {
            //     if (nums[i] > 0)
            //         nums[i] += 1;
            //     else if (nums[i] < 0)
            //         nums[i] -= 1;
            //     else 
            //     {
            //     }
            // }
            // for (int i = 0; i < nums.Length; i++)
            // {
            //     Console.WriteLine(nums[i]);
            // }
            // Console.ReadKey();
            ////练习3:数组里面都是人的名字,分割成:例如:老杨|老苏|老邹…
            //string[] name = { "laoyang", "laosu", "laozhou", "laoma" };
            //string str = "";
            //for (int i = 0; i < name.Length; i++)
            //{
            //    str += name[i] + "|";
            //}
            //Console.WriteLine(str);
            //Console.ReadKey();
            //////练习1：从一个整数数组中取出最大的整数,最小整数,总和,平均值
            //////声明一个int类型的数组 并且随意的赋初值
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int max = 0;
            //int min = 0;
            //int sum = 0;
            //for (int i = 0; i <nums.Length; i++)
            //{
            //    if (nums[i]>max)
            //        max = nums[i];
            //    if (nums[i]<min)
            //        min = nums[i];
            //    sum += nums[i];
            //}
            //Console.WriteLine("这个数组的最大值为{0},最小值为{1}，总和为{2}，平均值为{3}",max,min,sum,sum/nums.Length);
            //Console.ReadKey();
            //int[] nums =new int [10];
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    nums[i] = i;
            //}
            //Console.WriteLine(nums[4]);
            //Console.ReadKey();
            ////定义一个结构叫MyColor,有三个成员,分别定义为int类型的red,green,blue
            ////声明一个 MyColor类型的变量,并对其成员赋值.使MyColor可以表示成一个红色
            //Mycolor mycolor;
            //mycolor._red = 255;
            //mycolor._blue =0;
            //mycolor._green = 0;
            //Console.WriteLine(mycolor._red);
            //Console.ReadKey();
            //person zhangjian;
            //zhangjian._name = "张健";
            //zhangjian._age = 20;
            //zhangjian._gender = Gender.man;
            //Console.WriteLine("我叫{0}，我今年{1}岁了，我的性别是{2}。",zhangjian._name,zhangjian._age,zhangjian._gender);
            //Console.ReadKey();
            ////提示用户选择一个在线状态，我们接受，并将用户的输入转换成枚举类型。
            ////再次打印到控制台中
            //Console.WriteLine("请选择您的QQ在线状态\t1--Online\t2--Busy\t3--Offline\t4--Leave\t5--Qme");
            //int num = Convert.ToInt32(Console.ReadLine());
            //QQstate state = (QQstate)num;
            //switch (num)
            //{
            //    case 1:
            //        Console.WriteLine("您当前的QQ状态是{0}", state);
            //        break;
            //    case 2:
            //        Console.WriteLine("您当前的QQ状态时{0}", state);
            //        break;
            //    case 3:
            //        Console.WriteLine("您当前的QQ状态是{0}", state)
            //            ;
            //        break;
            //    case 4:
            //        Console.WriteLine("您当前的QQ状态是{0}", state);
            //        break;
            //    default:
            //        Console.WriteLine("您当前的QQ状态是", state);
            //        break;
            //}
            //Console.ReadKey();
            //string s = "ABCDEFG";
            ////将s转换成枚举类型
            ////Convert.ToInt32()  int.parse()  int.TryParse()
            ////调用Parse()方法的目的就是为了让它帮助我们将一个字符串转换成对应的枚举类型
            ////
            //QQstate state = (QQstate)Enum.Parse(typeof(QQstate), s);
            //Console.WriteLine(state);
            //Console.ReadKey();
            //int n1 = 10;
            //string s = n1.ToString();
            //Console.WriteLine(s);
            //Console.ReadKey();
            //Gender gender = Gender.man;
            //Seasons s = Seasons.冬;
            //QQstate qqstate = QQstate.Leave;
            //int a = (int)qqstate;
            //Console.WriteLine(a);
            //Console.WriteLine((int)QQstate.Offline);
            //Console.WriteLine((int)QQstate.Qme);
            //Console.ReadKey();
            //int a = 1;
            //QQstate qqstate = (QQstate)a;
            //Console.WriteLine(qqstate);
            //Console.ReadKey();
            //Random r = new Random();
            //while (true)
            //{ 
            //int rNumber=r.Next(1,7);
            //    Console.WriteLine("请输入一个姓名");
            //    string Name = Console.ReadLine();
            //    switch (rNumber)
            //    {
            //        case 1:
            //            Console.WriteLine("{0}上辈子是一个大帅哥",Name);
            //            break;
            //        case 2:
            //            Console.WriteLine("{0}上辈子是一个打工的",Name);
            //            break;
            //        case 3:
            //            Console.WriteLine("{0}上辈子是一个大富翁",Name);
            //            break;
            //        case 4:
            //            Console.WriteLine("{0}上辈子是一个苦命的人",Name);
            //            break;
            //        case 5:
            //            Console.WriteLine("{0}上辈子是一个努力生活的人",Name);
            //            break;
            //        case 6:
            //            Console.WriteLine("{0}上辈子是一个囚犯",Name);
            //            break;
            //    }

            //}
            ////提示用户输入一个姓名 只要输入的不是老赵  就全是流氓
            //Console.WriteLine("请输入姓名");
            //string Name = Convert.ToString(Console.ReadLine());
            //string reauslt = Name == "zhangjian" ? "handsome" : "stupid";
            //Console.WriteLine(reauslt);
            //Console.ReadKey();
            //Console.WriteLine("请输入第一个数字");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第二个数字");
            //int b = Convert.ToInt32(Console.ReadLine());
            //int max =a>b?a:b;
            //Console.WriteLine("输入的最大值为{0}",max);
            //Console.ReadKey();
            ////找出100内所有的素数
            ////素数/质数：只能被1和这个数字本身整除的数字
            ////2 3  4  5  6  7
            ////7   7%1   7%2 7%3 7%4 7%5 7%6  7%7  6%2

            //for (int i = 2; i <= 100; i++)
            //{
            //    bool b = true;
            //    {
            //        for (int j = 2; j < i; j++)
            //        {
            //            if (i % j == 0)
            //            {
            //                b = false;
            //                break;
            //            }
            //        }
            //    }
            //    if (b)
            //        Console.WriteLine(i);
            //}
            //Console.ReadKey();
            ////练习1：用 while continue实现计算1到100(含)之间的除了能被7整除之外所有整数的和。
            //int i = 0;
            //int sum = 0;
            //while (i <= 100)
            //{
            //    if (i % 7 == 0)
            //    {
            //        i++;
            //        continue;
            //    }
            //    i++;
            //    sum += i;
            //}
            //Console.WriteLine(sum);
            //Console.ReadKey();
            //while (true)
            //{
            //    Console.WriteLine("hello world");
            //    continue;
            //}
            //Console.ReadKey();
            //1~100之间的整数相加，得到累加值大于20的当前数
            //(比如:1+2+3+4+5+6=21)结果6 sum>=20  i
            //int sum = 0;
            //for (int i =1; i <= 100; i++)
            //{
            //    sum += i;
            //    if (sum >= 20)
            //    {
            //        Console.WriteLine(i);
            //        break;
            //    }
            //}
            //Console.ReadKey();
            ////练习2：在while中用break实现要求用户一直输入用户名和密码，
            ////只要不是admin、88888就一直提示要求重新输入,如果正确则提登录成功
            //string Name = " ";
            //string Password = " ";
            //while (Name != "admin" || Password != "888888")
            //{
            //    Console.WriteLine("请输入用户名");
            //    Name = Convert.ToString(Console.ReadLine());
            //    Console.WriteLine("请输入密码");
            //    Password = Convert.ToString(Console.ReadLine());
            //    if (Name == "admin" && Password == "888888")
            //    {
            //        Console.WriteLine("登陆成功！");
            //        break;
            //    }
            //}
            //Console.ReadKey();
            ////练习1:循环录入5个人的年龄并计算平均年龄,
            ////如果录入的数据出现负数或大于100的数,立即停止输入并报错
            //int sum = 0;
            //bool b = true;
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("请输入您的年龄");
            //    try
            //    {
            //        int age = 0;
            //        age = Convert.ToInt32(Console.ReadLine());
            //        if (age >= 0 && age <= 100)
            //        {
            //            sum += age;
            //        }
            //        else
            //        {
            //            Console.WriteLine("输入的年龄超过范围，请重新输入");
            //            b = false;
            //        }
            //    }
            //    catch
            //    {
            //        Console.WriteLine("输入的格式不正确，程序退出");
            //        b = false;
            //    }
            //}
            //if (b)
            //    Console.WriteLine("五个人的平均年龄是{0}", sum / 5);
            //Console.ReadKey();
            //Console.WriteLine ("请输入一个数字");
            //int number = Convert.ToInt32(Console.ReadLine());
            //for (int i =1; i <=number; i++)
            //{
            //    Console.WriteLine("{0}+{1}={2}",i,number-i,number);
            //}
            //Console.ReadKey();
            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.WriteLine("{0}*{1}={2}\t", j, i, i * j);
            //    }
            //}
            //Console.ReadKey();            //for (int i = 0; i < 10; i++)
            //            {
            //            for (int j = 0; j < 10; j++)
            //                      {
            //                     Console.WriteLine("Hello World i循环了{0}次，j循环了{1}次", i, j);
            //                        break;
            //                      }
            //                }
            //            Console.ReadKey();

            //for (int i = 100; i <= 999; i++)
            //{
            //  int bai =i/100;
            //    int shi = i % 100 / 10;
            //    int ge = i%10;
            //    if (bai * bai * bai + shi * shi * shi + ge * ge * ge ==i)
            //    {
            //        Console.WriteLine("水仙花数有{0}",i);
            //    }

            //}

            //Console.ReadKey();
            #region
            //  //练习5：不断要求用户输入一个数字（假定用户输入的都是正整数），当用户输入end的时候显示刚才输入的数字中的最大值
            //  //循环体：提示用户输入一个数字  接收  转换成int类型  不停的比较大小
            //  //循环条件：输入的不能是end
            //  string input = " ";
            //  int max = 0;
            //while (input != "end")
            //      {
            //          Console.WriteLine("请输入一个数字，我们将显示其累计的最大值");
            //          input = Console.ReadLine();
            //          if (input!= "end")
            //          {
            //              try
            //              {
            //                  int pending = Convert.ToInt32(input);
            //                  if (pending > max)
            //                  {
            //                      max = pending;
            //                  }
            //              }
            //              catch
            //              {
            //                  Console.WriteLine("您输入的内容不符合规范，程序退出");
            //              }
            //          }
            //          else
            //          {
            //              Console.WriteLine("您输入的最大值为{0}", max);
            //          }

            //  }

            //  Console.ReadKey();
            #endregion

            #region
            //  //练习4：不断要求用户输入一个数字，然后打印这个数字的二倍，当用户输入q的时候程序退出。
            //  //循环体：提示用户输入一个数字 接收 转换  打印2倍
            //  //循环条件：输入的不能是q
            // string  a = " ";
            //while (a != "q")
            //  {
            //      Console.WriteLine("请输入一个数字，我们将打印他的两倍");
            //      a = Console.ReadLine();
            //      if (a != "q")
            //      {
            //          try
            //          {

            //              int b = Convert.ToInt32(a);
            //              int c = b * 2;
            //              Console.WriteLine("该数字的两倍为{0}", c);
            //          }
            //          catch
            //          {
            //              Console.WriteLine("输入的数据不符合规范，程序退出");
            //          }
            //      }
            //      else 
            //      {
            //          Console.WriteLine("输入的是q，程序退出");
            //      }
            //  }
            //  Console.ReadKey ();
            #endregion
        }
    }
}
