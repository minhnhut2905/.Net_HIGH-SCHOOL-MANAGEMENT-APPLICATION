using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class LopHocBUS
    {
        //Lấy DS nhân viên
        public static List<LopHocDTO> LayDSLopHoc()
        {
            return LopHocDAO.LayDSLopHoc();
        }
        public static bool ThemLopHoc(LopHocDTO lh)
        {
            return LopHocDAO.ThemLopHoc(lh);
        }
        public static LopHocDTO TimLopHocTheoMa(string ma)
        {
            return LopHocDAO.TimLopHocTheoMa(ma);
        }
        public static bool SuaLopHoc(LopHocDTO lh)
        {
            return LopHocDAO.SuaLopHoc(lh);
        }
        public static bool XoaLopHoc(LopHocDTO lh)
        {
            return LopHocDAO.XoaLopHoc(lh);
        }
    }
}
