namespace GUI
{
    partial class frmLuongGV
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
            this.dgvLuongGV = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnMoi = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTimKiemMa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboMaGV = new System.Windows.Forms.ComboBox();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHSLuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuongGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLuongGV
            // 
            this.dgvLuongGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLuongGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLuongGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLuongGV.Location = new System.Drawing.Point(0, 387);
            this.dgvLuongGV.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLuongGV.Name = "dgvLuongGV";
            this.dgvLuongGV.RowHeadersWidth = 62;
            this.dgvLuongGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLuongGV.Size = new System.Drawing.Size(656, 140);
            this.dgvLuongGV.TabIndex = 3;
            this.dgvLuongGV.Click += new System.EventHandler(this.dgvLuongGV_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.txtGhiChu);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnMoi);
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Controls.Add(this.txtTimKiemMa);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cboMaGV);
            this.panel1.Controls.Add(this.dtpNgayBD);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtHSLuong);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 387);
            this.panel1.TabIndex = 2;
            // 
            // btnLoad
            // 
            this.btnLoad.Image = global::GUI.Properties.Resources.refresh161;
            this.btnLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoad.Location = new System.Drawing.Point(504, 275);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(104, 37);
            this.btnLoad.TabIndex = 83;
            this.btnLoad.Text = "Bỏ qua";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(168, 204);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(263, 137);
            this.txtGhiChu.TabIndex = 20;
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::GUI.Properties.Resources.exit16;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(504, 232);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(104, 37);
            this.btnThoat.TabIndex = 18;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnMoi
            // 
            this.btnMoi.Image = global::GUI.Properties.Resources.pxnoitru;
            this.btnMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoi.Location = new System.Drawing.Point(504, 68);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(104, 37);
            this.btnMoi.TabIndex = 14;
            this.btnMoi.Text = "Mới";
            this.btnMoi.UseVisualStyleBackColor = true;
            this.btnMoi.Click += new System.EventHandler(this.btnMoi_Click);
            // 
            // btnTim
            // 
            this.btnTim.Image = global::GUI.Properties.Resources.view16;
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.Location = new System.Drawing.Point(504, 341);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(125, 28);
            this.btnTim.TabIndex = 19;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTimKiemMa
            // 
            this.txtTimKiemMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtTimKiemMa.Location = new System.Drawing.Point(260, 348);
            this.txtTimKiemMa.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiemMa.Name = "txtTimKiemMa";
            this.txtTimKiemMa.Size = new System.Drawing.Size(171, 23);
            this.txtTimKiemMa.TabIndex = 17;
            this.txtTimKiemMa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 349);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(229, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tìm kiếm theo Mã Giảng Viên";
            // 
            // cboMaGV
            // 
            this.cboMaGV.FormattingEnabled = true;
            this.cboMaGV.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboMaGV.Location = new System.Drawing.Point(168, 81);
            this.cboMaGV.Name = "cboMaGV";
            this.cboMaGV.Size = new System.Drawing.Size(263, 24);
            this.cboMaGV.TabIndex = 4;
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.Checked = false;
            this.dtpNgayBD.CustomFormat = "M-dd-yyyy";
            this.dtpNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBD.Location = new System.Drawing.Point(168, 164);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(263, 22);
            this.dtpNgayBD.TabIndex = 3;
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::GUI.Properties.Resources.delete16;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(504, 191);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(104, 37);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ghi Chú";
            // 
            // txtHSLuong
            // 
            this.txtHSLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtHSLuong.Location = new System.Drawing.Point(168, 122);
            this.txtHSLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtHSLuong.Name = "txtHSLuong";
            this.txtHSLuong.Size = new System.Drawing.Size(263, 23);
            this.txtHSLuong.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 165);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày Bắt Đầu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hệ số lương";
            // 
            // btnSua
            // 
            this.btnSua.Image = global::GUI.Properties.Resources.edit16;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(504, 150);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(104, 37);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = global::GUI.Properties.Resources.add16;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(504, 109);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(104, 37);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Giảng Viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(86, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(499, 38);
            this.label4.TabIndex = 0;
            this.label4.Text = "QUẢN LÍ LƯƠNG GIẢNG VIÊN";
            // 
            // frmLuongGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 527);
            this.Controls.Add(this.dgvLuongGV);
            this.Controls.Add(this.panel1);
            this.Name = "frmLuongGV";
            this.Text = "Quá Trình Lương Giảng Viên";
            this.Load += new System.EventHandler(this.frmLuongGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuongGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLuongGV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnMoi;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTimKiemMa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboMaGV;
        private System.Windows.Forms.DateTimePicker dtpNgayBD;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHSLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnLoad;
    }
}