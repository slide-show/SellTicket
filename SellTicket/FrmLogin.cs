using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SellTicket
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.LogImg.Image = Image.FromStream(WebRequest.Create("http://ssr0.cn:8000/ACG").GetResponse().GetResponseStream());          
        }
        public string Name;
        public int UserID;
        private void butLogin_Click(object sender, EventArgs e)
        {
            if (Login(this.textUserName.Text, this.textPwd.Text))
            {
                FrmMianzjm11 zjm = new FrmMianzjm11();
                zjm.UserName = Name;
                zjm.UserID = UserID;
                zjm.Show();          
                this.Hide();
            }
            else
            {
                MessageBox.Show("账号或密码错误！", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private bool Login(string UserName,string Pwd)
        {
            DBHelper helper = new DBHelper();
            string sql = string.Format("select * from Users where UserName='{0}' and Pwd='{1}'", UserName, Pwd);
            SqlDataReader dt = helper.GetData(sql);
            if (dt.Read())
            {
                UserID = Convert.ToInt32(dt[0]);
                Name = Convert.ToString(dt[1]);
                dt.Close();
                helper.Close();
                return true;
            }
            else
            {
                dt.Close();
                helper.Close();
                return false;
            }
        }

        private void btSignOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void lkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form test = Application.OpenForms["frmrg"];//查找是否打开过该子窗体
            if ((test == null) || (test.IsDisposed))//未找到则新创建
            {
                FrmMian frmrg = new FrmMian();
                frmrg.Show();
            }
            else//否则聚焦该窗口
            {
                test.Activate();
            }
               
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lkAdmin1_Click(object sender, EventArgs e)
        {
            Form test = Application.OpenForms["Admin1"];//查找是否打开过该子窗体
            if ((test == null) || (test.IsDisposed))//未找到则新创建
            {
                FrmAdmin1 Admin1 = new FrmAdmin1();
                Admin1.Show();
                this.Hide();
            }
            else//否则聚焦该窗口
            {
                test.Activate();
            }
        }
    }
}
