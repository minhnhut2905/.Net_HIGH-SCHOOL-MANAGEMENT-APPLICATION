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
    public partial class frmLuongGV : Form
    {
        public frmLuongGV()
        {
            InitializeComponent();
        }
        #region Xử lý dữ liệu
        private void HienThiDSLuongGiangVienLenDatagrid()
        {

            List<LuongGV_DTO> lstLuongGV = LuongGV_BUS.LayDSLuongGV();
            dgvLuongGV.DataSource = lstLuongGV;
            dgvLuongGV.Columns["SMaGiangVien"].HeaderText = "Giảng Viên";
            dgvLuongGV.Columns["DtNgayBD1"].HeaderText = "Ngày bắt đầu";
            dgvLuongGV.Columns["FHSLuong"].HeaderText = "Hệ số lương";
            dgvLuongGV.Columns["SGhiChu"].HeaderText = "Ghi Chú";
           

            dgvLuongGV.Columns["SMaGiangVien"].Width = 60;
            dgvLuongGV.Columns["DtNgayBD1"].Width = 60;
            dgvLuongGV.Columns["FHSLuong"].Width = 60;
            dgvLuongGV.Columns["SGhiChu"].Width = 120;


        }
        private void HienThiGiangVienLenCombobox()
        {
            List<GiangVienDTO> lstGiangVien = GiangVienBUS.LayDSGiangVien();
            cboMaGV.DataSource = lstGiangVien;
            cboMaGV.DisplayMember = "STenGV";
            cboMaGV.ValueMember = "SMaGV";
        }
        private void dgvLuongGV_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgvLuongGV.SelectedRows[0];
            cboMaGV.SelectedValue = r.Cells["SMaGiangVien"].Value.ToString();
            dtpNgayBD.Text = r.Cells["DtNgayBD1"].Value.ToString();
            txtHSLuong.Text = r.Cells["FHSLuong"].Value.ToString();
            txtGhiChu.Text = r.Cells["SGhiChu"].Value.ToString();


        }
        private void frmLuongGV_Load(object sender, EventArgs e)
        {
            HienThiGiangVienLenCombobox();
            HienThiDSLuongGiangVienLenDatagrid();
            dgvLuongGV_Click(sender, e);
        }
        #endregion
        #region Các nút chức năng
        private void btnMoi_Click(object sender, EventArgs e)
        {
            cboMaGV.Text = "";
            dtpNgayBD.Value = DateTime.Today;
            txtHSLuong.Text = "";
            txtGhiChu.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Kiểm tra dữ liệu có bị bỏ trống không?
            if (cboMaGV.SelectedValue.ToString() == "" || dtpNgayBD.Text == "")
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
            LuongGV_DTO luong = new LuongGV_DTO();
            luong.SMaGiangVien = cboMaGV.SelectedValue.ToString();
            luong.DtNgayBD1 = DateTime.Parse(dtpNgayBD.Text);
            luong.FHSLuong = float.Parse(txtHSLuong.Text);
            luong.SGhiChu = txtGhiChu.Text;


            if (LuongGV_BUS.ThemLuongGV(luong) == false)
            {
                MessageBox.Show("Không tìm được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HienThiDSLuongGiangVienLenDatagrid();
            MessageBox.Show("Đã thêm quá trình lương thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //Kiểm tra dữ liệu có bị bỏ trống không?
            if (cboMaGV.SelectedValue.ToString() == "" || dtpNgayBD.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra mã giảng viên có bị trùng hay không?
            if (LuongGV_BUS.TimLuongTheoMa(cboMaGV.SelectedValue.ToString()) == null)
            {
                MessageBox.Show("Không tồn tại mã giảng viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Gán giá trị vào LuongGV_DTO(), thực hiện sửa LuongGV_DTO
            LuongGV_DTO luong = new LuongGV_DTO();
            luong.SMaGiangVien = cboMaGV.SelectedValue.ToString();
            luong.DtNgayBD1 = DateTime.Parse(dtpNgayBD.Text);
            luong.FHSLuong = float.Parse(txtHSLuong.Text);
            luong.SGhiChu = txtGhiChu.Text;


            if (LuongGV_BUS.SuaLuong(luong) == false)
            {
                MessageBox.Show("Chưa cập nhật được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HienThiDSLuongGiangVienLenDatagrid();
            MessageBox.Show("Đã cập nhật quá trình lương  thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            // Kiểm tra mã chức vụ có tồn tại hay không? Nếu không thì không xóa.
            if (LuongGV_BUS.TimLuongTheoMa(cboMaGV.SelectedValue.ToString()) == null)
            {
                MessageBox.Show("Không tồn tại mã giảng viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Gán giá trị vào LuongGiangVienDTO(), thực hiện sửa LuongGiangVienDTO.
            LuongGV_DTO luong = new LuongGV_DTO();
            luong.SMaGiangVien = cboMaGV.SelectedValue.ToString();

            if (LuongGV_BUS.XoaLuong(luong) == false)
            {
                MessageBox.Show("Chưa xóa được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HienThiDSLuongGiangVienLenDatagrid();
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
        public void LayDuLieuMa(string Tim)
        {
            SqlCommand cmd = new SqlCommand(@"SELECT * FROM LuongGiangVien WHERE MaGiangVien LIKE N'%" + Tim + "%'");

        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            List<LuongGV_DTO> ds = LuongGV_BUS.LayDSLuongGV();
            List<LuongGV_DTO> result = (from luong in ds
                                       where luong.SMaGiangVien.Contains(txtTimKiemMa.Text)
                                       select luong).ToList();
            dgvLuongGV.DataSource = result;
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            frmLuongGV_Load(sender, e);
        }
        #endregion
    }
}
