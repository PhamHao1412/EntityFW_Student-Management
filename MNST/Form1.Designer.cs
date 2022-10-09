namespace MNST
{
    partial class Form1
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
            this.dtgvData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtavgscore = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.bntDel = new System.Windows.Forms.Button();
            this.bntAdd = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbMore = new System.Windows.Forms.RadioButton();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.cmbfac = new System.Windows.Forms.ComboBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnreload = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvData
            // 
            this.dtgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvData.Location = new System.Drawing.Point(216, 309);
            this.dtgvData.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvData.Name = "dtgvData";
            this.dtgvData.RowHeadersWidth = 51;
            this.dtgvData.RowTemplate.Height = 24;
            this.dtgvData.Size = new System.Drawing.Size(606, 335);
            this.dtgvData.TabIndex = 0;
            this.dtgvData.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dtgvData_DataError);
            this.dtgvData.SelectionChanged += new System.EventHandler(this.dtgvData_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã số";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(603, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Điểm trung bình";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Họ tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 197);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Quê quán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(628, 202);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ngành";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(177, 97);
            this.txtid.Margin = new System.Windows.Forms.Padding(4);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(132, 25);
            this.txtid.TabIndex = 8;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(429, 92);
            this.txtname.Margin = new System.Windows.Forms.Padding(4);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(132, 25);
            this.txtname.TabIndex = 9;
            // 
            // txtavgscore
            // 
            this.txtavgscore.Location = new System.Drawing.Point(709, 100);
            this.txtavgscore.Margin = new System.Windows.Forms.Padding(4);
            this.txtavgscore.Name = "txtavgscore";
            this.txtavgscore.Size = new System.Drawing.Size(146, 25);
            this.txtavgscore.TabIndex = 10;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(429, 194);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(140, 25);
            this.txtaddress.TabIndex = 11;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(95, 581);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(74, 50);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // bntDel
            // 
            this.bntDel.Location = new System.Drawing.Point(95, 483);
            this.bntDel.Margin = new System.Windows.Forms.Padding(4);
            this.bntDel.Name = "bntDel";
            this.bntDel.Size = new System.Drawing.Size(74, 50);
            this.bntDel.TabIndex = 15;
            this.bntDel.Text = "Xóa";
            this.bntDel.UseVisualStyleBackColor = true;
            this.bntDel.Click += new System.EventHandler(this.bntDel_Click);
            // 
            // bntAdd
            // 
            this.bntAdd.Location = new System.Drawing.Point(95, 395);
            this.bntAdd.Margin = new System.Windows.Forms.Padding(4);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(74, 50);
            this.bntAdd.TabIndex = 16;
            this.bntAdd.Text = "Thêm";
            this.bntAdd.UseVisualStyleBackColor = true;
            this.bntAdd.Click += new System.EventHandler(this.bntAdd_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(830, 543);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(102, 50);
            this.btnQuit.TabIndex = 17;
            this.btnQuit.Text = "Thoát";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbMore);
            this.groupBox1.Controls.Add(this.rdbFemale);
            this.groupBox1.Controls.Add(this.rdbMale);
            this.groupBox1.Location = new System.Drawing.Point(119, 146);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(102, 134);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giới tính";
            // 
            // rdbMore
            // 
            this.rdbMore.AutoSize = true;
            this.rdbMore.Location = new System.Drawing.Point(5, 102);
            this.rdbMore.Margin = new System.Windows.Forms.Padding(4);
            this.rdbMore.Name = "rdbMore";
            this.rdbMore.Size = new System.Drawing.Size(59, 24);
            this.rdbMore.TabIndex = 2;
            this.rdbMore.TabStop = true;
            this.rdbMore.Text = "Khác";
            this.rdbMore.UseVisualStyleBackColor = true;
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Location = new System.Drawing.Point(5, 70);
            this.rdbFemale.Margin = new System.Windows.Forms.Padding(4);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(47, 24);
            this.rdbFemale.TabIndex = 1;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Nữ";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Location = new System.Drawing.Point(6, 38);
            this.rdbMale.Margin = new System.Windows.Forms.Padding(4);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(57, 24);
            this.rdbMale.TabIndex = 0;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Nam";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // cmbfac
            // 
            this.cmbfac.FormattingEnabled = true;
            this.cmbfac.Location = new System.Drawing.Point(695, 194);
            this.cmbfac.Margin = new System.Windows.Forms.Padding(4);
            this.cmbfac.Name = "cmbfac";
            this.cmbfac.Size = new System.Drawing.Size(164, 28);
            this.cmbfac.TabIndex = 20;
            this.cmbfac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbfac_KeyPress);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(95, 309);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(74, 50);
            this.btnsearch.TabIndex = 21;
            this.btnsearch.Text = "Tìm kiếm";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnreload
            // 
            this.btnreload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreload.Location = new System.Drawing.Point(845, 309);
            this.btnreload.Margin = new System.Windows.Forms.Padding(4);
            this.btnreload.Name = "btnreload";
            this.btnreload.Size = new System.Drawing.Size(84, 58);
            this.btnreload.TabIndex = 22;
            this.btnreload.Text = "Reload";
            this.btnreload.UseVisualStyleBackColor = true;
            this.btnreload.Click += new System.EventHandler(this.btnreload_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(290, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(384, 52);
            this.label4.TabIndex = 23;
            this.label4.Text = "STUDENT MANAGER";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 675);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnreload);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.cmbfac);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.bntAdd);
            this.Controls.Add(this.bntDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtavgscore);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvData);
            this.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtavgscore;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button bntDel;
        private System.Windows.Forms.Button bntAdd;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.RadioButton rdbMore;
        private System.Windows.Forms.ComboBox cmbfac;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnreload;
        private System.Windows.Forms.Label label4;
    }
}

