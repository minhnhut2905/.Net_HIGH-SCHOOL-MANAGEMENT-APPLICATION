using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhanLopDTO
    {
        private string sMaHocSinh;
        private string sMaLop;
        private DateTime dtNamHoc;

        public string SMaHocSinh { get => sMaHocSinh; set => sMaHocSinh = value; }
        public string SMaLop { get => sMaLop; set => sMaLop = value; }
        public DateTime DtNamHoc { get => dtNamHoc; set => dtNamHoc = value; }
    }
}
