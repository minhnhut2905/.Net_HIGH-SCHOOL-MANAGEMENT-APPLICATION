using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class GiangVienBUS
    {
        //Lấy DS giảng viên
        public static List<GiangVienDTO> LayDSGiangVien()
        {
            return GiangVienDAO.LayDSGiangVien();
        }
        public static bool ThemGiangVien(GiangVienDTO gv)
        {
            return GiangVienDAO.ThemGiangVien(gv);
        }
        public static GiangVienDTO TimGiangVienTheoMa(string ma)
        {
            return GiangVienDAO.TimGiangVienTheoMa(ma);
        }
        public static bool SuaGiangVien(GiangVienDTO gv)
        {
            return GiangVienDAO.SuaGiangVien(gv);
        }
        public static bool XoaGiangVien(GiangVienDTO gv)
        {
            return GiangVienDAO.XoaGiangVien(gv);
        }
    }
}
