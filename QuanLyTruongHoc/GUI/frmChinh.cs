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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using System.IO;
using GUI.Nhang_CustomControls;

namespace GUI
{
    
    public partial class frmChinh : Form
    {
        public bool bDangNhap = false; // Biến cờ cho biết người dùng đăng nhập hay chưa
        public static NguoiDungDTO NguoiDung; // lưu thông tin người dùng đã đăng nhập
        bool sidebarExpand;
        bool QuanLyExpand=true;
        bool BangDiemExpand=true;
        public frmChinh()
        {
            InitializeComponent();
            DangNhap();
        }
        #region Biến toàn cục
        frmChucVu fCV;
        frmQueQuan fQQ;
        frmNguoiDung fND;
        frmLopHoc fLH;
        frmPhanLop fPhanLop;
        frmGiangVien fGV;
        frmHocSinh fHS;
        frmLuongGV fLuongGV;
        frmLuongNV fLuongNV;
        frmBangDiemHK1 fBangDiemHK1;
        frmBangDiemHK2 fBangDiemHK2;
        frmBangDiemCaNam fBangDiemCaNam;
        frmReportHocSinh fInHocSinh;
        frmReportGiangVien fINGiangVien;
        frmIn_BangDiemHK1 fInBangDiemHk1;
        frmNhanVien fNhanVien;
        frmThongTinCaNhan fThongTin;
        frmInBangDiemHK2 fInBangDiemHK2;
        private Form activeForm;
        frmDangNhap fDN = new frmDangNhap();
        frmDoiMatKhau fDMK;
        #endregion

