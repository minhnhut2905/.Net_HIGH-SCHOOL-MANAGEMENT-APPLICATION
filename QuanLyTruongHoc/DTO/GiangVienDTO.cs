using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GiangVienDTO
    {
        private string sMaGV;
        private string sTenGV;
        private DateTime dtNgaySinh;
        private string sDiaChi;
        private int iSDT;
        private string sGioiTinh;
        private string sHinhAnh;
        private string sMaQueQuan;
        private string sMaChucVu;
        private string sMaPhongBan;
        private float fLuongCanBan;

        public string SMaGV { get => sMaGV; set => sMaGV = value; }
        public string STenGV { get => sTenGV; set => sTenGV = value; }
        public DateTime DtNgaySinh { get => dtNgaySinh; set => dtNgaySinh = value; }
        public string SDiaChi { get => sDiaChi; set => sDiaChi = value; }
        public int ISDT { get => iSDT; set => iSDT = value; }
        public string SGioiTinh { get => sGioiTinh; set => sGioiTinh = value; }
        public string SHinhAnh { get => sHinhAnh; set => sHinhAnh = value; }
        public string SMaQueQuan { get => sMaQueQuan; set => sMaQueQuan = value; }
        public string SMaChucVu { get => sMaChucVu; set => sMaChucVu = value; }
        public string SMaPhongBan { get => sMaPhongBan; set => sMaPhongBan = value; }
        public float FLuongCanBan { get => fLuongCanBan; set => fLuongCanBan = value; }
    }
}
