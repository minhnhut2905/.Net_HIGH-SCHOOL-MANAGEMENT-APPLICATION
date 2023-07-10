using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmThongTinCaNhan : Form
    {
        public frmThongTinCaNhan()
        {
            InitializeComponent();
        }

        private void frmThongTinCaNhan_Load(object sender, EventArgs e)
        {
            txtTenDN.Text = frmChinh.NguoiDung.STenDN;
            txtTenDN.Enabled = false;
            txtHoTen.Text = frmChinh.NguoiDung.SHoTen;
            txtHoTen.Enabled = true;
            txtMatKhau.Text = frmChinh.NguoiDung.SMatKhau;
            txtMatKhau.Enabled = false;
            txtAnh.Text = frmChinh.NguoiDung.SHinhAnh;
            txtAnh.Enabled = true;
            txtQuyenHan.Text = (frmChinh.NguoiDung.IQuyen).ToString();
            txtQuyenHan.Enabled = false;
            //txtMatKhau.UseSystemPasswordChar = true;
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau fdoimk = new frmDoiMatKhau();
            fdoimk.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //Kiểm tra dữ liệu có bị bỏ trống không?
            if (txtTenDN.Text == "" || txtMatKhau.Text == "" || txtQuyenHan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Gán giá trị vào NguoiDungDTO(), thực hiện sửa NguoiDungDTO
            NguoiDungDTO nd = new NguoiDungDTO();
            nd.STenDN = txtTenDN.Text;
            nd.SHoTen = txtHoTen.Text;
            nd.SMatKhau = txtMatKhau.Text;
            nd.SHinhAnh = txtAnh.Text;
            nd.IQuyen = int.Parse(txtQuyenHan.Text); ;

            if (NguoiDungBUS.SuaNguoiDung(nd) == false)
            {
                MessageBox.Show("Chưa cập nhật được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Đã cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
