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
    public partial class frmBangDiemCaNam : Form
    {
        public frmBangDiemCaNam()
        {
            InitializeComponent();
        }
        #region Các nút chức năng
        private void btnLoad_Click(object sender, EventArgs e)
        {
            frmBangDiemCaNam_Load(sender, e);
        }
        public void LayDuLieuMa(string Tim)
        {
            SqlCommand cmd = new SqlCommand(@"SELECT * FROM BangDiemCaNam WHERE MaHocSinh LIKE N'%" + Tim + "%' OR  MaLop LIKE N'%" + Tim + "%'");

        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            List<BangDiemCaNam_DTO> ds = BangDiemCaNam_BUS.LayDSBangDiemCaNam();
            List<BangDiemCaNam_DTO> result = (from bd in ds
                                            where bd.SMaHS.Contains(txtTimKiem.Text)
                                            select bd).ToList();
            dgvBangDiemCaNam.DataSource = result;
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            cboMaHS.Text = "";
            cboMaLop.Text = "";
            txtDiemTB1.Text= "0";
            txtDiemTB2.Text = "0";
            txtDiemTBCaNam.Text = "0";
            txtXepLoai.Text = "Giỏi";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Kiểm tra dữ liệu có bị bỏ trống không?
            if (cboMaHS.SelectedValue.ToString() == "" || cboMaLop.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BangDiemCaNam_DTO bd = new BangDiemCaNam_DTO();
            bd.SMaHS = cboMaHS.SelectedValue.ToString();
            bd.SMaLop = cboMaLop.SelectedValue.ToString();
            bd.FDiemTB_HK1 = float.Parse(txtDiemTB1.Text);
            bd.FDiemTB_HK2 = float.Parse(txtDiemTB2.Text);
            bd.SXepLoaiCaNam = txtXepLoai.Text;

            if (BangDiemCaNam_BUS.ThemBangDiem(bd) == false)
            {
                MessageBox.Show("Không thêm được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HienThiBangDiemCaNamLenDatagrid();
            MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //Kiểm tra dữ liệu có bị bỏ trống không?
            if (cboMaHS.SelectedValue.ToString() == "" || cboMaLop.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra mã học sinh có bị trùng hay không?
            if (BangDiemCaNam_BUS.TimBangDiemTheoMa(cboMaHS.SelectedValue.ToString()) == null)
            {
                MessageBox.Show("Không tồn tại mã học sinh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Gán giá trị vào BangDiemHKCaNam_DTO(), thực hiện sửa BangDiemHKCaNam_DTO
            BangDiemCaNam_DTO bd = new BangDiemCaNam_DTO();
            bd.SMaHS = cboMaHS.SelectedValue.ToString();
            bd.SMaLop = cboMaLop.SelectedValue.ToString();
            bd.FDiemTB_HK1 = float.Parse(txtDiemTB1.Text);
            bd.FDiemTB_HK2 = float.Parse(txtDiemTB2.Text);
            bd.FDiemTbCaNam = float.Parse(txtDiemTB2.Text);
            bd.SXepLoaiCaNam = txtXepLoai.Text;
            if (BangDiemCaNam_BUS.SuaBangDiem(bd) == false)
            {
                MessageBox.Show("Chưa cập nhật được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HienThiBangDiemCaNamLenDatagrid();
            MessageBox.Show("Đã cập nhật bảng điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra mã học sinh có tồn tại hay không? Nếu không thì không xóa.
            if (BangDiemCaNam_BUS.TimBangDiemTheoMa(cboMaHS.SelectedValue.ToString()) == null)
            {
                MessageBox.Show("Không tồn tại mã học sinh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Gán giá trị vào BangDiemCaNam_DTO(), thực hiện sửa BangDiemCaNam_DTO.
            BangDiemCaNam_DTO bd = new BangDiemCaNam_DTO();
            bd.SMaHS = cboMaHS.SelectedValue.ToString();

            if (BangDiemCaNam_BUS.XoaBangDiem(bd) == false)
            {
                MessageBox.Show("Chưa xóa được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HienThiBangDiemCaNamLenDatagrid();
            MessageBox.Show("Đã xóa bảng điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            float DiemTBHK1 = float.Parse(txtDiemTB1.Text);
            float DiemTBHK2 = float.Parse(txtDiemTB2.Text);
            float DiemTBCaNam = 0;
            DiemTBCaNam = (DiemTBHK1 + (DiemTBHK2 * 2))/ 3;

            if(DiemTBCaNam >= 8)
            {
                txtDiemTBCaNam.Text = DiemTBCaNam.ToString();
                txtXepLoai.Text = "Giỏi";
            }    
            else if((DiemTBCaNam >= 6.5) && (DiemTBCaNam < 8))
            {
                txtDiemTBCaNam.Text = DiemTBCaNam.ToString();
                txtXepLoai.Text = "Khá";
            }
            else if ((DiemTBCaNam >= 5) && (DiemTBCaNam < 6.5))
            {
                txtDiemTBCaNam.Text = DiemTBCaNam.ToString();
                txtXepLoai.Text = "Trung Bình";
            }
            else
            {
                txtDiemTBCaNam.Text = DiemTBCaNam.ToString();
                txtXepLoai.Text = "Yếu";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        #endregion

        #region Xử lý
        private void HienThiBangDiemCaNamLenDatagrid()
        {
            List<BangDiemCaNam_DTO> lstBangDiem = BangDiemCaNam_BUS.LayDSBangDiemCaNam();
            dgvBangDiemCaNam.DataSource = lstBangDiem;
            // Việt hóa tiêu đề cột
            dgvBangDiemCaNam.Columns["SMaHS"].HeaderText = "Mã Học Sinh";
            dgvBangDiemCaNam.Columns["SMaLop"].HeaderText = "Lớp";

            dgvBangDiemCaNam.Columns["FDiemTB_HK1"].HeaderText = "Điểm Trung Bình HK1";
            dgvBangDiemCaNam.Columns["FDiemTB_HK2"].HeaderText = "Điểm Trung Bình HK2";
            dgvBangDiemCaNam.Columns["FDiemTbCaNam"].HeaderText = "Điểm Trung Bình Cả Năm";
            dgvBangDiemCaNam.Columns["SXepLoaiCaNam"].HeaderText = "Xếp Loại";
            //Chỉnh độ rộng của cột
            dgvBangDiemCaNam.Columns["SMaHS"].Width = 60;
            dgvBangDiemCaNam.Columns["SMaLop"].Width = 60;
            dgvBangDiemCaNam.Columns["FDiemTB_HK1"].Width = 60;
            dgvBangDiemCaNam.Columns["FDiemTB_HK2"].Width = 60;
            dgvBangDiemCaNam.Columns["FDiemTbCaNam"].Width = 60;
            dgvBangDiemCaNam.Columns["SXepLoaiCaNam"].Width = 60;
        }
        private void HienThiHocSinhLenCombobox()
        {
            List<HocSinhDTO> lstHocSinh = HocSinhBUS.LayDSHocSinh();
            cboMaHS.DataSource = lstHocSinh;
            cboMaHS.DisplayMember = "STenHS";
            cboMaHS.ValueMember = "SMaHS";
        }
        private void HienThiLopHocLenCombobox()
        {
            List<PhanLopDTO> lstPhanLop = PhanLopBUS.LayDSPhanLop();
            cboMaLop.DataSource = lstPhanLop;
            cboMaLop.DisplayMember = "STenLop";
            cboMaLop.ValueMember = "SMaLop";
        }
        private void frmBangDiemCaNam_Load(object sender, EventArgs e)
        {
            txtDiemTBCaNam.Enabled = false;
            txtXepLoai.Enabled = false;
            //txtDiemTB1.Enabled = false;
            //txtDiemTB2.Enabled = false;
            HienThiHocSinhLenCombobox();
            HienThiLopHocLenCombobox();
            HienThiBangDiemCaNamLenDatagrid();
            dgvBangDiemCaNam_Click(sender, e);
        }

        private void dgvBangDiemCaNam_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgvBangDiemCaNam.SelectedRows[0];
            cboMaHS.SelectedValue = r.Cells["SMaHS"].Value.ToString();
            cboMaLop.SelectedValue = r.Cells["SMaLop"].Value.ToString();
            txtDiemTB1.Text = r.Cells["FDiemTB_HK1"].Value.ToString();
            txtDiemTB2.Text = r.Cells["FDiemTB_HK2"].Value.ToString();
            txtDiemTBCaNam.Text = r.Cells["FDiemTbCaNam"].Value.ToString();
            txtXepLoai.Text = r.Cells["SXepLoaiCaNam"].Value.ToString();
        }

        private void cboMaHS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PhanLopBUS.TimPhanLopTheoMa(cboMaHS.SelectedValue.ToString()) != null)// bằng null thì không có mã học sinh.
            {
                PhanLopDTO bd = PhanLopBUS.TimPhanLopTheoMa(cboMaHS.SelectedValue.ToString());
                cboMaLop.Text = bd.SMaLop;  
            }
            if(BangDiemCaNam_BUS.TimBangDiemTheoMa(cboMaHS.SelectedValue.ToString()) != null)
            {
                BangDiemCaNam_DTO bd1 = BangDiemCaNam_BUS.TimBangDiemTheoMa(cboMaHS.SelectedValue.ToString());
                cboMaLop.Text = bd1.SMaLop;
                txtDiemTB1.Text = bd1.FDiemTB_HK1.ToString();
                txtDiemTB2.Text = bd1.FDiemTB_HK2.ToString();

            }
        }
        #endregion
    }
}
