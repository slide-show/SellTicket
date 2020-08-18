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
    public partial class FrmMovieManagement : Form
    {
        public FrmMovieManagement()
        {
            InitializeComponent();
        }

        private void btSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmAdminZjm zjm = new FrmAdminZjm();
            zjm.Show();
        }

        private void FrmMovieManagement_Load(object sender, EventArgs e)
        {
            Getdata();
            dataGridView1.CurrentCell = null;
        }
        private void Getdata()
        {
            DBHelper helper = new DBHelper();
            string sql = "select * from MovieInfo";
            DataSet ds = helper.GetDataSet(sql);
            dataGridView1.DataSource = ds.Tables[0];
            lbNumbers.Text = ds.Tables[0].Rows.Count.ToString();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textName.Text == null)
            {
                MessageBox.Show("请输入信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string sql = "insert into MovieInfo(MovieName,Director,ToStar,MovieType,MovieImage,Introduce,Price) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')";
                sql = string.Format(sql, textName.Text, textDirector.Text, textToStar.Text, textMovieType.Text, ImageDZ, textIntroduce.Text, textPrice.Text);
                Update(sql);
                textDirector.Text = null;
                textIntroduce.Text = null;
                textMovieType.Text = null;
                textName.Text = null;
                textPrice.Text = null;
                textToStar.Text = null;
                pbMovieImage.Image = null;
                Edit();
            }         
        }
        private void Update(string sql)
        {
            DBHelper helper = new DBHelper();
            if (helper.Updata(sql) > 0)
            {
                MessageBox.Show("更新成功","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Getdata();
            }              
            else
                MessageBox.Show("更新失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        string ImageDZ = "";
        private void pbMovieImage_Click(object sender, EventArgs e) //提交电影图片
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "D:\\电影\\";//注意这里写路径时要用c:\\而不是c:\
            openFileDialog.Filter = "文本文件|*.*|C#文件|*.cs|所有文件|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImageDZ = openFileDialog.FileName;
                pbMovieImage.Image = Image.FromFile(ImageDZ);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //修改文本框内容和图片
        {
            int indexz = dataGridView1.CurrentRow.Index;
            if ( indexz> -1)
            {
                textName.Text = dataGridView1.Rows[indexz].Cells[1].Value.ToString();
                textDirector.Text = dataGridView1.Rows[indexz].Cells[2].Value.ToString();
                textToStar.Text = dataGridView1.Rows[indexz].Cells[3].Value.ToString();
                textMovieType.Text = dataGridView1.Rows[indexz].Cells[4].Value.ToString();
                ImageDZ = dataGridView1.Rows[indexz].Cells[5].Value.ToString();
                pbMovieImage.Image = Image.FromFile(ImageDZ);
                textIntroduce.Text = dataGridView1.Rows[indexz].Cells[6].Value.ToString();
                textPrice.Text = dataGridView1.Rows[indexz].Cells[7].Value.ToString();
                NoEdit();
            }
        }
        private void Edit()//进入编辑状态
        {
            textDirector.Enabled = true;
            textIntroduce.Enabled = true;
            textMovieType.Enabled = true;
            textName.Enabled = true;
            textPrice.Enabled = true;
            textToStar.Enabled = true;
        }
        private void NoEdit()
        {
            textDirector.Enabled = false;
            textIntroduce.Enabled = false;
            textMovieType.Enabled = false;
            textName.Enabled = false;
            textPrice.Enabled = false;
            textToStar.Enabled = false;
        }
        private void btnEdit_Click(object sender, EventArgs e) 
        {
            Edit();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            string sql = "update MovieInfo set MovieName='{0}',Director='{1}',ToStar='{2}',MovieType='{3}',MovieImage='{4}',Introduce='{5}',Price='{6}' where MovieID={7}";
            sql = string.Format(sql,textName.Text,textDirector.Text,textToStar.Text,textMovieType.Text,ImageDZ,textIntroduce.Text,textPrice.Text,ID);
            Update(sql);
        }

        private void btnEmpty_Click(object sender, EventArgs e)
        {
            textDirector.Text = null;
            textIntroduce.Text = null;
            textMovieType.Text = null;
            textName.Text = null;
            textPrice.Text = null;
            textToStar.Text = null;
            pbMovieImage.Image = null;
            Edit();
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            if ((int)MessageBox.Show("确认删除", "友情提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != 1)
            {
                return;
            }
            else 
            {
                int ID = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
                string sql = "delete MovieInfo where MovieID={0}";
                sql = string.Format(sql, ID);
                Update(sql);
            }
        }
        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
