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
using Microsoft.Reporting.WinForms;

namespace GUI
{
    public partial class frmIn_BangDiemHK1 : Form
    {
        public frmIn_BangDiemHK1()
        {
            InitializeComponent();
        }

        private void frmIn_BangDiemHK1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyTruongHocDataSet1.BangDiem_HK1' table. You can move, or remove it, as needed.
            //this.bangDiem_HK1TableAdapter.Fill(this.quanLyTruongHocDataSet1.BangDiem_HK1);
            /*
            List<BangDiemHK1_DTO> list = BangDiem_Hk1_BUS.LayDSBangDiemHK1();
            bangDiemHK1BindingSource1.DataSource = list;
            this.reportViewer1.RefreshReport();
            */
            List<BangDiemHK1_DTO> list = BangDiem_Hk1_BUS.LayDSBangDiemHK1();
            this.reportViewer1.LocalReport.ReportPath = "ReportBangDiemHK1.rdlc";

            ReportDataSource reportDataSource = new ReportDataSource("DataSet1", list);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
