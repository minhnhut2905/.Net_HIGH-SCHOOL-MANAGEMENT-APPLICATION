using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class LuongGV_BUS
    {
        public static List<LuongGV_DTO> LayDSLuongGV()
        {
            return LuongGV_DAO.LayDSLuongGV();
        }
        public static bool ThemLuongGV(LuongGV_DTO luong)
        {
            return LuongGV_DAO.ThemLuongGV(luong);
        }
        public static LuongGV_DTO TimLuongTheoMa(string ma)
        {
            return LuongGV_DAO.TimLuongTheoMa(ma);
        }
        public static bool SuaLuong(LuongGV_DTO luong)
        {
            return LuongGV_DAO.SuaLuong(luong);
        }
        public static bool XoaLuong(LuongGV_DTO luong)
        {
            return LuongGV_DAO.XoaLuong(luong);
        }
    }
}
