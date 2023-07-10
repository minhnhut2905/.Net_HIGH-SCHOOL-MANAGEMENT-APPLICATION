using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class PhanLopBUS
    {
        public static List<PhanLopDTO> LayDSPhanLop()
        {
            return PhanLopDAO.LayDSPhanLop();
        }
        public static bool ThemPhanLop(PhanLopDTO pl)
        {
            return PhanLopDAO.ThemPhanLop(pl);
        }
        public static PhanLopDTO TimPhanLopTheoMa(string ma)
        {
            return PhanLopDAO.TimPhanLopTheoMa(ma);
        }
        public static bool SuaPhanLop(PhanLopDTO pl)
        {
            return PhanLopDAO.SuaPhanLop(pl);
        }
        public static bool XoaPhanLop(PhanLopDTO pl)
        {
            return PhanLopDAO.XoaPhanLop(pl);
        }
    }
}
