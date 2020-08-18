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
    public partial class FrmMovieOrder : Form
    {
        public FrmMovieOrder()
        {
            InitializeComponent();
        }
        public string MovieName;
        public int UserID;
        public int MovieID;
        private int Getdata()
        {
            string sql = "select * from MovieInfo M join Movieaddtime T on M.MovieID =T.MovieId join ShowMovie S on s.MovieId = m.MovieID where m.MovieName ='{0}'";
            sql = string.Format(sql, MovieName);
            DBHelper helper = new DBHelper();
            DataSet ds = helper.GetDataSet(sql);
            DataTable dt = ds.Tables[0];
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("没有相关信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return 0;
            }
            DataRow dr = dt.Rows[0];
            text1.Text = Convert.ToString(dr["MovieName"]);
            text2.Text = Convert.ToString(dr["Director"]);
            text3.Text = Convert.ToString(dr["ToStar"]);
            textBox4.Text = Convert.ToString(dr["MovieType"]);
            textBox5.Text = Convert.ToString(dr["Price"]);
            textBox6.Text = Convert.ToString(dr["Introduce"]);
            pictureBox1.Image = Image.FromFile(Convert.ToString(dr["MovieImage"]));
            textBox1.Text = Convert.ToString(dr["addtime"]);
            MovieID = Convert.ToInt32(dr["MovieID"]);
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                dr = dt.Rows[i];
                cbxTime.Items.Add(Convert.ToString(dr["upshow"]));
            }
            return 1;
        }

        private void FrmMovieOrder_Load(object sender, EventArgs e)
        {
            if (Getdata() == 1)
            {
                cbxTime.SelectedIndex = 0;
                siteEndel();
            }
            else return;
        }

        private void btSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private Point mPoint;//鼠标坐标

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);//鼠标按下时更新坐标
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
        }
        string site;
        #region 座位
        private void button1_Click(object sender, EventArgs e)
        {
            site = this.button1.Text;
        }   
        private void button2_Click(object sender, EventArgs e)
        {
            site = this.button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            site = this.button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            site = this.button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            site = this.button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            site = this.button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            site = this.button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            site = this.button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            site = this.button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            site = this.button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            site = this.button11.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            site = this.button12.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            site = this.button13.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            site = this.button14.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            site = this.button15.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            site = this.button16.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            site = this.button17.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            site = this.button18.Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            site = this.button19.Text;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            site = this.button20.Text;
        }
        #endregion
        #region 座位状态
        private void siteEndel()
        {
            DBHelper helper = new DBHelper();
            string sql = "select m.MovieName,o.addTime,o.addMoney,o.addNumber,o.Seat,o.MovieUptime from MovieInfo M join OrderInfo O on m.MovieID = o.MovieId where MovieName='{0}' and MovieUptime ='{1}'";
            sql = string.Format(sql, text1.Text,cbxTime.Text);
            DataSet ds = helper.GetDataSet(sql);
            DataTable dt = ds.Tables[0];
            int count = dt.Rows.Count;
            DataRow dr;
            siteEnt();
            for (int i = 0; i < count; i++)
            {
                dr = dt.Rows[i];
                if (Convert.ToString(dr["Seat"]) == button1.Text)
                {
                    button1.Enabled = false;
                    button1.BackColor = Color.Red;
                }
                else if(Convert.ToString(dr["Seat"]) == button2.Text)
                {
                    button2.Enabled = false;
                    button2.BackColor = Color.Red;
                }
                else if (Convert.ToString(dr["Seat"]) == button3.Text)
                {
                    button3.Enabled = false;
                    button3.BackColor = Color.Red;
                }
                else if (Convert.ToString(dr["Seat"]) == button4.Text)
                {
                    button4.Enabled = false;
                    button4.BackColor = Color.Red;
                }
                else if (Convert.ToString(dr["Seat"]) == button5.Text)
                {
                    button5.Enabled = false;
                    button5.BackColor = Color.Red;
                }
                else if (Convert.ToString(dr["Seat"]) == button6.Text)
                {
                    button6.Enabled = false;
                    button6.BackColor = Color.Red;
                }
                else if (Convert.ToString(dr["Seat"]) == button7.Text)
                {
                    button7.Enabled = false;
                    button7.BackColor = Color.Red;
                }
                else if (Convert.ToString(dr["Seat"]) == button8.Text)
                {
                    button8.Enabled = false;
                    button8.BackColor = Color.Red;
                }
                else if (Convert.ToString(dr["Seat"]) == button9.Text)
                {
                    button9.Enabled = false;
                    button9.BackColor = Color.Red;
                }
                else if (Convert.ToString(dr["Seat"]) == button10.Text)
                {
                    button10.Enabled = false;
                    button10.BackColor = Color.Red;
                }
                else if (Convert.ToString(dr["Seat"]) == button11.Text)
                {
                    button11.Enabled = false;
                    button11.BackColor = Color.Red;
                }
                else if (Convert.ToString(dr["Seat"]) == button12.Text)
                {
                    button12.Enabled = false;
                    button12.BackColor = Color.Red;
                }
                else if (Convert.ToString(dr["Seat"]) == button13.Text)
                {
                    button13.Enabled = false;
                    button13.BackColor = Color.Red;
                }
                else if (Convert.ToString(dr["Seat"]) == button14.Text)
                {
                    button14.Enabled = false;
                    button14.BackColor = Color.Red;
                }
                else if (Convert.ToString(dr["Seat"]) == button15.Text)
                {
                    button15.Enabled = false;
                    button15.BackColor = Color.Red;
                }
                else if (Convert.ToString(dr["Seat"]) == button16.Text)
                {
                    button16.Enabled = false;
                    button16.BackColor = Color.Red;
                }
                else if (Convert.ToString(dr["Seat"]) == button17.Text)
                {
                    button17.Enabled = false;
                    button17.BackColor = Color.Red;
                }
                else if (Convert.ToString(dr["Seat"]) == button18.Text)
                {
                    button18.Enabled = false;
                    button18.BackColor = Color.Red;
                }
                else if (Convert.ToString(dr["Seat"]) == button19.Text)
                {
                    button19.Enabled = false;
                    button19.BackColor = Color.Red;
                }
                else if (Convert.ToString(dr["Seat"]) == button20.Text)
                {
                    button20.Enabled = false;
                    button20.BackColor = Color.Red;
                }
            }
           
                
        }
        #endregion
        #region 默认座位状态
        private void siteEnt()
        {
            button1.Enabled = true;
            button1.BackColor = Color.FromArgb(24, 187, 255);
            button2.Enabled = true;
            button2.BackColor = Color.FromArgb(24, 187, 255);
            button3.Enabled = true;
            button3.BackColor = Color.FromArgb(24, 187, 255);
            button4.Enabled = true;
            button4.BackColor = Color.FromArgb(24, 187, 255);
            button5.Enabled = true;
            button5.BackColor = Color.FromArgb(24, 187, 255);
            button6.Enabled = true;
            button6.BackColor = Color.FromArgb(24, 187, 255);
            button7.Enabled = true;
            button7.BackColor = Color.FromArgb(24, 187, 255);
            button8.Enabled = true;
            button8.BackColor = Color.FromArgb(24, 187, 255);
            button9.Enabled = true;
            button9.BackColor = Color.FromArgb(24, 187, 255);
            button10.Enabled = true;
            button10.BackColor = Color.FromArgb(24, 187, 255);
            button11.Enabled = true;
            button11.BackColor = Color.FromArgb(24, 187, 255);
            button12.Enabled = true;
            button12.BackColor = Color.FromArgb(24, 187, 255);
            button13.Enabled = true;
            button13.BackColor = Color.FromArgb(24, 187, 255);
            button14.Enabled = true;
            button14.BackColor = Color.FromArgb(24, 187, 255);
            button15.Enabled = true;
            button15.BackColor = Color.FromArgb(24, 187, 255);
            button16.Enabled = true;
            button16.BackColor = Color.FromArgb(24, 187, 255);
            button17.Enabled = true;
            button17.BackColor = Color.FromArgb(24, 187, 255);
            button18.Enabled = true;
            button18.BackColor = Color.FromArgb(24, 187, 255);
            button19.Enabled = true;
            button19.BackColor = Color.FromArgb(24, 187, 255);
            button20.Enabled = true;
            button20.BackColor = Color.FromArgb(24, 187, 255);
        }
        #endregion
        private void btnBuy_Click(object sender, EventArgs e)
        {
            string sql = "insert into OrderInfo(MovieId,UserId,addTime,addMoney,addNumber,Seat,MovieUptime) values({0},{1},'{2}',{3},{4},'{5}','{6}')";
            sql = string.Format(sql,MovieID,UserID, DateTime.Now, textBox5.Text,1,site, cbxTime.Text);
            if (site == null)
            {
                MessageBox.Show("请选择座位","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            //if (DateTime.Compare(DateTime.Parse(textBox1.Text), DateTime.Parse(dateTimePicker1.Value.ToString())) > 0)
            //{
            //    MessageBox.Show("选择的观影时间有误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}              
            //else if ((DateTime.Parse(dateTimePicker1.Value.ToString()).Subtract(DateTime.Now)).Days > 7)
            //{
            //    MessageBox.Show("请选择7天内的观影时间", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            else
            {
                Update(sql);
                siteEndel();
                site = null;
            }        
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            siteEndel();
        }

        private void cbxTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            siteEndel();
        }
        private void Update(string sql)
        {
            DBHelper helper = new DBHelper();
            if (helper.Updata(sql) > 0)
                MessageBox.Show("成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("失败","提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}
