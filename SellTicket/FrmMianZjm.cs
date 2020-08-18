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
    public partial class FrmMianzjm11 : Form
    {
        public FrmMianzjm11()
        {
            InitializeComponent();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;//用双缓冲绘制窗口的所有子控件
                return cp;
            }
        }
        private void btSignOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        public string UserName;
        public int UserID;
        private void FrmMianZjm_Load(object sender, EventArgs e)
        {
            //设置主页按钮颜色
            this.btnHome.BackColor = Color.FromArgb(34, 187, 255);
            this.lkUserName.Text = UserName;
            this.labTime.Text = DateTime.Now.ToString("MM月dd日 hh:mm:ss");
            //加载主页
            FrmHome home = new FrmHome();
            home.TopLevel = false;
            home.Dock = DockStyle.Fill;//把子窗体设置为控件
            home.FormBorderStyle = FormBorderStyle.None;
            this.panHome.Controls.Clear();
            this.panHome.Controls.Add(home);
            home.UserID = UserID;
            home.Show();
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
        private void UpTImeGet_Tick(object sender, EventArgs e)
        {
            this.labTime.Text = DateTime.Now.ToString("MM月dd日 hh:mm:ss");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (this.btnHome.BackColor == Color.Transparent)//判断按钮颜色
            {
                this.btnHome.BackColor = Color.FromArgb(24, 187, 255);
                this.BtnClassification.BackColor = Color.Transparent;
                this.btnRanking.BackColor = Color.Transparent;
                this.btnOrder.BackColor = Color.Transparent;
            }
            FrmHome home = new FrmHome();
            home.TopLevel = false;
            home.Dock = DockStyle.Fill;//把子窗体设置为控件
            home.FormBorderStyle = FormBorderStyle.None;
            this.panHome.Controls.Clear();
            this.panHome.Controls.Add(home);
            home.UserID = UserID;
            home.Show();
        }

        private void BtnClassification_Click(object sender, EventArgs e)
        {
            if (this.BtnClassification.BackColor == Color.Transparent)//判断按钮颜色
            {
                this.btnHome.BackColor = Color.Transparent;
                this.BtnClassification.BackColor = Color.FromArgb(24, 187, 255);
                this.btnRanking.BackColor = Color.Transparent;
                this.btnOrder.BackColor = Color.Transparent;
            }
            FrmMovieClass mcl = new FrmMovieClass();
            mcl.TopLevel = false;
            mcl.Dock = DockStyle.Fill;
            mcl.FormBorderStyle = FormBorderStyle.None;
            this.panHome.Controls.Clear();
            this.panHome.Controls.Add(mcl);
            mcl.UserID = UserID;
            mcl.Show();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin lg = new FrmLogin();
            lg.Show();
        }

        private void btnRanking_Click(object sender, EventArgs e)
        {
            if(this.btnRanking.BackColor == Color.Transparent)
            {
                this.btnHome.BackColor = Color.Transparent;
                this.BtnClassification.BackColor = Color.Transparent;
                this.btnRanking.BackColor = Color.FromArgb(24, 187, 255);
                this.btnOrder.BackColor = Color.Transparent;
            }
            FrmList list = new FrmList();
            list.TopLevel = false;
            list.Dock = DockStyle.Fill;
            list.FormBorderStyle = FormBorderStyle.None;
            this.panHome.Controls.Clear();
            this.panHome.Controls.Add(list);
            list.UserID = UserID;
            list.Show();
        }
        private void btnOrder_Click_1(object sender, EventArgs e)
        {
            if (this.btnOrder.BackColor == Color.Transparent)
            {
                this.btnHome.BackColor = Color.Transparent;
                this.BtnClassification.BackColor = Color.Transparent;
                this.btnRanking.BackColor = Color.Transparent;
                this.btnOrder.BackColor = Color.FromArgb(24, 187, 255);
            }
            FrmUserOrder od = new FrmUserOrder();
            od.TopLevel = false;
            od.Dock = DockStyle.Fill;
            od.FormBorderStyle = FormBorderStyle.None;
            this.panHome.Controls.Clear();
            this.panHome.Controls.Add(od);
            od.UserID = UserID;
            od.Show();
        }

        private void lkUserName_Click(object sender, EventArgs e)
        {
            if (this.btnOrder.BackColor == Color.Transparent)
            {
                this.btnHome.BackColor = Color.Transparent;
                this.BtnClassification.BackColor = Color.Transparent;
                this.btnRanking.BackColor = Color.Transparent;
                this.btnOrder.BackColor = Color.FromArgb(24, 187, 255);
            }
            FrmUserOrder od = new FrmUserOrder();
            od.TopLevel = false;
            od.Dock = DockStyle.Fill;
            od.FormBorderStyle = FormBorderStyle.None;
            this.panHome.Controls.Clear();
            this.panHome.Controls.Add(od);
            od.UserID = UserID;
            od.Show();
        }
    }
}
