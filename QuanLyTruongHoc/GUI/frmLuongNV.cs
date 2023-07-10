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
    public partial class frmLuongNV : Form
    {
        public frmLuongNV()
        {
            InitializeComponent();
        }
        #region Các nút chức năng
        private void btnMoi_Click(object sender, EventArgs e)
        {
            cboMaNV.Text = "";
            dtpNgayBD.Value = DateTime.Today;
            txtHSLuong.Text = "";
            txtGhiChu.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Kiểm tra dữ liệu có bị bỏ trống không?
            if (cboMaNV.SelectedValue.ToString() == "" || dtpNgayBD.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Kiểm tra mã chức vụ có độ dài chuỗi hợp lệ hay không?
            //if (cboMaGV.SelectedValue.ToString().Length > 4)
            //{
            //  MessageBox.Show("Mã giảng viên tối thiểu có 4 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //return;
            //}
            LuongNhanVien_DTO luong = new LuongNhanVien_DTO();
            luong.SMaNV = cboMaNV.SelectedValue.ToString();
            luong.DtNgayBD = DateTime.Parse(dtpNgayBD.Text);
            luong.FHSLuong = float.Parse(txtHSLuong.Text);
            luong.SGhiChu = txtGhiChu.Text;


            if (LuongNhanVien_BUS.ThemLuong(luong) == false)
            {
                MessageBox.Show("Không tìm được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HienThiDSLuongNhanVienLenDatagrid();
            MessageBox.Show("Đã thêm quá trình lương thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //Kiểm tra dữ liệu có bị bỏ trống không?
            if (cboMaNV.SelectedValue.ToString() == "" || dtpNgayBD.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra mã nhân viên có bị trùng hay không?
            if (LuongNhanVien_BUS.TimLuongTheoMa(cboMaNV.SelectedValue.ToString()) == null)
            {
                MessageBox.Show("Không tồn tại mã giảng viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Gán giá trị vào LuongNV_DTO(), thực hiện sửa LuongNV_DTO
            LuongNhanVien_DTO luong = new LuongNhanVien_DTO();
            luong.SMaNV = cboMaNV.SelectedValue.ToString();
            luong.DtNgayBD = DateTime.Parse(dtpNgayBD.Text);
            luong.FHSLuong = float.Parse(txtHSLuong.Text);
            luong.SGhiChu = txtGhiChu.Text;


            if (LuongNhanVien_BUS.SuaLuong(luong) == false)
            {
                MessageBox.Show("Chưa cập nhật được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HienThiDSLuongNhanVienLenDatagrid();
            MessageBox.Show("Đã cập nhật quá trình lương  thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra mã nhân viên có tồn tại hay không? Nếu không thì không xóa.
            if (LuongNhanVien_BUS.TimLuongTheoMa(cboMaNV.SelectedValue.ToString()) == null)
            {
                MessageBox.Show("Không tồn tại mã nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Gán giá trị vào LuongNhanVienDTO(), thực hiện sửa LuongNhanVienDTO.
            LuongNhanVien_DTO luong = new LuongNhanVien_DTO();
            luong.SMaNV = cboMaNV.SelectedValue.ToString();

            if (LuongNhanVien_BUS.XoaLuong(luong) == false)
            {
                MessageBox.Show("Chưa xóa được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HienThiDSLuongNhanVienLenDatagrid();
            MessageBox.Show("Đã xóa quá trình thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            frmLuongNV_Load(sender, e);
        }
        public void LayDuLieuMa(string Tim)
        {
            SqlCommand cmd = new SqlCommand(@"SELECT * FROM LuongNhanVien WHERE MaNhanVien LIKE N'%" + Tim + "%'");

        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            List<LuongNhanVien_DTO> ds = LuongNhanVien_BUS.LayDSLuongNV();
            List<LuongNhanVien_DTO> result = (from luong in ds
                                        where luong.SMaNV.Contains(txtTimKiemMa.Text)
                                        select luong).ToList();
            dgvLuongNV.DataSource = result;
        }
        #endregion

        #region XỬ lý dữ liệu
        private void HienThiDSLuongNhanVienLenDatagrid()
        {

            List<LuongNhanVien_DTO> lstLuongNV = LuongNhanVien_BUS.LayDSLuongNV();
            dgvLuongNV.DataSource = lstLuongNV;
            dgvLuongNV.Columns["SMaNV"].HeaderText = "Nhân Viên";
            dgvLuongNV.Columns["DtNgayBD"].HeaderText = "Ngày bắt đầu";
            dgvLuongNV.Columns["FHSLuong"].HeaderText = "Hệ số lương";
            dgvLuongNV.Columns["SGhiChu"].HeaderText = "Ghi Chú";


            dgvLuongNV.Columns["SMaNV"].Width = 60;
            dgvLuongNV.Columns["DtNgayBD"].Width = 60;
            dgvLuongNV.Columns["FHSLuong"].Width = 60;
            dgvLuongNV.Columns["SGhiChu"].Width = 120;


        }
        private void HienThiNhanVienLenCombobox()
        {
            List<NhanVien_DTO> lstNhanVien = NhanVien_BUS.LayDSNhanVien();
            cboMaNV.DataSource = lstNhanVien;
            cboMaNV.DisplayMember = "STenNV";
            cboMaNV.ValueMember = "SMaNV";
        }
        private void frmLuongNV_Load(object sender, EventArgs e)
        {
            HienThiNhanVienLenCombobox();
            HienThiDSLuongNhanVienLenDatagrid();
            dgvLuongNV_Click(sender,e);
        }
        private void dgvLuongNV_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgvLuongNV.SelectedRows[0];
            cboMaNV.SelectedValue = r.Cells["SMaNV"].Value.ToString();
            dtpNgayBD.Text = r.Cells["DtNgayBD"].Value.ToString();
            txtHSLuong.Text = r.Cells["FHSLuong"].Value.ToString();
            txtGhiChu.Text = r.Cells["SGhiChu"].Value.ToString();
        }
        #endregion
    }
}
