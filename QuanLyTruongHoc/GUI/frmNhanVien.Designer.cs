namespace GUI
{
    partial class frmNhanVien
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
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTimKiem = new GUI.Nhang_CustomControls.NhangButton();
            this.btnInAn = new GUI.Nhang_CustomControls.NhangButton();
            this.btnLoad = new GUI.Nhang_CustomControls.NhangButton();
            this.btnMoi = new GUI.Nhang_CustomControls.NhangButton();
            this.btnSua = new GUI.Nhang_CustomControls.NhangButton();
            this.btnThem = new GUI.Nhang_CustomControls.NhangButton();
            this.btnXoa = new GUI.Nhang_CustomControls.NhangButton();
            this.btnChon = new GUI.Nhang_CustomControls.NhangButton();
            this.txtTimKiemTen = new GUI.Nhang_CustomControls.NhangTextBox();
            this.txtTimKiemMa = new GUI.Nhang_CustomControls.NhangTextBox();
            this.picAnh = new GUI.Nhang_CustomControls.NhangCircularPictureBox();
            this.txtLuongCB = new GUI.Nhang_CustomControls.NhangTextBox();
            this.txtSDT = new GUI.Nhang_CustomControls.NhangTextBox();
            this.txtDiaChi = new GUI.Nhang_CustomControls.NhangTextBox();
            this.txtAnh = new GUI.Nhang_CustomControls.NhangTextBox();
            this.dtpNgaySinh = new GUI.Nhang_CustomControls.NhangDateTimePicker();
            this.txtTenNV = new GUI.Nhang_CustomControls.NhangTextBox();
            this.txtMaNV = new GUI.Nhang_CustomControls.NhangTextBox();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.cboChucVu = new System.Windows.Forms.ComboBox();
            this.cboPhongBan = new System.Windows.Forms.ComboBox();
            this.cboQueQuan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(0, 432);
            this.dgvNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 62;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(1388, 101);
            this.dgvNhanVien.TabIndex = 3;
            this.dgvNhanVien.Click += new System.EventHandler(this.dgvNhanVien_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.btnInAn);
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.btnMoi);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnChon);
            this.panel1.Controls.Add(this.txtTimKiemTen);
            this.panel1.Controls.Add(this.txtTimKiemMa);
            this.panel1.Controls.Add(this.picAnh);
            this.panel1.Controls.Add(this.txtLuongCB);
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.txtAnh);
            this.panel1.Controls.Add(this.dtpNgaySinh);
            this.panel1.Controls.Add(this.txtTenNV);
            this.panel1.Controls.Add(this.txtMaNV);
            this.panel1.Controls.Add(this.radNu);
            this.panel1.Controls.Add(this.radNam);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cboChucVu);
            this.panel1.Controls.Add(this.cboPhongBan);
            this.panel1.Controls.Add(this.cboQueQuan);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1388, 432);
            this.panel1.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnTimKiem.BorderRadius = 10;
            this.btnTimKiem.BorderSize = 2;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.Black;
            this.btnTimKiem.Location = new System.Drawing.Point(741, 370);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(104, 39);
            this.btnTimKiem.TabIndex = 111;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextColor = System.Drawing.Color.Black;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnInAn
            // 
            this.btnInAn.BackColor = System.Drawing.Color.DimGray;
            this.btnInAn.BackgroundColor = System.Drawing.Color.DimGray;
            this.btnInAn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnInAn.BorderRadius = 10;
            this.btnInAn.BorderSize = 0;
            this.btnInAn.FlatAppearance.BorderSize = 0;
            this.btnInAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInAn.ForeColor = System.Drawing.Color.White;
            this.btnInAn.Location = new System.Drawing.Point(1099, 289);
            this.btnInAn.Name = "btnInAn";
            this.btnInAn.Size = new System.Drawing.Size(104, 39);
            this.btnInAn.TabIndex = 110;
            this.btnInAn.Text = "In Ấn";
            this.btnInAn.TextColor = System.Drawing.Color.White;
            this.btnInAn.UseVisualStyleBackColor = false;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLoad.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.btnLoad.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLoad.BorderRadius = 10;
            this.btnLoad.BorderSize = 0;
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(1099, 334);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(104, 39);
            this.btnLoad.TabIndex = 109;
            this.btnLoad.Text = "Bỏ qua";
            this.btnLoad.TextColor = System.Drawing.Color.White;
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click_1);
            // 
            // btnMoi
            // 
            this.btnMoi.BackColor = System.Drawing.Color.Olive;
            this.btnMoi.BackgroundColor = System.Drawing.Color.Olive;
            this.btnMoi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMoi.BorderRadius = 10;
            this.btnMoi.BorderSize = 0;
            this.btnMoi.FlatAppearance.BorderSize = 0;
            this.btnMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoi.ForeColor = System.Drawing.Color.White;
            this.btnMoi.Location = new System.Drawing.Point(1100, 374);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(104, 39);
            this.btnMoi.TabIndex = 108;
            this.btnMoi.Text = "Tạo mới";
            this.btnMoi.TextColor = System.Drawing.Color.White;
            this.btnMoi.UseVisualStyleBackColor = false;
            this.btnMoi.Click += new System.EventHandler(this.btnMoi_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSua.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnSua.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSua.BorderRadius = 10;
            this.btnSua.BorderSize = 0;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(1244, 334);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(104, 39);
            this.btnSua.TabIndex = 107;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextColor = System.Drawing.Color.White;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.ForestGreen;
            this.btnThem.BackgroundColor = System.Drawing.Color.ForestGreen;
            this.btnThem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThem.BorderRadius = 10;
            this.btnThem.BorderSize = 0;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(1243, 289);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(104, 39);
            this.btnThem.TabIndex = 106;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextColor = System.Drawing.Color.White;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.BackgroundColor = System.Drawing.Color.Red;
            this.btnXoa.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXoa.BorderRadius = 10;
            this.btnXoa.BorderSize = 0;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(1244, 374);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(104, 39);
            this.btnXoa.TabIndex = 105;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextColor = System.Drawing.Color.White;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnChon
            // 
            this.btnChon.BackColor = System.Drawing.Color.Transparent;
            this.btnChon.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnChon.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnChon.BorderRadius = 10;
            this.btnChon.BorderSize = 2;
            this.btnChon.FlatAppearance.BorderSize = 0;
            this.btnChon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.ForeColor = System.Drawing.Color.Black;
            this.btnChon.Location = new System.Drawing.Point(1155, 205);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(104, 39);
            this.btnChon.TabIndex = 102;
            this.btnChon.Text = "Chọn Ảnh";
            this.btnChon.TextColor = System.Drawing.Color.Black;
            this.btnChon.UseVisualStyleBackColor = false;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click_1);
            // 
            // txtTimKiemTen
            // 
            this.txtTimKiemTen.BackColor = System.Drawing.SystemColors.Window;
            this.txtTimKiemTen.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTimKiemTen.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTimKiemTen.BorderRadius = 15;
            this.txtTimKiemTen.BorderSize = 1;
            this.txtTimKiemTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTimKiemTen.Location = new System.Drawing.Point(448, 374);
            this.txtTimKiemTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiemTen.Multiline = false;
            this.txtTimKiemTen.Name = "txtTimKiemTen";
            this.txtTimKiemTen.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTimKiemTen.PasswordChar = false;
            this.txtTimKiemTen.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTimKiemTen.PlaceholderText = "";
            this.txtTimKiemTen.Size = new System.Drawing.Size(250, 35);
            this.txtTimKiemTen.TabIndex = 100;
            this.txtTimKiemTen.UnderlinedStyle = false;
            // 
            // txtTimKiemMa
            // 
            this.txtTimKiemMa.BackColor = System.Drawing.SystemColors.Window;
            this.txtTimKiemMa.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTimKiemMa.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTimKiemMa.BorderRadius = 15;
            this.txtTimKiemMa.BorderSize = 1;
            this.txtTimKiemMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemMa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTimKiemMa.Location = new System.Drawing.Point(168, 375);
            this.txtTimKiemMa.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiemMa.Multiline = false;
            this.txtTimKiemMa.Name = "txtTimKiemMa";
            this.txtTimKiemMa.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTimKiemMa.PasswordChar = false;
            this.txtTimKiemMa.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTimKiemMa.PlaceholderText = "";
            this.txtTimKiemMa.Size = new System.Drawing.Size(250, 35);
            this.txtTimKiemMa.TabIndex = 101;
            this.txtTimKiemMa.UnderlinedStyle = false;
            // 
            // picAnh
            // 
            this.picAnh.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.picAnh.BorderColor = System.Drawing.Color.RoyalBlue;
            this.picAnh.BorderColor2 = System.Drawing.Color.HotPink;
            this.picAnh.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.picAnh.BorderSize = 2;
            this.picAnh.GradientAngle = 50F;
            this.picAnh.Location = new System.Drawing.Point(1143, 32);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(143, 143);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnh.TabIndex = 99;
            this.picAnh.TabStop = false;
            // 
            // txtLuongCB
            // 
            this.txtLuongCB.BackColor = System.Drawing.SystemColors.Window;
            this.txtLuongCB.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtLuongCB.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtLuongCB.BorderRadius = 15;
            this.txtLuongCB.BorderSize = 1;
            this.txtLuongCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuongCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLuongCB.Location = new System.Drawing.Point(694, 308);
            this.txtLuongCB.Margin = new System.Windows.Forms.Padding(4);
            this.txtLuongCB.Multiline = false;
            this.txtLuongCB.Name = "txtLuongCB";
            this.txtLuongCB.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtLuongCB.PasswordChar = false;
            this.txtLuongCB.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtLuongCB.PlaceholderText = "";
            this.txtLuongCB.Size = new System.Drawing.Size(250, 35);
            this.txtLuongCB.TabIndex = 90;
            this.txtLuongCB.UnderlinedStyle = false;
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.SystemColors.Window;
            this.txtSDT.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSDT.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSDT.BorderRadius = 15;
            this.txtSDT.BorderSize = 1;
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSDT.Location = new System.Drawing.Point(694, 111);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Multiline = false;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSDT.PasswordChar = false;
            this.txtSDT.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSDT.PlaceholderText = "";
            this.txtSDT.Size = new System.Drawing.Size(250, 35);
            this.txtSDT.TabIndex = 89;
            this.txtSDT.UnderlinedStyle = false;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.SystemColors.Window;
            this.txtDiaChi.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDiaChi.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDiaChi.BorderRadius = 15;
            this.txtDiaChi.BorderSize = 1;
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDiaChi.Location = new System.Drawing.Point(694, 68);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Multiline = false;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDiaChi.PasswordChar = false;
            this.txtDiaChi.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDiaChi.PlaceholderText = "";
            this.txtDiaChi.Size = new System.Drawing.Size(250, 35);
            this.txtDiaChi.TabIndex = 88;
            this.txtDiaChi.UnderlinedStyle = false;
            // 
            // txtAnh
            // 
            this.txtAnh.BackColor = System.Drawing.SystemColors.Window;
            this.txtAnh.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtAnh.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtAnh.BorderRadius = 15;
            this.txtAnh.BorderSize = 1;
            this.txtAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAnh.Location = new System.Drawing.Point(168, 240);
            this.txtAnh.Margin = new System.Windows.Forms.Padding(4);
            this.txtAnh.Multiline = false;
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtAnh.PasswordChar = false;
            this.txtAnh.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAnh.PlaceholderText = "";
            this.txtAnh.Size = new System.Drawing.Size(250, 35);
            this.txtAnh.TabIndex = 87;
            this.txtAnh.UnderlinedStyle = false;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtpNgaySinh.BorderSize = 0;
            this.dtpNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(168, 164);
            this.dtpNgaySinh.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(195, 35);
            this.dtpNgaySinh.SkinColor = System.Drawing.Color.RoyalBlue;
            this.dtpNgaySinh.TabIndex = 86;
            this.dtpNgaySinh.TextColor = System.Drawing.Color.White;
            // 
            // txtTenNV
            // 
            this.txtTenNV.BackColor = System.Drawing.SystemColors.Window;
            this.txtTenNV.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTenNV.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTenNV.BorderRadius = 15;
            this.txtTenNV.BorderSize = 1;
            this.txtTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTenNV.Location = new System.Drawing.Point(168, 117);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNV.Multiline = false;
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTenNV.PasswordChar = false;
            this.txtTenNV.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTenNV.PlaceholderText = "";
            this.txtTenNV.Size = new System.Drawing.Size(250, 35);
            this.txtTenNV.TabIndex = 85;
            this.txtTenNV.UnderlinedStyle = false;
            // 
            // txtMaNV
            // 
            this.txtMaNV.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaNV.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMaNV.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMaNV.BorderRadius = 15;
            this.txtMaNV.BorderSize = 1;
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMaNV.Location = new System.Drawing.Point(168, 68);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNV.Multiline = false;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMaNV.PasswordChar = false;
            this.txtMaNV.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaNV.PlaceholderText = "";
            this.txtMaNV.Size = new System.Drawing.Size(250, 35);
            this.txtMaNV.TabIndex = 84;
            this.txtMaNV.UnderlinedStyle = false;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.radNu.Location = new System.Drawing.Point(759, 165);
            this.radNu.Margin = new System.Windows.Forms.Padding(4);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(47, 21);
            this.radNu.TabIndex = 9;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Checked = true;
            this.radNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.radNam.Location = new System.Drawing.Point(695, 165);
            this.radNam.Margin = new System.Windows.Forms.Padding(4);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(58, 21);
            this.radNam.TabIndex = 8;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(33, 385);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tìm kiếm ";
            // 
            // cboChucVu
            // 
            this.cboChucVu.FormattingEnabled = true;
            this.cboChucVu.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboChucVu.Location = new System.Drawing.Point(168, 205);
            this.cboChucVu.Name = "cboChucVu";
            this.cboChucVu.Size = new System.Drawing.Size(195, 24);
            this.cboChucVu.TabIndex = 4;
            // 
            // cboPhongBan
            // 
            this.cboPhongBan.FormattingEnabled = true;
            this.cboPhongBan.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboPhongBan.Location = new System.Drawing.Point(694, 247);
            this.cboPhongBan.Name = "cboPhongBan";
            this.cboPhongBan.Size = new System.Drawing.Size(250, 24);
            this.cboPhongBan.TabIndex = 11;
            // 
            // cboQueQuan
            // 
            this.cboQueQuan.FormattingEnabled = true;
            this.cboQueQuan.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboQueQuan.Location = new System.Drawing.Point(694, 207);
            this.cboQueQuan.Name = "cboQueQuan";
            this.cboQueQuan.Size = new System.Drawing.Size(250, 24);
            this.cboQueQuan.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chức Vụ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(557, 249);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Phòng Ban";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(557, 207);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Quê quán";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(557, 165);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Giới Tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(557, 123);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "SDT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(557, 81);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Địa Chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 165);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày Sinh";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(28, 249);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Hình Ảnh";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(557, 308);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Lương Căn bản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(519, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(353, 38);
            this.label4.TabIndex = 0;
            this.label4.Text = "QUẢN LÍ NHÂN VIÊN";
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 533);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.panel1);
            this.Name = "frmNhanVien";
            this.Text = "Nhân Viên";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboChucVu;
        private System.Windows.Forms.ComboBox cboPhongBan;
        private System.Windows.Forms.ComboBox cboQueQuan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Nhang_CustomControls.NhangTextBox txtTenNV;
        private Nhang_CustomControls.NhangTextBox txtMaNV;
        private Nhang_CustomControls.NhangDateTimePicker dtpNgaySinh;
        private Nhang_CustomControls.NhangTextBox txtAnh;
        private Nhang_CustomControls.NhangTextBox txtSDT;
        private Nhang_CustomControls.NhangTextBox txtDiaChi;
        private Nhang_CustomControls.NhangTextBox txtLuongCB;
        private Nhang_CustomControls.NhangCircularPictureBox picAnh;
        private Nhang_CustomControls.NhangTextBox txtTimKiemTen;
        private Nhang_CustomControls.NhangTextBox txtTimKiemMa;
        private Nhang_CustomControls.NhangButton btnChon;
        private Nhang_CustomControls.NhangButton btnInAn;
        private Nhang_CustomControls.NhangButton btnLoad;
        private Nhang_CustomControls.NhangButton btnMoi;
        private Nhang_CustomControls.NhangButton btnSua;
        private Nhang_CustomControls.NhangButton btnThem;
        private Nhang_CustomControls.NhangButton btnXoa;
        private Nhang_CustomControls.NhangButton btnTimKiem;
    }
}