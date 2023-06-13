using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 飞行棋
{
    internal class Program
    {
        //用静态字段来模拟全局变量
        public static int[] maps = new int[100];
        //静态数组存储玩家A和玩家B的坐标
        public static int[] PlayerPos = new int[2];
        //存储两个玩家的姓名
        public static string[] PlayerName = new string[2];
        //两个玩家的标记
        public static bool[] Flags = new bool[2];  //默认值为false
        /// <summary>
        /// 
        /// </summary>
        public static void Gameshow()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*******************************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*******************************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*******************************");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("******张健的飞行棋小游戏*******");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("*******************************");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("*******************************");
        }//游戏标题
        public static void InitailMap()
        {
            int[] luckyturn = { 6, 23, 40, 55, 69, 83 };//幸运轮盘◎
            for (int i = 0; i < luckyturn.Length; i++)
            {
                int index = luckyturn[i];
                maps[index] = 1;
            }
            int[] landMine = { 5, 13, 17, 33, 38, 50, 64, 80, 94 };//地雷☆
            for (int i = 0; i < landMine.Length; i++)
            {
                int index = landMine[i];
                maps[index] = 2;
            }
            int[] pause = { 9, 27, 60, 93 };//暂停▲
            for (int i = 0; i < pause.Length; i++)
            {
                int index = pause[i];
                maps[index] = 3;
            }
            int[] timeTunnel = { 20, 25, 45, 63, 72, 88, 90 };//时空隧道卐  
            for (int i = 0; i < timeTunnel.Length; i++)
            {
                int index = timeTunnel[i];
                maps[index] = 4;
            }
        }//初始化地图
        public static void DrawMap()//画地图
        {
            Console.WriteLine("图例:幸运轮盘:◎   地雷:☆   暂停:▲   时空隧道:卐");
            #region 第一横行
            //第一横行
            for (int i = 0; i < 30; i++)
            {
                Console.Write(DrawStringMap(i));
            }
            #endregion
            //画完第一横行后应该换行
            Console.WriteLine();
            #region 画第一竖行
            for (int i = 30; i < 35; i++)
            {
                for (int j = 0; j <= 28; j++)
                {
                    Console.Write("  ");
                }
                Console.Write(DrawStringMap(i));
                Console.WriteLine();
            }
            #endregion
            #region 画第二横行
            for (int i = 64; i >= 35; i--)
            {
                Console.Write(DrawStringMap(i));
            }
            #endregion
            //画完第二横行应该换行
            Console.WriteLine();
            #region 第二竖行
            for (int i = 65; i <= 69; i++)
            {
                Console.WriteLine(DrawStringMap(i));
            }
            #endregion
            #region 第三横行
            for (int i = 70; i <= 99; i++)
            {
                Console.Write(DrawStringMap(i));
            }
            #endregion
            Console.WriteLine();
        }
        public static string DrawStringMap(int i)
        {
            string str = " ";
            #region 画图
            //如果A和B的坐标相同，并且都在地图上，画一个尖括号
            if (PlayerPos[0] == PlayerPos[1] && PlayerPos[0] == i)
            {
                str = "<>";
            }
            else if (PlayerPos[0] == i)
            {
                str = "A";
            }
            else if (PlayerPos[1] == i)
            {
                str = "B";
            }
            else
            {
                switch (maps[i])
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Red;
                        str = "□";
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        str = "◎";
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        str = "☆";
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.White;
                        str = "▲";
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        str = "卐";
                        break;
                }
            }
            #endregion
            return str;
        }//画图的方法
        public static void PlayerGame(int playerNmuber) //游戏规则
        {
            Random r = new Random();
            int rnumber = r.Next(1, 7);
            Console.WriteLine("{0}按任意键开始掷骰子", PlayerName[playerNmuber]);
            Console.ReadKey(true);
            Console.WriteLine("{0}掷出了{1}", PlayerName[playerNmuber], rnumber);
            PlayerPos[playerNmuber] += rnumber;
            PlayPos();
            Console.ReadKey(true);
            Console.WriteLine("{0}按任意键开始行动", PlayerName[playerNmuber]);
            Console.ReadKey(true);
            Console.WriteLine("{0}行动完了", PlayerName[playerNmuber]);
            Console.ReadKey(true);
            //玩家A有可能踩到 玩家B 方块 幸运轮盘 地雷 暂停 时空隧道
            if (PlayerPos[playerNmuber] == PlayerPos[1 - playerNmuber])
            {
                Console.WriteLine("玩家{0}踩到了玩家{1}，玩家{2}退后6格", PlayerName[playerNmuber], PlayerName[1 - playerNmuber], PlayerName[1 - playerNmuber]);
                PlayerPos[1 - playerNmuber] -= 6;
                PlayPos();
                Console.ReadKey(true);
            }
            else//踩到关卡
            {
                //玩家的坐标
                switch (maps[PlayerPos[playerNmuber]])
                {
                    case 0:
                        Console.WriteLine("玩家{0}踩到了方块，安全", PlayerName[playerNmuber]);
                        Console.ReadKey(true);
                        break;
                    case 1:
                        Console.WriteLine("玩家{0}踩到了幸运轮盘，\n请选择  1--交换位置  2--轰炸对方", PlayerName[playerNmuber]);
                        string input = Console.ReadLine();
                        while (true)
                        {
                            if (input == "1")
                            {
                                Console.WriteLine("玩家{0}选择与玩家{1}交换位置", PlayerName[playerNmuber], PlayerName[1 - playerNmuber]);
                                Console.ReadKey(true);
                                int temp = PlayerPos[playerNmuber];
                                PlayerPos[playerNmuber] = PlayerPos[1 - playerNmuber];
                                PlayerPos[1 - playerNmuber] = temp;
                                Console.WriteLine("交换成功，按任意键继续");
                                Console.ReadKey(true);
                                break;
                            }
                            else if (input == "2")
                            {
                                Console.WriteLine("玩家{0}选择轰炸玩家{1}，玩家{2}退后六格", PlayerName[playerNmuber], PlayerName[1 - playerNmuber], PlayerName[1 - playerNmuber]);
                                Console.ReadKey(true);
                                PlayerPos[1 - playerNmuber] -= 6;
                                PlayPos();
                                Console.WriteLine("玩家{0}退后了六格", PlayerName[1 - playerNmuber]);
                                Console.ReadKey(true);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("只能输入1或者2\n 1--交换位置  2--轰炸对方");
                                input = Console.ReadLine();
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("玩家{0}踩到了地雷，退后六格", PlayerName[playerNmuber]);
                        Console.ReadKey(true);
                        PlayerPos[playerNmuber] -= 6;
                        PlayPos();
                        break;
                    case 3:
                        Console.WriteLine("玩家{0}踩到了暂停，暂停一回合", PlayerName[playerNmuber]);
                        Flags[playerNmuber] = true;
                        Console.ReadKey(true);
                        break;
                    case 4:
                        Console.WriteLine("玩家{0}踩到了时空隧道，前进十格", PlayerName[playerNmuber]);
                        PlayerName[playerNmuber] += 10;
                        PlayPos();
                        Console.ReadKey(true);
                        break;
                }
            }
            PlayPos();
            Console.Clear();
            DrawMap();
        }
        /// <summary>
        /// 当玩家坐标改变时调用该方法
        /// </summary>
        public static void PlayPos()//防止玩家出界
        {
            if (PlayerPos[0] < 0)
            {
                PlayerPos[0] = 0;
            }
            if (PlayerPos[0] > 99)
            {
                PlayerPos[0] = 99;
            }
            if (PlayerPos[1] < 0)
            {
                PlayerPos[1] = 0;
            }
            if (PlayerPos[1] > 99)
            {
                PlayerPos[1] = 99;
            }
        }
        public static void Win()//胜利
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                                          ◆                      ");
            Console.WriteLine("                    ■                  ◆               ■        ■");
            Console.WriteLine("      ■■■■  ■  ■                ◆■         ■    ■        ■");
            Console.WriteLine("      ■    ■  ■  ■              ◆  ■         ■    ■        ■");
            Console.WriteLine("      ■    ■ ■■■■■■       ■■■■■■■   ■    ■        ■");
            Console.WriteLine("      ■■■■ ■   ■                ●■●       ■    ■        ■");
            Console.WriteLine("      ■    ■      ■               ● ■ ●      ■    ■        ■");
            Console.WriteLine("      ■    ■ ■■■■■■         ●  ■  ●     ■    ■        ■");
            Console.WriteLine("      ■■■■      ■             ●   ■   ■    ■    ■        ■");
            Console.WriteLine("      ■    ■      ■            ■    ■         ■    ■        ■");
            Console.WriteLine("      ■    ■      ■                  ■               ■        ■ ");
            Console.WriteLine("     ■     ■      ■                  ■           ●  ■          ");
            Console.WriteLine("    ■    ■■ ■■■■■■             ■              ●         ●");
            Console.ResetColor();
        }
        static void Main(string[] args)
        {
            Gameshow();
            #region 输入玩家的姓名
            Console.WriteLine("请输入玩家A的姓名");
            PlayerName[0] = Console.ReadLine();
            while (PlayerName[0] == " ")
            {
                Console.WriteLine("玩家A的姓名不能为空，请重新输入");
                PlayerName[0] = Console.ReadLine();
            }
            Console.WriteLine("请输入玩家B的姓名");
            PlayerName[1] = Console.ReadLine();
            while (PlayerName[1] == "" || PlayerName[1] == PlayerName[0])
            {
                if (PlayerName[1] == "")
                {
                    Console.WriteLine("玩家B的姓名不能为空，请重新输入");
                    PlayerName[1] = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("玩家B的姓名不能与A相同，请重新输入");
                    PlayerName[1] = Console.ReadLine();
                }
            }
            #endregion
            //玩家姓名输入后，应首先清屏，然后再打印一遍标题
            Console.Clear();
            Gameshow();
            Console.WriteLine("{0}的士兵用A表示", PlayerName[0]);
            Console.WriteLine("{0}的士兵用B表示", PlayerName[1]);
            //在画地图之前需要初始化地图
            InitailMap();
            DrawMap();
            //当玩家A与玩家B没有一个人在终点时，游戏不结束
            while (PlayerPos[0] < 99 && PlayerPos[1] < 99)
            {
                if (Flags[0] == false)
                    PlayerGame(0);
                else
                {
                    Flags[0] = false;
                }
                if (PlayerPos[0] >= 99)
                {
                    Console.WriteLine("玩家{0}赢了玩家{1}", PlayerName[0], PlayerName[1]);
                    break;
                }
                if (Flags[1] == false)
                    PlayerGame(1);
                else
                {
                    Flags[1] = false;
                }
                if (PlayerPos[1] >= 99)
                {
                    Console.WriteLine("玩家{0}赢了玩家{1}", PlayerName[1], PlayerName[0]);
                    break;
                }
            }
            Win();
            Console.ReadKey();
        }
    }
}
