namespace SellTicket
{
    partial class FrmUserOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserOrder));
            this.lbOrder = new System.Windows.Forms.Label();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnRecent = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAddTIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNumbers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSeat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cluptime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnEndt = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbOrder
            // 
            this.lbOrder.AutoSize = true;
            this.lbOrder.Font = new System.Drawing.Font("宋体", 22F);
            this.lbOrder.ForeColor = System.Drawing.Color.White;
            this.lbOrder.Location = new System.Drawing.Point(527, 128);
            this.lbOrder.Name = "lbOrder";
            this.lbOrder.Size = new System.Drawing.Size(133, 30);
            this.lbOrder.TabIndex = 0;
            this.lbOrder.Text = "我的订单";
            // 
            // btnAll
            // 
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Font = new System.Drawing.Font("宋体", 10F);
            this.btnAll.ForeColor = System.Drawing.Color.White;
            this.btnAll.Location = new System.Drawing.Point(1145, 623);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(77, 38);
            this.btnAll.TabIndex = 8;
            this.btnAll.Text = "全部";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnRecent
            // 
            this.btnRecent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecent.Font = new System.Drawing.Font("宋体", 10F);
            this.btnRecent.ForeColor = System.Drawing.Color.White;
            this.btnRecent.Location = new System.Drawing.Point(1228, 622);
            this.btnRecent.Name = "btnRecent";
            this.btnRecent.Size = new System.Drawing.Size(77, 38);
            this.btnRecent.TabIndex = 9;
            this.btnRecent.Text = "最近";
            this.btnRecent.UseVisualStyleBackColor = true;
            this.btnRecent.Click += new System.EventHandler(this.btnRecent_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clName,
            this.clAddTIme,
            this.ClMoney,
            this.clNumbers,
            this.clSeat,
            this.Cluptime});
            this.dataGridView1.Location = new System.Drawing.Point(532, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(773, 395);
            this.dataGridView1.TabIndex = 1;
            // 
            // clName
            // 
            this.clName.DataPropertyName = "MovieName";
            this.clName.HeaderText = "片名";
            this.clName.Name = "clName";
            this.clName.ReadOnly = true;
            this.clName.Width = 120;
            // 
            // clAddTIme
            // 
            this.clAddTIme.DataPropertyName = "addTime";
            this.clAddTIme.HeaderText = "购买时间";
            this.clAddTIme.Name = "clAddTIme";
            this.clAddTIme.ReadOnly = true;
            this.clAddTIme.Width = 150;
            // 
            // ClMoney
            // 
            this.ClMoney.DataPropertyName = "addMoney";
            this.ClMoney.HeaderText = "金额";
            this.ClMoney.Name = "ClMoney";
            this.ClMoney.ReadOnly = true;
            // 
            // clNumbers
            // 
            this.clNumbers.DataPropertyName = "addNumber";
            this.clNumbers.HeaderText = "数量";
            this.clNumbers.Name = "clNumbers";
            this.clNumbers.ReadOnly = true;
            // 
            // clSeat
            // 
            this.clSeat.DataPropertyName = "Seat";
            this.clSeat.HeaderText = "座位";
            this.clSeat.Name = "clSeat";
            this.clSeat.ReadOnly = true;
            // 
            // Cluptime
            // 
            this.Cluptime.DataPropertyName = "MovieUptime";
            this.Cluptime.HeaderText = "观影时间";
            this.Cluptime.Name = "Cluptime";
            this.Cluptime.ReadOnly = true;
            this.Cluptime.Width = 160;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "个人中心";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 22F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "个人信息";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(66, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "名称";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("宋体", 12F);
            this.textBox1.Location = new System.Drawing.Point(115, 298);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 26);
            this.textBox1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(40, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "银行卡号";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("宋体", 12F);
            this.textBox2.Location = new System.Drawing.Point(115, 397);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(196, 26);
            this.textBox2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(50, 448);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "手机号";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("宋体", 12F);
            this.textBox3.Location = new System.Drawing.Point(115, 441);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(196, 26);
            this.textBox3.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(66, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "生日";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("宋体", 12F);
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(115, 351);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(196, 21);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // btnEndt
            // 
            this.btnEndt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndt.Font = new System.Drawing.Font("宋体", 10F);
            this.btnEndt.ForeColor = System.Drawing.Color.White;
            this.btnEndt.Location = new System.Drawing.Point(109, 531);
            this.btnEndt.Name = "btnEndt";
            this.btnEndt.Size = new System.Drawing.Size(202, 38);
            this.btnEndt.TabIndex = 5;
            this.btnEndt.Text = "修改个人信息";
            this.btnEndt.UseVisualStyleBackColor = true;
            this.btnEndt.Click += new System.EventHandler(this.btnEndt_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("宋体", 10F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(106, 603);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(202, 38);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "保存个人信息";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("宋体", 10F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(106, 673);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(202, 38);
            this.button3.TabIndex = 7;
            this.button3.Text = "修改密码";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(66, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "账号";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(66, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "编号";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("宋体", 13F);
            this.textBox5.ForeColor = System.Drawing.Color.White;
            this.textBox5.Location = new System.Drawing.Point(112, 212);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 23);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "1";
            this.textBox5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("宋体", 13F);
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(112, 254);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(199, 23);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "www";
            this.textBox4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmUserOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1330, 792);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRecent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbOrder);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEndt);
            this.Controls.Add(this.btnAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUserOrder";
            this.Text = "FrmUserOrder";
            this.Load += new System.EventHandler(this.FrmUserOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbOrder;
        private System.Windows.Forms.Button btnRecent;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnEndt;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label textBox5;
        private System.Windows.Forms.Label textBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn clName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAddTIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNumbers;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSeat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cluptime;
    }
}