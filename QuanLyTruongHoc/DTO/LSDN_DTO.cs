using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LSDN_DTO
    {
        private string tenDangNhap;
        private DateTime thoiGian;
        private string tenNguoiDung;
        private int quyenHan;
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public DateTime ThoiGian { get => thoiGian; set => thoiGian = value; }
        public string TenNguoiDung { get => tenNguoiDung; set => tenNguoiDung = value; }
        public int QuyenHan { get => quyenHan; set => quyenHan = value; }
    }
}
