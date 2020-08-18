using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace SellTicket
{
    public partial class FrmAdmin1 : Form
    {
        public FrmAdmin1()
        {
            InitializeComponent();
        }

        private void btSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin lg = new FrmLogin();
            lg.Show();
        }
        public bool Login(string UserName,string Pwd)
        {
            DBHelper helper = new DBHelper();
            string sql = string.Format("select * from Users where UserName='{0}' and Pwd='{1}' and [Admin] = 1", UserName, Pwd);
            SqlDataReader dt = helper.GetData(sql);
            if (dt.Read())
            {
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

        private void butLogin_Click(object sender, EventArgs e)
        {
            if (Login(this.textUserName.Text, this.textPwd.Text))
            {
                FrmAdminZjm adminzjm = new FrmAdminZjm();
                this.Close();
                adminzjm.Show();
            }
            else
            {
                MessageBox.Show("账号没有权限或密码错误", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
