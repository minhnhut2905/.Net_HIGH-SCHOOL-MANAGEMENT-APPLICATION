using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NguoiDungDTO
    {
        private string sTenDN;
        private string sHoTen;
        private string sMatKhau;
        private string sHinhAnh;
        private int iQuyen;

        public string STenDN { get => sTenDN; set => sTenDN = value; }
        public string SHoTen { get => sHoTen; set => sHoTen = value; }
        public string SMatKhau { get => sMatKhau; set => sMatKhau = value; }
        public string SHinhAnh { get => sHinhAnh; set => sHinhAnh = value; }
        public int IQuyen { get => iQuyen; set => iQuyen = value; }
    }
}
