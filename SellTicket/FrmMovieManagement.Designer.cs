namespace SellTicket
{
    partial class FrmMovieManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMovieManagement));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMini = new System.Windows.Forms.Button();
            this.btSignOut = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDirector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clToStar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMovieType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clImage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIntroduce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbMovieImage = new System.Windows.Forms.PictureBox();
            this.labName = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.labDirector = new System.Windows.Forms.Label();
            this.textDirector = new System.Windows.Forms.TextBox();
            this.labToStar = new System.Windows.Forms.Label();
            this.textToStar = new System.Windows.Forms.TextBox();
            this.labMovieType = new System.Windows.Forms.Label();
            this.textMovieType = new System.Windows.Forms.TextBox();
            this.labPrice = new System.Windows.Forms.Label();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.labIntroduce = new System.Windows.Forms.Label();
            this.textIntroduce = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEmpty = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNumbers = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMovieImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMini);
            this.panel1.Controls.Add(this.btSignOut);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1214, 36);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 34);
            this.label1.TabIndex = 13;
            this.label1.Text = "影片管理";
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
            this.btnMini.Location = new System.Drawing.Point(1141, 4);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(25, 25);
            this.btnMini.TabIndex = 12;
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
            this.btSignOut.Location = new System.Drawing.Point(1179, 4);
            this.btSignOut.Margin = new System.Windows.Forms.Padding(0);
            this.btSignOut.Name = "btSignOut";
            this.btSignOut.Size = new System.Drawing.Size(25, 25);
            this.btSignOut.TabIndex = 11;
            this.btSignOut.UseVisualStyleBackColor = false;
            this.btSignOut.Click += new System.EventHandler(this.btSignOut_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clID,
            this.clName,
            this.clDirector,
            this.clToStar,
            this.clMovieType,
            this.clImage,
            this.clIntroduce,
            this.clPrice});
            this.dataGridView1.Location = new System.Drawing.Point(400, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(805, 276);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // clID
            // 
            this.clID.DataPropertyName = "MovieID";
            this.clID.HeaderText = "编号";
            this.clID.Name = "clID";
            this.clID.ReadOnly = true;
            this.clID.Width = 80;
            // 
            // clName
            // 
            this.clName.DataPropertyName = "MovieName";
            this.clName.HeaderText = "片名";
            this.clName.Name = "clName";
            this.clName.ReadOnly = true;
            // 
            // clDirector
            // 
            this.clDirector.DataPropertyName = "Director";
            this.clDirector.HeaderText = "导演";
            this.clDirector.Name = "clDirector";
            this.clDirector.ReadOnly = true;
            // 
            // clToStar
            // 
            this.clToStar.DataPropertyName = "ToStar";
            this.clToStar.HeaderText = "主演";
            this.clToStar.Name = "clToStar";
            this.clToStar.ReadOnly = true;
            // 
            // clMovieType
            // 
            this.clMovieType.DataPropertyName = "MovieType";
            this.clMovieType.HeaderText = "类型";
            this.clMovieType.Name = "clMovieType";
            this.clMovieType.ReadOnly = true;
            // 
            // clImage
            // 
            this.clImage.DataPropertyName = "MovieImage";
            this.clImage.HeaderText = "图片路径";
            this.clImage.Name = "clImage";
            this.clImage.ReadOnly = true;
            // 
            // clIntroduce
            // 
            this.clIntroduce.DataPropertyName = "Introduce";
            this.clIntroduce.HeaderText = "简介";
            this.clIntroduce.Name = "clIntroduce";
            this.clIntroduce.ReadOnly = true;
            // 
            // clPrice
            // 
            this.clPrice.DataPropertyName = "Price";
            this.clPrice.HeaderText = "票价";
            this.clPrice.Name = "clPrice";
            this.clPrice.ReadOnly = true;
            // 
            // pbMovieImage
            // 
            this.pbMovieImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pbMovieImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbMovieImage.BackgroundImage")));
            this.pbMovieImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbMovieImage.Location = new System.Drawing.Point(12, 63);
            this.pbMovieImage.Name = "pbMovieImage";
            this.pbMovieImage.Size = new System.Drawing.Size(194, 276);
            this.pbMovieImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMovieImage.TabIndex = 4;
            this.pbMovieImage.TabStop = false;
            this.pbMovieImage.Click += new System.EventHandler(this.pbMovieImage_Click);
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.labName.ForeColor = System.Drawing.Color.White;
            this.labName.Location = new System.Drawing.Point(212, 63);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(37, 20);
            this.labName.TabIndex = 5;
            this.labName.Text = "片名";
            // 
            // textName
            // 
            this.textName.Enabled = false;
            this.textName.Location = new System.Drawing.Point(255, 62);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(139, 21);
            this.textName.TabIndex = 1;
            // 
            // labDirector
            // 
            this.labDirector.AutoSize = true;
            this.labDirector.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.labDirector.ForeColor = System.Drawing.Color.White;
            this.labDirector.Location = new System.Drawing.Point(212, 104);
            this.labDirector.Name = "labDirector";
            this.labDirector.Size = new System.Drawing.Size(37, 20);
            this.labDirector.TabIndex = 5;
            this.labDirector.Text = "导演";
            // 
            // textDirector
            // 
            this.textDirector.Enabled = false;
            this.textDirector.Location = new System.Drawing.Point(255, 103);
            this.textDirector.Name = "textDirector";
            this.textDirector.Size = new System.Drawing.Size(139, 21);
            this.textDirector.TabIndex = 2;
            // 
            // labToStar
            // 
            this.labToStar.AutoSize = true;
            this.labToStar.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.labToStar.ForeColor = System.Drawing.Color.White;
            this.labToStar.Location = new System.Drawing.Point(212, 145);
            this.labToStar.Name = "labToStar";
            this.labToStar.Size = new System.Drawing.Size(37, 20);
            this.labToStar.TabIndex = 5;
            this.labToStar.Text = "主演";
            // 
            // textToStar
            // 
            this.textToStar.Enabled = false;
            this.textToStar.Location = new System.Drawing.Point(255, 144);
            this.textToStar.Name = "textToStar";
            this.textToStar.Size = new System.Drawing.Size(139, 21);
            this.textToStar.TabIndex = 3;
            // 
            // labMovieType
            // 
            this.labMovieType.AutoSize = true;
            this.labMovieType.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.labMovieType.ForeColor = System.Drawing.Color.White;
            this.labMovieType.Location = new System.Drawing.Point(212, 186);
            this.labMovieType.Name = "labMovieType";
            this.labMovieType.Size = new System.Drawing.Size(37, 20);
            this.labMovieType.TabIndex = 5;
            this.labMovieType.Text = "类型";
            // 
            // textMovieType
            // 
            this.textMovieType.Enabled = false;
            this.textMovieType.Location = new System.Drawing.Point(255, 185);
            this.textMovieType.Name = "textMovieType";
            this.textMovieType.Size = new System.Drawing.Size(139, 21);
            this.textMovieType.TabIndex = 4;
            // 
            // labPrice
            // 
            this.labPrice.AutoSize = true;
            this.labPrice.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.labPrice.ForeColor = System.Drawing.Color.White;
            this.labPrice.Location = new System.Drawing.Point(212, 227);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(37, 20);
            this.labPrice.TabIndex = 5;
            this.labPrice.Text = "票价";
            // 
            // textPrice
            // 
            this.textPrice.Enabled = false;
            this.textPrice.Location = new System.Drawing.Point(255, 226);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(139, 21);
            this.textPrice.TabIndex = 5;
            // 
            // labIntroduce
            // 
            this.labIntroduce.AutoSize = true;
            this.labIntroduce.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.labIntroduce.ForeColor = System.Drawing.Color.White;
            this.labIntroduce.Location = new System.Drawing.Point(212, 268);
            this.labIntroduce.Name = "labIntroduce";
            this.labIntroduce.Size = new System.Drawing.Size(37, 20);
            this.labIntroduce.TabIndex = 5;
            this.labIntroduce.Text = "简介";
            // 
            // textIntroduce
            // 
            this.textIntroduce.Enabled = false;
            this.textIntroduce.Location = new System.Drawing.Point(255, 267);
            this.textIntroduce.Multiline = true;
            this.textIntroduce.Name = "textIntroduce";
            this.textIntroduce.Size = new System.Drawing.Size(139, 69);
            this.textIntroduce.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Noto Sans CJK Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(22, 469);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 42);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Noto Sans CJK Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(22, 394);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 42);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "编辑";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Noto Sans CJK Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(141, 394);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 42);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "保存修改";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEmpty
            // 
            this.btnEmpty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpty.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEmpty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpty.Font = new System.Drawing.Font("Noto Sans CJK Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEmpty.ForeColor = System.Drawing.Color.White;
            this.btnEmpty.Location = new System.Drawing.Point(141, 469);
            this.btnEmpty.Name = "btnEmpty";
            this.btnEmpty.Size = new System.Drawing.Size(108, 42);
            this.btnEmpty.TabIndex = 10;
            this.btnEmpty.Text = "清空信息";
            this.btnEmpty.UseVisualStyleBackColor = true;
            this.btnEmpty.Click += new System.EventHandler(this.btnEmpty_Click);
            // 
            // btndelete
            // 
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Noto Sans CJK Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btndelete.ForeColor = System.Drawing.Color.Red;
            this.btndelete.Location = new System.Drawing.Point(22, 540);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 42);
            this.btndelete.TabIndex = 11;
            this.btndelete.Text = "！ 删除";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 19F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(943, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "电影总数：";
            // 
            // lbNumbers
            // 
            this.lbNumbers.AutoSize = true;
            this.lbNumbers.Font = new System.Drawing.Font("宋体", 19F);
            this.lbNumbers.ForeColor = System.Drawing.Color.White;
            this.lbNumbers.Location = new System.Drawing.Point(1082, 401);
            this.lbNumbers.Name = "lbNumbers";
            this.lbNumbers.Size = new System.Drawing.Size(25, 26);
            this.lbNumbers.TabIndex = 9;
            this.lbNumbers.Text = "1";
            // 
            // FrmMovieManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1214, 616);
            this.Controls.Add(this.lbNumbers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnEmpty);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textIntroduce);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.textMovieType);
            this.Controls.Add(this.textToStar);
            this.Controls.Add(this.textDirector);
            this.Controls.Add(this.labIntroduce);
            this.Controls.Add(this.labPrice);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labMovieType);
            this.Controls.Add(this.labToStar);
            this.Controls.Add(this.labDirector);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.pbMovieImage);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMovieManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MovieManagement";
            this.Load += new System.EventHandler(this.FrmMovieManagement_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMovieImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMini;
        private System.Windows.Forms.Button btSignOut;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pbMovieImage;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label labDirector;
        private System.Windows.Forms.TextBox textDirector;
        private System.Windows.Forms.Label labToStar;
        private System.Windows.Forms.TextBox textToStar;
        private System.Windows.Forms.Label labMovieType;
        private System.Windows.Forms.TextBox textMovieType;
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.Label labIntroduce;
        private System.Windows.Forms.TextBox textIntroduce;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn clID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDirector;
        private System.Windows.Forms.DataGridViewTextBoxColumn clToStar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMovieType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIntroduce;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEmpty;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbNumbers;
    }
}