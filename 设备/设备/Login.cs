using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 设备
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text; 
            string password = textBox2.Text;
            string connString = @"Data Source=laptop-g2274mht; Initial Catalog=MyEquipment;Integrated Security=true";
            SqlConnection conn = new SqlConnection(connString);
            //创建连接对象
            string sql = string.Format("select count(*) from [user] where username='{0}'and password = '{1}'", userName, password);
            //获取用户名和密码匹配的行数
            try
            {
                conn.Open();//打开数据库连接
                SqlCommand comm = new SqlCommand(sql, conn); int n = (int)comm.ExecuteScalar();
                //反馈查询到的行数
                if (n >= 1)
                {
                    this.Hide();
                    MainFrm mainFrm = new MainFrm(); mainFrm.Show();//登陆成功 打开新窗口
                }
                else
                {
                    MessageBox.Show("您输入的账户名或密码有误，请检查");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "数据库操作失败");
            }
            finally
            {
                conn.Close();//关闭数据库
            }
        }

    }
}
