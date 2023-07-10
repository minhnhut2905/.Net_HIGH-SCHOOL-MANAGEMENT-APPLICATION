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
using BUS;
using DTO;
namespace GUI.DangNhap
{
    public partial class frmLSDN : Form
    {
        public frmLSDN()
        {
            InitializeComponent();
        }

        private void frmLSDN_Load(object sender, EventArgs e)
        {
            HienLichSuDangNhap();
        }
        public void HienLichSuDangNhap()
        {
            List<LSDN_DTO> lstLSDN = LSDN_BUS.LayLSDN();

            dataGridView.DataSource = lstLSDN;
            if (lstLSDN != null)
            {
                dataGridView.Columns["TenDangNhap"].HeaderText = "Tên đăng nhập";
                dataGridView.Columns["ThoiGian"].HeaderText = "Thời gian đăng nhập";
                dataGridView.Columns["TenNguoiDung"].HeaderText = "Tên người dùng";
                dataGridView.Columns["QuyenHan"].HeaderText = "Quyền hạn";
                for (int i = 0; i < dataGridView.RowCount; i++)
                {
                    dataGridView.Rows[i].Height = 30;
                    dataGridView.Rows[i].Cells["STT"].Value = (i + 1).ToString();
                }
            }
        }

        private void bbtnXoaChon_Click(object sender, EventArgs e)
        {
            DialogResult thongbao = MessageBox.Show("Bạn có chắc muốn xóa dòng lịch sử đăng nhập này không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                // Gán dữ liệu vào kiểu HSXDTO
                LSDN_DTO ls = new LSDN_DTO();
                ls.ThoiGian = (DateTime)dataGridView.CurrentRow.Cells["ThoiGian"].Value;
                ls.TenDangNhap = dataGridView.CurrentRow.Cells["TenDangNhap"].Value.ToString();
                if (LSDN_BUS.XoaLS(ls) == false)
                {
                    MessageBox.Show("Không xóa được.");
                    return;
                }
                HienLichSuDangNhap();
                MessageBox.Show("Đã xóa lịch sử dòng.");
            }
        }

        private void txtTuKhoa__TextChanged(object sender, EventArgs e)
        {
            List<LSDN_DTO> lstLSDN = LSDN_BUS.TimLSDN(txtTuKhoa.Text);

            dataGridView.DataSource = lstLSDN;
            if (lstLSDN != null)
            {
                dataGridView.Columns["TenDangNhap"].HeaderText = "Tên đăng nhập";
                dataGridView.Columns["ThoiGian"].HeaderText = "Thời gian đăng nhập";
                dataGridView.Columns["TenNguoiDung"].HeaderText = "Tên người dùng";
                dataGridView.Columns["QuyenHan"].HeaderText = "Quyền hạn";
                for (int i = 0; i < dataGridView.RowCount; i++)
                {
                    dataGridView.Rows[i].Height = 30;
                    dataGridView.Rows[i].Cells["STT"].Value = (i + 1).ToString();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao = MessageBox.Show("Bạn có chắc muốn xóa lịch sử đăng nhập không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                // Thực hiện xóa (xóa quá trình lương trước khi xóa nhân viên)
                if (LSDN_BUS.XoaLS() == false)
                {
                    MessageBox.Show("Không xóa được.");
                    return;
                }
                HienLichSuDangNhap();
                MessageBox.Show("Đã xóa lịch sử.");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            List<LSDN_DTO> lstLSDN = LSDN_BUS.TimLSDN(fromDate.Value.ToString(), toDate.Value.ToString());

            dataGridView.DataSource = lstLSDN;
            if (lstLSDN != null)
            {
                dataGridView.Columns["TenDangNhap"].HeaderText = "Tên Đăng Nhập";
                dataGridView.Columns["ThoiGian"].HeaderText = "Thời gian đăng nhập";
                dataGridView.Columns["TenNguoiDung"].HeaderText = "Tên người dùng";
                dataGridView.Columns["QuyenHan"].HeaderText = "Quyền hạn";
                for (int i = 0; i < dataGridView.RowCount; i++)
                {
                    dataGridView.Rows[i].Height = 30;
                    dataGridView.Rows[i].Cells["STT"].Value = (i + 1).ToString();
                }
            }
        }
    }
}
