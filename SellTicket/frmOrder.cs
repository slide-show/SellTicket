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
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmAdminZjm zjm = new FrmAdminZjm();
            zjm.Show();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            Getdate();
            Getpf();
        }
        private void Getdate()
        {
            DBHelper helper = new DBHelper();
            string sql = "select o.orderId,m.MovieID,MovieName,m.MovieType,m.Price,o.addNumber,o.Seat,u.zhName,u.UserName,o.MovieUptime from MovieInfo M join OrderInfo  O on M.MovieID = O.MovieId join Users U on o.UserId = u.ID";
            DataSet ds = helper.GetDataSet(sql);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private Point mPoint;//鼠标坐标

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);//鼠标按下时更新坐标
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
        }
        private void Getpf()
        {
            string sql = "select M.MovieID,M.MovieName,count(M.MovieID) 销量,sum(Price) 票房 from MovieInfo M join OrderInfo O on m.MovieID = o.MovieId group by M.MovieID,M.MovieName";
            DBHelper helper = new DBHelper();
            dataGridView2.DataSource = helper.GetDataSet(sql).Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((int)MessageBox.Show("确认删除", "友情提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != 1)
            {
                return;
            }
            else
            {
                int ID = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
                string sql = "delete OrderInfo where orderId={0}";
                sql = string.Format(sql, ID);
                Update(sql);
                Getpf();
                Getdate();
            }
        }
        private void Update(string sql)
        {
            DBHelper helper = new DBHelper();
            if (helper.Updata(sql) > 0)
            {
                MessageBox.Show("更新成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("更新失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
