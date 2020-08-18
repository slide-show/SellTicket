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
    public partial class FrmMian : Form
    {
        public FrmMian()
        {
            InitializeComponent();
        }

        private void btSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.textPhone.Text = "";
            this.textUserName.Text = "";
            this.textPwd.Text = "";
            this.textPwded.Text = "";
            this.textBank.Text = "";
            this.textName.Text = "";
        }
        private Point mPoint;//鼠标坐标
        private void FrmMian_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);//鼠标按下时更新坐标
        }

        private void FrmMian_MouseMove(object sender, MouseEventArgs e)//鼠标按下移动是更新坐标给窗体
        {
            if (e.Button == MouseButtons.Left)
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            if (Updata() >= 1)
            {
                MessageBox.Show("注册成功", "注册", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("注册失败", "注册", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private int Updata()
        {
            string sql = "insert into Users(zhName,UserName,Pwd,Birthday,Bank,Phone) values('{0}','{1}','{2}','{3}','{4}','{5}')";
            if (textPwd.Text == textPwded.Text)
            {
                sql = string.Format(sql, textName.Text, textUserName.Text, textPwd.Text,dateTimePicker1.Value, textBank.Text, textPhone.Text);
            }
            else
            {
                MessageBox.Show("两次输入的密码不一样！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DBHelper helper = new DBHelper();
            return helper.Updata(sql);
        }
    }
}
