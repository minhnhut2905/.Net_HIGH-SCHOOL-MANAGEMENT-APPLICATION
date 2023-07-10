using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class BangDiem_Hk1_BUS
    {
        //Lấy Danh sách bảng điểm
        public static List<BangDiemHK1_DTO> LayDSBangDiemHK1()
        {
            return BangDiemHK1_DAO.LayDSBangDiemHK1();
        }
        public static bool ThemBangDiem(BangDiemHK1_DTO bangdiem)
        {
            return BangDiemHK1_DAO.ThemBangDiem(bangdiem);
        }
        public static BangDiemHK1_DTO TimBangDiemTheoMa(string ma)
        {
            return BangDiemHK1_DAO.TimBangDiemTheoMa(ma);
        }
        public static bool SuaBangDiem(BangDiemHK1_DTO bangdiem)
        {
            return BangDiemHK1_DAO.SuaBangDiem(bangdiem);
        }
        public static bool XoaBangDiem(BangDiemHK1_DTO bangdiem)
        {
            return BangDiemHK1_DAO.XoaBangDiem(bangdiem);
        }
    }
}
