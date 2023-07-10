using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class QueQuanBUS
    {
        //Lấy DS nhân viên
        public static List<QueQuanDTO> LayDSQueQuan() {
            return QueQuanDAO.LayDSQueQuan();
        }
        public static bool ThemNhanVien(QueQuanDTO qq)
        {
            return QueQuanDAO.ThemQueQuan(qq);
        }
        public static QueQuanDTO TimQueQuanTheoMa(string ma)
        {
            return QueQuanDAO.TimQueQuanTheoMa(ma);
        }
        public static bool SuaQueQuan(QueQuanDTO qq)
        {
            return QueQuanDAO.SuaQueQuan(qq);
        }
        public static bool XoaQueQuan(QueQuanDTO qq)
        {
            return QueQuanDAO.XoaQueQuan(qq);
        }

    }    
}
