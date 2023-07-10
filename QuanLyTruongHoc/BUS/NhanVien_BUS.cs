using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class NhanVien_BUS
    {

        //Lấy DS Nhân viên
        public static List<NhanVien_DTO> LayDSNhanVien()
        {
            return NhanVienDAO.LayDSNhanVien();
        }
        public static bool ThemNhanVien(NhanVien_DTO nv)
        {
            return NhanVienDAO.ThemNhanVien(nv);
        }
        public static NhanVien_DTO TimNhanVienTheoMa(string ma)
        {
            return NhanVienDAO.TimNhanVienTheoMa(ma);
        }
        public static bool SuaNhanvien(NhanVien_DTO nv)
        {
            return NhanVienDAO.SuaNhanvien(nv);
        }
        public static bool XoaNhanVien(NhanVien_DTO nv)
        {
            return NhanVienDAO.XoaNhanVien(nv);
        }
    }
}
