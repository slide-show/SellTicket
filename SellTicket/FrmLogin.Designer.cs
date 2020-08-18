namespace SellTicket
{
    partial class FrmLogin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.labUser = new System.Windows.Forms.Label();
            this.labPwd = new System.Windows.Forms.Label();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.textPwd = new System.Windows.Forms.TextBox();
            this.butLogin = new System.Windows.Forms.Button();
            this.LogImg = new System.Windows.Forms.PictureBox();
            this.Logsr = new System.Windows.Forms.Panel();
            this.btnMini = new System.Windows.Forms.Button();
            this.btSignOut = new System.Windows.Forms.Button();
            this.lkRegister = new System.Windows.Forms.LinkLabel();
            this.lkAdmin1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.LogImg)).BeginInit();
            this.Logsr.SuspendLayout();
            this.SuspendLayout();
            // 
            // labUser
            // 
            this.labUser.AutoSize = true;
            this.labUser.BackColor = System.Drawing.Color.Transparent;
            this.labUser.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labUser.Location = new System.Drawing.Point(21, 65);
            this.labUser.Name = "labUser";
            this.labUser.Size = new System.Drawing.Size(42, 21);
            this.labUser.TabIndex = 0;
            this.labUser.Text = "账号";
            // 
            // labPwd
            // 
            this.labPwd.AutoSize = true;
            this.labPwd.BackColor = System.Drawing.Color.Transparent;
            this.labPwd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labPwd.Location = new System.Drawing.Point(21, 112);
            this.labPwd.Name = "labPwd";
            this.labPwd.Size = new System.Drawing.Size(42, 21);
            this.labPwd.TabIndex = 0;
            this.labPwd.Text = "密码";
            // 
            // textUserName
            // 
            this.textUserName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textUserName.Location = new System.Drawing.Point(69, 62);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(174, 29);
            this.textUserName.TabIndex = 1;
            // 
            // textPwd
            // 
            this.textPwd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textPwd.Location = new System.Drawing.Point(69, 110);
            this.textPwd.Name = "textPwd";
            this.textPwd.PasswordChar = '●';
            this.textPwd.Size = new System.Drawing.Size(174, 29);
            this.textPwd.TabIndex = 2;
            // 
            // butLogin
            // 
            this.butLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.butLogin.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butLogin.Location = new System.Drawing.Point(45, 197);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(192, 41);
            this.butLogin.TabIndex = 3;
            this.butLogin.Text = "登录";
            this.butLogin.UseVisualStyleBackColor = false;
            this.butLogin.Click += new System.EventHandler(this.butLogin_Click);
            // 
            // LogImg
            // 
            this.LogImg.Dock = System.Windows.Forms.DockStyle.Left;
            this.LogImg.Location = new System.Drawing.Point(0, 0);
            this.LogImg.Name = "LogImg";
            this.LogImg.Size = new System.Drawing.Size(941, 565);
            this.LogImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogImg.TabIndex = 4;
            this.LogImg.TabStop = false;
            // 
            // Logsr
            // 
            this.Logsr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logsr.BackgroundImage")));
            this.Logsr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Logsr.Controls.Add(this.btnMini);
            this.Logsr.Controls.Add(this.btSignOut);
            this.Logsr.Controls.Add(this.lkAdmin1);
            this.Logsr.Controls.Add(this.lkRegister);
            this.Logsr.Controls.Add(this.textUserName);
            this.Logsr.Controls.Add(this.labUser);
            this.Logsr.Controls.Add(this.butLogin);
            this.Logsr.Controls.Add(this.labPwd);
            this.Logsr.Controls.Add(this.textPwd);
            this.Logsr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Logsr.Location = new System.Drawing.Point(941, 0);
            this.Logsr.Name = "Logsr";
            this.Logsr.Size = new System.Drawing.Size(286, 565);
            this.Logsr.TabIndex = 5;
            // 
            // btnMini
            // 
            this.btnMini.BackColor = System.Drawing.Color.Transparent;
            this.btnMini.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMini.BackgroundImage")));
            this.btnMini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMini.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnMini.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMini.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMini.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnMini.Location = new System.Drawing.Point(218, 4);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(25, 25);
            this.btnMini.TabIndex = 8;
            this.btnMini.UseVisualStyleBackColor = false;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // btSignOut
            // 
            this.btSignOut.BackColor = System.Drawing.Color.Transparent;
            this.btSignOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btSignOut.BackgroundImage")));
            this.btSignOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSignOut.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btSignOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btSignOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSignOut.ForeColor = System.Drawing.Color.Transparent;
            this.btSignOut.Location = new System.Drawing.Point(256, 4);
            this.btSignOut.Margin = new System.Windows.Forms.Padding(0);
            this.btSignOut.Name = "btSignOut";
            this.btSignOut.Size = new System.Drawing.Size(25, 25);
            this.btSignOut.TabIndex = 7;
            this.btSignOut.UseVisualStyleBackColor = false;
            this.btSignOut.Click += new System.EventHandler(this.btSignOut_Click);
            // 
            // lkRegister
            // 
            this.lkRegister.AutoSize = true;
            this.lkRegister.BackColor = System.Drawing.Color.Transparent;
            this.lkRegister.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lkRegister.LinkColor = System.Drawing.Color.Black;
            this.lkRegister.Location = new System.Drawing.Point(168, 160);
            this.lkRegister.Name = "lkRegister";
            this.lkRegister.Size = new System.Drawing.Size(79, 20);
            this.lkRegister.TabIndex = 4;
            this.lkRegister.TabStop = true;
            this.lkRegister.Text = "新用户注册";
            this.lkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkRegister_LinkClicked);
            // 
            // lkAdmin1
            // 
            this.lkAdmin1.AutoSize = true;
            this.lkAdmin1.BackColor = System.Drawing.Color.Transparent;
            this.lkAdmin1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lkAdmin1.LinkColor = System.Drawing.Color.Black;
            this.lkAdmin1.Location = new System.Drawing.Point(24, 160);
            this.lkAdmin1.Name = "lkAdmin1";
            this.lkAdmin1.Size = new System.Drawing.Size(79, 20);
            this.lkAdmin1.TabIndex = 4;
            this.lkAdmin1.TabStop = true;
            this.lkAdmin1.Text = "管理员登录";
            this.lkAdmin1.Click += new System.EventHandler(this.lkAdmin1_Click);
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.butLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1227, 565);
            this.ControlBox = false;
            this.Controls.Add(this.Logsr);
            this.Controls.Add(this.LogImg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogImg)).EndInit();
            this.Logsr.ResumeLayout(false);
            this.Logsr.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labUser;
        private System.Windows.Forms.Label labPwd;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.TextBox textPwd;
        private System.Windows.Forms.Button butLogin;
        private System.Windows.Forms.PictureBox LogImg;
        private System.Windows.Forms.Panel Logsr;
        private System.Windows.Forms.LinkLabel lkRegister;
        private System.Windows.Forms.Button btSignOut;
        private System.Windows.Forms.Button btnMini;
        private System.Windows.Forms.LinkLabel lkAdmin1;
    }
}

