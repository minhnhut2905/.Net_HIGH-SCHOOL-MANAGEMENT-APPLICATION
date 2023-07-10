using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class ChucVuBUS
    {
        public static List<ChucVuDTO> LayChucVu()
        {
            return ChucVuDAO.LayChucVu();
        }
        public static bool ThemChucVu(ChucVuDTO cv)
        {
            return ChucVuDAO.ThemChucVu(cv);
        }
        public static ChucVuDTO TimChucVuTheoMa(string ma)
        {
            return ChucVuDAO.TimChucVuTheoMa(ma);
        }
        public static bool SuaChucVu(ChucVuDTO cv)
        {
            return ChucVuDAO.SuaChucVu(cv);
        }
        public static bool XoaChucVu(ChucVuDTO cv)
        {
            return ChucVuDAO.XoaChucVu(cv);
        }
    }
}
