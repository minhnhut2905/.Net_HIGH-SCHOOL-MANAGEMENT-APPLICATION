using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DTO;
using BUS;

namespace GUI
{
    public partial class frmQueQuan : Form
    {
        public frmQueQuan()
        {
            InitializeComponent();
        }

        private void frm_dmNhanVien_Load(object sender, EventArgs e)
        {

            // Datagrid quê quán
            HienThiDSQueQuanLenDatagrid();
            // Load, lấy dòng đầu tiên
            dgvQueQuan_Click(sender, e);
        }


        private void HienThiDSQueQuanLenDatagrid() {
            List<QueQuanDTO> lstQueQuan = QueQuanBUS.LayDSQueQuan();
            dgvQueQuan.DataSource = lstQueQuan;
            dgvQueQuan.Columns["SMaQueQuan"].HeaderText = "Mã quê quán";
            dgvQueQuan.Columns["STenQueQuan"].HeaderText = "Tên quê quán";

            dgvQueQuan.Columns["SMaQueQuan"].Width = 60;
            dgvQueQuan.Columns["STenQueQuan"].Width = 120;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Kiểm tra dữ liệu có bị bỏ trống không?
            if (txtMaQueQuan.Text == "" || txtTenQueQuan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Kiểm tra mã quê quán có độ dài chuỗi hợp lệ hay không?
            if (txtMaQueQuan.Text.Length > 2)
            {
                MessageBox.Show("Mã quê quán tối đa có 2 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            QueQuanDTO qq = new QueQuanDTO();
            qq.SMaQueQuan = txtMaQueQuan.Text;
            qq.STenQueQuan = txtTenQueQuan.Text;

            if (QueQuanBUS.ThemNhanVien(qq) == false)
            {
                MessageBox.Show("Không tìm được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HienThiDSQueQuanLenDatagrid();
            MessageBox.Show("Đã thêm mới quê quán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void LayDuLieuMa(string Tim)
        {
            SqlCommand cmd = new SqlCommand(@"SELECT * FROM QueQuan WHERE MaQueQuan LIKE N'%" + Tim + "%'");

        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            List<QueQuanDTO> ds = QueQuanBUS.LayDSQueQuan();
            List<QueQuanDTO> result = (from qq in ds
                                       where qq.SMaQueQuan.Contains(txtTimKiemMa.Text)
                                       where qq.STenQueQuan.Contains(txtTimKiemTen.Text)
                                        select qq).ToList();
            dgvQueQuan.DataSource = result;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra mã quê quán có tồn tại hay không? Nếu không thì không xóa.
            if (QueQuanBUS.TimQueQuanTheoMa(txtMaQueQuan.Text) == null)
            {
                MessageBox.Show("Không tồn tại mã nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Gán giá trị vào QueQUan(), thực hiện sửa QueQUanDTO.
            QueQuanDTO qq = new QueQuanDTO();
            qq.SMaQueQuan = txtMaQueQuan.Text;
      
            if (QueQuanBUS.XoaQueQuan( qq) == false)
            {
                MessageBox.Show("Chưa xóa được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HienThiDSQueQuanLenDatagrid();
            MessageBox.Show("Đã xóa quê quán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //Kiểm tra dữ liệu có bị bỏ trống không?
            if (txtMaQueQuan.Text == "" || txtTenQueQuan.Text == "" )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra mã lớp học có bị trùng hay không?
            if (QueQuanBUS.TimQueQuanTheoMa(txtMaQueQuan.Text) == null)
            {
                MessageBox.Show("Không tồn tại mã lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Gán giá trị vào NhanVienDTO(), thực hiện sửa NhanVienDTO
            QueQuanDTO qq = new QueQuanDTO();
            qq.SMaQueQuan = txtMaQueQuan.Text;
            qq.STenQueQuan = txtTenQueQuan.Text;


            if (QueQuanBUS.SuaQueQuan(qq) == false)
            {
                MessageBox.Show("Chưa cập nhật được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HienThiDSQueQuanLenDatagrid();
            MessageBox.Show("Đã cập nhật lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvQueQuan_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgvQueQuan.SelectedRows[0];
            txtMaQueQuan.Text = r.Cells["SMaQueQuan"].Value.ToString();
            txtTenQueQuan.Text = r.Cells["STenQueQuan"].Value.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            txtMaQueQuan.Text = "";
            txtTenQueQuan.Text = "";
            txtTimKiemMa.Text = "";
            txtTimKiemTen.Text = "";
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            frm_dmNhanVien_Load(sender, e);
        }
    }
}

