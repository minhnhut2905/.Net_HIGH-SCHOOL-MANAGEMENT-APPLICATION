using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LuongGV_DTO
    {
        private string sMaGiangVien;
        private DateTime DtNgayBD;
        private float fHSLuong;
        private string sGhiChu;

        public string SMaGiangVien { get => sMaGiangVien; set => sMaGiangVien = value; }
        public DateTime DtNgayBD1 { get => DtNgayBD; set => DtNgayBD = value; }
        public float FHSLuong { get => fHSLuong; set => fHSLuong = value; }
        public string SGhiChu { get => sGhiChu; set => sGhiChu = value; }
    }
}
