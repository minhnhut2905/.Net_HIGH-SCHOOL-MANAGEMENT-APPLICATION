namespace GUI
{
    partial class frmInBangDiemHK2
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QuanLyTruongHocDataSet = new GUI.QuanLyTruongHocDataSet();
            this.bangDiemHK2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bangDiem_HK2TableAdapter = new GUI.QuanLyTruongHocDataSetTableAdapters.BangDiem_HK2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyTruongHocDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangDiemHK2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.bangDiemHK2BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ReportBangDiemHK2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // quanLyTruongHocDataSet1
            // 
            this.QuanLyTruongHocDataSet.DataSetName = "QuanLyTruongHocDataSet1";
            this.QuanLyTruongHocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bangDiemHK2BindingSource
            // 
            this.bangDiemHK2BindingSource.DataMember = "BangDiem_HK2";
            this.bangDiemHK2BindingSource.DataSource = this.QuanLyTruongHocDataSet;
            // 
            // bangDiem_HK2TableAdapter
            // 
            this.bangDiem_HK2TableAdapter.ClearBeforeFill = true;
            // 
            // frmInBangDiemHK2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmInBangDiemHK2";
            this.Text = "Bảng Điểm HK2";
            this.Load += new System.EventHandler(this.frmInBangDiemHK2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyTruongHocDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangDiemHK2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QuanLyTruongHocDataSet QuanLyTruongHocDataSet;
        private System.Windows.Forms.BindingSource bangDiemHK2BindingSource;
        private QuanLyTruongHocDataSetTableAdapters.BangDiem_HK2TableAdapter bangDiem_HK2TableAdapter;
    }
}