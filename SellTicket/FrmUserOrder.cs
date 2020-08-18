using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SellTicket
{
    public partial class FrmUserOrder : Form
    {
        public FrmUserOrder()
        {
            InitializeComponent();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            btnAll.BackColor = Color.FromArgb(24, 187, 255);
            btnRecent.BackColor = Color.Transparent;
            sql = "select m.MovieName,o.addTime,o.addMoney,o.addNumber,o.Seat,o.MovieUptime from MovieInfo M join OrderInfo O on m.MovieID = o.MovieId where UserId = {0}";
            sql = string.Format(sql, UserID);
            GetdateOrder(sql);
        }

        private void btnRecent_Click(object sender, EventArgs e)
        {
            btnAll.BackColor = Color.Transparent;
            btnRecent.BackColor = Color.FromArgb(24, 187, 255);
            sql = "select m.MovieName,o.addTime,o.addMoney,o.addNumber,o.Seat,o.MovieUptime from MovieInfo M join OrderInfo O on m.MovieID = o.MovieId where UserId = {0} order by o.addTime desc";
            sql = string.Format(sql, UserID);
            GetdateOrder(sql);
        }
        public int UserID;
        private string sql;
        private void FrmUserOrder_Load(object sender, EventArgs e)
        {
            btnAll.BackColor = Color.FromArgb(24, 187, 255);
            sql = "select m.MovieName,o.addTime,o.addMoney,o.addNumber,o.Seat,o.MovieUptime from MovieInfo M join OrderInfo O on m.MovieID = o.MovieId where UserId = {0}";
            sql = string.Format(sql, UserID);
            GetdateOrder(sql);
            GetUser();
        }
        private void GetdateOrder(string sql)
        {
            DBHelper helper = new DBHelper();
            DataSet ds = helper.GetDataSet(sql);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[5].DefaultCellStyle.Format = "yyyy-MM-dd hh:mm";
        }
        private void GetUser()
        {
            DBHelper helper = new DBHelper();
            string sql = string.Format("select * from Users where ID={0}",UserID);
            DataSet ds = helper.GetDataSet(sql);
            DataTable dt = ds.Tables[0];
            DataRow dr = dt.Rows[0];
            textBox1.Text = Convert.ToString(dr["zhName"]);
            textBox2.Text = Convert.ToString(dr["Bank"]);
            textBox3.Text = Convert.ToString(dr["Phone"]);
            textBox4.Text = Convert.ToString(dr["UserName"]);
            textBox5.Text = Convert.ToString(dr["ID"]);
            dateTimePicker1.Value = Convert.ToDateTime(dr["Birthday"]);
        }
        private void btnEndt_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            dateTimePicker1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql = "update Users set zhName='{0}',Birthday='{1}',Bank='{2}',Phone='{3}' where id={4}";
            sql = string.Format(sql, textBox1.Text, dateTimePicker1.Value, textBox2.Text, textBox3.Text,UserID);
            Update(sql);
        }
        private void Update(string sql)
        {
            DBHelper helper = new DBHelper();
            if (helper.Updata(sql) > 0)
            {
                MessageBox.Show("保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetUser();
                textBox1.Enabled = false;
                dateTimePicker1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
            }              
            else
                MessageBox.Show("保存失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmUserPwd pwdz = new frmUserPwd();
            pwdz.ID = UserID;
            pwdz.Show();
        }
    }
}
