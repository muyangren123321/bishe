using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Student[] s = new Student[100];
        StudentList sl = new StudentList();
        int i = 0;
        public class Student
        {
            public int ID;
            public string Name;
            public double ChineseGrade;
            public double MathsGrade;
            public double EnglishGrade;
            public double Sum
            {
                get { return ChineseGrade + MathsGrade + EnglishGrade; }
            }
            public Student(int ID, string Name, double ChineseGrade, double MathsGrade, double EnglishGrade)
            {
                this.ID = ID;
                this.Name = Name;
                this.ChineseGrade = ChineseGrade;
                this.MathsGrade = MathsGrade;
                this.EnglishGrade = EnglishGrade;
            }
        }
        public class StudentList
        {
            Student[] stu = new Student[100];
            double[] sum = new double[100];
            public int i = 0;
            public void AddStudent(Student s)
            {
                stu[i] = s;
                sum[i] = stu[i].Sum;
                i++;
            }
            //查询每个学生的总成绩
            int j = 0;
            int index = 0;
            bool Judge = false;
            public double GetSum(string s)
            {
                for (j = 0; j < i; j++)
                {
                    if (stu[j].Name == s)
                    {
                        index = j;
                        Judge = true;
                    }
                }
                if (Judge == true)
                {
                    return sum[index];
                }
                else
                {
                    return -1;//若未搜索到该学生姓名，则返回-1
                }
            }
            //全班学生的平均成绩为
            double avg = 0;
            public double GetAvg()
            {
                for (j = 0; j < i; j++)
                {
                    avg += sum[j];
                }
                return avg / i;
            }
            //全班前3名的名单为
            public string GetTopthree()
            {
                Student[] t = new Student[1];
                t[0] = new Student(0, "", 0, 0, 0);
                for (j = 0; j < i - 1; j++)
                {
                    for (int y = j + 1; y < i; y++)
                    {
                        if (sum[y] > sum[j])
                        {
                            double temp = sum[y];
                            sum[y] = sum[j];
                            sum[j] = temp;
                            t[0] = stu[y];
                            stu[y] = stu[j];
                            stu[j] = t[0];
                        }
                    }
                }
                return " " + stu[0].Name + " " + stu[1].Name + " " + stu[2].Name;
            }
            //单科语文成绩最高分为
            double maxChinese = 0;
            public double GetMaxChinese()
            {
                for (j = 0; j < i; j++)
                {
                    if (stu[j].ChineseGrade > maxChinese)
                    {
                        maxChinese = stu[j].ChineseGrade;
                    }
                }
                return maxChinese;
            }
            //单科数学成绩最高分
            double maxMaths = 0;
            public double GetMaxMaths()
            {
                for (j = 0; j < i; j++)
                {
                    if (stu[j].MathsGrade > maxMaths)
                    {
                        maxMaths = stu[j].MathsGrade;
                    }
                }
                return maxChinese;
            }
            //单科英语成绩最高分
            double maxEnglish = 0;
            public double GetMaxEnglish()
            {
                for (j = 0; j < i; j++)
                {
                    if (stu[j].EnglishGrade > maxEnglish)
                    {
                        maxEnglish = stu[j].EnglishGrade;
                    }
                }
                return maxEnglish;
            }
            //语文不及格的学生名单为
            string ChineseFalse;
            public string GetFasleChinese()
            {
                for (int x = 0; x < i; x++)
                {
                    if (stu[x].ChineseGrade < 60)
                    {
                        ChineseFalse += stu[x].Name;
                    }
                }
                return " " + ChineseFalse;
            }
            //数学不及格的学生名单为
            string MathsFalse;
            public string GetFasleMaths()
            {
                for (int x = 0; x < i; x++)
                {
                    if (stu[x].MathsGrade < 60)
                    {
                        MathsFalse += stu[x].Name;
                    }
                }
                return " " + MathsFalse;
            }
            //英语不及格的学生名单为
            string EnglishFalse;
            public string GetFasleEnglish()
            {
                for (int x = 0; x < i; x++)
                {
                    if (stu[x].EnglishGrade < 60)
                    {
                        EnglishFalse += stu[x].Name;
                    }
                }
                return " " + EnglishFalse;
            }
            //各科成绩在不同分数段的学生人数百分比为
            public string GetBFBChinese()
            {
                double ChineseGrade1 = 0, ChineseGrade2 = 0, ChineseGrade3 = 0, ChineseGrade4 = 0, ChineseGrade5 = 0;
                for (int x = 0; x < i; x++)
                {
                    if (stu[x].ChineseGrade <= 100 && stu[x].ChineseGrade >= 90)
                        ChineseGrade1++;
                    else if (stu[x].ChineseGrade < 90 && stu[x].ChineseGrade >= 80)
                        ChineseGrade2++;
                    else if (stu[x].ChineseGrade < 80 && stu[x].ChineseGrade >= 70)
                        ChineseGrade3++;
                    else if (stu[x].ChineseGrade < 70 && stu[x].ChineseGrade >= 60)
                        ChineseGrade4++;
                    else
                        ChineseGrade5++;
                }
                return "\n90-100:" + (ChineseGrade1 / i) * 100.0 + "%\n80-90:" + (ChineseGrade2 / i) * 100.0 + "%\n70-80:" + (ChineseGrade3 / i) * 100.0
                        + "%\n60-70:" + (ChineseGrade4 / i) * 100.0 + "%\n60以下:" + (ChineseGrade5 / i) * 100.0 + "%";
            }
            public string GetBFBMaths()
            {
                double MathsGrade1 = 0, MathsGrade2 = 0, MathsGrade3 = 0, MathsGrade4 = 0, MathsGrade5 = 0;
                for (int x = 0; x < i; x++)
                {
                    if (stu[x].MathsGrade <= 100 && stu[x].ChineseGrade >= 90)
                        MathsGrade1++;
                    else if (stu[x].MathsGrade < 90 && stu[x].ChineseGrade >= 80)
                        MathsGrade2++;
                    else if (stu[x].MathsGrade < 80 && stu[x].ChineseGrade >= 70)
                        MathsGrade3++;
                    else if (stu[x].MathsGrade < 70 && stu[x].ChineseGrade >= 60)
                        MathsGrade4++;
                    else
                        MathsGrade5++;
                }
                return "\n90-100:" + (MathsGrade1 / i) * 100.0 + "%\n80-90:" + (MathsGrade2 / i) * 100.0 + "%\n70-80:" + (MathsGrade3 / i) * 100.0
                        + "%\n60-70:" + (MathsGrade4 / i) * 100.0 + "%\n60以下:" + (MathsGrade5 / i) * 100.0 + "%";
            }
            public string GetBFBEnglish()
            {
                double EnglishGrade1 = 0, EnglishGrade2 = 0, EnglishGrade3 = 0, EnglishGrade4 = 0, EnglishGrade5 = 0;
                for (int x = 0; x < i; x++)
                {
                    if (stu[x].EnglishGrade <= 100 && stu[x].EnglishGrade >= 90)
                        EnglishGrade1++;
                    else if (stu[x].EnglishGrade < 90 && stu[x].EnglishGrade >= 80)
                        EnglishGrade2++;
                    else if (stu[x].EnglishGrade < 80 && stu[x].EnglishGrade >= 70)
                        EnglishGrade3++;
                    else if (stu[x].EnglishGrade < 70 && stu[x].EnglishGrade >= 60)
                        EnglishGrade4++;
                    else
                        EnglishGrade5++;
                }
                return "\n90-100:" + (EnglishGrade1 / i) * 100.0 + "%\n80-90:" + (EnglishGrade2 / i) * 100.0 + "%\n70-80:" + (EnglishGrade3 / i) * 100.0
                        + "%\n60-70:" + (EnglishGrade4 / i) * 100.0 + "%\n60以下:" + (EnglishGrade5 / i) * 100.0 + "%";
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txtsNo.Text);//将文本框输入的string强转为int型
            string Name = Convert.ToString(txtsName.Text);
            double ChineseGrade = Convert.ToDouble(txtChinese.Text);//将文本框输入的string强转为double型
            double MathsGrade = Convert.ToDouble(txtMaths.Text);//将文本框输入的string强转为double型
            double EnglishGrade = Convert.ToDouble(txtEnglish.Text);//将文本框输入的string强转为double型
            Student stu = new Student(ID, Name, ChineseGrade, MathsGrade, EnglishGrade);//将变量传入数组
            try//异常处理
            {
                int sno = Convert.ToInt32(txtsNo.Text);
                string sname = Convert.ToString(txtsName.Text);
                double chinese = Convert.ToDouble(txtChinese.Text);
                double maths = Convert.ToDouble(txtMaths.Text);
                double english = Convert.ToDouble(txtEnglish.Text);
            }
            catch (FormatException ex)
            {
                lblShow.Text = ex.Message;
            }
            catch (OverflowException ex)
            {
                lblShow.Text = ex.Message;
            }
            catch (Exception ex)
            {
                lblShow.Text = ex.Message;
            }
            sl.AddStudent(stu);
            s[i] = new Student(ID, Name, ChineseGrade, MathsGrade, EnglishGrade);
            i++;
            lblShow.Text = string.Format("成功添加{0}个同学的信息", i);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnCount_Click_Click(object sender, EventArgs e)
        {
            double result = sl.GetSum(txtsName.Text);
            txtGrade.Text = Convert.ToString(result);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            {
                lblShow.Text = string.Format("全班前3名的名单为：{0}", sl.GetTopthree());
                lblShow.Text += string.Format("\n语文成绩最高分为：{0}", sl.GetMaxChinese());
                lblShow.Text += string.Format("\n数学成绩最高分为：{0}", sl.GetMaxMaths());
                lblShow.Text += string.Format("\n英语成绩最高分为：{0}", sl.GetMaxEnglish());
                lblShow.Text += string.Format("\n语文不及格的学生名单为：{0}", sl.GetFasleChinese());
                lblShow.Text += string.Format("\n数学不及格的学生名单为：{0}", sl.GetFasleMaths());
                lblShow.Text += string.Format("\n英语不及格的学生名单为：{0}", sl.GetFasleEnglish());
                lblShow.Text += string.Format("\n全班学生的平均成绩为：{0}", sl.GetAvg());
                lblShow.Text += string.Format("\n语文成绩在不同分数段的学生人数百分比为：{0}", sl.GetBFBChinese());
                lblShow.Text += string.Format("\n数学成绩在不同分数段的学生人数百分比为：{0}", sl.GetBFBMaths());
                lblShow.Text += string.Format("\n英语成绩在不同分数段的学生人数百分比为：{0}", sl.GetBFBEnglish());
            }
        }
    }
}


