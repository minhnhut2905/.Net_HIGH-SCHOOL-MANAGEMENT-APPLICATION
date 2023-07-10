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
    public partial class frmHocSinh : Form
    {
        public frmHocSinh()
        {
            InitializeComponent();
        }
        #region Các nút chức năng
        public void LayDuLieuMa(string Tim)
        {
            SqlCommand cmd = new SqlCommand(@"SELECT * FROM HocSinh WHERE MaHocSinh LIKE N'%" + Tim + "%'");

        }
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            //Kiểm tra dữ liệu có bị bỏ trống không?
            if (txtMaHS.Text == "" || txtTenHS.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Kiểm tra mã học sinh có độ dài chuỗi hợp lệ hay không?
            if (txtMaHS.Text.Length > 6)
            {
                MessageBox.Show("Mã học sinh tối đa có 6 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HocSinhDTO hs = new HocSinhDTO();
            hs.SMaHS = txtMaHS.Text;
            hs.STenHS = txtTenHS.Text;
            hs.DNgaySinh = DateTime.Parse(dtpNgaySinh.Text);

            if (radNam.Checked == true)
            {
                hs.SGioiTinh = "Nam";
            }
            else
            {
                hs.SGioiTinh = "Nữ";
            }
            hs.SDiaChi = txtDiaChi.Text;
            hs.ISDT = int.Parse(txtSDT.Text);
            hs.SAnh = txtAnh.Text;
            hs.SMaQueQuan = cboQueQuan.SelectedValue.ToString();

            if (HocSinhBUS.ThemHocSinh(hs) == false)
            {
                MessageBox.Show("Không tìm được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HienThiDSHocSinhLenDatagrid();
            MessageBox.Show("Đã thêm học sinh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {

            //Kiểm tra dữ liệu có bị bỏ trống không?
            if (txtMaHS.Text == "" || txtTenHS.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra mã học sinh có bị trùng hay không?
            if (HocSinhBUS.TimHocSinhTheoMa(txtMaHS.Text) == null)
            {
                MessageBox.Show("Không tồn tại mã học sinh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Gán giá trị vào HocSinhDTO(), thực hiện sửa HocSinhDTO
            HocSinhDTO hs = new HocSinhDTO();
            hs.SMaHS = txtMaHS.Text;
            hs.STenHS = txtTenHS.Text;
            hs.DNgaySinh = DateTime.Parse(dtpNgaySinh.Text);
            if (radNam.Checked == true)
            {
                hs.SGioiTinh = "Nam";
            }
            else
            {
                hs.SGioiTinh = "Nữ";
            };
            hs.SDiaChi = txtDiaChi.Text;
            hs.ISDT = int.Parse(txtSDT.Text);
            hs.SAnh = txtAnh.Text;
            hs.SMaQueQuan = cboQueQuan.SelectedValue.ToString();


            if (HocSinhBUS.SuaHocSinh(hs) == false)
            {
                MessageBox.Show("Chưa cập nhật được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HienThiDSHocSinhLenDatagrid();
            MessageBox.Show("Đã cập nhật học sinh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra mã học sinh có tồn tại hay không? Nếu không thì không xóa.
            if (HocSinhBUS.TimHocSinhTheoMa(txtMaHS.Text) == null)
            {
                MessageBox.Show("Không tồn tại mã học sinh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Gán giá trị vào HocSinhDTO(), thực hiện sửa HocSinhDTO.
            HocSinhDTO hs = new HocSinhDTO();
            hs.SMaHS = txtMaHS.Text;

            if (HocSinhBUS.XoaHocSinh(hs) == false)
            {
                MessageBox.Show("Chưa xóa được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HienThiDSHocSinhLenDatagrid();

            MessageBox.Show("Đã xóa học sinh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMoi_Click_1(object sender, EventArgs e)
        {
            txtAnh.Text = "";
            txtMaHS.Text = "";
            txtTenHS.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            dtpNgaySinh.Value = DateTime.Today;
            radNam.Checked = true;
            cboQueQuan.Text = "";
        }

        private void btnLoad_Click_1(object sender, EventArgs e)
        {
            frmHocSinh_Load(sender, e);
        }

        private void btnInAn_Click(object sender, EventArgs e)
        {
            frmReportHocSinh hs = new frmReportHocSinh();
            hs.ShowDialog();
        }

        private void btnChon_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2; //ưu tiên ảnh đuôi .jpg trước
            dlgOpen.InitialDirectory = Application.StartupPath + "\\Resources\\AnhHocSinh";
            dlgOpen.Title = "Chọn ảnh học sinh!";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                txtAnh.Text = System.IO.Path.GetFileName(dlgOpen.FileName);
                picAnh.Image = Image.FromFile(Application.StartupPath + "\\Resources\\AnhHocSinh\\" + txtAnh.Text);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            List<HocSinhDTO> ds = HocSinhBUS.LayDSHocSinh();
            List<HocSinhDTO> result = (from hs in ds
                                       where hs.SMaHS.Contains(txtTimKiemMa.Text)
                                       where hs.STenHS.Contains(txtTimKiemTen.Text)
                                       select hs).ToList();
            dgvHocSinh.DataSource = result;
        }
        #endregion

        #region Load Combobox, load datagridview
        private void HienThiDSHocSinhLenDatagrid()
        {

            List<HocSinhDTO> lstHocSinh = HocSinhBUS.LayDSHocSinh();
            dgvHocSinh.DataSource = lstHocSinh;
            dgvHocSinh.Columns["SMaHS"].HeaderText = "Mã Học Sinh";
            dgvHocSinh.Columns["STenHS"].HeaderText = "Tên Học Sinh";
            dgvHocSinh.Columns["DNgaySinh"].HeaderText = "Ngày sinh";
            dgvHocSinh.Columns["SGioiTinh"].HeaderText = "Giới tính";
            dgvHocSinh.Columns["SDiaChi"].HeaderText = "Địa Chỉ";
            dgvHocSinh.Columns["ISDT"].HeaderText = "SDT";
            dgvHocSinh.Columns["SAnh"].HeaderText = "Hình Ảnh";
            dgvHocSinh.Columns["SMaQueQuan"].HeaderText = "Quê quán";

            dgvHocSinh.Columns["SMaHS"].Width = 60;
            dgvHocSinh.Columns["STenHS"].Width = 120;
            dgvHocSinh.Columns["DNgaySinh"].Width = 60;
            dgvHocSinh.Columns["SGioiTinh"].Width = 60;
            dgvHocSinh.Columns["SDiaChi"].Width = 120;
            dgvHocSinh.Columns["ISDT"].Width = 60;
            dgvHocSinh.Columns["SAnh"].Width = 60;
            dgvHocSinh.Columns["SMaQueQuan"].Width = 60;

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
        private void frmHocSinh_Load(object sender, EventArgs e)
        {
            HienThiQueQuanLenCombobox();
            HienThiDSHocSinhLenDatagrid();
            dgvHocSinh_Click(sender, e);
        }

        private void dgvHocSinh_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgvHocSinh.SelectedRows[0];
            txtMaHS.Text = r.Cells["SMaHS"].Value.ToString();
            txtTenHS.Text = r.Cells["STenHS"].Value.ToString();
            dtpNgaySinh.Text = r.Cells["DNgaySinh"].Value.ToString();

            if (r.Cells["SGioiTinh"].Value.ToString() == "Nam")
            {
                radNam.Checked = true;
            }
            else
                radNu.Checked = true;

            txtDiaChi.Text = r.Cells["SDiaChi"].Value.ToString();
            txtSDT.Text = r.Cells["ISDT"].Value.ToString();
            txtAnh.Text = r.Cells["SAnh"].Value.ToString();

            cboQueQuan.SelectedValue = r.Cells["SMaQueQuan"].Value.ToString();

            if (txtAnh.Text.Trim() != "")
            {
                try
                {
                    picAnh.Image = Image.FromFile(Application.StartupPath + "\\Resources\\AnhHocSinh\\" + txtAnh.Text);
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
        #endregion

        
    }
}
