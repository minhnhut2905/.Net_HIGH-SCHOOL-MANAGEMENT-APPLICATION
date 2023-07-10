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
namespace GUI
{
    public partial class frmInBangDiemHK2 : Form
    {
        public frmInBangDiemHK2()
        {
            InitializeComponent();
        }

        private void frmInBangDiemHK2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyTruongHocDataSet1.BangDiem_HK2' table. You can move, or remove it, as needed.
            //this.bangDiem_HK2TableAdapter.Fill(this.quanLyTruongHocDataSet1.BangDiem_HK2);
            List<BangDiemHK2_DTO> list = BangDiemHK2_BUS.LayDSBangDiemHK2();
            bangDiemHK2BindingSource.DataSource = list;
            this.reportViewer1.RefreshReport();
        }
    }
}
