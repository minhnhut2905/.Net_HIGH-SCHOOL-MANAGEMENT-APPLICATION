namespace GUI
{
    partial class frmThongTinCaNhan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAnh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuyenHan = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDoiMK = new System.Windows.Forms.Button();
            this.picAnh = new GUI.Nhang_CustomControls.NhangCircularPictureBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(135, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN CÁ NHÂN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Đăng Nhập";
            // 
            // txtTenDN
            // 
            this.txtTenDN.Location = new System.Drawing.Point(170, 55);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(204, 22);
            this.txtTenDN.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ Và Tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(170, 96);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(204, 22);
            this.txtHoTen.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mật Khẩu";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(170, 140);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(204, 22);
            this.txtMatKhau.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Hình Ảnh";
            // 
            // txtAnh
            // 
            this.txtAnh.Location = new System.Drawing.Point(170, 186);
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.Size = new System.Drawing.Size(204, 22);
            this.txtAnh.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Quyền Hạn";
            // 
            // txtQuyenHan
            // 
            this.txtQuyenHan.Location = new System.Drawing.Point(170, 226);
            this.txtQuyenHan.Name = "txtQuyenHan";
            this.txtQuyenHan.Size = new System.Drawing.Size(204, 22);
            this.txtQuyenHan.TabIndex = 2;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Red;
            this.btnThoat.Image = global::GUI.Properties.Resources.exit16;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(413, 307);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(117, 37);
            this.btnThoat.TabIndex = 82;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.ForeColor = System.Drawing.Color.Black;
            this.btnDoiMK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoiMK.Location = new System.Drawing.Point(75, 307);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(145, 37);
            this.btnDoiMK.TabIndex = 84;
            this.btnDoiMK.Text = "Đổi Mật Khẩu";
            this.btnDoiMK.UseVisualStyleBackColor = true;
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // picAnh
            // 
            this.picAnh.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.picAnh.BorderColor = System.Drawing.Color.RoyalBlue;
            this.picAnh.BorderColor2 = System.Drawing.Color.HotPink;
            this.picAnh.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.picAnh.BorderSize = 2;
            this.picAnh.GradientAngle = 50F;
            this.picAnh.Location = new System.Drawing.Point(466, 19);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(143, 143);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnh.TabIndex = 102;
            this.picAnh.TabStop = false;
            // 
            // btnChon
            // 
            this.btnChon.ForeColor = System.Drawing.Color.Black;
            this.btnChon.Image = global::GUI.Properties.Resources.view16;
            this.btnChon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChon.Location = new System.Drawing.Point(478, 180);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(120, 35);
            this.btnChon.TabIndex = 101;
            this.btnChon.Text = "Chọn Ảnh";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::GUI.Properties.Resources.edit16;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(270, 307);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(104, 37);
            this.btnLuu.TabIndex = 103;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmThongTinCaNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 379);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.picAnh);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.btnDoiMK);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtQuyenHan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAnh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenDN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmThongTinCaNhan";
            this.Text = "Thông Tin Cá Nhân";
            this.Load += new System.EventHandler(this.frmThongTinCaNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAnh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQuyenHan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDoiMK;
        private Nhang_CustomControls.NhangCircularPictureBox picAnh;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnLuu;
    }
}