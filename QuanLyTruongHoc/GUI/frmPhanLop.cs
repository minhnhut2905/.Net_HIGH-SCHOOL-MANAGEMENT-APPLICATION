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
using System.Data.SqlClient;

namespace GUI
{
    public partial class frmPhanLop : Form
    {
        public frmPhanLop()
        {
            InitializeComponent();
        }
        #region Các nút chức năng
        private void btnNew_Click(object sender, EventArgs e)
        {
            cboMaHS.Text = "";
            cboMaLop.Text = "";
            dtpNamHoc.Text = "";
            txtTimKiemMaHS.Text = "";
            txtTimKiemMaLop.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Kiểm tra dữ liệu có bị bỏ trống không?
            if (cboMaHS.Text == "" || cboMaLop.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Kiểm tra mã học sinh có độ dài chuỗi hợp lệ hay không?
            //if (cboMaHS.Text.Length > 6)
            //{
                //MessageBox.Show("Mã học sinh tối đa có 6 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
               // return;
            //}
            PhanLopDTO pl = new PhanLopDTO();
            pl.SMaHocSinh = cboMaHS.SelectedValue.ToString();
            pl.SMaLop = cboMaLop.SelectedValue.ToString();
            pl.DtNamHoc = DateTime.Parse(dtpNamHoc.Text);

            if (PhanLopBUS.ThemPhanLop(pl) == false)
            {
                MessageBox.Show("Không tìm được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HienThiDSPhanLopLenDatagrid();
            MessageBox.Show("Đã thêm phân lớp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //Kiểm tra dữ liệu có bị bỏ trống không?
            if (cboMaHS.SelectedValue.ToString() == "" || cboMaLop.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra mã học sinh có bị trùng hay không?
            if (PhanLopBUS.TimPhanLopTheoMa(cboMaHS.SelectedValue.ToString()) == null)
            {
                MessageBox.Show("Không tồn tại mã học sinh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Gán giá trị vào PhanLopDTO(), thực hiện sửa PhanLopDTO
            PhanLopDTO pl = new PhanLopDTO();
            pl.SMaHocSinh = cboMaHS.SelectedValue.ToString();
            pl.SMaLop = cboMaLop.SelectedValue.ToString();
            pl.DtNamHoc = DateTime.Parse(dtpNamHoc.Text);

            if (PhanLopBUS.SuaPhanLop(pl) == false)
            {
                MessageBox.Show("Chưa cập nhật được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HienThiDSPhanLopLenDatagrid();
            MessageBox.Show("Đã cập nhật phân lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            // Kiểm tra mã học sinh có tồn tại hay không? Nếu không thì không xóa.
            if (PhanLopBUS.TimPhanLopTheoMa(cboMaHS.SelectedValue.ToString()) == null)
            {
                MessageBox.Show("Không tồn tại mã học sinh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Gán giá trị vào PhanLopDTO(), thực hiện sửa PhanLopDTO.
            PhanLopDTO pl = new PhanLopDTO();
            pl.SMaHocSinh = cboMaHS.SelectedValue.ToString();

            if (PhanLopBUS.XoaPhanLop(pl) == false)
            {
                MessageBox.Show("Chưa xóa được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HienThiDSPhanLopLenDatagrid();
            MessageBox.Show("Đã xóa học sinh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void LayDuLieuMa(string Tim)
        {
            SqlCommand cmd = new SqlCommand(@"SELECT * FROM PhanLop WHERE MaHocSinh LIKE N'%" + Tim + "%' OR MaLop LIKE N'%" + Tim + "%'");

        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            List<PhanLopDTO> ds = PhanLopBUS.LayDSPhanLop();
            List<PhanLopDTO> result = (from pl in ds
                                      where pl.SMaHocSinh.Contains(txtTimKiemMaHS.Text)
                                      where pl.SMaLop.Contains(txtTimKiemMaLop.Text)
                                      select pl).ToList();
            dgvPhanLop.DataSource = result;       
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            frmPhanLop_Load(sender, e);
        }

        private void txtTimKiemMa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTim_Click(sender, e);
            }
        }

        private void txtTimKiemTen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTim_Click(sender, e);
            }
        }
        #endregion
        #region Xử lý dữ liệu
        private void HienThiHocSinhLenCombobox()
        {
            List<HocSinhDTO> lstHocSinh = HocSinhBUS.LayDSHocSinh();
            cboMaHS.DataSource = lstHocSinh;
            cboMaHS.DisplayMember = "STenHS";
            cboMaHS.ValueMember = "SMaHS";
        }
        private void HienThiLopHocLenCombobox()
        {
            List<LopHocDTO> lstLopHoc = LopHocBUS.LayDSLopHoc();
            cboMaLop.DataSource = lstLopHoc;
            cboMaLop.DisplayMember = "STenLop";
            cboMaLop.ValueMember = "SMaLop";
        }
        // Load dữ liệu lên dgv
        private void HienThiDSPhanLopLenDatagrid()
        {

            List<PhanLopDTO> lstPhanLop = PhanLopBUS.LayDSPhanLop();
            dgvPhanLop.DataSource = lstPhanLop;
            dgvPhanLop.Columns["SMaHocSinh"].HeaderText = "Tên học sinh";
            dgvPhanLop.Columns["SMaLop"].HeaderText = "Lớp";
            dgvPhanLop.Columns["DtNamHoc"].HeaderText = "Năm học";

            dgvPhanLop.Columns["SMaHocSinh"].Width = 60;
            dgvPhanLop.Columns["SMaLop"].Width = 60;
            dgvPhanLop.Columns["DtNamHoc"].Width = 60; 
        }
        private void frmPhanLop_Load(object sender, EventArgs e)
        {
            HienThiHocSinhLenCombobox();
            HienThiLopHocLenCombobox();
            HienThiDSPhanLopLenDatagrid();
            dgvPhanLop_Click(sender, e);
        }

        //Click 1 rows trên dgv thì nó sẽ load data lên controls.
        private void dgvPhanLop_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgvPhanLop.SelectedRows[0];
            cboMaHS.SelectedValue = r.Cells["SMaHocSinh"].Value.ToString();
            cboMaLop.SelectedValue = r.Cells["SMaLop"].Value.ToString();
            dtpNamHoc.Text = r.Cells["DtNamHoc"].Value.ToString();
        }
        #endregion

    }
}
