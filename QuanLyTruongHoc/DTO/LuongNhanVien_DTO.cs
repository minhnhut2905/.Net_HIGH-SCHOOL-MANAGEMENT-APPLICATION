using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LuongNhanVien_DTO
    {
        private string sMaNV;
        private DateTime dtNgayBD;
        private float fHSLuong;
        private string sGhiChu;

        public string SMaNV { get => sMaNV; set => sMaNV = value; }
        public DateTime DtNgayBD { get => dtNgayBD; set => dtNgayBD = value; }
        public float FHSLuong { get => fHSLuong; set => fHSLuong = value; }
        public string SGhiChu { get => sGhiChu; set => sGhiChu = value; }
    }
}
