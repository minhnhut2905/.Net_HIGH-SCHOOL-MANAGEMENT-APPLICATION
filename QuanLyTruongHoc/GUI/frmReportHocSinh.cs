using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using System.Collections;

namespace GUI
{
    public partial class frmReportHocSinh : Form
    {
        public frmReportHocSinh()
        {
            InitializeComponent(); 
        }
        
        private void frmReportHocSinh_Load(object sender, EventArgs e)
        {
            
            List<HocSinhDTO> _lstHocSinh = HocSinhBUS.ReportHocSinh();
            this.reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            ReportDataSource reportDataSource= new ReportDataSource("HocSinhDataSet", _lstHocSinh);
            hocSinhBindingSource.DataSource = _lstHocSinh;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            
            this.reportViewer1.RefreshReport();  
            
        }


    }
}
