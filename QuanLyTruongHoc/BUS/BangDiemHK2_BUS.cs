using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class BangDiemHK2_BUS
    {
        //Lấy Danh sách bảng điểm
        public static List<BangDiemHK2_DTO> LayDSBangDiemHK2()
        {
            return BangDiemHK2_DAO.LayDSBangDiemHK2();
        }
        public static bool ThemBangDiem(BangDiemHK2_DTO bangdiem)
        {
            return BangDiemHK2_DAO.ThemBangDiem(bangdiem);
        }
        public static BangDiemHK2_DTO TimBangDiemTheoMa(string ma)
        {
            return BangDiemHK2_DAO.TimBangDiemTheoMa(ma);
        }
        public static bool SuaBangDiem(BangDiemHK2_DTO bangdiem)
        {
            return BangDiemHK2_DAO.SuaBangDiem(bangdiem);
        }
        public static bool XoaBangDiem(BangDiemHK2_DTO bangdiem)
        {
            return BangDiemHK2_DAO.XoaBangDiem(bangdiem);
        }
    }
}
