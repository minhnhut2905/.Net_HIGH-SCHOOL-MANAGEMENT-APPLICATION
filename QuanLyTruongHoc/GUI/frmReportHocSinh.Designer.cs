namespace GUI
{
    partial class frmReportHocSinh
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.hocSinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.hocSinhTableAdapter = new GUI.QuanLyTruongHocDataSetTableAdapters.HocSinhTableAdapter();
            this.HocSinhDataSet = new GUI.QuanLyTruongHocDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.hocSinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HocSinhDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "HocSinhDataSet";
            reportDataSource2.Value = this.hocSinhBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // hocSinhTableAdapter
            // 
            this.hocSinhTableAdapter.ClearBeforeFill = true;
            // 
            // HocSinhDataSet
            // 
            this.HocSinhDataSet.DataSetName = "QuanLyTruongHocDataSet";
            this.HocSinhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmReportHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReportHocSinh";
            this.Text = "Danh Sách Học Sinh";
            this.Load += new System.EventHandler(this.frmReportHocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hocSinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HocSinhDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource hocSinhBindingSource;
        private QuanLyTruongHocDataSetTableAdapters.HocSinhTableAdapter hocSinhTableAdapter;
        private QuanLyTruongHocDataSet HocSinhDataSet;
    }
}