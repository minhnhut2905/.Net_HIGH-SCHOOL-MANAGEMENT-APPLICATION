using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class LuongNhanVien_BUS
    {
        public static List<LuongNhanVien_DTO> LayDSLuongNV()
        {
            return LuongNhanVien_DAO.LayDSLuongNV();
        }
        public static bool ThemLuong(LuongNhanVien_DTO luong)
        {
            return LuongNhanVien_DAO.ThemLuongNV(luong);
        }
        public static LuongNhanVien_DTO TimLuongTheoMa(string ma)
        {
            return LuongNhanVien_DAO.TimLuongTheoMa(ma);
        }
        public static bool SuaLuong(LuongNhanVien_DTO luong)
        {
            return LuongNhanVien_DAO.SuaLuong(luong);
        }
        public static bool XoaLuong(LuongNhanVien_DTO luong)
        {
            return LuongNhanVien_DAO.XoaLuong(luong);
        }
    }
}
