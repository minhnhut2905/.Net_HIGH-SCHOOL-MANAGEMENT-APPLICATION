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
    public partial class frmLopHoc : Form
    {
        public frmLopHoc()
        {
            InitializeComponent();
        }
        private void HienThiDSLopHocLenDatagrid()
        {
            List<LopHocDTO> lstLopHoc = LopHocBUS.LayDSLopHoc();
            dgvLopHoc.DataSource = lstLopHoc;
            dgvLopHoc.Columns["SMaLop"].HeaderText = "Mã Lớp Học";
            dgvLopHoc.Columns["STenLop"].HeaderText = "Tên Lớp Học";

            dgvLopHoc.Columns["SMaLop"].Width = 60;
            dgvLopHoc.Columns["STenLop"].Width = 120;

        }

        private void frmLopHoc_Load(object sender, EventArgs e)
        {
            HienThiDSLopHocLenDatagrid();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Kiểm tra dữ liệu có bị bỏ trống không?
            if (txtMaLop.Text == "" || txtTenLop.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Kiểm tra mã lớp học có độ dài chuỗi hợp lệ hay không?
            if (txtMaLop.Text.Length > 4)
            {
                MessageBox.Show("Mã lớp học tối đa có 4 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LopHocDTO lh = new LopHocDTO();
            lh.SMaLop = txtMaLop.Text;
            lh.STenLop = txtTenLop.Text;

            if (LopHocBUS.ThemLopHoc(lh) == false)
            {
                MessageBox.Show("Không tìm được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HienThiDSLopHocLenDatagrid();
            MessageBox.Show("Đã thêm lớp học thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //Kiểm tra dữ liệu có bị bỏ trống không?
            if (txtMaLop.Text == "" || txtTenLop.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra mã lớp học có bị trùng hay không?
            if (LopHocBUS.TimLopHocTheoMa(txtMaLop.Text) == null)
            {
                MessageBox.Show("Không tồn tại mã lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Gán giá trị vào NhanVienDTO(), thực hiện sửa NhanVienDTO
            LopHocDTO lh = new LopHocDTO();
            lh.SMaLop = txtMaLop.Text;
            lh.STenLop = txtTenLop.Text;


            if (LopHocBUS.SuaLopHoc(lh) == false)
            {
                MessageBox.Show("Chưa cập nhật được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HienThiDSLopHocLenDatagrid();
            MessageBox.Show("Đã cập nhật lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra mã lớp học có tồn tại hay không? Nếu không thì không xóa.
            if (LopHocBUS.TimLopHocTheoMa(txtMaLop.Text) == null)
            {
                MessageBox.Show("Không tồn tại mã lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Gán giá trị vào QueQUan(), thực hiện sửa QueQUanDTO.
            LopHocDTO lh = new LopHocDTO();
            lh.SMaLop = txtMaLop.Text;

            if (LopHocBUS.XoaLopHoc(lh) == false)
            {
                MessageBox.Show("Chưa xóa được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HienThiDSLopHocLenDatagrid();
            MessageBox.Show("Đã xóa lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void LayDuLieuMa(string Tim)
        {
            SqlCommand cmd = new SqlCommand(@"SELECT * FROM LopHoc WHERE MaLop LIKE N'%" + Tim + "%'");

        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            List<LopHocDTO> ds = LopHocBUS.LayDSLopHoc();
            List<LopHocDTO> result = (from lh in ds
                                       where lh.SMaLop.Contains(txtTimKiemMa.Text)
                                       where lh.STenLop.Contains(txtTimKiemTen.Text)
                                       select lh).ToList();
            dgvLopHoc.DataSource = result;
        }

        private void dgvLopHoc_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgvLopHoc.SelectedRows[0];
            txtMaLop.Text = r.Cells["SMaLop"].Value.ToString();
            txtTenLop.Text = r.Cells["STenLop"].Value.ToString();
        }
    }
}
