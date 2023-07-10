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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        #region Hiển thị
        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgvNhanVien.SelectedRows[0];
            txtMaNV.Text = r.Cells["SManv"].Value.ToString();
            txtTenNV.Text = r.Cells["STennv"].Value.ToString();
            dtpNgaySinh.Text = r.Cells["DtNgaySinh"].Value.ToString();

            if (r.Cells["SGioiTinh"].Value.ToString() == "Nam")
            {
                radNam.Checked = true;
            }
            else
                radNu.Checked = true;
            //dtpNgaySinh.Text = r.Cells["DNgaySinh"].Value.ToString();
            txtDiaChi.Text = r.Cells["SDiaChi"].Value.ToString();
            txtSDT.Text = r.Cells["ISDT"].Value.ToString();
            txtAnh.Text = r.Cells["SHinhAnh"].Value.ToString();

            cboQueQuan.SelectedValue = r.Cells["SMaQueQuan"].Value.ToString();
            cboChucVu.SelectedValue = r.Cells["SMaChucVu"].Value.ToString();
            cboPhongBan.SelectedValue = r.Cells["SMaPhongBan"].Value.ToString();

            txtLuongCB.Text = r.Cells["FLuongCB"].Value.ToString();

            if (txtAnh.Text.Trim() != "")
            {
                try
                {
                    picAnh.Image = Image.FromFile(Application.StartupPath + "\\Resources\\AnhNhanVien\\" + txtAnh.Text);
                }
                catch
                {
                    picAnh.Image = Image.FromFile(Application.StartupPath + "\\Resources\\noimage.png");
                }
            }
            else
            {
                picAnh.Image = Image.FromFile(Application.StartupPath + "\\Resources\\noimage.png");
            }
        }
        private void HienThiDSNhanVienLenDatagrid()
        {
            List<NhanVien_DTO> lstGiannvien = NhanVien_BUS.LayDSNhanVien();
            dgvNhanVien.DataSource = lstGiannvien;
            dgvNhanVien.Columns["SMaNV"].HeaderText = "Mã Nhân Viên";
            dgvNhanVien.Columns["STenNV"].HeaderText = "Tên Nhân Viên";
            dgvNhanVien.Columns["DtNgaySinh"].HeaderText = "Ngày sinh";
            dgvNhanVien.Columns["SGioiTinh"].HeaderText = "Giới tính";
            dgvNhanVien.Columns["ISDT"].HeaderText = "SDT";
            dgvNhanVien.Columns["SDiaChi"].HeaderText = "Địa Chỉ";
            dgvNhanVien.Columns["SHinhAnh"].HeaderText = "Hình Ảnh";

            dgvNhanVien.Columns["SMaQueQuan"].HeaderText = "Quê quán";
            dgvNhanVien.Columns["SMaChucVu"].HeaderText = "Chức Vụ";
            dgvNhanVien.Columns["SMaPhongBan"].HeaderText = "Phòng Ban";

            dgvNhanVien.Columns["FLuongCB"].HeaderText = "Lương Căn Bản";



            dgvNhanVien.Columns["SMaNV"].Width = 60;
            dgvNhanVien.Columns["STenNV"].Width = 60;
            dgvNhanVien.Columns["DtNgaySinh"].Width = 60;
            dgvNhanVien.Columns["SGioiTinh"].Width = 60;
            dgvNhanVien.Columns["ISDT"].Width = 60;
            dgvNhanVien.Columns["SDiaChi"].Width = 120;
            dgvNhanVien.Columns["SHinhAnh"].Width = 60;

            dgvNhanVien.Columns["SMaQueQuan"].Width = 60;
            dgvNhanVien.Columns["SMaChucVu"].Width = 60;
            dgvNhanVien.Columns["SMaPhongBan"].Width = 60;

            dgvNhanVien.Columns["FLuongCB"].Width = 120;

            if (txtAnh.Text.Trim() != "")
            {
                try
                {
                    picAnh.Image = Image.FromFile(txtAnh.Text);
                }
                catch
                {
                    picAnh.Image = Image.FromFile(Application.StartupPath + "\\Resources\\noimage.png");
                }
            }
            else
            {
                picAnh.Image = Image.FromFile(Application.StartupPath + "\\Resources\\noimage.png");
            }
        }
        private void HienThiQueQuanLenCombobox()
        {
            List<QueQuanDTO> lstQueQuan = QueQuanBUS.LayDSQueQuan();
            cboQueQuan.DataSource = lstQueQuan;
            cboQueQuan.DisplayMember = "STenQueQuan";
            cboQueQuan.ValueMember = "SMaQueQuan";
        }
        private void HienThiChucVuLenCombobox()
        {
            List<ChucVuDTO> lstChucVu = ChucVuBUS.LayChucVu();
            cboChucVu.DataSource = lstChucVu;
            cboChucVu.DisplayMember = "STenCV";
            cboChucVu.ValueMember = "SMaCV";
        }
        private void HienThiPhongBanLenCombobox()
        {
            List<PhongBanDTO> lstPhongBan = PhongBanBUS.LayDSPhongBan();
            cboPhongBan.DataSource = lstPhongBan;
            cboPhongBan.DisplayMember = "STenPhongBan";
            cboPhongBan.ValueMember = "SMaPhongBan";
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            HienThiQueQuanLenCombobox();
            HienThiChucVuLenCombobox();
            HienThiPhongBanLenCombobox();
            HienThiDSNhanVienLenDatagrid();
            dgvNhanVien_Click(sender, e);
        }
