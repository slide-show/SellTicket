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

namespace SellTicket
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }
        public int UserID;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;//用双缓冲绘制窗口的所有子控件
                return cp;
            }
        }
        private void FrmHome_Load(object sender, EventArgs e)
        {
            GetVideName();//更新主页电影信息
        }
        private void GetVideName()
        {
            DBHelper helper = new DBHelper();
            string sql = "select MovieName,MovieImage,count(MovieName) 销量 from MovieInfo M join OrderInfo  O on M.MovieID = O.MovieId group by MovieName,MovieImage order by 销量 desc";
            DataSet ds = helper.GetDataSet(sql);
            DataTable dt = ds.Tables[0];
            DataRow dr = dt.Rows[0];
            this.VideImage1.Image = Image.FromFile(Convert.ToString(dr["MovieImage"]));
            this.labVideName1.Text = Convert.ToString(dr["MovieName"]);
            dr = dt.Rows[1];
            this.VideImage2.Image = Image.FromFile(Convert.ToString(dr["MovieImage"]));
            this.labVideName2.Text = Convert.ToString(dr["MovieName"]);
            dr = dt.Rows[2];
            this.VideImage3.Image = Image.FromFile(Convert.ToString(dr["MovieImage"]));
            this.labVideName3.Text = Convert.ToString(dr["MovieName"]);
            dr = dt.Rows[3];
            this.VideImage4.Image = Image.FromFile(Convert.ToString(dr["MovieImage"]));
            this.labVideName4.Text = Convert.ToString(dr["MovieName"]);
            sql = "select m.MovieID,m.MovieName,addtime,m.MovieImage from MovieInfo M join Movieaddtime T on M.MovieID =T.MovieId where datediff( day, SYSDATETIME(),t.addtime) >  0 order by t.addtime";
            ds = helper.GetDataSet(sql);
            dt = ds.Tables[0];
            dr = dt.Rows[0];
            pictureBox4.Image = Image.FromFile(Convert.ToString(dr["MovieImage"]));
            label5.Text = Convert.ToString(dr["MovieName"]);
            dr = dt.Rows[1];
            pictureBox6.Image = Image.FromFile(Convert.ToString(dr["MovieImage"]));
            label7.Text = Convert.ToString(dr["MovieName"]);
            dr = dt.Rows[2];
            pictureBox5.Image = Image.FromFile(Convert.ToString(dr["MovieImage"]));
            label6.Text = Convert.ToString(dr["MovieName"]);
            dr = dt.Rows[3];
            pictureBox7.Image = Image.FromFile(Convert.ToString(dr["MovieImage"]));
            label8.Text = Convert.ToString(dr["MovieName"]);
        }

        private void VideImage1_Click(object sender, EventArgs e)
        {
            FrmMovieOrder mo = new FrmMovieOrder();
            mo.MovieName = this.labVideName1.Text;
            mo.UserID = UserID;
            mo.Show();        
        }

        private void VideImage2_Click(object sender, EventArgs e)
        {
            FrmMovieOrder mo = new FrmMovieOrder();
            mo.MovieName = this.labVideName2.Text;
            mo.UserID = UserID;
            mo.Show();  
        }

        private void VideImage3_Click(object sender, EventArgs e)
        {
            FrmMovieOrder mo = new FrmMovieOrder();
            mo.MovieName = this.labVideName3.Text;
            mo.UserID = UserID;
            mo.Show();
            
        }

        private void VideImage4_Click(object sender, EventArgs e)
        {
            FrmMovieOrder mo = new FrmMovieOrder();
            mo.MovieName = this.labVideName4.Text;
            mo.UserID = UserID;
            mo.Show();
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("影片还未上映","提示",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("影片还未上映", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("影片还未上映", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("影片还未上映", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
