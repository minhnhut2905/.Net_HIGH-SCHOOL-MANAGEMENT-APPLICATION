using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BangDiemCaNam_DTO
    {
        private string sMaHS;
        private string sMaLop;
        private float fDiemTB_HK1;
        private float fDiemTB_HK2;
        private float fDiemTbCaNam;
        private string sXepLoaiCaNam;

        public string SMaHS { get => sMaHS; set => sMaHS = value; }
        public string SMaLop { get => sMaLop; set => sMaLop = value; }
        public float FDiemTB_HK1 { get => fDiemTB_HK1; set => fDiemTB_HK1 = value; }
        public float FDiemTB_HK2 { get => fDiemTB_HK2; set => fDiemTB_HK2 = value; }
        public float FDiemTbCaNam { get => fDiemTbCaNam; set => fDiemTbCaNam = value; }
        public string SXepLoaiCaNam { get => sXepLoaiCaNam; set => sXepLoaiCaNam = value; }
    }
}
