using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;

namespace GUI
{
    public partial class frmReportGiangVien : Form
    {
        public frmReportGiangVien()
        {
            InitializeComponent();
        }

        private void frmReportGiangVien_Load(object sender, EventArgs e)
        {
            /*
            this.giangVienTableAdapter.Fill(this.quanLyTruongHocDataSet.GiangVien);
            List<GiangVienDTO> lstGiangVien = GiangVienBUS.LayDSGiangVien();
            giangVienBindingSource.DataSource = lstGiangVien;
            this.rpViewGiangVien.RefreshReport();
            */
            
            List<GiangVienDTO> lstGiangVien = GiangVienBUS.LayDSGiangVien();
            this.rpViewGiangVien.LocalReport.ReportPath = "ReportGiangVien.rdlc";

            ReportDataSource reportDataSource = new ReportDataSource("DataSet2", lstGiangVien);
            rpViewGiangVien.LocalReport.DataSources.Clear();
            rpViewGiangVien.LocalReport.DataSources.Add(reportDataSource);
            this.rpViewGiangVien.RefreshReport();
            
        }
    }
}
