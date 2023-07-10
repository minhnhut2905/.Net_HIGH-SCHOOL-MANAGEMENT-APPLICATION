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
    public partial class frmGiangVien : Form
    {
        public frmGiangVien()
        {
            InitializeComponent();
            this.dgvGiangVien.DefaultCellStyle.Font = new Font("Arial", 10);
        }
        #region Xử lý dữ liệu
        private void dgvGiangVien_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgvGiangVien.SelectedRows[0];
            txtMaGV.Text = r.Cells["SMaGV"].Value.ToString();

            txtTenGV.Text = r.Cells["STenGV"].Value.ToString();
            dtpNgaySinh.Text = r.Cells["DtNgaySinh"].Value.ToString();

            if (r.Cells["SGioiTinh"].Value.ToString() == "Nam")
            {
                radNam.Checked = true;
            }
            else
                radNu.Checked = true;
            //dtpNgaySinh.Text = r.Cells["DNgaySinh"].Value.ToString();
            txtSDT.Text = r.Cells["ISDT"].Value.ToString();
            txtDiaChi.Text = r.Cells["SDiaChi"].Value.ToString();
            txtAnh.Text = r.Cells["SHinhAnh"].Value.ToString();

            cboQueQuan.SelectedValue = r.Cells["SMaQueQuan"].Value.ToString();
            cboChucVu.SelectedValue = r.Cells["SMaChucVu"].Value.ToString();
            cboPhongBan.SelectedValue = r.Cells["SMaPhongBan"].Value.ToString();

            txtLuongCB.Text = r.Cells["FLuongCanBan"].Value.ToString();


            if (txtAnh.Text.Trim() != "")
            {
                try
                {
                    picAnh.Image = Image.FromFile(Application.StartupPath + "\\Resources\\AnhGiangVien\\" + txtAnh.Text);
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
        private void HienThiDSGiangVienLenDatagrid()
        {
            List<GiangVienDTO> lstGiangVien = GiangVienBUS.LayDSGiangVien();
            dgvGiangVien.DataSource = lstGiangVien;
            dgvGiangVien.Columns["SMaGV"].HeaderText = "Mã Giảng Viên";
            
            dgvGiangVien.Columns["STenGV"].HeaderText = "Tên Giảng Viên";
            dgvGiangVien.Columns["DtNgaySinh"].HeaderText = "Ngày sinh";
            dgvGiangVien.Columns["SGioiTinh"].HeaderText = "Giới tính";
            dgvGiangVien.Columns["ISDT"].HeaderText = "SDT";
            dgvGiangVien.Columns["SDiaChi"].HeaderText = "Địa Chỉ";
            dgvGiangVien.Columns["SHinhAnh"].HeaderText = "Hình Ảnh";

            dgvGiangVien.Columns["SMaQueQuan"].HeaderText = "Quê quán";
            dgvGiangVien.Columns["SMaChucVu"].HeaderText = "Chức Vụ";
            dgvGiangVien.Columns["SMaPhongBan"].HeaderText = "Phòng Ban";

            dgvGiangVien.Columns["FLuongCanBan"].HeaderText = "Lương Căn Bản";

            dgvGiangVien.Columns["SMaGV"].Width = 60;
            
            dgvGiangVien.Columns["STenGV"].Width = 60;
            dgvGiangVien.Columns["DtNgaySinh"].Width = 60;
            dgvGiangVien.Columns["SGioiTinh"].Width = 60;
            dgvGiangVien.Columns["ISDT"].Width = 60;
            dgvGiangVien.Columns["SDiaChi"].Width = 120;
            dgvGiangVien.Columns["SHinhAnh"].Width = 60;

            dgvGiangVien.Columns["SMaQueQuan"].Width = 60;
            dgvGiangVien.Columns["SMaChucVu"].Width = 60;
            dgvGiangVien.Columns["SMaPhongBan"].Width = 60;

            dgvGiangVien.Columns["FLuongCanBan"].Width = 120;




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
        private void frmGiangVien_Load(object sender, EventArgs e)
        {
            HienThiQueQuanLenCombobox();
            HienThiChucVuLenCombobox();
            HienThiPhongBanLenCombobox();
            HienThiDSGiangVienLenDatagrid();
            dgvGiangVien_Click(sender,e);
        }
        #endregion
        #region Các nút chức năng
        public void LayDuLieuMa(string Tim)
        {
            SqlCommand cmd = new SqlCommand(@"SELECT * FROM GiangVien WHERE MaGiangVien LIKE N'%" + Tim + "%' OR  TenGiangVien LIKE N'%" + Tim + "%'");

        }
        private void btnXoa_Click_1(object sender, EventArgs e)
        {

            // Kiểm tra mã giảng viên có tồn tại hay không? Nếu không thì không xóa.
            if (GiangVienBUS.TimGiangVienTheoMa(txtMaGV.Text) == null)
            {
                MessageBox.Show("Không tồn tại mã giảng viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Gán giá trị vào GiangVienDTO(), thực hiện sửa GiangVienDTO.
            GiangVienDTO gv = new GiangVienDTO();
            gv.SMaGV = txtMaGV.Text;

            if (GiangVienBUS.XoaGiangVien(gv) == false)
            {
                MessageBox.Show("Chưa xóa được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HienThiDSGiangVienLenDatagrid();
            MessageBox.Show("Đã xóa giảng viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnChon_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2; //ưu tiên ảnh đuôi .jpg trước
            dlgOpen.InitialDirectory = Application.StartupPath + "\\Resources\\AnhGiangVien";
            dlgOpen.Title = "Chọn ảnh giảng viên";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                txtAnh.Text = System.IO.Path.GetFileName(dlgOpen.FileName);
                picAnh.Image = Image.FromFile(Application.StartupPath + "\\Resources\\AnhGiangVien\\" + txtAnh.Text);
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            //Kiểm tra dữ liệu có bị bỏ trống không?
            if (txtMaGV.Text == "" || txtTenGV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Kiểm tra mã giảng có độ dài chuỗi hợp lệ hay không?
            if (txtMaGV.Text.Length > 10)
            {
                MessageBox.Show("Mã giảng viên tối đa có 10 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            GiangVienDTO gv = new GiangVienDTO();
            gv.SMaGV = txtMaGV.Text;
            gv.STenGV = txtTenGV.Text;
            gv.DtNgaySinh = DateTime.Parse(dtpNgaySinh.Text);

            if (radNam.Checked == true)
            {
                gv.SGioiTinh = "Nam";
            }
            else
            {
                gv.SGioiTinh = "Nữ";
            }

            gv.SDiaChi = txtDiaChi.Text;
            gv.ISDT = int.Parse(txtSDT.Text);
            gv.SHinhAnh = txtAnh.Text;
            gv.SMaQueQuan = cboQueQuan.SelectedValue.ToString();
            gv.SMaChucVu = cboChucVu.SelectedValue.ToString();
            gv.SMaPhongBan = cboPhongBan.SelectedValue.ToString();
            gv.FLuongCanBan = float.Parse(txtLuongCB.Text);

            if (GiangVienBUS.ThemGiangVien(gv) == false)
            {
                MessageBox.Show("Không tìm được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HienThiDSGiangVienLenDatagrid();
            MessageBox.Show("Đã thêm giảng viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            //Kiểm tra dữ liệu có bị bỏ trống không?
            if (txtMaGV.Text == "" || txtTenGV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra mã giảng viên có bị trùng hay không?
            if (GiangVienBUS.TimGiangVienTheoMa(txtMaGV.Text) == null)
            {
                MessageBox.Show("Không tồn tại mã giảng viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Gán giá trị vào ChucVuDTO(), thực hiện sửa ChucVuDTO
            GiangVienDTO gv = new GiangVienDTO();
            gv.SMaGV = txtMaGV.Text;
            gv.STenGV = txtTenGV.Text;
            gv.DtNgaySinh = DateTime.Parse(dtpNgaySinh.Text);

            if (radNam.Checked == true)
            {
                gv.SGioiTinh = "Nam";
            }
            else
            {
                gv.SGioiTinh = "Nữ";
            }

            gv.SDiaChi = txtDiaChi.Text;
            gv.ISDT = int.Parse(txtSDT.Text);
            gv.SHinhAnh = txtAnh.Text;
            gv.SMaQueQuan = cboQueQuan.SelectedValue.ToString();
            gv.SMaChucVu = cboChucVu.SelectedValue.ToString();
            gv.SMaPhongBan = cboPhongBan.SelectedValue.ToString();
            gv.FLuongCanBan = float.Parse(txtLuongCB.Text);

            if (GiangVienBUS.SuaGiangVien(gv) == false)
            {
                MessageBox.Show("Chưa cập nhật được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HienThiDSGiangVienLenDatagrid();
            MessageBox.Show("Đã cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMoi_Click_1(object sender, EventArgs e)
        {
            txtAnh.Text = "";
            txtMaGV.Text = "";
            txtLuongCB.Text = "";
            txtTenGV.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            dtpNgaySinh.Value = DateTime.Today;
            radNam.Checked = true;
            cboQueQuan.Text = "";
            cboChucVu.Text = "";
            cboPhongBan.Text = "";
            txtTimKiemMa.Text = "";
            txtTimKiemTen.Text = "";
        }

        private void btnInAn_Click(object sender, EventArgs e)
        {
            frmReportGiangVien gv = new frmReportGiangVien();
            gv.ShowDialog();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            frmGiangVien_Load(sender, e);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            List<GiangVienDTO> ds = GiangVienBUS.LayDSGiangVien();
            List<GiangVienDTO> result = (from gv in ds
                                         where gv.SMaGV.Contains(txtTimKiemMa.Text)
                                         where gv.STenGV.Contains(txtTimKiemTen.Text)
                                         select gv).ToList();
            dgvGiangVien.DataSource = result;
        }
        #endregion
    }
}

