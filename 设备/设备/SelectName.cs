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
    public partial class SelectName : Form
    {
        string connString;
        SqlConnection connection;
        public SelectName()
        {
            InitializeComponent();
            connString = @"Data Source =laptop-g2274mht;Initial Catalog = MyEquipment;Integrated Security = True";
            connection = new SqlConnection(connString);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            //按名称查询设备
            string sql = String.Format("select* from equipment where name like '%{0}%' ", name);
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);
                DataSet dataSet = new DataSet("equipment");
                dataAdapter.Fill(dataSet);
                dataGridView1.Columns[0].DataPropertyName = "id";
                dataGridView1.Columns[1].DataPropertyName = "name";
                dataGridView1.Columns[2].DataPropertyName = "price";
                dataGridView1.Columns[3].DataPropertyName = "count";
                dataGridView1.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "操作数据库出错！",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
    }
}
