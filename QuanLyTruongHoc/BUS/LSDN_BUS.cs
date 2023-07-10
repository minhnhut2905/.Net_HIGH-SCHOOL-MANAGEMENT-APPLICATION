using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class LSDN_BUS
    {
        public static List<LSDN_DTO> LayLSDN()
        {
            return LSDN_DAO.LayLSDN();
        }
        public static List<LSDN_DTO> TimLSDN(string tukhoa)
        {
            return LSDN_DAO.TimLSDN(tukhoa);
        }
        public static bool ThemLS(LSDN_DTO ls)
        {
            return LSDN_DAO.ThemLS(ls);
        }
        public static bool XoaLS()
        {
            return LSDN_DAO.XoaLS();
        }
        public static bool XoaLS(LSDN_DTO ls)
        {
            return LSDN_DAO.XoaLS(ls);
        }
        public static List<LSDN_DTO> TimLSDN(string fDate, string tDate)
        {
            return LSDN_DAO.TimLSDN(fDate, tDate);
        }
    }
}
