using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class HocSinhBUS
    {
        //Lấy DS học sinh
        public static List<HocSinhDTO> LayDSHocSinh()
        {
            return HocSinhDAO.LayDSHocSinh();
        }
        public static List<HocSinhDTO> ReportHocSinh()
        {
            return HocSinhDAO.ReportHocSinh();
        }
        public static bool ThemHocSinh(HocSinhDTO hs)
        {
            return HocSinhDAO.ThemHocSinh(hs);
        }
        public static HocSinhDTO TimHocSinhTheoMa(string ma)
        {
            return HocSinhDAO.TimHocSinhTheoMa(ma);
        }
        public static bool SuaHocSinh(HocSinhDTO hs)
        {
            return HocSinhDAO.SuaHocSinh(hs);
        }
        public static bool XoaHocSinh(HocSinhDTO hs)
        {
            return HocSinhDAO.XoaHocSinh(hs);
        }
    }
}
