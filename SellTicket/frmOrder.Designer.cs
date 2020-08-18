namespace SellTicket
{
    partial class frmOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrder));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMini = new System.Windows.Forms.Button();
            this.btSignOut = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.clorderid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMovieID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clseat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cluser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clusername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clshowtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clname1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnumbers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnMini);
            this.panel2.Controls.Add(this.btSignOut);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(969, 45);
            this.panel2.TabIndex = 15;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("宋体", 19F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 43);
            this.label1.TabIndex = 11;
            this.label1.Text = "订单管理";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnMini.Location = new System.Drawing.Point(893, 10);
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
            this.btSignOut.Location = new System.Drawing.Point(931, 10);
            this.btSignOut.Margin = new System.Windows.Forms.Padding(0);
            this.btSignOut.Name = "btSignOut";
            this.btSignOut.Size = new System.Drawing.Size(25, 25);
            this.btSignOut.TabIndex = 9;
            this.btSignOut.UseVisualStyleBackColor = false;
            this.btSignOut.Click += new System.EventHandler(this.btSignOut_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clorderid,
            this.clMovieID,
            this.clName,
            this.clType,
            this.clPrice,
            this.clnumber,
            this.clseat,
            this.cluser,
            this.clusername,
            this.clshowtime});
            this.dataGridView1.Location = new System.Drawing.Point(12, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(945, 285);
            this.dataGridView1.TabIndex = 16;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.clname1,
            this.clnumbers,
            this.clpf});
            this.dataGridView2.Location = new System.Drawing.Point(12, 368);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(445, 186);
            this.dataGridView2.TabIndex = 17;
            // 
            // clorderid
            // 
            this.clorderid.DataPropertyName = "orderid";
            this.clorderid.HeaderText = "订单编号";
            this.clorderid.Name = "clorderid";
            this.clorderid.ReadOnly = true;
            // 
            // clMovieID
            // 
            this.clMovieID.DataPropertyName = "MovieID";
            this.clMovieID.HeaderText = "电影编号";
            this.clMovieID.Name = "clMovieID";
            this.clMovieID.ReadOnly = true;
            // 
            // clName
            // 
            this.clName.DataPropertyName = "MovieName";
            this.clName.HeaderText = "片名";
            this.clName.Name = "clName";
            this.clName.ReadOnly = true;
            // 
            // clType
            // 
            this.clType.DataPropertyName = "MovieType";
            this.clType.HeaderText = "类型";
            this.clType.Name = "clType";
            this.clType.ReadOnly = true;
            // 
            // clPrice
            // 
            this.clPrice.DataPropertyName = "Price";
            this.clPrice.HeaderText = "金额";
            this.clPrice.Name = "clPrice";
            this.clPrice.ReadOnly = true;
            // 
            // clnumber
            // 
            this.clnumber.DataPropertyName = "addNumber";
            this.clnumber.HeaderText = "购买数量";
            this.clnumber.Name = "clnumber";
            this.clnumber.ReadOnly = true;
            // 
            // clseat
            // 
            this.clseat.DataPropertyName = "Seat";
            this.clseat.HeaderText = "座位";
            this.clseat.Name = "clseat";
            this.clseat.ReadOnly = true;
            // 
            // cluser
            // 
            this.cluser.DataPropertyName = "zhName";
            this.cluser.HeaderText = "用户";
            this.cluser.Name = "cluser";
            this.cluser.ReadOnly = true;
            // 
            // clusername
            // 
            this.clusername.DataPropertyName = "UserName";
            this.clusername.HeaderText = "账号";
            this.clusername.Name = "clusername";
            this.clusername.ReadOnly = true;
            // 
            // clshowtime
            // 
            this.clshowtime.DataPropertyName = "MovieUptime";
            this.clshowtime.HeaderText = "观影时间";
            this.clshowtime.Name = "clshowtime";
            this.clshowtime.ReadOnly = true;
            // 
            // clmId
            // 
            this.clmId.DataPropertyName = "MovieID";
            this.clmId.HeaderText = "编号";
            this.clmId.Name = "clmId";
            this.clmId.ReadOnly = true;
            // 
            // clname1
            // 
            this.clname1.DataPropertyName = "MovieName";
            this.clname1.HeaderText = "片名";
            this.clname1.Name = "clname1";
            this.clname1.ReadOnly = true;
            // 
            // clnumbers
            // 
            this.clnumbers.DataPropertyName = "销量";
            this.clnumbers.HeaderText = "销量";
            this.clnumbers.Name = "clnumbers";
            this.clnumbers.ReadOnly = true;
            // 
            // clpf
            // 
            this.clpf.DataPropertyName = "票房";
            this.clpf.HeaderText = "票房";
            this.clpf.Name = "clpf";
            this.clpf.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("宋体", 19F);
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(743, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 65);
            this.button1.TabIndex = 18;
            this.button1.Text = "删除订单";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(969, 566);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrder";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMini;
        private System.Windows.Forms.Button btSignOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clorderid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMovieID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clseat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cluser;
        private System.Windows.Forms.DataGridViewTextBoxColumn clusername;
        private System.Windows.Forms.DataGridViewTextBoxColumn clshowtime;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clname1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnumbers;
        private System.Windows.Forms.DataGridViewTextBoxColumn clpf;
        private System.Windows.Forms.Button button1;
    }
}