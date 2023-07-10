namespace GUI
{
    partial class frmReportGiangVien
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.giangVienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyTruongHocDataSet = new GUI.QuanLyTruongHocDataSet();
            this.giangVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rpViewGiangVien = new Microsoft.Reporting.WinForms.ReportViewer();
            this.giangVienTableAdapter = new GUI.QuanLyTruongHocDataSetTableAdapters.GiangVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyTruongHocDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // giangVienBindingSource1
            // 
            this.giangVienBindingSource1.DataMember = "GiangVien";
            this.giangVienBindingSource1.DataSource = this.quanLyTruongHocDataSet;
            // 
            // quanLyTruongHocDataSet
            // 
            this.quanLyTruongHocDataSet.DataSetName = "QuanLyTruongHocDataSet1";
            this.quanLyTruongHocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // giangVienBindingSource
            // 
            this.giangVienBindingSource.DataMember = "GiangVien";
            this.giangVienBindingSource.DataSource = this.quanLyTruongHocDataSet;
            // 
            // rpViewGiangVien
            // 
            this.rpViewGiangVien.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.giangVienBindingSource1;
            this.rpViewGiangVien.LocalReport.DataSources.Add(reportDataSource1);
            this.rpViewGiangVien.LocalReport.ReportEmbeddedResource = "GUI.ReportGiangVien.rdlc";
            this.rpViewGiangVien.Location = new System.Drawing.Point(0, 0);
            this.rpViewGiangVien.Name = "rpViewGiangVien";
            this.rpViewGiangVien.ServerReport.BearerToken = null;
            this.rpViewGiangVien.Size = new System.Drawing.Size(800, 450);
            this.rpViewGiangVien.TabIndex = 0;
            // 
            // giangVienTableAdapter
            // 
            this.giangVienTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpViewGiangVien);
            this.Name = "frmReportGiangVien";
            this.Text = "Danh Sách Giảng Viên";
            this.Load += new System.EventHandler(this.frmReportGiangVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.giangVienBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyTruongHocDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpViewGiangVien;
        private QuanLyTruongHocDataSet quanLyTruongHocDataSet;
        private System.Windows.Forms.BindingSource giangVienBindingSource;
        private QuanLyTruongHocDataSetTableAdapters.GiangVienTableAdapter giangVienTableAdapter;
        private System.Windows.Forms.BindingSource giangVienBindingSource1;
    }
}