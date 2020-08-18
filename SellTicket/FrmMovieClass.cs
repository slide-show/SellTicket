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
    public partial class FrmMovieClass : Form
    {
        public FrmMovieClass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.button1.BackColor == Color.FromArgb(40, 41, 43))
            {
                this.button1.BackColor = Color.FromArgb(24, 187, 255);
                this.button2.BackColor = Color.FromArgb(40, 41, 43);
                this.button3.BackColor = Color.FromArgb(40, 41, 43);
                this.button4.BackColor = Color.FromArgb(40, 41, 43);
                this.button5.BackColor = Color.FromArgb(40, 41, 43);
                this.button6.BackColor = Color.FromArgb(40, 41, 43);
                this.button7.BackColor = Color.FromArgb(40, 41, 43);
                if (this.button8.BackColor == Color.FromArgb(24, 187, 255))
                    this.button8.BackColor = Color.FromArgb(40, 41, 43);
                XZ();
            }
            else
            {
                this.button1.BackColor = Color.FromArgb(40, 41, 43);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(this.button8.BackColor == Color.FromArgb(40, 41, 43))
            {
                this.button8.BackColor = Color.FromArgb(24, 187, 255);
                this.button1.BackColor = Color.FromArgb(40, 41, 43);
                this.button2.BackColor = Color.FromArgb(40, 41, 43);
                this.button3.BackColor = Color.FromArgb(40, 41, 43);
                this.button4.BackColor = Color.FromArgb(40, 41, 43);
                this.button5.BackColor = Color.FromArgb(40, 41, 43);
                this.button6.BackColor = Color.FromArgb(40, 41, 43);
                this.button7.BackColor = Color.FromArgb(40, 41, 43);
                XZ();
            }
            else
                button8.BackColor = Color.FromArgb(40, 41, 43);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.button2.BackColor == Color.FromArgb(40, 41, 43))
            {
                this.button2.BackColor = Color.FromArgb(24, 187, 255);
                this.button1.BackColor = Color.FromArgb(40, 41, 43);
                this.button3.BackColor = Color.FromArgb(40, 41, 43);
                this.button4.BackColor = Color.FromArgb(40, 41, 43);
                this.button5.BackColor = Color.FromArgb(40, 41, 43);
                this.button6.BackColor = Color.FromArgb(40, 41, 43);
                this.button7.BackColor = Color.FromArgb(40, 41, 43);
                if (this.button8.BackColor == Color.FromArgb(24, 187, 255))
                    this.button8.BackColor = Color.FromArgb(40, 41, 43);
                XZ();
            }
            else
            {
                this.button2.BackColor = Color.FromArgb(40, 41, 43);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.button3.BackColor == Color.FromArgb(40, 41, 43))
            {
                this.button3.BackColor = Color.FromArgb(24, 187, 255);
                this.button1.BackColor = Color.FromArgb(40, 41, 43);
                this.button2.BackColor = Color.FromArgb(40, 41, 43);
                this.button4.BackColor = Color.FromArgb(40, 41, 43);
                this.button5.BackColor = Color.FromArgb(40, 41, 43);
                this.button6.BackColor = Color.FromArgb(40, 41, 43);
                this.button7.BackColor = Color.FromArgb(40, 41, 43);
                if (this.button8.BackColor == Color.FromArgb(24, 187, 255))
                    this.button8.BackColor = Color.FromArgb(40, 41, 43);
                XZ();
            }
            else
            {
                this.button3.BackColor = Color.FromArgb(40, 41, 43);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.button4.BackColor == Color.FromArgb(40, 41, 43))
            {
                this.button4.BackColor = Color.FromArgb(24, 187, 255);
                this.button1.BackColor = Color.FromArgb(40, 41, 43);
                this.button2.BackColor = Color.FromArgb(40, 41, 43);
                this.button3.BackColor = Color.FromArgb(40, 41, 43);
                this.button5.BackColor = Color.FromArgb(40, 41, 43);
                this.button6.BackColor = Color.FromArgb(40, 41, 43);
                this.button7.BackColor = Color.FromArgb(40, 41, 43);
                if (this.button8.BackColor == Color.FromArgb(24, 187, 255))
                    this.button8.BackColor = Color.FromArgb(40, 41, 43);
                XZ();
            }
            else
            {
                this.button4.BackColor = Color.FromArgb(40, 41, 43);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.button5.BackColor == Color.FromArgb(40, 41, 43))
            {
                this.button5.BackColor = Color.FromArgb(24, 187, 255);
                this.button1.BackColor = Color.FromArgb(40, 41, 43);
                this.button2.BackColor = Color.FromArgb(40, 41, 43);
                this.button3.BackColor = Color.FromArgb(40, 41, 43);
                this.button4.BackColor = Color.FromArgb(40, 41, 43);
                this.button6.BackColor = Color.FromArgb(40, 41, 43);
                this.button7.BackColor = Color.FromArgb(40, 41, 43);
                if (this.button8.BackColor == Color.FromArgb(24, 187, 255))
                    this.button8.BackColor = Color.FromArgb(40, 41, 43);
                XZ();
            }
            else
            {
                this.button5.BackColor = Color.FromArgb(40, 41, 43);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.button6.BackColor == Color.FromArgb(40, 41, 43))
            {
                this.button1.BackColor = Color.FromArgb(40, 41, 43);
                this.button2.BackColor = Color.FromArgb(40, 41, 43);
                this.button3.BackColor = Color.FromArgb(40, 41, 43);
                this.button4.BackColor = Color.FromArgb(40, 41, 43);
                this.button5.BackColor = Color.FromArgb(40, 41, 43);
                this.button7.BackColor = Color.FromArgb(40, 41, 43);
                this.button6.BackColor = Color.FromArgb(24, 187, 255);
                if (this.button8.BackColor == Color.FromArgb(24, 187, 255))
                    this.button8.BackColor = Color.FromArgb(40, 41, 43);
                XZ();
            }
            else
            {
                this.button6.BackColor = Color.FromArgb(40, 41, 43);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (this.button7.BackColor == Color.FromArgb(40, 41, 43))
            {
                this.button7.BackColor = Color.FromArgb(24, 187, 255);
                this.button1.BackColor = Color.FromArgb(40, 41, 43);
                this.button2.BackColor = Color.FromArgb(40, 41, 43);
                this.button3.BackColor = Color.FromArgb(40, 41, 43);
                this.button4.BackColor = Color.FromArgb(40, 41, 43);
                this.button5.BackColor = Color.FromArgb(40, 41, 43);
                this.button6.BackColor = Color.FromArgb(40, 41, 43);
                if (this.button8.BackColor == Color.FromArgb(24, 187, 255))
                    this.button8.BackColor = Color.FromArgb(40, 41, 43);
                XZ();
            }
            else
            {
                this.button7.BackColor = Color.FromArgb(40, 41, 43);
            }
        }

        private void FrmMovieClass_Load(object sender, EventArgs e)
        {
            
        }

        private void btnss_Click(object sender, EventArgs e)
        {
            string sql = "select * from MovieInfo where MovieName Like'%{0}%'";
            if(textBox1.Text == null)
            {
                MessageBox.Show("请输入需要搜索的内容","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            sql = string.Format(sql, textBox1.Text);
            Getdate(sql);
        }
        private void Getdate(string sql)
        {
            DBHelper dB = new DBHelper();
            DataSet ds = dB.GetDataSet(sql);
            if (ds == null)
            {
                string a = string.Format("查询不到含{0}的电影", textBox1.Text);
                MessageBox.Show(a, "加载数据", MessageBoxButtons.OK);
                return;
            }
            DataTable dt = ds.Tables[0];
            this.listView1.Items.Clear();
            int count = dt.Rows.Count;
            if (count == 0)
            {
                string a = string.Format("查询不到含{0}的电影", textBox1.Text);
                MessageBox.Show(a, "加载数据", MessageBoxButtons.OK);
                return;
            }
            string[] img = new string[count];
            for (int i = 0; i < count; i++)
            {
                DataRow dr = dt.Rows[i];
                string Name = Convert.ToString(dr[1]);
                string Information = Convert.ToString(dr[2]);
                string fare = Convert.ToString(dr[3]);
                string VoideNumber = Convert.ToString(dr[4]);
                img[i] = Convert.ToString(dr[5]);
                string VoideActor = Convert.ToString(dr[6]);
                string VoideAddTime = Convert.ToString(dr[7]);
                ListViewItem item = new ListViewItem(Name, i);

                item.SubItems.Add(Information);
                item.SubItems.Add(fare);
                item.SubItems.Add(VoideNumber);
                item.SubItems.Add(VoideActor);
                item.SubItems.Add(VoideAddTime);
                this.listView1.Items.Add(item);
            }
            this.imageList1.Images.Clear();
            for (int i = 0; i < img.Length; i++)
            {
                Image Img = Image.FromFile(img[i]);
                this.imageList1.Images.Add(Img);
            }
        }
        private void XZ()
        {
            string sql;
            if(button8.BackColor == Color.FromArgb(24, 187, 255))
            {
                sql = "select * from MovieInfo";
                Getdate(sql);
                return;
            }
            if (button1.BackColor == Color.FromArgb(24, 187, 255))
            {
                sql = "select * from MovieInfo where MovieType Like'%{0}%'";
                sql = string.Format(sql, button1.Text);
                Getdate(sql);
                return; 
            }
            if (button2.BackColor == Color.FromArgb(24, 187, 255))
            {
                sql = "select * from MovieInfo where MovieType Like'%{0}%'";
                sql = string.Format(sql, button2.Text);
                Getdate(sql);
                return;
            }
            if (button3.BackColor == Color.FromArgb(24, 187, 255))
            {
                sql = "select * from MovieInfo where MovieType Like'%{0}%'";
                sql = string.Format(sql, button3.Text);
                Getdate(sql);
                return;
            }
            if (button4.BackColor == Color.FromArgb(24, 187, 255))
            {
                sql = "select * from MovieInfo where MovieType Like'%{0}%'";
                sql = string.Format(sql, button4.Text);
                Getdate(sql);
                return;
            }
            if (button5.BackColor == Color.FromArgb(24, 187, 255))
            {
                sql = "select * from MovieInfo where MovieType Like'%{0}%'";
                sql = string.Format(sql, button5.Text);
                Getdate(sql);
                return;
            }
            if (button6.BackColor == Color.FromArgb(24, 187, 255))
            {
                sql = "select * from MovieInfo where MovieType Like'%{0}%'";
                sql = string.Format(sql, button6.Text);
                Getdate(sql);
                return;
            }
            if (button7.BackColor == Color.FromArgb(24, 187, 255))
            {
                sql = "select * from MovieInfo where MovieType Like'%{0}%'";
                sql = string.Format(sql, button7.Text);
                Getdate(sql);
                return;
            }
        }
        public int UserID;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            FrmMovieOrder od = new FrmMovieOrder();
            od.UserID = UserID;
            od.MovieName = this.listView1.SelectedItems[0].Text;
            od.Show();
        }
    }
}
