namespace GUI
{
    partial class frmBangDiemCaNam
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnMoi = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cboMaLop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMaHS = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvBangDiemCaNam = new System.Windows.Forms.DataGridView();
            this.txtDiemTB1 = new GUI.Nhang_CustomControls.NhangTextBox();
            this.txtXepLoai = new GUI.Nhang_CustomControls.NhangTextBox();
            this.txtDiemTBCaNam = new GUI.Nhang_CustomControls.NhangTextBox();
            this.txtDiemTB2 = new GUI.Nhang_CustomControls.NhangTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTimKiem = new GUI.Nhang_CustomControls.NhangTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangDiemCaNam)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txtDiemTB2);
            this.groupBox1.Controls.Add(this.txtDiemTBCaNam);
            this.groupBox1.Controls.Add(this.txtXepLoai);
            this.groupBox1.Controls.Add(this.txtDiemTB1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.cboMaLop);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboMaHS);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1038, 343);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng Điểm Cả Năm";
            // 
            // btnTinh
            // 
            this.btnTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinh.ForeColor = System.Drawing.Color.Black;
            this.btnTinh.Image = global::GUI.Properties.Resources.microsoft_excel_32px;
            this.btnTinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTinh.Location = new System.Drawing.Point(238, 164);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(178, 37);
            this.btnTinh.TabIndex = 89;
            this.btnTinh.Text = "Tính Điểm";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.Black;
            this.btnTim.Image = global::GUI.Properties.Resources.search_16px;
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.Location = new System.Drawing.Point(334, 260);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(129, 37);
            this.btnTim.TabIndex = 88;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::GUI.Properties.Resources.waste_16px;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(68, 164);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(104, 37);
            this.btnXoa.TabIndex = 86;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnThem.Image = global::GUI.Properties.Resources.add_16px1;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(68, 87);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(104, 37);
            this.btnThem.TabIndex = 84;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Blue;
            this.btnSua.Image = global::GUI.Properties.Resources.settings_16px;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(238, 87);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(107, 37);
            this.btnSua.TabIndex = 85;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnLoad.Image = global::GUI.Properties.Resources.refresh_16px1;
            this.btnLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoad.Location = new System.Drawing.Point(68, 18);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(120, 37);
            this.btnLoad.TabIndex = 83;
            this.btnLoad.Text = "Tải Lại";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnMoi
            // 
            this.btnMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoi.ForeColor = System.Drawing.Color.Maroon;
            this.btnMoi.Image = global::GUI.Properties.Resources.new_copy_16px1;
            this.btnMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoi.Location = new System.Drawing.Point(238, 18);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(108, 37);
            this.btnMoi.TabIndex = 82;
            this.btnMoi.Text = "Mới";
            this.btnMoi.UseVisualStyleBackColor = true;
            this.btnMoi.Click += new System.EventHandler(this.btnMoi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(13, 301);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Xếp Loại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(13, 252);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Điểm Trung Bình Cả Năm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Điểm Trung Bình Học Kỳ 2";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(13, 157);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(209, 20);
            this.label17.TabIndex = 16;
            this.label17.Text = "Điểm Trung Bình Học Kỳ 1";
            // 
            // cboMaLop
            // 
            this.cboMaLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaLop.FormattingEnabled = true;
            this.cboMaLop.Location = new System.Drawing.Point(248, 99);
            this.cboMaLop.Name = "cboMaLop";
            this.cboMaLop.Size = new System.Drawing.Size(121, 33);
            this.cboMaLop.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lớp";
            // 
            // cboMaHS
            // 
            this.cboMaHS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaHS.FormattingEnabled = true;
            this.cboMaHS.Location = new System.Drawing.Point(248, 44);
            this.cboMaHS.Name = "cboMaHS";
            this.cboMaHS.Size = new System.Drawing.Size(223, 33);
            this.cboMaHS.TabIndex = 3;
            this.cboMaHS.SelectedIndexChanged += new System.EventHandler(this.cboMaHS_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Học Sinh";
            // 
            // dgvBangDiemCaNam
            // 
            this.dgvBangDiemCaNam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBangDiemCaNam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangDiemCaNam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBangDiemCaNam.Location = new System.Drawing.Point(0, 343);
            this.dgvBangDiemCaNam.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBangDiemCaNam.Name = "dgvBangDiemCaNam";
            this.dgvBangDiemCaNam.RowHeadersWidth = 62;
            this.dgvBangDiemCaNam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBangDiemCaNam.Size = new System.Drawing.Size(1038, 168);
            this.dgvBangDiemCaNam.TabIndex = 2;
            this.dgvBangDiemCaNam.Click += new System.EventHandler(this.dgvBangDiemCaNam_Click);
            // 
            // txtDiemTB1
            // 
            this.txtDiemTB1.BackColor = System.Drawing.SystemColors.Window;
            this.txtDiemTB1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDiemTB1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDiemTB1.BorderRadius = 15;
            this.txtDiemTB1.BorderSize = 1;
            this.txtDiemTB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemTB1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDiemTB1.Location = new System.Drawing.Point(248, 157);
            this.txtDiemTB1.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiemTB1.Multiline = false;
            this.txtDiemTB1.Name = "txtDiemTB1";
            this.txtDiemTB1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDiemTB1.PasswordChar = false;
            this.txtDiemTB1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDiemTB1.PlaceholderText = "";
            this.txtDiemTB1.Size = new System.Drawing.Size(110, 35);
            this.txtDiemTB1.TabIndex = 91;
            this.txtDiemTB1.UnderlinedStyle = false;
            // 
            // txtXepLoai
            // 
            this.txtXepLoai.BackColor = System.Drawing.SystemColors.Window;
            this.txtXepLoai.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtXepLoai.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtXepLoai.BorderRadius = 15;
            this.txtXepLoai.BorderSize = 1;
            this.txtXepLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXepLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtXepLoai.Location = new System.Drawing.Point(248, 301);
            this.txtXepLoai.Margin = new System.Windows.Forms.Padding(4);
            this.txtXepLoai.Multiline = false;
            this.txtXepLoai.Name = "txtXepLoai";
            this.txtXepLoai.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtXepLoai.PasswordChar = false;
            this.txtXepLoai.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtXepLoai.PlaceholderText = "";
            this.txtXepLoai.Size = new System.Drawing.Size(110, 35);
            this.txtXepLoai.TabIndex = 92;
            this.txtXepLoai.UnderlinedStyle = false;
            // 
            // txtDiemTBCaNam
            // 
            this.txtDiemTBCaNam.BackColor = System.Drawing.SystemColors.Window;
            this.txtDiemTBCaNam.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDiemTBCaNam.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDiemTBCaNam.BorderRadius = 15;
            this.txtDiemTBCaNam.BorderSize = 1;
            this.txtDiemTBCaNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemTBCaNam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDiemTBCaNam.Location = new System.Drawing.Point(248, 257);
            this.txtDiemTBCaNam.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiemTBCaNam.Multiline = false;
            this.txtDiemTBCaNam.Name = "txtDiemTBCaNam";
            this.txtDiemTBCaNam.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDiemTBCaNam.PasswordChar = false;
            this.txtDiemTBCaNam.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDiemTBCaNam.PlaceholderText = "";
            this.txtDiemTBCaNam.Size = new System.Drawing.Size(110, 35);
            this.txtDiemTBCaNam.TabIndex = 93;
            this.txtDiemTBCaNam.UnderlinedStyle = false;
            // 
            // txtDiemTB2
            // 
            this.txtDiemTB2.BackColor = System.Drawing.SystemColors.Window;
            this.txtDiemTB2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDiemTB2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDiemTB2.BorderRadius = 15;
            this.txtDiemTB2.BorderSize = 1;
            this.txtDiemTB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemTB2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDiemTB2.Location = new System.Drawing.Point(248, 208);
            this.txtDiemTB2.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiemTB2.Multiline = false;
            this.txtDiemTB2.Name = "txtDiemTB2";
            this.txtDiemTB2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDiemTB2.PasswordChar = false;
            this.txtDiemTB2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDiemTB2.PlaceholderText = "";
            this.txtDiemTB2.Size = new System.Drawing.Size(110, 35);
            this.txtDiemTB2.TabIndex = 94;
            this.txtDiemTB2.UnderlinedStyle = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.btnMoi);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnTinh);
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(552, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 314);
            this.panel1.TabIndex = 95;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.SystemColors.Window;
            this.txtTimKiem.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTimKiem.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTimKiem.BorderRadius = 15;
            this.txtTimKiem.BorderSize = 1;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTimKiem.Location = new System.Drawing.Point(22, 262);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Multiline = false;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTimKiem.PasswordChar = false;
            this.txtTimKiem.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTimKiem.PlaceholderText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(292, 35);
            this.txtTimKiem.TabIndex = 96;
            this.txtTimKiem.UnderlinedStyle = false;
            // 
            // frmBangDiemCaNam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 511);
            this.Controls.Add(this.dgvBangDiemCaNam);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBangDiemCaNam";
            this.Text = "Bảng Điểm Cả Năm";
            this.Load += new System.EventHandler(this.frmBangDiemCaNam_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangDiemCaNam)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboMaHS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboMaLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dgvBangDiemCaNam;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnMoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Panel panel1;
        private Nhang_CustomControls.NhangTextBox txtTimKiem;
        private Nhang_CustomControls.NhangTextBox txtDiemTB2;
        private Nhang_CustomControls.NhangTextBox txtDiemTBCaNam;
        private Nhang_CustomControls.NhangTextBox txtXepLoai;
        private Nhang_CustomControls.NhangTextBox txtDiemTB1;
    }
}