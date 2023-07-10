namespace GUI
{
    partial class frmPhanLop
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
            this.dgvPhanLop = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dtpNamHoc = new System.Windows.Forms.DateTimePicker();
            this.cboMaLop = new System.Windows.Forms.ComboBox();
            this.cboMaHS = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTimKiemMaLop = new System.Windows.Forms.TextBox();
            this.txtTimKiemMaHS = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanLop)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPhanLop
            // 
            this.dgvPhanLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhanLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhanLop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPhanLop.Location = new System.Drawing.Point(0, 313);
            this.dgvPhanLop.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPhanLop.Name = "dgvPhanLop";
            this.dgvPhanLop.RowHeadersWidth = 62;
            this.dgvPhanLop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhanLop.Size = new System.Drawing.Size(627, 137);
            this.dgvPhanLop.TabIndex = 1;
            this.dgvPhanLop.Click += new System.EventHandler(this.dgvPhanLop_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.dtpNamHoc);
            this.panel1.Controls.Add(this.cboMaLop);
            this.panel1.Controls.Add(this.cboMaHS);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Controls.Add(this.txtTimKiemMaLop);
            this.panel1.Controls.Add(this.txtTimKiemMaHS);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 306);
            this.panel1.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.Image = global::GUI.Properties.Resources.refresh161;
            this.btnLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoad.Location = new System.Drawing.Point(377, 81);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(95, 37);
            this.btnLoad.TabIndex = 82;
            this.btnLoad.Text = "Bỏ qua";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dtpNamHoc
            // 
            this.dtpNamHoc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNamHoc.Location = new System.Drawing.Point(168, 184);
            this.dtpNamHoc.Name = "dtpNamHoc";
            this.dtpNamHoc.Size = new System.Drawing.Size(202, 22);
            this.dtpNamHoc.TabIndex = 11;
            // 
            // cboMaLop
            // 
            this.cboMaLop.FormattingEnabled = true;
            this.cboMaLop.Location = new System.Drawing.Point(168, 129);
            this.cboMaLop.Name = "cboMaLop";
            this.cboMaLop.Size = new System.Drawing.Size(203, 24);
            this.cboMaLop.TabIndex = 10;
            // 
            // cboMaHS
            // 
            this.cboMaHS.FormattingEnabled = true;
            this.cboMaHS.Location = new System.Drawing.Point(168, 76);
            this.cboMaHS.Name = "cboMaHS";
            this.cboMaHS.Size = new System.Drawing.Size(203, 24);
            this.cboMaHS.TabIndex = 10;
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::GUI.Properties.Resources.exit16;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(490, 225);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(95, 38);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(377, 129);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(95, 38);
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "Làm mới";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnTim
            // 
            this.btnTim.Image = global::GUI.Properties.Resources.view16;
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.Location = new System.Drawing.Point(377, 224);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(95, 38);
            this.btnTim.TabIndex = 8;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTimKiemMaLop
            // 
            this.txtTimKiemMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtTimKiemMaLop.Location = new System.Drawing.Point(168, 264);
            this.txtTimKiemMaLop.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiemMaLop.Name = "txtTimKiemMaLop";
            this.txtTimKiemMaLop.Size = new System.Drawing.Size(201, 23);
            this.txtTimKiemMaLop.TabIndex = 3;
            this.txtTimKiemMaLop.Text = "Nhập mã lớp cần tìm";
            this.txtTimKiemMaLop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTimKiemMaLop.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiemTen_KeyDown);
            // 
            // txtTimKiemMaHS
            // 
            this.txtTimKiemMaHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtTimKiemMaHS.Location = new System.Drawing.Point(168, 233);
            this.txtTimKiemMaHS.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiemMaHS.Name = "txtTimKiemMaHS";
            this.txtTimKiemMaHS.Size = new System.Drawing.Size(201, 23);
            this.txtTimKiemMaHS.TabIndex = 3;
            this.txtTimKiemMaHS.Text = "Nhập mã học sinh cần tìm";
            this.txtTimKiemMaHS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTimKiemMaHS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiemMa_KeyDown);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::GUI.Properties.Resources.delete16;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(490, 178);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 38);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::GUI.Properties.Resources.edit16;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(490, 129);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(95, 38);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 184);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Năm học";
            // 
            // btnThem
            // 
            this.btnThem.Image = global::GUI.Properties.Resources.add16;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(377, 178);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 38);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 234);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên học sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(145, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(340, 38);
            this.label4.TabIndex = 0;
            this.label4.Text = "QUẢN LÍ PHÂN LỚP";
            // 
            // frmPhanLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvPhanLop);
            this.Name = "frmPhanLop";
            this.Text = "Phân Lớp";
            this.Load += new System.EventHandler(this.frmPhanLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanLop)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhanLop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTimKiemMaHS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMaLop;
        private System.Windows.Forms.ComboBox cboMaHS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNamHoc;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtTimKiemMaLop;
    }
}