namespace SellTicket
{
    partial class FrmMianzjm11
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMianzjm11));
            this.btnMini = new System.Windows.Forms.Button();
            this.btSignOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labTime = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lkUserName = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnRanking = new System.Windows.Forms.Button();
            this.BtnClassification = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.UpTImeGet = new System.Windows.Forms.Timer(this.components);
            this.panHome = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMini
            // 
            this.btnMini.BackColor = System.Drawing.Color.Transparent;
            this.btnMini.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMini.BackgroundImage")));
            this.btnMini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMini.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnMini.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMini.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMini.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnMini.Location = new System.Drawing.Point(1505, 15);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(25, 25);
            this.btnMini.TabIndex = 10;
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
            this.btSignOut.Location = new System.Drawing.Point(1543, 15);
            this.btSignOut.Margin = new System.Windows.Forms.Padding(0);
            this.btSignOut.Name = "btSignOut";
            this.btSignOut.Size = new System.Drawing.Size(25, 25);
            this.btSignOut.TabIndex = 9;
            this.btSignOut.UseVisualStyleBackColor = false;
            this.btSignOut.Click += new System.EventHandler(this.btSignOut_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnMini);
            this.panel1.Controls.Add(this.btSignOut);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1580, 59);
            this.panel1.TabIndex = 11;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 58);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // labTime
            // 
            this.labTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labTime.Font = new System.Drawing.Font("Bender", 18F, System.Drawing.FontStyle.Bold);
            this.labTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(34)))));
            this.labTime.Location = new System.Drawing.Point(0, 838);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(216, 30);
            this.labTime.TabIndex = 1;
            this.labTime.Text = "07月15日 ";
            this.labTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labTime);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.lkUserName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnOrder);
            this.panel2.Controls.Add(this.btnRanking);
            this.panel2.Controls.Add(this.BtnClassification);
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 870);
            this.panel2.TabIndex = 12;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Noto Sans CJK Bold", 12F, System.Drawing.FontStyle.Bold);
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(91, 48);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(42, 23);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "退出";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // lkUserName
            // 
            this.lkUserName.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.lkUserName.AutoSize = true;
            this.lkUserName.Font = new System.Drawing.Font("Noto Sans CJK Bold", 12F, System.Drawing.FontStyle.Bold);
            this.lkUserName.LinkColor = System.Drawing.SystemColors.Control;
            this.lkUserName.Location = new System.Drawing.Point(11, 48);
            this.lkUserName.Name = "lkUserName";
            this.lkUserName.Size = new System.Drawing.Size(74, 23);
            this.lkUserName.TabIndex = 14;
            this.lkUserName.TabStop = true;
            this.lkUserName.Text = "云之彼端";
            this.lkUserName.VisitedLinkColor = System.Drawing.Color.Transparent;
            this.lkUserName.Click += new System.EventHandler(this.lkUserName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans CJK Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "你好,";
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(187)))), ((int)(((byte)(255)))));
            this.btnOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(187)))), ((int)(((byte)(255)))));
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Noto Sans CJK Bold", 18F, System.Drawing.FontStyle.Bold);
            this.btnOrder.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOrder.Location = new System.Drawing.Point(0, 294);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnOrder.Size = new System.Drawing.Size(218, 54);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "个人中心";
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click_1);
            // 
            // btnRanking
            // 
            this.btnRanking.BackColor = System.Drawing.Color.Transparent;
            this.btnRanking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRanking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRanking.FlatAppearance.BorderSize = 0;
            this.btnRanking.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(187)))), ((int)(((byte)(255)))));
            this.btnRanking.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(187)))), ((int)(((byte)(255)))));
            this.btnRanking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRanking.Font = new System.Drawing.Font("Noto Sans CJK Bold", 18F, System.Drawing.FontStyle.Bold);
            this.btnRanking.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRanking.Location = new System.Drawing.Point(0, 234);
            this.btnRanking.Name = "btnRanking";
            this.btnRanking.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnRanking.Size = new System.Drawing.Size(218, 54);
            this.btnRanking.TabIndex = 3;
            this.btnRanking.Text = "排行榜";
            this.btnRanking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRanking.UseVisualStyleBackColor = false;
            this.btnRanking.Click += new System.EventHandler(this.btnRanking_Click);
            // 
            // BtnClassification
            // 
            this.BtnClassification.BackColor = System.Drawing.Color.Transparent;
            this.BtnClassification.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnClassification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClassification.FlatAppearance.BorderSize = 0;
            this.BtnClassification.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(187)))), ((int)(((byte)(255)))));
            this.BtnClassification.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(187)))), ((int)(((byte)(255)))));
            this.BtnClassification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClassification.Font = new System.Drawing.Font("Noto Sans CJK Bold", 18F, System.Drawing.FontStyle.Bold);
            this.BtnClassification.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnClassification.Location = new System.Drawing.Point(-1, 176);
            this.BtnClassification.Name = "BtnClassification";
            this.BtnClassification.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnClassification.Size = new System.Drawing.Size(218, 54);
            this.BtnClassification.TabIndex = 2;
            this.BtnClassification.Text = "分类";
            this.BtnClassification.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClassification.UseVisualStyleBackColor = false;
            this.BtnClassification.Click += new System.EventHandler(this.BtnClassification_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(187)))), ((int)(((byte)(255)))));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(187)))), ((int)(((byte)(255)))));
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(187)))), ((int)(((byte)(255)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Noto Sans CJK Bold", 18F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHome.Location = new System.Drawing.Point(-1, 118);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(218, 54);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "首页";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // UpTImeGet
            // 
            this.UpTImeGet.Enabled = true;
            this.UpTImeGet.Interval = 1000;
            this.UpTImeGet.Tick += new System.EventHandler(this.UpTImeGet_Tick);
            // 
            // panHome
            // 
            this.panHome.BackColor = System.Drawing.Color.Transparent;
            this.panHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panHome.Location = new System.Drawing.Point(218, 59);
            this.panHome.Name = "panHome";
            this.panHome.Size = new System.Drawing.Size(1362, 870);
            this.panHome.TabIndex = 13;
            // 
            // FrmMianzjm11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1580, 929);
            this.Controls.Add(this.panHome);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMianzjm11";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "影院售票系统";
            this.Load += new System.EventHandler(this.FrmMianZjm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMini;
        private System.Windows.Forms.Button btSignOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.Timer UpTImeGet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lkUserName;
        private System.Windows.Forms.Panel panHome;
        private System.Windows.Forms.Button BtnClassification;
        private System.Windows.Forms.Button btnRanking;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnOrder;
    }
}