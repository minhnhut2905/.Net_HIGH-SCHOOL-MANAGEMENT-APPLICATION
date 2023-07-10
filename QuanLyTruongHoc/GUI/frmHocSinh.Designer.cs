namespace GUI
{
    partial class frmHocSinh
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
            this.dgvHocSinh = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.cboQueQuan = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTimKiem = new GUI.Nhang_CustomControls.NhangButton();
            this.btnChon = new GUI.Nhang_CustomControls.NhangButton();
            this.picAnh = new GUI.Nhang_CustomControls.NhangCircularPictureBox();
            this.btnInAn = new GUI.Nhang_CustomControls.NhangButton();
            this.btnLoad = new GUI.Nhang_CustomControls.NhangButton();
            this.btnMoi = new GUI.Nhang_CustomControls.NhangButton();
            this.btnXoa = new GUI.Nhang_CustomControls.NhangButton();
            this.btnSua = new GUI.Nhang_CustomControls.NhangButton();
            this.btnThem = new GUI.Nhang_CustomControls.NhangButton();
            this.txtTimKiemTen = new GUI.Nhang_CustomControls.NhangTextBox();
            this.txtTimKiemMa = new GUI.Nhang_CustomControls.NhangTextBox();
            this.txtSDT = new GUI.Nhang_CustomControls.NhangTextBox();
            this.txtDiaChi = new GUI.Nhang_CustomControls.NhangTextBox();
            this.txtAnh = new GUI.Nhang_CustomControls.NhangTextBox();
            this.dtpNgaySinh = new GUI.Nhang_CustomControls.NhangDateTimePicker();
            this.txtTenHS = new GUI.Nhang_CustomControls.NhangTextBox();
            this.txtMaHS = new GUI.Nhang_CustomControls.NhangTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHocSinh
            // 
            this.dgvHocSinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocSinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHocSinh.Location = new System.Drawing.Point(0, 326);
            this.dgvHocSinh.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHocSinh.Name = "dgvHocSinh";
            this.dgvHocSinh.RowHeadersWidth = 62;
            this.dgvHocSinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHocSinh.Size = new System.Drawing.Size(1361, 221);
            this.dgvHocSinh.TabIndex = 1;
            this.dgvHocSinh.Click += new System.EventHandler(this.dgvHocSinh_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.btnChon);
            this.panel1.Controls.Add(this.picAnh);
            this.panel1.Controls.Add(this.btnInAn);
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.btnMoi);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.txtTimKiemTen);
            this.panel1.Controls.Add(this.txtTimKiemMa);
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.txtAnh);
            this.panel1.Controls.Add(this.dtpNgaySinh);
            this.panel1.Controls.Add(this.txtTenHS);
            this.panel1.Controls.Add(this.txtMaHS);
            this.panel1.Controls.Add(this.radNu);
            this.panel1.Controls.Add(this.radNam);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cboQueQuan);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1361, 326);
            this.panel1.TabIndex = 0;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.radNu.Location = new System.Drawing.Point(759, 166);
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
            this.radNam.Location = new System.Drawing.Point(695, 166);
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
            this.label10.Location = new System.Drawing.Point(28, 279);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tìm kiếm";
            // 
            // cboQueQuan
            // 
            this.cboQueQuan.FormattingEnabled = true;
            this.cboQueQuan.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboQueQuan.Location = new System.Drawing.Point(694, 207);
            this.cboQueQuan.Name = "cboQueQuan";
            this.cboQueQuan.Size = new System.Drawing.Size(143, 24);
            this.cboQueQuan.TabIndex = 10;
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
            this.label5.Location = new System.Drawing.Point(28, 168);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày Sinh";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1020, 249);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Hình Ảnh Học Sinh";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(28, 231);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Hình Ảnh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Học Sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Học Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(519, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(334, 38);
            this.label4.TabIndex = 0;
            this.label4.Text = "QUẢN LÍ HỌC SINH";
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
            this.btnTimKiem.Location = new System.Drawing.Point(733, 271);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(104, 39);
            this.btnTimKiem.TabIndex = 19;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextColor = System.Drawing.Color.Black;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
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
            this.btnChon.Location = new System.Drawing.Point(1040, 271);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(104, 39);
            this.btnChon.TabIndex = 12;
            this.btnChon.Text = "Chọn Ảnh";
            this.btnChon.TextColor = System.Drawing.Color.Black;
            this.btnChon.UseVisualStyleBackColor = false;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click_1);
            // 
            // picAnh
            // 
            this.picAnh.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.picAnh.BorderColor = System.Drawing.Color.RoyalBlue;
            this.picAnh.BorderColor2 = System.Drawing.Color.HotPink;
            this.picAnh.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.picAnh.BorderSize = 2;
            this.picAnh.GradientAngle = 50F;
            this.picAnh.Location = new System.Drawing.Point(1013, 66);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(143, 143);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnh.TabIndex = 97;
            this.picAnh.TabStop = false;
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
            this.btnInAn.Location = new System.Drawing.Point(1244, 27);
            this.btnInAn.Name = "btnInAn";
            this.btnInAn.Size = new System.Drawing.Size(104, 39);
            this.btnInAn.TabIndex = 18;
            this.btnInAn.Text = "In Ấn";
            this.btnInAn.TextColor = System.Drawing.Color.White;
            this.btnInAn.UseVisualStyleBackColor = false;
            this.btnInAn.Click += new System.EventHandler(this.btnInAn_Click);
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
            this.btnLoad.Location = new System.Drawing.Point(1244, 72);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(104, 39);
            this.btnLoad.TabIndex = 17;
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
            this.btnMoi.Location = new System.Drawing.Point(1245, 112);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(104, 39);
            this.btnMoi.TabIndex = 16;
            this.btnMoi.Text = "Tạo mới";
            this.btnMoi.TextColor = System.Drawing.Color.White;
            this.btnMoi.UseVisualStyleBackColor = false;
            this.btnMoi.Click += new System.EventHandler(this.btnMoi_Click_1);
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
            this.btnXoa.Location = new System.Drawing.Point(1244, 241);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(104, 39);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextColor = System.Drawing.Color.White;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
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
            this.btnSua.Location = new System.Drawing.Point(1244, 199);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(104, 39);
            this.btnSua.TabIndex = 14;
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
            this.btnThem.Location = new System.Drawing.Point(1244, 157);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(104, 39);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextColor = System.Drawing.Color.White;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
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
            this.txtTimKiemTen.Location = new System.Drawing.Point(442, 279);
            this.txtTimKiemTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiemTen.Multiline = false;
            this.txtTimKiemTen.Name = "txtTimKiemTen";
            this.txtTimKiemTen.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTimKiemTen.PasswordChar = false;
            this.txtTimKiemTen.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTimKiemTen.PlaceholderText = "";
            this.txtTimKiemTen.Size = new System.Drawing.Size(250, 35);
            this.txtTimKiemTen.TabIndex = 11;
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
            this.txtTimKiemMa.Location = new System.Drawing.Point(167, 279);
            this.txtTimKiemMa.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiemMa.Multiline = false;
            this.txtTimKiemMa.Name = "txtTimKiemMa";
            this.txtTimKiemMa.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTimKiemMa.PasswordChar = false;
            this.txtTimKiemMa.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTimKiemMa.PlaceholderText = "";
            this.txtTimKiemMa.Size = new System.Drawing.Size(250, 35);
            this.txtTimKiemMa.TabIndex = 5;
            this.txtTimKiemMa.UnderlinedStyle = false;
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
            this.txtSDT.Location = new System.Drawing.Point(694, 117);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Multiline = false;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSDT.PasswordChar = false;
            this.txtSDT.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSDT.PlaceholderText = "";
            this.txtSDT.Size = new System.Drawing.Size(250, 35);
            this.txtSDT.TabIndex = 7;
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
            this.txtDiaChi.Location = new System.Drawing.Point(695, 74);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Multiline = false;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDiaChi.PasswordChar = false;
            this.txtDiaChi.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDiaChi.PlaceholderText = "";
            this.txtDiaChi.Size = new System.Drawing.Size(250, 35);
            this.txtDiaChi.TabIndex = 6;
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
            this.txtAnh.Location = new System.Drawing.Point(168, 216);
            this.txtAnh.Margin = new System.Windows.Forms.Padding(4);
            this.txtAnh.Multiline = false;
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtAnh.PasswordChar = false;
            this.txtAnh.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAnh.PlaceholderText = "";
            this.txtAnh.Size = new System.Drawing.Size(250, 35);
            this.txtAnh.TabIndex = 4;
            this.txtAnh.UnderlinedStyle = false;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtpNgaySinh.BorderSize = 0;
            this.dtpNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dtpNgaySinh.Location = new System.Drawing.Point(168, 174);
            this.dtpNgaySinh.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(250, 35);
            this.dtpNgaySinh.SkinColor = System.Drawing.Color.RoyalBlue;
            this.dtpNgaySinh.TabIndex = 3;
            this.dtpNgaySinh.TextColor = System.Drawing.Color.White;
            // 
            // txtTenHS
            // 
            this.txtTenHS.BackColor = System.Drawing.SystemColors.Window;
            this.txtTenHS.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTenHS.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTenHS.BorderRadius = 15;
            this.txtTenHS.BorderSize = 1;
            this.txtTenHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTenHS.Location = new System.Drawing.Point(168, 123);
            this.txtTenHS.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenHS.Multiline = false;
            this.txtTenHS.Name = "txtTenHS";
            this.txtTenHS.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTenHS.PasswordChar = false;
            this.txtTenHS.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTenHS.PlaceholderText = "";
            this.txtTenHS.Size = new System.Drawing.Size(250, 35);
            this.txtTenHS.TabIndex = 2;
            this.txtTenHS.UnderlinedStyle = false;
            // 
            // txtMaHS
            // 
            this.txtMaHS.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaHS.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMaHS.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMaHS.BorderRadius = 15;
            this.txtMaHS.BorderSize = 1;
            this.txtMaHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMaHS.Location = new System.Drawing.Point(168, 74);
            this.txtMaHS.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHS.Multiline = false;
            this.txtMaHS.Name = "txtMaHS";
            this.txtMaHS.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMaHS.PasswordChar = false;
            this.txtMaHS.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaHS.PlaceholderText = "";
            this.txtMaHS.Size = new System.Drawing.Size(250, 35);
            this.txtMaHS.TabIndex = 1;
            this.txtMaHS.UnderlinedStyle = false;
            // 
            // frmHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 547);
            this.Controls.Add(this.dgvHocSinh);
            this.Controls.Add(this.panel1);
            this.Name = "frmHocSinh";
            this.Text = "Học Sinh";
            this.Load += new System.EventHandler(this.frmHocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvHocSinh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboQueQuan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.Label label11;
        private Nhang_CustomControls.NhangTextBox txtAnh;
        private Nhang_CustomControls.NhangDateTimePicker dtpNgaySinh;
        private Nhang_CustomControls.NhangTextBox txtTenHS;
        private Nhang_CustomControls.NhangTextBox txtMaHS;
        private Nhang_CustomControls.NhangTextBox txtTimKiemTen;
        private Nhang_CustomControls.NhangTextBox txtTimKiemMa;
        private Nhang_CustomControls.NhangTextBox txtSDT;
        private Nhang_CustomControls.NhangTextBox txtDiaChi;
        private Nhang_CustomControls.NhangButton btnSua;
        private Nhang_CustomControls.NhangButton btnXoa;
        private Nhang_CustomControls.NhangButton btnMoi;
        private Nhang_CustomControls.NhangButton btnThem;
        private Nhang_CustomControls.NhangButton btnLoad;
        private Nhang_CustomControls.NhangButton btnInAn;
        private Nhang_CustomControls.NhangButton btnChon;
        private Nhang_CustomControls.NhangCircularPictureBox picAnh;
        private Nhang_CustomControls.NhangButton btnTimKiem;
    }
}