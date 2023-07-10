using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace GUI
{
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtTenTK.Text = frmChinh.NguoiDung.STenDN;
            txtTenTK.Enabled = false;

            txtMKCu.UseSystemPasswordChar = true;
            txtMKMoi.UseSystemPasswordChar = true;
        }

        private void ckbPass_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbPass.Checked == true)
            {
                txtMKCu.UseSystemPasswordChar = false;
                txtMKMoi.UseSystemPasswordChar = false;
            }  
            else
            {
                txtMKCu.UseSystemPasswordChar = true;
                txtMKMoi.UseSystemPasswordChar = true;
            }
        }
        private void btnDoiMK_Click_1(object sender, EventArgs e)
        {
            //Xác nhận đúng mật khẩu
            if (NguoiDungBUS.LayNguoiDung(txtTenTK.Text, txtMKCu.Text) == null)
            {
                MessageBox.Show("Mật khẩu cũ chưa đúng!");
                return;
            }
            //Cập nhật mật khẩu mới
            NguoiDungDTO nd = new NguoiDungDTO();
            nd.STenDN = txtTenTK.Text;
            nd.SMatKhau = txtMKMoi.Text;
            if (!NguoiDungBUS.CapNhatMatKhau(nd))
            {
                MessageBox.Show("Chưa cập nhật được mật khẩu!");
                return;
            }
            MessageBox.Show("Đã cập nhật mật khẩu!");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
