using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class PhongBanBUS
    {
        public static List<PhongBanDTO> LayDSPhongBan()
        {
            return PhongBanDAO.LayDSPhongBan();
        }
        public static bool ThemPhongBan(PhongBanDTO pb)
        {
            return PhongBanDAO.ThemPhongBan(pb);
        }
        public static PhongBanDTO TimPhongBanTheoMa(string ma)
        {
            return PhongBanDAO.TimPhongBanTheoMa(ma);
        }
        public static bool SuaPhongBan(PhongBanDTO pb)
        {
            return PhongBanDAO.SuaPhongBan(pb);
        }
        public static bool XoaPhongBan(PhongBanDTO pb)
        {
            return PhongBanDAO.XoaPhongBan(pb);
        }
    }
}
