using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class BangDiemCaNam_BUS
    {
        //Lấy Danh sách bảng điểm
        public static List<BangDiemCaNam_DTO> LayDSBangDiemCaNam()
        {
            return BangDiemCaNam_DAO.LayDSBangDiemCaNam();
        }
        public static bool ThemBangDiem(BangDiemCaNam_DTO bangdiem)
        {
            return BangDiemCaNam_DAO.ThemBangDiem(bangdiem);
        }
        public static BangDiemCaNam_DTO TimBangDiemTheoMa(string ma)
        {
            return BangDiemCaNam_DAO.TimBangDiemTheoMa(ma);
        }
        public static bool SuaBangDiem(BangDiemCaNam_DTO bangdiem)
        {
            return BangDiemCaNam_DAO.SuaBangDiem(bangdiem);
        }
        public static bool XoaBangDiem(BangDiemCaNam_DTO bangdiem)
        {
            return BangDiemCaNam_DAO.XoaBangDiem(bangdiem);
        }
    }
}
