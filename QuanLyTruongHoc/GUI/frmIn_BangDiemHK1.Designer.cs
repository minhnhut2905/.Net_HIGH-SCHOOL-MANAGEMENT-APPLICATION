namespace GUI
{
    partial class frmIn_BangDiemHK1
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
            this.quanLyTruongHocDataSet = new GUI.QuanLyTruongHocDataSet();
            this.bangDiem_HK1TableAdapter = new GUI.QuanLyTruongHocDataSetTableAdapters.BangDiem_HK1TableAdapter();
            this.bangDiemHK1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyTruongHocDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangDiemHK1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.bangDiemHK1BindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ReportBangDiemHK1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // quanLyTruongHocDataSet1
            // 
            this.quanLyTruongHocDataSet.DataSetName = "QuanLyTruongHocDataSet1";
            this.quanLyTruongHocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bangDiem_HK1TableAdapter
            // 
            this.bangDiem_HK1TableAdapter.ClearBeforeFill = true;
            // 
            // bangDiemHK1BindingSource1
            // 
            this.bangDiemHK1BindingSource1.DataMember = "BangDiem_HK1";
            this.bangDiemHK1BindingSource1.DataSource = this.quanLyTruongHocDataSet;
            // 
            // frmIn_BangDiemHK1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmIn_BangDiemHK1";
            this.Text = "frmIn_BangDiemHK1";
            this.Load += new System.EventHandler(this.frmIn_BangDiemHK1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyTruongHocDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangDiemHK1BindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private QuanLyTruongHocDataSet quanLyTruongHocDataSet;
        private QuanLyTruongHocDataSetTableAdapters.BangDiem_HK1TableAdapter bangDiem_HK1TableAdapter;
        private System.Windows.Forms.BindingSource bangDiemHK1BindingSource1;
    }
}