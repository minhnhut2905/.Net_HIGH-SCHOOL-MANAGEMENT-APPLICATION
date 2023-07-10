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
    public partial class frmChucVu : Form
    {
        public frmChucVu()
        {
            InitializeComponent();
        }
        #region Xử lý dữ liệu
        private void HienThiDSChucVuLenDatagrid()
        {
            List<ChucVuDTO> lstLopHoc = ChucVuBUS.LayChucVu();
            dgvChucVu.DataSource = lstLopHoc;
            dgvChucVu.Columns["SMaCV"].HeaderText = "Mã Chức Vụ";
            dgvChucVu.Columns["STenCV"].HeaderText = "Tên Chức Vụ";

            dgvChucVu.Columns["SMaCV"].Width = 60;
            dgvChucVu.Columns["STenCV"].Width = 120;

        }
        private void dgvChucVu_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgvChucVu.SelectedRows[0];
            txtMaCV.Text = r.Cells["SMaCV"].Value.ToString();
            txtTenCV.Text = r.Cells["STenCV"].Value.ToString();
        }
        private void frmChucVu_Load(object sender, EventArgs e)
        {
            HienThiDSChucVuLenDatagrid();
            dgvChucVu_Click(sender, e);
        }
        #endregion
        #region Các nút chức năng
        private void btnThem_Click(object sender, EventArgs e)
        {
            //Kiểm tra dữ liệu có bị bỏ trống không?
            if (txtMaCV.Text == "" || txtTenCV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Kiểm tra mã chức vụ có độ dài chuỗi hợp lệ hay không?
            if (txtMaCV.Text.Length > 5)
            {
                MessageBox.Show("Mã chức vụ tối đa có 5 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ChucVuDTO cv = new ChucVuDTO();
            cv.SMaCV = txtMaCV.Text;
            cv.STenCV = txtTenCV.Text;

            if (ChucVuBUS.ThemChucVu(cv) == false)
            {
                MessageBox.Show("Không tìm được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HienThiDSChucVuLenDatagrid();
            MessageBox.Show("Đã thêm chức vụ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //Kiểm tra dữ liệu có bị bỏ trống không?
            if (txtMaCV.Text == "" || txtTenCV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra mã chức vụ có bị trùng hay không?
            if (ChucVuBUS.TimChucVuTheoMa(txtMaCV.Text) == null)
            {
                MessageBox.Show("Không tồn tại mã chức vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Gán giá trị vào ChucVuDTO(), thực hiện sửa ChucVuDTO
            ChucVuDTO cv = new ChucVuDTO();
            cv.SMaCV = txtMaCV.Text;
            cv.STenCV = txtTenCV.Text;


            if (ChucVuBUS.SuaChucVu(cv) == false)
            {
                MessageBox.Show("Chưa cập nhật được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HienThiDSChucVuLenDatagrid();
            MessageBox.Show("Đã cập nhật chức vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra mã chức vụ có tồn tại hay không? Nếu không thì không xóa.
            if (ChucVuBUS.TimChucVuTheoMa(txtMaCV.Text) == null)
            {
                MessageBox.Show("Không tồn tại mã chức vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Gán giá trị vào ChucVuDTO(), thực hiện sửa ChucVuDTO.
            ChucVuDTO cv = new ChucVuDTO();
            cv.SMaCV = txtMaCV.Text;

            if (ChucVuBUS.XoaChucVu(cv) == false)
            {
                MessageBox.Show("Chưa xóa được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HienThiDSChucVuLenDatagrid();
            MessageBox.Show("Đã xóa chức vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void LayDuLieuMa(string Tim)
        {
            SqlCommand cmd = new SqlCommand(@"SELECT * FROM LopHoc WHERE MaChucVu LIKE N'%" + Tim + "%' OR TenChucVu LIKE N'%" + Tim + "%'");

        }
        private void btnTim_Click(object sender, EventArgs e)
        {

            List<ChucVuDTO> ds = ChucVuBUS.LayChucVu();
            List<ChucVuDTO> result = (from cv in ds
                                      where cv.SMaCV.Contains(txtTimKiemMa.Text)
                                      where cv.STenCV.Contains(txtTimKiemTen.Text)
                                      select cv).ToList();
            dgvChucVu.DataSource = result;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            frmChucVu_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            txtMaCV.Text = "";
            txtTenCV.Text = "";
            txtTimKiemMa.Text = "";
            txtTimKiemTen.Text = "";
        }
        #endregion
    }
}
