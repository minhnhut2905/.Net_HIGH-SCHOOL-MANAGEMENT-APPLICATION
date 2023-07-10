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
    public partial class frmBangDiemHK2 : Form
    {
        public frmBangDiemHK2()
        {
            InitializeComponent();
        }
        #region Các nút chức năng
        //Thoát.
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        //Làm mới.
        private void btnMoi_Click(object sender, EventArgs e)
        {
            cboMaHS.Text = "";
            cboMaLop.Text = "";
            txtDiemToan.Text = "";
            txtDiemVan.Text = "";
            txtDiemAnh.Text = "";
            txtDiemSinh.Text = "";
            dtpNamHoc.Value = DateTime.Today;
            txtDiemHoa.Text = "";
            txtDiemLi.Text = "";
            txtDiemSu.Text = "";
            txtDiemDia.Text = "";
            txtDiemGDCD.Text = "";
            txtDiemCN.Text = "";
            txtDiemTin.Text = "";
            txtDiemTB.Text = "0";
            txtXepLoai.Text = "Giỏi";
        }
        //Thêm bảng điểm.
        private void btnThem_Click(object sender, EventArgs e)
        {
            //Kiểm tra dữ liệu có bị bỏ trống không?
            if (cboMaHS.SelectedValue.ToString() == "" || cboMaLop.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Kiểm tra mã học sinh có độ dài chuỗi hợp lệ hay không?
            /*
            if (cboMaHS.Text.Length > 10)
            {
                MessageBox.Show("Mã học sinh tối đa có 10 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            */
            BangDiemHK2_DTO bd = new BangDiemHK2_DTO();
            bd.SMaHS = cboMaHS.SelectedValue.ToString();
            bd.SMaLop = cboMaLop.SelectedValue.ToString();
            bd.DtNamHoc = DateTime.Parse(dtpNamHoc.Text);

            bd.FDiemToan = float.Parse(txtDiemToan.Text);
            bd.FDiemVan = float.Parse(txtDiemVan.Text);
            bd.FDiemAnh = float.Parse(txtDiemAnh.Text);
            bd.FDiemSinh = float.Parse(txtDiemSinh.Text);
            bd.FDiemHoa = float.Parse(txtDiemHoa.Text);
            bd.FDiemLi = float.Parse(txtDiemLi.Text);
            bd.FDiemSu = float.Parse(txtDiemSu.Text);
            bd.FDiemDia = float.Parse(txtDiemDia.Text);
            bd.FDiemGDCD = float.Parse(txtDiemGDCD.Text);
            bd.FCongNghe = float.Parse(txtDiemCN.Text);
            bd.FDiemTinHoc = float.Parse(txtDiemTin.Text);
            bd.FDiem_TB_HK2 = float.Parse(txtDiemTB.Text);
            bd.SXepLoaiHk2 = txtXepLoai.Text;

            if (BangDiemHK2_BUS.ThemBangDiem(bd) == false)
            {
                MessageBox.Show("Không tìm được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HienThiBangDiem2LenDatagrid();
            MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Sửa bảng điểm.
        private void btnSua_Click(object sender, EventArgs e)
        {

            //Kiểm tra dữ liệu có bị bỏ trống không?
            if (cboMaHS.SelectedValue.ToString() == "" || cboMaLop.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra mã học sinh có bị trùng hay không?
            if (BangDiemHK2_BUS.TimBangDiemTheoMa(cboMaHS.SelectedValue.ToString()) == null)
            {
                MessageBox.Show("Không tồn tại mã học sinh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Gán giá trị vào BangDiemHK1_DTO(), thực hiện sửa BangDiemHK1_DTO
            BangDiemHK2_DTO bd = new BangDiemHK2_DTO();
            bd.SMaHS = cboMaHS.SelectedValue.ToString();
            bd.SMaLop = cboMaLop.SelectedValue.ToString();
            bd.DtNamHoc = DateTime.Parse(dtpNamHoc.Text);
            bd.FDiemToan = float.Parse(txtDiemToan.Text);
            bd.FDiemVan = float.Parse(txtDiemVan.Text);
            bd.FDiemAnh = float.Parse(txtDiemAnh.Text);
            bd.FDiemSinh = float.Parse(txtDiemSinh.Text);
            bd.FDiemHoa = float.Parse(txtDiemHoa.Text);
            bd.FDiemLi = float.Parse(txtDiemLi.Text);
            bd.FDiemSu = float.Parse(txtDiemSu.Text);
            bd.FDiemDia = float.Parse(txtDiemDia.Text);
            bd.FCongNghe = float.Parse(txtDiemCN.Text);
            bd.FDiemTinHoc = float.Parse(txtDiemTin.Text);
            bd.FDiem_TB_HK2 = float.Parse(txtDiemTB.Text);
            bd.SXepLoaiHk2 = txtXepLoai.Text;
            if (BangDiemHK2_BUS.SuaBangDiem(bd) == false)
            {
                MessageBox.Show("Chưa cập nhật được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HienThiBangDiem2LenDatagrid();
            MessageBox.Show("Đã cập nhật bảng điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Xóa bảng điểm.
        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra mã học sinh có tồn tại hay không? Nếu không thì không xóa.
            if (BangDiemHK2_BUS.TimBangDiemTheoMa(cboMaHS.SelectedValue.ToString()) == null)
            {
                MessageBox.Show("Không tồn tại mã học sinh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Gán giá trị vào BangDiemHK1_DTO(), thực hiện sửa BangDiemHK1_DTO.
            BangDiemHK2_DTO bd = new BangDiemHK2_DTO();
            bd.SMaHS = cboMaHS.SelectedValue.ToString();

            if (BangDiemHK2_BUS.XoaBangDiem(bd) == false)
            {
                MessageBox.Show("Chưa xóa được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HienThiBangDiem2LenDatagrid();
            MessageBox.Show("Đã xóa bảng điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Lấy dữ liệu
        public void LayDuLieuMa(string Tim)
        {
            SqlCommand cmd = new SqlCommand(@"SELECT * FROM BangDiem_HK2 WHERE MaHocSinh LIKE N'%" + Tim + "%' OR  MaLop LIKE N'%" + Tim + "%'");

        }
        //Tìm 
        private void btnTim_Click(object sender, EventArgs e)
        {
            List<BangDiemHK2_DTO> ds = BangDiemHK2_BUS.LayDSBangDiemHK2();
            List<BangDiemHK2_DTO> result = (from bd in ds
                                            where bd.SMaHS.Contains(txtTimKiem.Text)
                                            //where gv.STenGV.Contains(txtTimKiemTen.Text)
                                            select bd).ToList();
            dgvBangDiem2.DataSource = result;
        }
        //Tính điểm trung bình, xếp loại.
        private void btnTinh_Click(object sender, EventArgs e)
        {
            float Toan = float.Parse(txtDiemToan.Text);
            float Van = float.Parse(txtDiemVan.Text);
            float Anh = float.Parse(txtDiemAnh.Text);
            float Sinh = float.Parse(txtDiemSinh.Text);
            float Hoa = float.Parse(txtDiemHoa.Text);
            float Li = float.Parse(txtDiemLi.Text);
            float Su = float.Parse(txtDiemSu.Text);
            float Dia = float.Parse(txtDiemDia.Text);
            float GDCD = float.Parse(txtDiemGDCD.Text);
            float CongNghe = float.Parse(txtDiemCN.Text);
            float TinHoc = float.Parse(txtDiemTin.Text);
            float DiemTB = 0;
            

            DiemTB = ((Toan + Van) * 2 + (Anh + Sinh + Hoa + Li + Su + Dia + GDCD + CongNghe + TinHoc)) / 13;
            // Nếu Điểm Trung Bình >= 8
            if (DiemTB >= 8)
            {
                // Nếu Toán > = 8
                if ((Toan >= 8))
                {
                    //Nếu Điểm Văn >= 6.5
                    if ((Van >= 6.5))
                    {
                        //Nếu Điểm Anh Văn >= 6.5
                        if (Anh >= 6.5)
                        {
                            txtDiemTB.Text = DiemTB.ToString();
                            txtXepLoai.Text = "Giỏi";
                        }
                        else if ((Anh >= 5) && (Anh < 6.5)) // Nếu 5 <= Điểm Anh Văn < 6.5
                        {
                            txtDiemTB.Text = DiemTB.ToString();
                            txtXepLoai.Text = "Khá";
                        }
                        else if ((Anh >= 4) && (Anh < 5)) // Nếu  4 <= Điểm Anh Văn < 5
                        {
                            txtDiemTB.Text = DiemTB.ToString();
                            txtXepLoai.Text = "Trung bình";
                        }
                        else // Nếu Điểm Anh Văn < 4
                        {
                            txtDiemTB.Text = DiemTB.ToString();
                            txtXepLoai.Text = "Yếu";
                        }
                    }
                    else if ((Van >= 5) && (Van < 6.5)) //Nếu 5 <= Điểm Văn < 6.5
                    {
                        if (Anh >= 5)
                        {
                            txtDiemTB.Text = DiemTB.ToString();
                            txtXepLoai.Text = "Khá";
                        }
                        else if ((Anh >= 4) && (Anh < 5))
                        {
                            txtDiemTB.Text = DiemTB.ToString();
                            txtXepLoai.Text = "Trung Bình";
                        }
                        else
                        {
                            txtDiemTB.Text = DiemTB.ToString();
                            txtXepLoai.Text = "Yếu";
                        }
                    }
                    else if ((Van >= 4) && (Van < 5))
                    {
                        if (Anh >= 4)
                        {
                            txtDiemTB.Text = DiemTB.ToString();
                            txtXepLoai.Text = "Trung Bình";
                        }
                        else
                        {
                            txtDiemTB.Text = DiemTB.ToString();
                            txtXepLoai.Text = "Yếu";
                        }
                    }
                    else
                    {
                        txtDiemTB.Text = DiemTB.ToString();
                        txtXepLoai.Text = "Yếu";
                    }

                }
                // Nếu 6.5 <= Toán < 8 
                else if ((Toan >= 6.5) && (Toan < 8))
                {
                    if (Van >= 8)
                    {
                        if (Anh >= 6.5)
                        {
                            txtDiemTB.Text = DiemTB.ToString();
                            txtXepLoai.Text = "Giỏi";
                        }
                        else if (Anh >= 5 && Anh < 6.5)
                        {
                            txtDiemTB.Text = DiemTB.ToString();
                            txtXepLoai.Text = "Khá";
                        }
                        else if (Anh >= 4 && Anh < 5)
                        {
                            txtDiemTB.Text = DiemTB.ToString();
                            txtXepLoai.Text = "Trung Bình";
                        }
                        else
                        {
                            txtDiemTB.Text = DiemTB.ToString();
                            txtXepLoai.Text = "Yếu";
                        }
                    }
                    else if ((Van >= 6.5) && (Van < 8))
                    {
                        if (Anh >= 5)
                        {
                            txtDiemTB.Text = DiemTB.ToString();
                            txtXepLoai.Text = "Khá";
                        }
                        else if ((Anh >= 4) && (Anh < 5))
                        {
                            txtDiemTB.Text = DiemTB.ToString();
                            txtXepLoai.Text = "Trung Bình";
                        }
                        else
                        {
                            txtDiemTB.Text = DiemTB.ToString();
                            txtXepLoai.Text = "Yếu";
                        }
                    }
                    else if ((Van >= 5) && (Van < 6.5))
                    {
                        if (Anh >= 5)
                        {
                            txtDiemTB.Text = DiemTB.ToString();
                            txtXepLoai.Text = "Khá";
                        }
                        else if ((Anh >= 4) && (Anh < 5))
                        {
                            txtDiemTB.Text = DiemTB.ToString();
                            txtXepLoai.Text = "Trung Bình";
                        }
                        else
                        {
                            txtDiemTB.Text = DiemTB.ToString();
                            txtXepLoai.Text = "Yếu";
                        }
                    }
                    else if ((Van >= 4) && (Van < 5))
                    {
                        if (Anh >= 4)
                        {
                            txtDiemTB.Text = DiemTB.ToString();
                            txtXepLoai.Text = "Trung Bình";
                        }
                        else
                        {
                            txtDiemTB.Text = DiemTB.ToString();
                            txtXepLoai.Text = "Yếu";
                        }
                    }
                    else
                    {
                        txtDiemTB.Text = DiemTB.ToString();
                        txtXepLoai.Text = "Yếu";
                    }
                }
                // Nếu 5 <=  Toán < 6.5
                else if (Toan >= 5 && Toan < 6.5)
                {
                    if ((Van >= 6.5))
                    {
                        if (Anh >= 4)
                        {
                            txtDiemTB.Text = DiemTB.ToString();
                            txtXepLoai.Text = "Khá";
                        }
                        else if ((Anh >= 4) && (Anh < 5))
                        {
                            txtDiemTB.Text = DiemTB.ToString();
                            txtXepLoai.Text = "Trung Bình";
                        }
                        else
                        {
                            txtDiemTB.Text = DiemTB.ToString();
                            txtXepLoai.Text = "Yếu";
                        }

                    }
                    if ((Van >= 4) && (Van < 6.5))
                    {
                        if (Anh >= 4)
                        {
                            txtDiemTB.Text = DiemTB.ToString();
                            txtXepLoai.Text = "Trung Bình";
                        }
                        else
                        {
                            txtDiemTB.Text = DiemTB.ToString();
                            txtXepLoai.Text = "Yếu";
                        }
                    }
                    else
                    {
                        txtDiemTB.Text = DiemTB.ToString();
                        txtXepLoai.Text = "Yếu";
                    }
                }
                // Nếu 4 <=  Toán < 5
                else if ((Toan >= 4) && (Toan < 5))
                {
                    if (Van >= 5)
                    {
                        if (Anh >= 4)
                        {
                            txtDiemTB.Text = DiemTB.ToString();
                            txtXepLoai.Text = "Trung Bình";
                        }
                        else
                        {
                            txtDiemTB.Text = DiemTB.ToString();
                            txtXepLoai.Text = "Yếu";
                        }

                    }
                    else
                    {
                        txtDiemTB.Text = DiemTB.ToString();
                        txtXepLoai.Text = "Yếu";
                    }

                }
                // Nếu Toán < 4
                else
                {
                    txtDiemTB.Text = DiemTB.ToString();
                    txtXepLoai.Text = "Yếu";
                }

            }
            //Điểm Trung Bình Từ 6.5 - 8
            else if (DiemTB >= 6.5 && DiemTB < 8)
            {
                // Nếu Toán > = 6.5
                if ((Toan >= 6.5))
                {
                    if ((Van >= 5))
                    {
                        if (Anh >= 5)
                        {
                            txtDiemTB.Text = DiemTB.ToString();
                            txtXepLoai.Text = "Khá";
                        }
                        else if ((Anh >= 4) && (Anh < 5))
                        {
                            txtDiemTB.Text = DiemTB.ToString();
                            txtXepLoai.Text = "Trung bình";
                        }
                        else
                        {
                            txtDiemTB.Text = DiemTB.ToString();
                            txtXepLoai.Text = "Yếu";
                        }
                    }
                    else if ((Van >= 4) && (Van < 5))
                    {
                        if (Anh >= 4)
                        {
                            txtDiemTB.Text = DiemTB.ToString();
                            txtXepLoai.Text = "Trung Bình";
                        }
                        else
                        {
                            txtDiemTB.Text = DiemTB.ToString();
                            txtXepLoai.Text = "Yếu";
                        }
                    }
                    else
                    {
                        txtDiemTB.Text = DiemTB.ToString();
                        txtXepLoai.Text = "Yếu";
                    }
                }
                // Nếu 4 <= Toán < 6.5
                else if ((Toan >= 5) && (Toan < 6.5))
                {
                    if ((Van >= 6.5))
                    {
                        if (Anh >= 5)
                        {
                            txtDiemTB.Text = DiemTB.ToString();
                            txtXepLoai.Text = "Khá";
                        }
                        else if ((Anh < 5) && (Anh >= 4))
                        {
                            txtDiemTB.Text = DiemTB.ToString();
                            txtXepLoai.Text = "Trung Bình";
                        }
                        else
                        {
                            txtDiemTB.Text = DiemTB.ToString();
                            txtXepLoai.Text = "Yếu";
                        }

                    }
                    else if ((Van < 6.5) && (Van >= 4))
                    {
                        if ((Anh >= 4))
                        {
                            txtDiemTB.Text = DiemTB.ToString();
                            txtXepLoai.Text = "Trung Bình";
                        }
                        else
                        {
                            txtDiemTB.Text = DiemTB.ToString();
                            txtXepLoai.Text = "Yếu";
                        }
                    }
                    else
                    {
                        txtDiemTB.Text = DiemTB.ToString();
                        txtXepLoai.Text = "Yếu";
                    }
                }
                // Nếu 4 <= Toán < 5
                else if ((Toan >= 4) && (Toan < 5))
                {
                    if ((Van >= 6.5))
                    {
                        if (Anh >= 5)
                        {
                            txtDiemTB.Text = DiemTB.ToString();
                            txtXepLoai.Text = "Khá";
                        }
                        else if ((Anh < 5) && (Anh >= 4))
                        {
                            txtDiemTB.Text = DiemTB.ToString();
                            txtXepLoai.Text = "Trung Bình";
                        }
                        else
                        {
                            txtDiemTB.Text = DiemTB.ToString();
                            txtXepLoai.Text = "Yếu";
                        }

                    }
                    else if ((Van < 6.5) && (Van >= 4))
                    {
                        if ((Anh >= 4))
                        {
                            txtDiemTB.Text = DiemTB.ToString();
                            txtXepLoai.Text = "Trung Bình";
                        }
                        else
                        {
                            txtDiemTB.Text = DiemTB.ToString();
                            txtXepLoai.Text = "Yếu";
                        }
                    }
                    else
                    {
                        txtDiemTB.Text = DiemTB.ToString();
                        txtXepLoai.Text = "Yếu";
                    }
                }
                // Nếu Toán < 4
                else
                {
                    txtDiemTB.Text = DiemTB.ToString();
                    txtXepLoai.Text = "Yếu";
                }

            }
            else if (DiemTB >= 4 && DiemTB < 5)
            {
                txtDiemTB.Text = DiemTB.ToString();
                txtXepLoai.Text = "Trung Bình";
            }
            else
            {
                txtDiemTB.Text = DiemTB.ToString();
                txtXepLoai.Text = "Yếu";
            }
        }
        // Tải lại.
        private void btnLoad_Click(object sender, EventArgs e)
        {
            frmBangDiemHK2_Load(sender, e);
        }
        #endregion

        //Lấy Tên Học Sinh hiển thị lên combobox
        private void HienThiHocSinhLenCombobox()
        {
            List<HocSinhDTO> lstHocSinh = HocSinhBUS.LayDSHocSinh();
            cboMaHS.DataSource = lstHocSinh;
            cboMaHS.DisplayMember = "STenHS";
            cboMaHS.ValueMember = "SMaHS";
        }
        //Lấy Lớp hiển thị lên combobox
        private void HienThiLopHocLenCombobox()
        {
            List<PhanLopDTO> lstPhanLop = PhanLopBUS.LayDSPhanLop();
            cboMaLop.DataSource = lstPhanLop;
            cboMaLop.DisplayMember = "STenLop";
            cboMaLop.ValueMember = "SMaLop";
        }
        // Click lên datagridview.
        private void dgvBangDiem2_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgvBangDiem2.SelectedRows[0];
            cboMaHS.SelectedValue = r.Cells["SMaHS"].Value.ToString();
            cboMaLop.SelectedValue = r.Cells["SMaLop"].Value.ToString();
            dtpNamHoc.Text = r.Cells["DtNamHoc"].Value.ToString();
            txtDiemToan.Text = r.Cells["FDiemToan"].Value.ToString();
            txtDiemVan.Text = r.Cells["FDiemVan"].Value.ToString();
            txtDiemAnh.Text = r.Cells["FDiemAnh"].Value.ToString();
            txtDiemSinh.Text = r.Cells["FDiemSinh"].Value.ToString();
            txtDiemHoa.Text = r.Cells["FDiemHoa"].Value.ToString();
            txtDiemLi.Text = r.Cells["FDiemLi"].Value.ToString();
            txtDiemSu.Text = r.Cells["FDiemSu"].Value.ToString();
            txtDiemDia.Text = r.Cells["FDiemDia"].Value.ToString();
            txtDiemGDCD.Text = r.Cells["FDiemGDCD"].Value.ToString();
            txtDiemCN.Text = r.Cells["FCongNghe"].Value.ToString();
            txtDiemTin.Text = r.Cells["FDiemTinHoc"].Value.ToString();
            txtDiemTB.Text = r.Cells["FDiem_TB_HK2"].Value.ToString();
            txtXepLoai.Text = r.Cells["SXepLoaiHk2"].Value.ToString();
        }
        //Hiển thị lên datagridview
        private void HienThiBangDiem2LenDatagrid()
        {
            List<BangDiemHK2_DTO> lstBangDiem = BangDiemHK2_BUS.LayDSBangDiemHK2();
            dgvBangDiem2.DataSource = lstBangDiem;
            // Việt hóa tiêu đề cột
            dgvBangDiem2.Columns["SMaHS"].HeaderText = "Mã Học Sinh";
            dgvBangDiem2.Columns["SMaLop"].HeaderText = "Lớp";
            dgvBangDiem2.Columns["DtNamHoc"].HeaderText = "Năm học";
            dgvBangDiem2.Columns["FDiemToan"].HeaderText = "Toán";
            dgvBangDiem2.Columns["FDiemVan"].HeaderText = "Ngữ Văn";
            dgvBangDiem2.Columns["FDiemAnh"].HeaderText = "Anh Văn";
            dgvBangDiem2.Columns["FDiemSinh"].HeaderText = "Sinh Học";
            dgvBangDiem2.Columns["FDiemHoa"].HeaderText = "Hóa Học";
            dgvBangDiem2.Columns["FDiemLi"].HeaderText = "Vật Lí";
            dgvBangDiem2.Columns["FDiemSu"].HeaderText = "Lịch Sử";
            dgvBangDiem2.Columns["FDiemDia"].HeaderText = "Địa Lí";
            dgvBangDiem2.Columns["FDiemGDCD"].HeaderText = "GDCD";
            dgvBangDiem2.Columns["FCongNghe"].HeaderText = "Công Nghệ";
            dgvBangDiem2.Columns["FDiemTinHoc"].HeaderText = "Tin Học";
            dgvBangDiem2.Columns["FDiem_TB_HK2"].HeaderText = "Điểm Trung Bình HK2";
            dgvBangDiem2.Columns["SXepLoaiHk2"].HeaderText = "Xếp Loại Học Kì 2";
            //Chỉnh độ rộng của cột
            dgvBangDiem2.Columns["SMaHS"].Width = 60;
            dgvBangDiem2.Columns["SMaLop"].Width = 60;
            dgvBangDiem2.Columns["DtNamHoc"].Width = 60;
            dgvBangDiem2.Columns["FDiemToan"].Width = 60;
            dgvBangDiem2.Columns["FDiemVan"].Width = 60;
            dgvBangDiem2.Columns["FDiemAnh"].Width = 120;
            dgvBangDiem2.Columns["FDiemSinh"].Width = 60;
            dgvBangDiem2.Columns["FDiemHoa"].Width = 60;
            dgvBangDiem2.Columns["FDiemLi"].Width = 60;
            dgvBangDiem2.Columns["FDiemSu"].Width = 60;
            dgvBangDiem2.Columns["FDiemDia"].Width = 60;
            dgvBangDiem2.Columns["FDiemGDCD"].Width = 60;
            dgvBangDiem2.Columns["FCongNghe"].Width = 60;
            dgvBangDiem2.Columns["FDiemTinHoc"].Width = 60;
            dgvBangDiem2.Columns["FDiem_TB_HK2"].Width = 60;
            dgvBangDiem2.Columns["SXepLoaiHk2"].Width = 60;
        }

        private void frmBangDiemHK2_Load(object sender, EventArgs e)
        {
            txtDiemTB.Enabled = false;
            txtXepLoai.Enabled = false;
            HienThiHocSinhLenCombobox();
            HienThiLopHocLenCombobox();
            HienThiBangDiem2LenDatagrid();
            dgvBangDiem2_Click(sender, e);
        }

        private void cboMaHS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PhanLopBUS.TimPhanLopTheoMa(cboMaHS.SelectedValue.ToString()) != null)// bằng null thì không có mã học sinh.
            {
                PhanLopDTO bd = PhanLopBUS.TimPhanLopTheoMa(cboMaHS.SelectedValue.ToString());
                cboMaLop.Text = bd.SMaLop;
            }
        }
    }
}
