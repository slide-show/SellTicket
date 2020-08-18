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
    public partial class FrmUserMMG : Form
    {
        public FrmUserMMG()
        {
            InitializeComponent();
        }
        private void btSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmAdminZjm zjm = new FrmAdminZjm();
            zjm.Show();          
        }

        private void FrmUserMMG_Load(object sender, EventArgs e)
        {
            GetData();
            guding();
            this.btnCancel.Enabled = false;
            
        }
        DataSet ds;
        private void GetData()
        {
            DBHelper helper = new DBHelper();
            string sql = "select ID,zhName,UserName,Birthday,Bank,Phone,[Admin] from Users";
            ds = helper.GetDataSet(sql);
            DataTable dt = ds.Tables[0];
            Upchose(dt);
            this.dataGridView1.DataSource = dt;
        }
        private void Upchose(DataTable dt)//更新用户名单选项
        {
            this.cbxChoose.Items.Clear();
            int count = dt.Rows.Count;
            for(int i = 0; i < count; i++)
            {
                DataRow dr = dt.Rows[i];
                this.cbxChoose.Items.Add(Convert.ToString(dr["zhName"]));          
            }     
        }
        private void guding()//更改文本状态
        {          
            this.textName.Enabled = false;
            this.textBank.Enabled = false;
            this.textBirthday.Enabled = false;
            this.textPhone.Enabled = false;
            this.textUserName.Enabled = false;
            this.cbxAdmin.Enabled = false;
        }

        private void cbxChoose_SelectedIndexChanged(object sender, EventArgs e)//选择后更新显示信息
        {
            int sele = this.cbxChoose.SelectedIndex;
            DataRow dr = ds.Tables[0].Rows[sele];
            this.textName.Text = Convert.ToString(dr["zhName"]);
            this.textUserName.Text = Convert.ToString(dr["UserName"]);
            this.textBirthday.Text = Convert.ToString(Convert.ToDateTime(dr["Birthday"]).ToString("yyyy年MM月dd日"));
            this.textBank.Text = Convert.ToString(dr["Bank"]);
            this.textPhone.Text = Convert.ToString(dr["Phone"]);
            if (Convert.ToInt32(dr["Admin"]) == 1)
            {
                this.cbxAdmin.Text = "管理员";
            }
            else
            {
                this.cbxAdmin.Text = "普通用户";
            }
            guding();
            this.dataGridView1.BindingContext[this.dataGridView1.DataSource].Position = sele;


        }
        private void btnAdd_Click(object sender, EventArgs e)//进入注册界面
        {
            FrmMian reg = new FrmMian();
            reg.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)//更新数据
        {
            GetData();
            guding();
        }

        private void btnEdit_Click(object sender, EventArgs e)//修改可用状态进入编辑状态
        {
            this.textName.Enabled = true;
            this.textBank.Enabled = true;
            this.textBirthday.Enabled = true;
            this.textPhone.Enabled = true;
            this.textUserName.Enabled = true;
            this.cbxAdmin.Enabled = true;
            this.btnCancel.Enabled = true;
        }
        private void btnCancel_Click(object sender, EventArgs e)//取消编辑，恢复之前内容
        {
            int sele = this.cbxChoose.SelectedIndex;
            DataRow dr = ds.Tables[0].Rows[sele];
            this.textName.Text = Convert.ToString(dr["zhName"]);
            this.textUserName.Text = Convert.ToString(dr["UserName"]);
            this.textBirthday.Text = Convert.ToString(Convert.ToDateTime(dr["Birthday"]).ToString("yyyy年MM月dd日"));
            this.textBank.Text = Convert.ToString(dr["Bank"]);
            this.textPhone.Text = Convert.ToString(dr["Phone"]);
            if (Convert.ToInt32(dr["Admin"]) == 1)
            {
                this.cbxAdmin.Text = "管理员";
            }
            else
            {
                this.cbxAdmin.Text = "普通用户";
            }
            guding();
            this.btnCancel.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)//更新数据到数据库
        {
            DBHelper helper1 = new DBHelper();
            string sql = "update Users set zhName='{0}' ,UserName='{1}',Birthday='{2}',Bank='{3}',Phone='{4}',Admin='{5}' where ID={6}";
            int admin;
            if (this.cbxAdmin.Text.Equals("管理员"))
                admin = 1;
            else
                admin = 0;
            DataRow idb = ds.Tables[0].Rows[this.cbxChoose.SelectedIndex];
            sql = string.Format(sql, this.textName.Text, this.textUserName.Text,DateTime.Parse(this.textBirthday.Text), this.textBank.Text, this.textPhone.Text,admin,idb["ID"]);
            int resle = helper1.Updata(sql);
            if (resle > 0)
                MessageBox.Show("保存成功", "保存", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("保存失败", "保存", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.btnCancel.Enabled = false;
            guding();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DBHelper helper = new DBHelper();
            DataRow id = ds.Tables[0].Rows[this.cbxChoose.SelectedIndex];
            string sql = string.Format("delete Users where ID='{0}'",id["ID"]);
            MessageBox.Show("确认删除？", "删除", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (helper.Updata(sql) > 0)
                MessageBox.Show("删除成功", "删除", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("删除失败", "删除", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dataGridView1.CurrentRow.Index >= 0 && this.dataGridView1.CurrentRow.Index < ds.Tables[0].Rows.Count)
                {
                    DataRow dr = ds.Tables[0].Rows[this.dataGridView1.CurrentRow.Index];
                    this.textName.Text = Convert.ToString(dr["zhName"]);
                    this.textUserName.Text = Convert.ToString(dr["UserName"]);
                    this.textBirthday.Text = Convert.ToString(Convert.ToDateTime(dr["Birthday"]).ToString("yyyy年MM月dd日"));
                    this.textBank.Text = Convert.ToString(dr["Bank"]);
                    this.textPhone.Text = Convert.ToString(dr["Phone"]);
                    if (Convert.ToInt32(dr["Admin"]) == 1)
                    {
                        this.cbxAdmin.Text = "管理员";
                    }
                    else
                    {
                        this.cbxAdmin.Text = "普通用户";
                    }
                    this.cbxChoose.SelectedIndex = this.dataGridView1.CurrentRow.Index;
                }
                else
                {
                    return;
                }
            }
            catch (Exception)
            {

                return;
            }
        }
    }
}
