namespace GUI
{
    partial class frmDoiMatKhau
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
            this.label3 = new System.Windows.Forms.Label();
            this.ckbPass = new System.Windows.Forms.CheckBox();
            this.txtMKMoi = new System.Windows.Forms.TextBox();
            this.txtMKCu = new System.Windows.Forms.TextBox();
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.btnDoiMK = new GUI.Nhang_CustomControls.NhangButton();
            this.btnHuy = new GUI.Nhang_CustomControls.NhangButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu cũ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật khẩu mới:";
            // 
            // ckbPass
            // 
            this.ckbPass.AutoSize = true;
            this.ckbPass.Location = new System.Drawing.Point(123, 238);
            this.ckbPass.Name = "ckbPass";
            this.ckbPass.Size = new System.Drawing.Size(130, 20);
            this.ckbPass.TabIndex = 4;
            this.ckbPass.Text = "Hiển thị mật khẩu";
            this.ckbPass.UseVisualStyleBackColor = true;
            this.ckbPass.CheckedChanged += new System.EventHandler(this.ckbPass_CheckedChanged);
            // 
            // txtMKMoi
            // 
            this.txtMKMoi.Location = new System.Drawing.Point(160, 192);
            this.txtMKMoi.Name = "txtMKMoi";
            this.txtMKMoi.Size = new System.Drawing.Size(173, 22);
            this.txtMKMoi.TabIndex = 3;
            // 
            // txtMKCu
            // 
            this.txtMKCu.Location = new System.Drawing.Point(160, 133);
            this.txtMKCu.Name = "txtMKCu";
            this.txtMKCu.Size = new System.Drawing.Size(173, 22);
            this.txtMKCu.TabIndex = 2;
            // 
            // txtTenTK
            // 
            this.txtTenTK.Location = new System.Drawing.Point(160, 74);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(173, 22);
            this.txtTenTK.TabIndex = 1;
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDoiMK.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnDoiMK.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDoiMK.BorderRadius = 10;
            this.btnDoiMK.BorderSize = 0;
            this.btnDoiMK.FlatAppearance.BorderSize = 0;
            this.btnDoiMK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMK.ForeColor = System.Drawing.Color.White;
            this.btnDoiMK.Location = new System.Drawing.Point(36, 279);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(104, 39);
            this.btnDoiMK.TabIndex = 108;
            this.btnDoiMK.Text = "Đồng ý";
            this.btnDoiMK.TextColor = System.Drawing.Color.White;
            this.btnDoiMK.UseVisualStyleBackColor = false;
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click_1);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Red;
            this.btnHuy.BackgroundColor = System.Drawing.Color.Red;
            this.btnHuy.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnHuy.BorderRadius = 10;
            this.btnHuy.BorderSize = 0;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(177, 279);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(104, 39);
            this.btnHuy.TabIndex = 109;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextColor = System.Drawing.Color.White;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 364);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDoiMK);
            this.Controls.Add(this.ckbPass);
            this.Controls.Add(this.txtMKMoi);
            this.Controls.Add(this.txtMKCu);
            this.Controls.Add(this.txtTenTK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDoiMatKhau";
            this.Text = "Đổi Mật Khẩu";
            this.Load += new System.EventHandler(this.frmDoiMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckbPass;
        private System.Windows.Forms.TextBox txtMKMoi;
        private System.Windows.Forms.TextBox txtMKCu;
        private System.Windows.Forms.TextBox txtTenTK;
        private Nhang_CustomControls.NhangButton btnDoiMK;
        private Nhang_CustomControls.NhangButton btnHuy;
    }
}