#endregion

        #region Các nút chức năng
        private void btnChon_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2; //ưu tiên ảnh đuôi .jpg trước
            dlgOpen.InitialDirectory = Application.StartupPath + "\\Resources\\AnhNhanVien";
            dlgOpen.Title = "Chọn ảnh giảng viên";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                txtAnh.Text = System.IO.Path.GetFileName(dlgOpen.FileName);
                picAnh.Image = Image.FromFile(Application.StartupPath + "\\Resources\\AnhNhanVien\\" + txtAnh.Text);
            }
        }

        private void btnLoad_Click_1(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
        }

        private void btnMoi_Click_1(object sender, EventArgs e)
        {
            txtAnh.Text = "";
            txtMaNV.Text = "";
            txtLuongCB.Text = "";
            txtTenNV.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            dtpNgaySinh.Value = DateTime.Today;
            radNam.Checked = true;
            cboQueQuan.Text = "";
            cboChucVu.Text = "";
            cboPhongBan.Text = "";
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            //Kiểm tra dữ liệu có bị bỏ trống không?
            if (txtMaNV.Text == "" || txtTenNV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Kiểm tra mã giảng có độ dài chuỗi hợp lệ hay không?
            if (txtMaNV.Text.Length > 10)
            {
                MessageBox.Show("Mã giảng viên tối đa có 10 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.SMaNV = txtMaNV.Text;
            nv.STenNV = txtTenNV.Text;
            nv.DtNgaySinh = DateTime.Parse(dtpNgaySinh.Text);

            if (radNam.Checked == true)
            {
                nv.SGioiTinh = "Nam";
            }
            else
            {
                nv.SGioiTinh = "Nữ";
            }

            nv.SDiaChi = txtDiaChi.Text;
            nv.ISDT = int.Parse(txtSDT.Text);
            nv.SHinhAnh = txtAnh.Text;
            nv.SMaQueQuan = cboQueQuan.SelectedValue.ToString();
            nv.SMaChucVu = cboChucVu.SelectedValue.ToString();
            nv.SMaPhongBan = cboPhongBan.SelectedValue.ToString();
            nv.FLuongCB = float.Parse(txtLuongCB.Text);

            if (NhanVien_BUS.ThemNhanVien(nv) == false)
            {
                MessageBox.Show("Không tìm được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HienThiDSNhanVienLenDatagrid();
            MessageBox.Show("Đã thêm giảng viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            //Kiểm tra dữ liệu có bị bỏ trống không?
            if (txtMaNV.Text == "" || txtTenNV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra mã giảng viên có bị trùng hay không?
            if (NhanVien_BUS.TimNhanVienTheoMa(txtMaNV.Text) == null)
            {
                MessageBox.Show("Không tồn tại mã nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Gán giá trị vào ChucVuDTO(), thực hiện sửa ChucVuDTO
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.SMaNV = txtMaNV.Text;
            nv.STenNV = txtTenNV.Text;
            nv.DtNgaySinh = DateTime.Parse(dtpNgaySinh.Text);

            if (radNam.Checked == true)
            {
                nv.SGioiTinh = "Nam";
            }
            else
            {
                nv.SGioiTinh = "Nữ";
            }

            nv.SDiaChi = txtDiaChi.Text;
            nv.ISDT = int.Parse(txtSDT.Text);
            nv.SHinhAnh = txtAnh.Text;
            nv.SMaQueQuan = cboQueQuan.SelectedValue.ToString();
            nv.SMaChucVu = cboChucVu.SelectedValue.ToString();
            nv.SMaPhongBan = cboPhongBan.SelectedValue.ToString();
            nv.FLuongCB = float.Parse(txtLuongCB.Text);

            if (NhanVien_BUS.SuaNhanvien(nv) == false)
            {
                MessageBox.Show("Chưa cập nhật được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HienThiDSNhanVienLenDatagrid();
            MessageBox.Show("Đã cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra mã giảng viên có tồn tại hay không? Nếu không thì không xóa.
            if (NhanVien_BUS.TimNhanVienTheoMa(txtMaNV.Text) == null)
            {
                MessageBox.Show("Không tồn tại mã nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Gán giá trị vào GiangVienDTO(), thực hiện sửa GiangVienDTO.
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.SMaNV = txtMaNV.Text;

            if (NhanVien_BUS.XoaNhanVien(nv) == false)
            {
                MessageBox.Show("Chưa xóa được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HienThiDSNhanVienLenDatagrid();
            MessageBox.Show("Đã xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            List<NhanVien_DTO> ds = NhanVien_BUS.LayDSNhanVien();
            List<NhanVien_DTO> result = (from nv in ds
                                         where nv.SMaNV.Contains(txtTimKiemMa.Text)
                                         where nv.STenNV.Contains(txtTimKiemTen.Text)
                                         select nv).ToList();
            dgvNhanVien.DataSource = result;
        }
        public void LayDuLieuMa(string Tim)
        {
            SqlCommand cmd = new SqlCommand(@"SELECT * FROM NhanVien WHERE MaNhanVien LIKE N'%" + Tim + "%'");

        }
        #endregion
    }
}
