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
    public partial class DataMaint : Form
    {
        private SqlDataAdapter da = new SqlDataAdapter();
        private DataSet ds = new DataSet("my");
        private void ShowData()
        {
            string connString = @"Data Source=laptop-g2274mht; Initial Catalog=MyEquipment;Integrated Security=true";
            string sql = "select id as 设备编号,name as 设备名称,price as 价格, count as 数量 from equipment";
            SqlConnection conn = new SqlConnection(connString);//创建连接对象
            conn.Open();//连接数据库
            SqlCommand comm = new SqlCommand(sql, conn); da.SelectCommand = comm;//把命令对象绑定数据适配器对象
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            da.Fill(ds, "equipment");
            dataGridView1.DataSource = ds.Tables["equipment"];//绑定数据
            conn.Close();//关闭数据库
        }

        public DataMaint()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)//关闭
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)//刷新
        {
            ShowData();
        }

        private void DataMaint_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            da.Update(ds, "equipment");
            MessageBox.Show("数据更新已经成功！", "注意", MessageBoxButtons.OKCancel);
        }
    }
}
