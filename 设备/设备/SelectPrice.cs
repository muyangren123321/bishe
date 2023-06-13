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
    public partial class SelectPrice : Form
    {
        string connString;
        SqlConnection connection;
        public SelectPrice()
        {
            InitializeComponent();
            connString = @"Data Source=laptop-g2274mht; Initial Catalog=MyEquipment;Integrated Security=true";
            connection = new SqlConnection(connString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal price1, price2;
            try
            {
                price1 = Convert.ToDecimal(textBox1.Text); price2 = Convert.ToDecimal(textBox2.Text);
            }
            catch
            {
                price1 = 0; price2 = 2000000M;//默认为最大值
            }
            if (price1 > price2)
            { //如果price1 > price2,交换两者
                decimal temp = price1;
                price1 = price2;
                price2 = temp;
            }
            //按价格查询设备
            string sql = String.Format("select* from [equipment] where price between {0} and {1} ", price1, price2);
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);
                DataSet dataSet = new DataSet("equipment");
                dataAdapter.Fill(dataSet);
                //设置各列的显示数据字段
                dataGridView1.Columns[0].DataPropertyName = "id";
                dataGridView1.Columns[1].DataPropertyName = "name";
                dataGridView1.Columns[2].DataPropertyName = "price";
                dataGridView1.Columns[3].DataPropertyName = "count";
                dataGridView1.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错 ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
