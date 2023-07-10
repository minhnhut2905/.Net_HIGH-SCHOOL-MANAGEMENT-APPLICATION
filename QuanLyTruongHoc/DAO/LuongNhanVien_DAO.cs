using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class LuongNhanVien_DAO
    {
        static SqlConnection con;

        // Lấy danh sách tất cả lương nhân viên
        public static List<LuongNhanVien_DTO> LayDSLuongNV()
        {
            string sTruyVan = "select * from LuongNhanVien";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<LuongNhanVien_DTO> lstLuongNV = new List<DTO.LuongNhanVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LuongNhanVien_DTO luong = new LuongNhanVien_DTO();
                luong.SMaNV = dt.Rows[i]["MaNhanVien"].ToString();
                luong.DtNgayBD = DateTime.Parse(dt.Rows[i]["NgaBD"].ToString());
                luong.FHSLuong = float.Parse(dt.Rows[i]["HeSoLuong"].ToString());
                luong.SGhiChu = dt.Rows[i]["GhiChu"].ToString();
                lstLuongNV.Add(luong);
            }
            DataProvider.DongKetNoi(con);
            return lstLuongNV;
        }
        //Thêm lương nhân viên
        public static bool ThemLuongNV(LuongNhanVien_DTO luong)
        {
            string sTruyVan = string.Format(@"INSERT INTO LuongNhanVien VALUES(N'{0}',N'{1}',N'{2}',N'{3}'
                    )", luong.SMaNV, luong.DtNgayBD, luong.FHSLuong, luong.SGhiChu);

            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        // Lấy thông tin lương nhân viên có mã ma, trả về null nếu không thấy
        public static LuongNhanVien_DTO TimLuongTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from LuongNhanVien where MaNhanVien=N'{0}'",
            ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            LuongNhanVien_DTO luong = new LuongNhanVien_DTO();
            luong.SMaNV = dt.Rows[0]["MaNhanVien"].ToString();
            luong.DtNgayBD = DateTime.Parse(dt.Rows[0]["NgaBD"].ToString());
            luong.FHSLuong = float.Parse(dt.Rows[0]["HeSoLuong"].ToString());
            luong.SGhiChu = dt.Rows[0]["GhiChu"].ToString();

            DataProvider.DongKetNoi(con);
            return luong;
        }
        //Sửa bảng quá trình lương giảng viên
        public static bool SuaLuong(LuongNhanVien_DTO luong)
        {
            string sTruyVan = string.Format(@"UPDATE LuongNhanVien SET NgaBD=N'{0}',HeSoLuong=N'{1}',
             GhiChu=N'{2}' WHERE MaNhanVien=N'{3}'", luong.DtNgayBD, luong.FHSLuong, luong.SGhiChu, luong.SMaNV);
            con = DataProvider.MoKetNoi();
            bool result = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            return result;
        }
        //Xóa quá trình lương giảng viên
        public static bool XoaLuong(LuongNhanVien_DTO luong)
        {
            string sTruyVan = string.Format(@"DELETE FROM LuongNhanVien  WHERE MaNhanVien=N'{0}'", luong.SMaNV);
            con = DataProvider.MoKetNoi();
            bool result = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            return result;
        }
    }
}
