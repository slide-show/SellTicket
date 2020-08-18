namespace SellTicket
{
    partial class FrmUserMMG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserMMG));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSignOut = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.textBirthday = new System.Windows.Forms.TextBox();
            this.textBank = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.cbxAdmin = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxChoose = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btSignOut);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 36);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
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
            this.btSignOut.Location = new System.Drawing.Point(973, 5);
            this.btSignOut.Margin = new System.Windows.Forms.Padding(0);
            this.btSignOut.Name = "btSignOut";
            this.btSignOut.Size = new System.Drawing.Size(25, 25);
            this.btSignOut.TabIndex = 11;
            this.btSignOut.UseVisualStyleBackColor = false;
            this.btSignOut.Click += new System.EventHandler(this.btSignOut_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 31);
            this.label7.TabIndex = 4;
            this.label7.Text = "用户中心";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "账号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(44, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "生日";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(44, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "卡号";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "手机号";
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.textName.Location = new System.Drawing.Point(113, 146);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(194, 30);
            this.textName.TabIndex = 6;
            // 
            // textUserName
            // 
            this.textUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.textUserName.Location = new System.Drawing.Point(113, 193);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(194, 30);
            this.textUserName.TabIndex = 6;
            // 
            // textBirthday
            // 
            this.textBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.textBirthday.Location = new System.Drawing.Point(113, 240);
            this.textBirthday.Name = "textBirthday";
            this.textBirthday.Size = new System.Drawing.Size(194, 30);
            this.textBirthday.TabIndex = 6;
            // 
            // textBank
            // 
            this.textBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.textBank.Location = new System.Drawing.Point(113, 287);
            this.textBank.Name = "textBank";
            this.textBank.Size = new System.Drawing.Size(194, 30);
            this.textBank.TabIndex = 6;
            // 
            // textPhone
            // 
            this.textPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.textPhone.Location = new System.Drawing.Point(113, 334);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(194, 30);
            this.textPhone.TabIndex = 6;
            // 
            // cbxAdmin
            // 
            this.cbxAdmin.Enabled = false;
            this.cbxAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.cbxAdmin.FormattingEnabled = true;
            this.cbxAdmin.Items.AddRange(new object[] {
            "管理员",
            "普通用户"});
            this.cbxAdmin.Location = new System.Drawing.Point(113, 383);
            this.cbxAdmin.Name = "cbxAdmin";
            this.cbxAdmin.Size = new System.Drawing.Size(194, 33);
            this.cbxAdmin.TabIndex = 8;
            this.cbxAdmin.Text = "普通用户";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(44, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "权限";
            // 
            // cbxChoose
            // 
            this.cbxChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.cbxChoose.FormattingEnabled = true;
            this.cbxChoose.Location = new System.Drawing.Point(113, 100);
            this.cbxChoose.Name = "cbxChoose";
            this.cbxChoose.Size = new System.Drawing.Size(194, 33);
            this.cbxChoose.TabIndex = 9;
            this.cbxChoose.SelectedIndexChanged += new System.EventHandler(this.cbxChoose_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(14, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "用户选择";
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEdit.Location = new System.Drawing.Point(29, 503);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(107, 61);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "编辑";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAdd.Location = new System.Drawing.Point(329, 503);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 61);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRefresh.Location = new System.Drawing.Point(603, 503);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(381, 61);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "更新数据";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSave.Location = new System.Drawing.Point(181, 503);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 61);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCancel.Location = new System.Drawing.Point(474, 503);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 61);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(881, 440);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 47);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "! 删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(355, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(634, 320);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // FrmUserMMG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1011, 657);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cbxChoose);
            this.Controls.Add(this.cbxAdmin);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.textBank);
            this.Controls.Add(this.textBirthday);
            this.Controls.Add(this.textUserName);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUserMMG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUserMMG";
            this.Load += new System.EventHandler(this.FrmUserMMG_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btSignOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.TextBox textBirthday;
        private System.Windows.Forms.TextBox textBank;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.ComboBox cbxAdmin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxChoose;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}