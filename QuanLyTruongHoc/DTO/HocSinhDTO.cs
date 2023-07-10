using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HocSinhDTO
    {
        private string sMaHS;
        private string sTenHS;
        private string sGioiTinh;
        private DateTime dNgaySinh;
        private int iSDT;
        private string sDiaChi;
        private string sAnh;
        private string sMaQueQuan;

        public string SMaHS { get => sMaHS; set => sMaHS = value; }
        public string STenHS { get => sTenHS; set => sTenHS = value; }
        public string SGioiTinh { get => sGioiTinh; set => sGioiTinh = value; }
        public DateTime DNgaySinh { get => dNgaySinh; set => dNgaySinh = value; }
        public int ISDT { get => iSDT; set => iSDT = value; }
        public string SDiaChi { get => sDiaChi; set => sDiaChi = value; }
        public string SMaQueQuan { get => sMaQueQuan; set => sMaQueQuan = value; }
        public string SAnh { get => sAnh; set => sAnh = value; }
    }
}