        private void HienThiMenu()
        {
            mnuDangNhap.Enabled = !bDangNhap;
            mnuDangXuat.Enabled = bDangNhap;
            // Hiển thị thông tin đăng nhập lên thanh trạng thái
            if (bDangNhap == true)
            {
                
                lblThoiGian.Text = "Thời điểm đăng nhập: " + DateTime.Now;
                lblHoTen.Text = "" + NguoiDung.SHoTen;  
                try
                   {
                     picAnh.Image = Image.FromFile(Application.StartupPath + @"\Resources\AnhNguoiDung\"+ NguoiDung.SHinhAnh);
                   }
                catch
                   {
                      picAnh.Image = Image.FromFile(Application.StartupPath + @"\Resources\noimage.png");
                   }

                // Hiển thị menu theo quyền
                int iQuyen;
                if (NguoiDung == null)
                {
                    iQuyen = 0;
                }
                else
                {
                    iQuyen = int.Parse(NguoiDung.IQuyen.ToString());
                }
                switch (iQuyen)
                {
                    case 1: //Quyền hạn của admin
                        lblQuyen.Text = "Quyền hạn: admin";
                        mniQueQuan.Enabled = true;
                        mniChucVu.Enabled = true;
                        mniNguoiDung.Enabled = true;
                        mniLopHoc.Enabled = true;
                        mniHocSinh.Enabled = true;
                        mniGiangVien.Enabled = true;
                        mniLuongGV.Enabled = false;
                        mniLuongNV.Enabled = false;
                        mniPhanLop.Enabled = true;
                        mnuDoiMK.Enabled = true;
                        mnuDangNhap.Enabled = false;
                        mnuDangXuat.Enabled = true;
                        mniBangDiemHK1.Enabled = false;
                        mnuBangDiemHK2.Enabled = false;
                        mnuBangDiemCaNam.Enabled = false;
                        mnuInGiangVien.Enabled = true;
                        mnuINHocSinh.Enabled = true;
                        mnuInBangDiemHK1.Enabled = false;
                        mnuInBangDiemHK2.Enabled = false;
                        mnuInBangDiem.Enabled = false;
                        mnuNhanVien.Enabled = true;

                        toolHocSinh.Enabled = true;
                        toolNhanVien.Enabled = true;
                        toolGiaoVien.Enabled = true;
                        toolTaiKhoan.Enabled = true;
                        toolBangDiem1.Enabled = false;
                        toolBangDiem2.Enabled = false;
                        toolBangDiemCaNam.Enabled = false;
                        toolLuongGiaoVien.Enabled = false;
                        toolLuongNhanVien.Enabled = false;
                        toolDangNhap.Enabled=false;
                        toolDangXuat.Enabled = true;

                        btnBangDiem.Enabled=false;
                        btnBangDiem1.Enabled=false;
                        btnBangDiem2.Enabled=false;
                        btnDiemCaNam.Enabled=false;
                        btnQuanLy.Enabled = true;
                        btnHocSinh.Enabled = true;
                        btnGiaoVien.Enabled = true;
                        btnNhanVien.Enabled = true;
                        btnLopHoc.Enabled = true;
                        btnChucVu.Enabled = true;
                        btnNguoiDung.Enabled = true;
                        btnInAn.Enabled = false;
                        btnThongKe.Enabled = false;

                        break;
                    case 2: //Quyền hạn của user
                        lblQuyen.Text = "Quyền hạn: user";

                        mnuDangNhap.Enabled = false;
                        mnuDangXuat.Enabled = true;
                        mniQueQuan.Enabled = true;
                        mniChucVu.Enabled = true;
                        mniNguoiDung.Enabled = false;
                        mniLopHoc.Enabled = true;
                        mniHocSinh.Enabled = true;
                        mniGiangVien.Enabled = true;
                        mniLuongGV.Enabled = true;
                        mniLuongNV.Enabled = true;
                        mniPhanLop.Enabled = true;
                        mnuDoiMK.Enabled = true;
                        mniBangDiemHK1.Enabled = true;
                        mnuBangDiemHK2.Enabled = true;
                        mnuBangDiemCaNam.Enabled = true;
                        mnuInGiangVien.Enabled = true;
                        mnuINHocSinh.Enabled = true;
                        mnuInBangDiemHK1.Enabled = true;
                        mnuInBangDiemHK2.Enabled = true;
                        mnuInBangDiem.Enabled = true;
                        mnuNhanVien.Enabled = true;


                        toolHocSinh.Enabled = true;
                        toolNhanVien.Enabled = true;
                        toolGiaoVien.Enabled = true;
                        toolTaiKhoan.Enabled = false;
                        toolBangDiem1.Enabled = true;
                        toolBangDiem2.Enabled = true;
                        toolBangDiemCaNam.Enabled = true;
                        toolLuongGiaoVien.Enabled = true;
                        toolLuongNhanVien.Enabled = true;
                        toolDangNhap.Enabled = false;
                        toolDangXuat.Enabled = true;

                        btnBangDiem.Enabled = true;
                        btnBangDiem1.Enabled = true;
                        btnBangDiem2.Enabled = true;
                        btnDiemCaNam.Enabled = true;
                        btnQuanLy.Enabled = true;
                        btnHocSinh.Enabled = true;
                        btnGiaoVien.Enabled = true;
                        btnNhanVien.Enabled = true;
                        btnLopHoc.Enabled = true;
                        btnChucVu.Enabled = true;
                        btnNguoiDung.Enabled = false;
                        btnInAn.Enabled= true;
                        btnThongKe.Enabled = true;

                        break;
                    default:
                        break;
                }
            }
            else
            {
                
                lblThoiGian.Text = "";
                lblHoTen.Text = "";
                lblQuyen.Text = "Chưa đăng nhập";
                picAnh.Image = Image.FromFile(Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + @"\Images\cloud_user.png");

                mniChucVu.Enabled = false;
                mniQueQuan.Enabled = false;
                mnuDangXuat.Enabled = false;
                mniNguoiDung.Enabled = false;
                mniLopHoc.Enabled = false;
                mniLopHoc.Enabled = false;
                mniHocSinh.Enabled = false;
                mniGiangVien.Enabled = false;
                mniLuongGV.Enabled = false;
                mniLuongNV.Enabled = false;
                mniPhanLop.Enabled = false;
                mnuDoiMK.Enabled = false;
                mniBangDiemHK1.Enabled = false;
                mnuBangDiemHK2.Enabled = false;
                mnuBangDiemCaNam.Enabled = false;
                mnuInGiangVien.Enabled = false;
                mnuINHocSinh.Enabled = false;
                mnuInBangDiemHK1.Enabled = false;
                mnuInBangDiemHK2.Enabled = false;
                mnuInBangDiem.Enabled = false;
                mnuNhanVien.Enabled = false;

                //btnThoat.Enabled = true;


                toolHocSinh.Enabled = false;
                toolNhanVien.Enabled = false;
                toolGiaoVien.Enabled = false;
                toolTaiKhoan.Enabled = false;
                toolBangDiem1.Enabled = false;
                toolBangDiem2.Enabled = false;
                toolBangDiemCaNam.Enabled = false;
                toolLuongGiaoVien.Enabled = false;
                toolLuongNhanVien.Enabled = false;
                toolDangNhap.Enabled = true;
                toolDangXuat.Enabled = false;

                btnBangDiem.Enabled = false;
                btnBangDiem1.Enabled = false;
                btnBangDiem2.Enabled = false;
                btnDiemCaNam.Enabled = false;
                btnQuanLy.Enabled = false;
                btnHocSinh.Enabled = false;
                btnGiaoVien.Enabled = false;
                btnNhanVien.Enabled =false;
                btnLopHoc.Enabled = false;
                btnChucVu.Enabled = false;
                btnNguoiDung.Enabled = false;
                btnInAn.Enabled = false;
                btnThongKe.Enabled = false;

            }
        }
        private void DangNhap()
        {
            if (fDN.ShowDialog() == DialogResult.OK)
            {
                if (fDN.txtTen.Text.Trim() == "")
                {
                    MessageBox.Show("Chưa nhập tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    fDN.txtTen.Focus();
                    return;
                }
                if (fDN.txtMatKhau.Text.Trim() == "")
                {
                    MessageBox.Show("Chưa nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    fDN.txtMatKhau.Focus();
                    return;
                }
                string sTenDangNhap = fDN.txtTen.Text;
                string sMatKhau = fDN.txtMatKhau.Text;
                NguoiDung = new NguoiDungDTO();
                NguoiDung = NguoiDungBUS.KiemTraTaiKhoan(sTenDangNhap, sMatKhau);
                if (NguoiDung != null)
                {
                    bDangNhap = true;

                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bDangNhap = false;
                }
            }
        }
        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
           // frmDangNhap fDN;
            /*
            if(fDN.ShowDialog() == DialogResult.OK)
            {
                string sTen = fDN.txtTen.Text;
                string sMatKhau = fDN.txtMatKhau.Text;
                
                NguoiDung = new NguoiDungDTO();
                NguoiDung = NguoiDungBUS.LayNguoiDung(sTen, sMatKhau);
                if(NguoiDung != null)
                {
                    bDangNhap = true;
                }    
            }
            else
            {
                bDangNhap = false;
            } */
            DangNhap();
            HienThiMenu();

        }
        private void frmChinh_Load(object sender, EventArgs e)
        {
            HienThiMenu();
            SidebarTimer.Start();
            lblNgay.Text = DateTime.Now.ToShortDateString();
        }
        
        public void MoFormCon(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(childForm);
            this.pnlMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
            //-----------------------------------------------------------------------------------------------------------
            #region Các nút chức năng
        private void i_dmChucVu_Click(object sender, EventArgs e)
        {
            /*
            if (fCV == null || fQQ.IsDisposed)
            {
                fCV = new frmChucVu();
                fCV.MdiParent = this;
                fCV.Show();
            }*/
            MoFormCon(new frmChucVu(), sender);
        } 
        private void i_dmNguoiDung_Click(object sender, EventArgs e)
        {
            /*
            if (fND == null || fND.IsDisposed)
            {
                fND = new frmNguoiDung();
                fND.MdiParent = this;
                fND.Show();
            }*/
            MoFormCon(new frmNguoiDung(), sender);
        }
        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao = MessageBox.Show("Bạn có chắc muốn đăng xuất không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                if (activeForm != null)
                    activeForm.Close();
                bDangNhap = false;
                picAnh.Image = Image.FromFile(Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + @"\Images\cloud_user.png");
                HienThiMenu();
            }
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void mnuChangePass_Click(object sender, EventArgs e)
        {
            /*
            if (fDMK == null || fDMK.IsDisposed)
            {
                fDMK = new frmDoiMatKhau();
                fDMK.MdiParent = this;
                fDMK.Show();
            }*/
            MoFormCon(new frmDoiMatKhau(), sender);

        }

        private void mniQueQuan_Click(object sender, EventArgs e)
        {
            /*
            if (fQQ == null || fQQ.IsDisposed)
            {
                fQQ = new frmQueQuan();
                fQQ.MdiParent = this;
                fQQ.Show();
            }*/
            MoFormCon(new frmQueQuan(), sender);
        }

        private void mniLopHoc_Click(object sender, EventArgs e)
        {
            /*
            if (fLH == null || fLH.IsDisposed)
            {
                fLH = new frmLopHoc();
                fLH.MdiParent = this;
                fLH.Show();
            }
            */
            MoFormCon(new frmLopHoc(), sender);
        }

        private void mniHocSinh_Click(object sender, EventArgs e)
        {
            /*
            if (fHS == null || fHS.IsDisposed)
            {
                fHS = new frmHocSinh();
                fHS.MdiParent = this;
                fHS.Show();
            }
            */
            MoFormCon(new frmHocSinh(), sender);
        }

        private void mniGiangVien_Click(object sender, EventArgs e)
        {
            /*
            if (fGV == null || fGV.IsDisposed)
            {
                fGV = new frmGiangVien();
                fGV.MdiParent = this;
                fGV.Show();
            }
            */
            MoFormCon(new frmGiangVien(), sender);
        }

        private void mniLuongGV_Click(object sender, EventArgs e)
        {
            /*
            if (fLuongGV == null || fLuongGV.IsDisposed)
            {
                fLuongGV = new frmLuongGV();
                fLuongGV.MdiParent = this;
                fLuongGV.Show();
            }
            */
            MoFormCon(new frmLuongGV(), sender);
        }

        private void mniLuongNV_Click(object sender, EventArgs e)
        {
            /*
            if (fLuongNV == null || fLuongNV.IsDisposed)
            {
                fLuongNV = new frmLuongNV();
                fLuongNV.MdiParent = this;
                fLuongNV.Show();
            } */
            MoFormCon(new frmLuongNV(), sender);
        }

        private void mniBangDiemHK1_Click(object sender, EventArgs e)
        {
            /*
            if (fBangDiemHK1 == null || fBangDiemHK1.IsDisposed)
            {
                fBangDiemHK1 = new frmBangDiemHK1();
                fBangDiemHK1.MdiParent = this;
                fBangDiemHK1.Show();
            }
            */
            MoFormCon(new frmBangDiemHK1(), sender);
        }

        private void mniPhanLop_Click(object sender, EventArgs e)
        {
            /*
            if (fPhanLop == null || fPhanLop.IsDisposed)
            {
                fPhanLop = new frmPhanLop();
                fPhanLop.MdiParent = this;
                fPhanLop.Show();
            }*/
            MoFormCon(new frmPhanLop(), sender);
        }

        private void mnuBangDiemHK2_Click(object sender, EventArgs e)
        {
            /*
            if (fBangDiemHK2 == null || fBangDiemHK2.IsDisposed)
            {
                fBangDiemHK2 = new frmBangDiemHK2();
                fBangDiemHK2.MdiParent = this;
                fBangDiemHK2.Show();
            }*/
            MoFormCon(new frmBangDiemHK2(), sender);
        }
        private void mnuBangDiemCaNam_Click(object sender, EventArgs e)
        {
            /*
            if (fBangDiemCaNam == null || fBangDiemCaNam.IsDisposed)
            {
                fBangDiemCaNam = new frmBangDiemCaNam();
                fBangDiemCaNam.MdiParent = this;
                fBangDiemCaNam.Show();
            }*/
            MoFormCon(new frmBangDiemCaNam(), sender);
        }

        private void mniHuongDanSD_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "HDSD.chm");
        }

        private void mnuINHocSinh_Click(object sender, EventArgs e)
        {
            /*
            if (fInHocSinh == null || fInHocSinh.IsDisposed)
            {
                fInHocSinh = new frmReportHocSinh();
                fInHocSinh.MdiParent = this;
                fInHocSinh.Show();
            }*/
            MoFormCon(new frmReportHocSinh(), sender);
        }

        private void mnuInGiangVien_Click(object sender, EventArgs e)
        {
            /*
            if (fINGiangVien == null || fINGiangVien.IsDisposed)
            {
                fINGiangVien = new frmReportGiangVien();
                fINGiangVien.MdiParent = this;
                fINGiangVien.Show();
            }*/
            MoFormCon(new frmReportGiangVien(), sender);
        }

        private void mnuInBangDiemHK1_Click(object sender, EventArgs e)
        {
            /*
            if (fInBangDiemHk1 == null || fInBangDiemHk1.IsDisposed)
            {
                fInBangDiemHk1 = new frmIn_BangDiemHK1();
                fInBangDiemHk1.MdiParent = this;
                fInBangDiemHk1.Show();
            }*/
            MoFormCon(new frmIn_BangDiemHK1(), sender);
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            /*
            if (fNhanVien == null || fNhanVien.IsDisposed)
            {
                fNhanVien = new frmNhanVien();
                fNhanVien.MdiParent = this;
                fNhanVien.Show();
            }*/
            MoFormCon(new frmNhanVien(), sender);
        }

        private void mnuInBangDiemHK2_Click(object sender, EventArgs e)
        {
            /*
            if (fInBangDiemHK2 == null || fBangDiemHK2.IsDisposed)
            {
                fInBangDiemHK2 = new frmInBangDiemHK2();
                fInBangDiemHK2.MdiParent = this;
                fInBangDiemHK2.Show();
            }*/
            MoFormCon(new frmInBangDiemHK2(), sender);
        }
        //-----------------------------------------------------------------------------------------------------------
        private void mnuThanhCongCu_Click(object sender, EventArgs e)
        {
            mnuThanhCongCu.Checked = !mnuThanhCongCu.Checked;
            toolStrip.Visible = mnuThanhCongCu.Checked;
        }

        private void mnuThanhChucNang_Click(object sender, EventArgs e)
        {
            mnuThanhChucNang.Checked = !mnuThanhChucNang.Checked;
            Sidebar.Visible = mnuThanhChucNang.Checked;
        }

        //-----------------------------------------------------------------------------------------------------------
        private void toolDangNhap_Click(object sender, EventArgs e)
        {
            mnuDangNhap_Click(sender, e);
        }

        private void toolDangXuat_Click(object sender, EventArgs e)
        {
            mnuDangXuat_Click(sender, e);
        }

        private void toolTaiKhoan_Click(object sender, EventArgs e)
        {
            i_dmNguoiDung_Click(sender, e);
        }

        private void toolGiaoVien_Click(object sender, EventArgs e)
        {
            mniGiangVien_Click((sender, e), e);
        }

        private void toolNhanVien_Click(object sender, EventArgs e)
        {
            mnuNhanVien_Click(sender, e);
        }

        private void toolHocSinh_Click(object sender, EventArgs e)
        {
            mniHocSinh_Click(sender, e);
        }

        private void toolBangDiem1_Click(object sender, EventArgs e)
        {
            mniBangDiemHK1_Click(sender, e);
        }

        private void toolBangDiem2_Click(object sender, EventArgs e)
        {
            mnuInBangDiemHK2_Click(sender, e);
        }

        private void toolBangDiemCaNam_Click(object sender, EventArgs e)
        {
            mnuBangDiemCaNam_Click(sender, e);
        }

        private void toolLuongNhanVien_Click(object sender, EventArgs e)
        {
            mniLuongNV_Click(sender, e);
        }

        private void toolLuongGiaoVien_Click(object sender, EventArgs e)
        {
            mniLuongGV_Click(sender, e);
        }

        private void toolThoat_Click(object sender, EventArgs e)
        {
            mnuThoat_Click(sender, e);
        }
        
        private void btnMore_Click(object sender, EventArgs e)
        {

        }
        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            BtnHover(btnTrangChu);
            if (activeForm != null)
                activeForm.Close();
        }
        private void btnHocSinh_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmHocSinh(), sender);
        }

        private void btnBangDiem2_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmBangDiemHK2(), sender);
            //new frmBangDiemHK2().ShowDialog();
        }

        private void btnDiemCaNam_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmBangDiemCaNam(), sender);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmNhanVien(), sender);
        }

        private void btnGiaoVien_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmGiangVien(), sender);
        }

        private void btnChucVu_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmChucVu(), sender);
        }

        private void btnLopHoc_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmLopHoc(), sender);
        }

        private void btnBangDiem1_Click_1(object sender, EventArgs e)
        {
            MoFormCon(new frmBangDiemHK1(), sender);
        }

        private void btnNguoiDung_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmNguoiDung(), sender);
        }
        private void picAnh_Click(object sender, EventArgs e)
        {
            btnMore_Click(sender, e);
        }
        #endregion
        #region Hiệu ứng Menu
        private void SidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                // Nếu sidebar mở rộng, giảm
                Sidebar.Width -= 10;
                if(Sidebar.Width==Sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    SidebarTimer.Stop();
                }
            }
            else
            {
                Sidebar.Width += 10;
                if(Sidebar.Width==Sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    SidebarTimer.Stop();
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            SidebarTimer.Start();
        }

        private void frmChinh_Click(object sender, EventArgs e)
        {

        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            //hideSubMenu(btnQuanLy);

            //BtnHover(btnQuanLy);
            QuanLyTimer.Start();
        }

        private void QuanLyTimer_Tick(object sender, EventArgs e)
        {
            if (QuanLyExpand)
            {
                pnlQuanLy.Height += 10;
                if (pnlQuanLy.Height == pnlQuanLy.MaximumSize.Height)
                {
                    QuanLyExpand = false;
                    QuanLyTimer.Stop();
                }
            }
            else
            {
                pnlQuanLy.Height -= 10;
                if (pnlQuanLy.Height == pnlQuanLy.MinimumSize.Height)
                {
                    QuanLyExpand = true;
                    QuanLyTimer.Stop();
                }
            }
        }
        private void BangDiemTimer_Tick(object sender, EventArgs e)
        {
            if (BangDiemExpand)
            {
                pnlBangDiem.Height += 10;
                if (pnlBangDiem.Height == pnlBangDiem.MaximumSize.Height)
                {
                    BangDiemExpand = false;
                    BangDiemTimer.Stop();
                }
            }
            else
            {
                pnlBangDiem.Height -= 10;
                if (pnlBangDiem.Height == pnlBangDiem.MinimumSize.Height)
                {
                    BangDiemExpand = true;
                    BangDiemTimer.Stop();
                }
            }
        }

        private void btnBangDiem_Click(object sender, EventArgs e)
        {
           // hideSubMenu(btnBangDiem);

            //BtnHover(btnBangDiem);
            BangDiemTimer.Start();
        }
        void BtnHover(Button btn)
       {
            Sidebar.Top = btn.Top;
        }
        private void closeSubMenu()
        {
            
            pnlQuanLy.Height = 0;
            pnlBangDiem.Height = 0;
            QuanLyExpand = false;
            BangDiemExpand = false; 
        }
        private void hideSubMenu(Button t)
        {
            if (t == btnQuanLy)
            {
                pnlQuanLy.Height = 0;
                QuanLyExpand = false;
            }

            else
            {
                pnlBangDiem.Height = 0;
                BangDiemExpand = false;
            }

        }

        #endregion

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "HDSD.chm");
        }

        private void mnuThongTin_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmThongTinCaNhan(), sender);
        }
    }
}
