namespace SellTicket
{
    partial class FrmAdmin1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin1));
            this.btSignOut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.labUser = new System.Windows.Forms.Label();
            this.textPwd = new System.Windows.Forms.TextBox();
            this.labPwd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.butLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.btSignOut.Location = new System.Drawing.Point(319, 9);
            this.btSignOut.Margin = new System.Windows.Forms.Padding(0);
            this.btSignOut.Name = "btSignOut";
            this.btSignOut.Size = new System.Drawing.Size(25, 25);
            this.btSignOut.TabIndex = 8;
            this.btSignOut.UseVisualStyleBackColor = false;
            this.btSignOut.Click += new System.EventHandler(this.btSignOut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-32, -14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 200);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // textUserName
            // 
            this.textUserName.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.textUserName.Location = new System.Drawing.Point(151, 164);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(144, 25);
            this.textUserName.TabIndex = 1;
            // 
            // labUser
            // 
            this.labUser.AutoSize = true;
            this.labUser.BackColor = System.Drawing.Color.Transparent;
            this.labUser.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUser.Location = new System.Drawing.Point(57, 167);
            this.labUser.Name = "labUser";
            this.labUser.Size = new System.Drawing.Size(74, 19);
            this.labUser.TabIndex = 11;
            this.labUser.Text = "管理员账号";
            // 
            // textPwd
            // 
            this.textPwd.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.textPwd.Location = new System.Drawing.Point(151, 209);
            this.textPwd.Name = "textPwd";
            this.textPwd.PasswordChar = '●';
            this.textPwd.Size = new System.Drawing.Size(144, 25);
            this.textPwd.TabIndex = 2;
            // 
            // labPwd
            // 
            this.labPwd.AutoSize = true;
            this.labPwd.BackColor = System.Drawing.Color.Transparent;
            this.labPwd.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPwd.Location = new System.Drawing.Point(57, 209);
            this.labPwd.Name = "labPwd";
            this.labPwd.Size = new System.Drawing.Size(74, 19);
            this.labPwd.TabIndex = 11;
            this.labPwd.Text = "管理员密码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 20F);
            this.label1.Location = new System.Drawing.Point(105, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 35);
            this.label1.TabIndex = 11;
            this.label1.Text = "管理员登录";
            // 
            // butLogin
            // 
            this.butLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.butLogin.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butLogin.Location = new System.Drawing.Point(61, 291);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(234, 41);
            this.butLogin.TabIndex = 3;
            this.butLogin.Text = "登录";
            this.butLogin.UseVisualStyleBackColor = false;
            this.butLogin.Click += new System.EventHandler(this.butLogin_Click);
            // 
            // FrmAdmin1
            // 
            this.AcceptButton = this.butLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(358, 476);
            this.Controls.Add(this.butLogin);
            this.Controls.Add(this.labPwd);
            this.Controls.Add(this.textPwd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labUser);
            this.Controls.Add(this.textUserName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btSignOut);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdmin1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理员登录";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSignOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.Label labUser;
        private System.Windows.Forms.TextBox textPwd;
        private System.Windows.Forms.Label labPwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butLogin;
    }
}