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
    public partial class frmshowMovieMMG : Form
    {
        public frmshowMovieMMG()
        {
            InitializeComponent();
        }
        private DataTable GetData(string sql)
        {
            DBHelper helper = new DBHelper();
            DataSet ds = helper.GetDataSet(sql);
            return ds.Tables[0];
        }

        private void frmshowMovieMMG_Load(object sender, EventArgs e)
        {
            Uptabel();
            textBox1.Text = null;
        }

        private void btSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmAdminZjm adz = new FrmAdminZjm();
            adz.Show();
        }
        private Point mPoint;//鼠标坐标

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);//鼠标按下时更新坐标
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
        }

        private void btnaddnew_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("请选择电影！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string sql = "select m.MovieName,upshow from ShowMovie S join MovieInfo M on s.MovieId = m.MovieID  where s.upshow='{0} {1}'";
            sql = string.Format(sql, dateTimePicker1.Value.ToString("yyyy-MM-dd"), cbxtime.Text);
            if (GetData(sql).Rows.Count>0)
                MessageBox.Show("时间已存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                sql = "insert into ShowMovie(MovieID,upshow) values({0},'{1} {2}')";
                sql = string.Format(sql, int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString()), dateTimePicker1.Value.ToString("yyyy-MM-dd"), cbxtime.Text);
                Update(sql);
                Uptabel();
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
        private void Uptabel()
        {
            string sql = "select MovieID,MovieName from MovieInfo";
            dataGridView1.DataSource = GetData(sql);
            sql = "select m.MovieID,MovieName,addtime from MovieInfo M join Movieaddtime A on m.MovieID = a.movieId";
            dataGridView2.DataSource = GetData(sql);
            sql = "select m.MovieName,upshow,id from ShowMovie S join MovieInfo M on s.MovieId = m.MovieID Order by m.MovieID";
            dataGridView3.DataSource = GetData(sql);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((int)MessageBox.Show("确认删除", "友情提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != 1)
            {
                return;
            }
            else
            {
                string sql = string.Format("delete from ShowMovie where id ={0}", dataGridView3.Rows[dataGridView3.CurrentRow.Index].Cells[2].Value.ToString());
                Update(sql);
                Uptabel();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView2.CurrentRow.Index;
            textBox2.Text = dataGridView2.Rows[index].Cells[1].Value.ToString();
            dateTimePicker2.Text = dataGridView2.Rows[index].Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = string.Format("update Movieaddtime set addtime = '{0}' where MovieId={1}",dateTimePicker2.Value.ToString("yyyy-MM-dd"), dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells[0].Value.ToString());
            Update(sql);
            Uptabel();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "select m.MovieID,MovieName,addtime from MovieInfo M join Movieaddtime A on m.MovieID = a.movieId where A.MovieID='{0}'";
            sql = string.Format(sql, dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            if (GetData(sql).Rows.Count > 0)
            {
                MessageBox.Show("影片已存在上架时间", "友情提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                sql = string.Format("insert into Movieaddtime(addtime,MovieId) values('{0}',{1})",dateTimePicker3.Value.ToString("yyyy-MM-dd"), dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
                Update(sql);
                Uptabel();
            }    
        }
    }
}
