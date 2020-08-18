using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SellTicket
{
    public partial class frmUserPwd : Form
    {
        public frmUserPwd()
        {
            InitializeComponent();
        }
        public int ID;
        private void button1_Click(object sender, EventArgs e)
        {
            DBHelper helper = new DBHelper();
            string sql = string.Format("select pwd from Users where ID={0}",ID);
            SqlDataReader sdr = helper.GetData(sql);
            sdr.Read();
            if (Convert.ToString(sdr[0]).Equals(textpwd.Text))
            {
                if(textNewpwd.Text==textnewpwd2.Text)
                {
                    sdr.Close();
                    sql = string.Format("update Users set Pwd='{0}'", textNewpwd.Text);
                    if (helper.Updata(sql) > 0)
                        MessageBox.Show("成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("旧密码输入错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
