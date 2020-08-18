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
    public partial class FrmAdminZjm : Form
    {
        public FrmAdminZjm()
        {
            InitializeComponent();
        }

        private void btSignOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private Point mPoint;//鼠标坐标

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);//鼠标按下时更新坐标
        }
        private void btnViode_Click(object sender, EventArgs e)
        {
            FrmMovieManagement mmg = new FrmMovieManagement();
            mmg.Show();
            this.Close();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            FrmUserMMG mmg = new FrmUserMMG();
            mmg.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmOrder od = new frmOrder();
            od.Show();
            this.Close();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            frmshowMovieMMG smv = new frmshowMovieMMG();
            smv.Show();
            this.Close();
        }
    }
}
