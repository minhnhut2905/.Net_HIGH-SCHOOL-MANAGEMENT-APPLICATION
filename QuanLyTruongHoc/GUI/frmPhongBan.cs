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
    public partial class frmPhongBan : Form
    {
        public frmPhongBan()
        {
            InitializeComponent();
        }
        #region Load dữ liệu
        private void HienThiDSPhongBanLenDatagrid()
        {
            List<PhongBanDTO> lstPhongBan = PhongBanBUS.LayDSPhongBan();
            dgvPhongBan.DataSource = lstPhongBan;
            dgvPhongBan.Columns["SMaPhongBan"].HeaderText = "Mã Phòng Ban";
            dgvPhongBan.Columns["STenPhongBan"].HeaderText = "Tên Phòng Ban";

            dgvPhongBan.Columns["SMaPhongBan"].Width = 60;
            dgvPhongBan.Columns["STenPhongBan"].Width = 120;

        }
        private void dgvPhongBan_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgvPhongBan.SelectedRows[0];
            txtMaPhongBan.Text = r.Cells["SMaPhongBan"].Value.ToString();
            txtTenPhongBan.Text = r.Cells["STenPhongBan"].Value.ToString();
        }
        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            HienThiDSPhongBanLenDatagrid();
            dgvPhongBan_Click(sender, e);
        }
        #endregion
        #region Các nút chức năng
        private void btnThem_Click(object sender, EventArgs e)
        {
            //Kiểm tra dữ liệu có bị bỏ trống không?
            if (txtMaPhongBan.Text == "" || txtTenPhongBan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Kiểm tra mã phòng ban có độ dài chuỗi hợp lệ hay không?
            if (txtMaPhongBan.Text.Length > 6)
            {
                MessageBox.Show("Mã phòng ban tối đa có 6 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            PhongBanDTO pb = new PhongBanDTO();
            pb.SMaPhongBan = txtMaPhongBan.Text;
            pb.STenPhongBan = txtTenPhongBan.Text;

            if (PhongBanBUS.ThemPhongBan(pb) == false)
            {
                MessageBox.Show("Không tìm được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HienThiDSPhongBanLenDatagrid();
            MessageBox.Show("Đã thêm phòng ban thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            //Kiểm tra dữ liệu có bị bỏ trống không?
            if (txtMaPhongBan.Text == "" || txtTenPhongBan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra mã phòng ban có bị trùng hay không?
            if (PhongBanBUS.TimPhongBanTheoMa(txtMaPhongBan.Text) == null)
            {
                MessageBox.Show("Không tồn tại mã phòng ban!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Gán giá trị vào PhongBanDTO(), thực hiện sửa PhongBanDTO
            PhongBanDTO pb = new PhongBanDTO();
            pb.SMaPhongBan = txtMaPhongBan.Text;
            pb.STenPhongBan = txtTenPhongBan.Text;


            if (PhongBanBUS.SuaPhongBan(pb) == false)
            {
                MessageBox.Show("Chưa cập nhật được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HienThiDSPhongBanLenDatagrid();
            MessageBox.Show("Đã cập nhật phòng ban thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra mã phòng ban có tồn tại hay không? Nếu không thì không xóa.
            if (PhongBanBUS.TimPhongBanTheoMa(txtMaPhongBan.Text) == null)
            {
                MessageBox.Show("Không tồn tại mã phòng ban!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Gán giá trị vào PhongBanDTO(), thực hiện sửa PhongBanDTO.
            PhongBanDTO pb = new PhongBanDTO();
            pb.SMaPhongBan = txtMaPhongBan.Text;

            if (PhongBanBUS.XoaPhongBan(pb) == false)
            {
                MessageBox.Show("Chưa xóa được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HienThiDSPhongBanLenDatagrid();
            MessageBox.Show("Đã xóa phòng ban thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtMaPhongBan.Clear();
            txtTenPhongBan.Clear();

        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            frmPhongBan_Load(sender, e);
        }
        public void LayDuLieuMa(string Tim)
        {
            SqlCommand cmd = new SqlCommand(@"SELECT * FROM PhongBan WHERE MaPhongBan LIKE N'%" + Tim + "%' OR TenPhongBan LIKE N'%" + Tim + "%' ");

        }
        private void btnTim_Click(object sender, EventArgs e)
        {

            List<PhongBanDTO> ds = PhongBanBUS.LayDSPhongBan();
            List<PhongBanDTO> result = (from pb in ds
                                      where pb.SMaPhongBan.Contains(txtTimKiemMa.Text) 
                                      where pb.STenPhongBan.Contains(txtTimKiemTen.Text)
                                      select pb).ToList();
            dgvPhongBan.DataSource = result;
        }
        #endregion
    }
}
