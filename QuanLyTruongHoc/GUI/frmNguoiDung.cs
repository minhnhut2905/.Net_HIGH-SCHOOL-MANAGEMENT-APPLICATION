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
using GUI.DangNhap;

namespace GUI
{
    public partial class frmNguoiDung : Form
    {
        public frmNguoiDung()
        {
            InitializeComponent();
        }
        private void HienThiDSNguoiDungLenDatagrid()
        {
            List<NguoiDungDTO> lstNhanVien = NguoiDungBUS.LayDSNguoiDung();
            dgDSNguoiDung.DataSource = lstNhanVien;
            dgDSNguoiDung.Columns["STenDN"].HeaderText = "Tên đăng nhập";
            dgDSNguoiDung.Columns["SHoTen"].HeaderText = "Họ Tên";
            dgDSNguoiDung.Columns["SMatKhau"].HeaderText = "Mật khẩu";
            dgDSNguoiDung.Columns["SHinhAnh"].HeaderText = "Hình Ảnh";
            dgDSNguoiDung.Columns["iQuyen"].HeaderText = "Quyền Hạn";

            dgDSNguoiDung.Columns["STenDN"].Width = 60;
            dgDSNguoiDung.Columns["SHoTen"].Width = 120;
            dgDSNguoiDung.Columns["SMatKhau"].Width = 120;
            dgDSNguoiDung.Columns["SHinhAnh"].Width = 120;
            dgDSNguoiDung.Columns["iQuyen"].Width = 50;

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

        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
            HienThiDSNguoiDungLenDatagrid();
            dgDSNguoiDung_Click(sender, e);
        }

        private void dgDSNguoiDung_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgDSNguoiDung.SelectedRows[0];
            txtTenNguoiDung.Text = r.Cells["STenDN"].Value.ToString();
            txtHoTen.Text = r.Cells["SHoTen"].Value.ToString();
            txtMatKhau.Text = r.Cells["SMatKhau"].Value.ToString();
            txtAnh.Text = r.Cells["SHinhAnh"].Value.ToString();
            txtQuyenHan.Text = r.Cells["iQuyen"].Value.ToString();

            if (txtAnh.Text.Trim() != "")
            {
                try
                {
                    picAnh.Image = Image.FromFile(Application.StartupPath + "\\Resources\\AnhNguoiDung\\" + txtAnh.Text);
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Kiểm tra dữ liệu có bị bỏ trống không?
            if (txtTenNguoiDung.Text == "" || txtMatKhau.Text == "" || txtQuyenHan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Kiểm tra tên người dùng có độ dài chuỗi hợp lệ hay không?
            if (txtTenNguoiDung.Text.Length > 30)
            {
                MessageBox.Show("Tên người dùng tối đa có 30 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Kiểm tra tên người dùng có bị trùng hay không?
            if (QueQuanBUS.TimQueQuanTheoMa(txtTenNguoiDung.Text) != null)
            {
                MessageBox.Show("Tên người dùng đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            NguoiDungDTO nd = new NguoiDungDTO();
            nd.STenDN = txtTenNguoiDung.Text;
            nd.SHoTen = txtHoTen.Text;
            nd.SMatKhau = txtMatKhau.Text;
            nd.SHinhAnh = txtAnh.Text;
            nd.IQuyen = int.Parse(txtQuyenHan.Text); 

            if (NguoiDungBUS.CapNhatMatKhau(nd) == false)
            {
                MessageBox.Show("Chưa cập nhật được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (NguoiDungBUS.ThemNguoiDung(nd) == false)
            {
                MessageBox.Show("Không tìm được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmNguoiDung_Load(sender, e);
            dgDSNguoiDung_Click(sender, e);
            MessageBox.Show("Đã thêm mới học sinh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //Kiểm tra dữ liệu có bị bỏ trống không?
            if (txtTenNguoiDung.Text == "" || txtMatKhau.Text == "" || txtQuyenHan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Gán giá trị vào NguoiDungDTO(), thực hiện sửa NguoiDungDTO
            NguoiDungDTO nd = new NguoiDungDTO();
            nd.STenDN = txtTenNguoiDung.Text;
            nd.SHoTen = txtHoTen.Text;
            nd.SMatKhau = txtMatKhau.Text;
            nd.SHinhAnh = txtAnh.Text;
            nd.IQuyen = int.Parse(txtQuyenHan.Text); ;

            if (NguoiDungBUS.SuaNguoiDung(nd) == false)
            {
                MessageBox.Show("Chưa cập nhật được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dgDSNguoiDung_Click(sender, e);
            HienThiDSNguoiDungLenDatagrid();
            MessageBox.Show("Đã cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            //Gán giá trị vào NguoDungDTO(), thực hiện sửa NguoDungDTO.
            NguoiDungDTO nd = new NguoiDungDTO();
            nd.STenDN = txtTenNguoiDung.Text;

            if (NguoiDungBUS.XoaNguoiDung(nd) == false)
            {
                MessageBox.Show("Chưa xóa được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dgDSNguoiDung_Click(sender, e);
            HienThiDSNguoiDungLenDatagrid();
            MessageBox.Show("Đã xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnMoi_Click(object sender, EventArgs e)
        {
            txtTenNguoiDung.Text = "";
            txtHoTen.Text = "";
            txtMatKhau.Text = "";
            txtAnh.Text = "";
            txtQuyenHan.Text = "";
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            frmNguoiDung_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void dgDSNguoiDung_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgDSNguoiDung.Columns[e.ColumnIndex].Name == "SMatKhau")
            {
                e.Value = "••••••••••";
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2; //ưu tiên ảnh đuôi .jpg trước
            dlgOpen.InitialDirectory = Application.StartupPath + "\\Resources\\AnhNguoiDung";
            dlgOpen.Title = "Chọn ảnh học sinh!";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                txtAnh.Text = System.IO.Path.GetFileName(dlgOpen.FileName);
                picAnh.Image = Image.FromFile(Application.StartupPath + "\\Resources\\AnhNguoiDung\\" + txtAnh.Text);
            }
        }

        private void btnLS_Click(object sender, EventArgs e)
        {
            new frmLSDN().ShowDialog();
        }

        private void picAnh_Click(object sender, EventArgs e)
        {

        }
    }
}
