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
    public partial class FrmList : Form
    {
        public FrmList()
        {
            InitializeComponent();
        }

        private void btnHot_Click(object sender, EventArgs e)
        {
            btnHot.BackColor = Color.FromArgb(24, 187, 255);
            btnUp.BackColor = Color.Transparent;
            string sql = "select m.MovieName,M.MovieImage,m.MovieID,count(M.MovieID) 销量 from MovieInfo M join OrderInfo O on m.MovieID=o.MovieId Group by M.MovieName,m.MovieID,M.MovieImage order by M.MovieID";
            index = 0;
            Getdate(sql);
            UpMovie();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            btnHot.BackColor = Color.Transparent;
            btnUp.BackColor = Color.FromArgb(24, 187, 255);
            string sql = "select m.MovieID,m.MovieName,addtime,m.MovieImage from MovieInfo M join Movieaddtime T on M.MovieID =T.MovieId order by t.addtime desc";
            index = 0;
            Getdate(sql);
            Cler();
            UpMovie();
        }

        private void FrmList_Load(object sender, EventArgs e)
        {
            btnHot.BackColor = Color.FromArgb(24, 187, 255);
            string sql = "select m.MovieName,M.MovieImage,m.MovieID,count(M.MovieID) 销量 from MovieInfo M join OrderInfo O on m.MovieID=o.MovieId Group by M.MovieName,m.MovieID,M.MovieImage order by M.MovieID";
            Getdate(sql);
            Cler();
            UpMovie();
            ket();
            add();
        }
        DataTable dt;
        int index=0;
        int count;
        private void Getdate(string sql)
        {
            DBHelper helper = new DBHelper();
            DataSet ds = helper.GetDataSet(sql);
            dt = ds.Tables[0];
            count = ds.Tables[0].Rows.Count-1;
        }
        private void UpMovie()
        {
            Cler();
            if (index > count) {  Endcike(); return; }
            DataRow dr = dt.Rows[index];
            pictureBox1.Image = Image.FromFile(Convert.ToString(dr["MovieImage"]));
            label1.Text = Convert.ToString(dr["MovieName"]);
            if (index + 1 > count) { Endcike(); return; }
            dr = dt.Rows[index+1];
            pictureBox2.Image = Image.FromFile(Convert.ToString(dr["MovieImage"]));
            label2.Text = Convert.ToString(dr["MovieName"]);
            if (index + 2 > count) { Endcike(); return; }
            dr = dt.Rows[index+2];
            pictureBox3.Image = Image.FromFile(Convert.ToString(dr["MovieImage"]));
            label3.Text = Convert.ToString(dr["MovieName"]);
            if (index + 3 > count) { Endcike(); return; }
            dr = dt.Rows[index+3];
            pictureBox4.Image = Image.FromFile(Convert.ToString(dr["MovieImage"]));
            label4.Text = Convert.ToString(dr["MovieName"]);
            if (index + 4 > count) { Endcike(); return; }
            dr = dt.Rows[index+4];
            pictureBox5.Image = Image.FromFile(Convert.ToString(dr["MovieImage"]));
            label5.Text = Convert.ToString(dr["MovieName"]);
            if (index + 5 > count) { Endcike(); return; }
            dr = dt.Rows[index+5];
            pictureBox6.Image = Image.FromFile(Convert.ToString(dr["MovieImage"]));
            label6.Text = Convert.ToString(dr["MovieName"]);
            if (index + 6 > count) { Endcike(); return; }
            dr = dt.Rows[index+6];
            pictureBox7.Image = Image.FromFile(Convert.ToString(dr["MovieImage"]));
            label7.Text = Convert.ToString(dr["MovieName"]);
            if (index + 7 > count) { Endcike(); return; }
            dr = dt.Rows[index+7];
            pictureBox8.Image = Image.FromFile(Convert.ToString(dr["MovieImage"]));
            label8.Text = Convert.ToString(dr["MovieName"]);
        }
        private void Endcike()
        {
            if (label1.Text == null)
                panel1.Enabled = false;
            else
                panel1.Enabled = true;
            if (label2.Text == null)
                panel2.Enabled = false;
            else
                panel2.Enabled = true;
            if (label3.Text == null)
                panel3.Enabled = false;
            else
                panel3.Enabled = true;
            if (label4.Text == null)
                panel4.Enabled = false;
            else
                panel4.Enabled = true;
            if (label5.Text == null)
                panel5.Enabled = false;
            else
                panel5.Enabled = true;
            if (label6.Text == null)
                panel6.Enabled = false;
            else
                panel6.Enabled = true;
            if (label7.Text == null)
                panel7.Enabled = false;
            else
                panel7.Enabled = true;
            if (label8.Text == null)
                panel8.Enabled = false;
            else
                panel8.Enabled = true;
        }
        private void Cler()
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            label1.Text = null;
            label2.Text = null;
            label3.Text = null;
            label4.Text = null;
            label5.Text = null;
            label6.Text = null;
            label7.Text = null;
            label8.Text = null;
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            ket();
        }
        private void ket()
        {
            if (index == 0)
            {
                btndel.Enabled = false;
                btnadd.Enabled = true;
                return;
            }
            else
            {
                index -= 8;
                UpMovie();
                if (index == 0)
                {
                    btndel.Enabled = false;
                    btnadd.Enabled = true;
                    return;
                }
            }
        }
        private void add()
        {
            if (index >= count)
            {
                btnadd.Enabled = false;
                btndel.Enabled = true;
                return;
            }
            else
            {
                index += 8;
                UpMovie();
                if (index >= count)
                {
                    btnadd.Enabled = false;
                    btndel.Enabled = true;
                    return;
                }
            }
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            add();
        }
        public int UserID;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmMovieOrder od = new FrmMovieOrder();
            od.UserID = UserID;
            od.MovieName = label1.Text;
            od.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmMovieOrder od = new FrmMovieOrder();
            od.UserID = UserID;
            od.MovieName = label2.Text;
            od.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmMovieOrder od = new FrmMovieOrder();
            od.UserID = UserID;
            od.MovieName = label3.Text;
            od.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FrmMovieOrder od = new FrmMovieOrder();
            od.UserID = UserID;
            od.MovieName = label4.Text;
            od.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FrmMovieOrder od = new FrmMovieOrder();
            od.UserID = UserID;
            od.MovieName = label5.Text;
            od.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FrmMovieOrder od = new FrmMovieOrder();
            od.UserID = UserID;
            od.MovieName = label6.Text;
            od.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            FrmMovieOrder od = new FrmMovieOrder();
            od.UserID = UserID;
            od.MovieName = label7.Text;
            od.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            FrmMovieOrder od = new FrmMovieOrder();
            od.UserID = UserID;
            od.MovieName = label8.Text;
            od.Show();
        }
    }
}
