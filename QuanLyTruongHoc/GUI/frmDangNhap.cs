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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private void ckbPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbPass.Checked == true)
            {
                txtMatKhau.UseSystemPasswordChar = false;
               
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtTen.Focus();
            txtMatKhau.UseSystemPasswordChar = true;
        }

    }
}
