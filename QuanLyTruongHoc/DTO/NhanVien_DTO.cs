using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien_DTO
    {
        private string sMaNV;
        private string sTenNV;
        private DateTime dtNgaySinh;
        private string sGioiTinh;
        private string sDiaChi;
        private int iSDT;
        private string sHinhAnh;
        private string sMaQueQuan;
        private string sMaChucVu;
        private string sMaPhongBan;
        private float fLuongCB;

        public string SMaNV { get => sMaNV; set => sMaNV = value; }
        public string STenNV { get => sTenNV; set => sTenNV = value; }
        public DateTime DtNgaySinh { get => dtNgaySinh; set => dtNgaySinh = value; }
        public string SGioiTinh { get => sGioiTinh; set => sGioiTinh = value; }
        public string SDiaChi { get => sDiaChi; set => sDiaChi = value; }
        public int ISDT { get => iSDT; set => iSDT = value; }
        public string SHinhAnh { get => sHinhAnh; set => sHinhAnh = value; }
        public string SMaQueQuan { get => sMaQueQuan; set => sMaQueQuan = value; }
        public string SMaChucVu { get => sMaChucVu; set => sMaChucVu = value; }
        public string SMaPhongBan { get => sMaPhongBan; set => sMaPhongBan = value; }
        public float FLuongCB { get => fLuongCB; set => fLuongCB = value; }
    }
}
