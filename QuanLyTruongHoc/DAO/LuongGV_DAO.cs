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
    public class LuongGV_DAO
    {
        static SqlConnection con;

        // Lấy danh sách tất cả lương giảng viên
        public static List<LuongGV_DTO> LayDSLuongGV()
        {
            string sTruyVan = "select * from LuongGiangVien";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<LuongGV_DTO> lstLuongGV = new List<DTO.LuongGV_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LuongGV_DTO luong = new LuongGV_DTO();
                luong.SMaGiangVien = dt.Rows[i]["MaGiangVien"].ToString();
                luong.DtNgayBD1 = DateTime.Parse(dt.Rows[i]["NgayBD"].ToString());
                luong.FHSLuong = float.Parse(dt.Rows[i]["HeSoLuong"].ToString());
                luong.SGhiChu = dt.Rows[i]["GhiChu"].ToString();
                lstLuongGV.Add(luong);
            }
            DataProvider.DongKetNoi(con);
            return lstLuongGV;
        }
        //Thêm lương giảng viên
        public static bool ThemLuongGV(LuongGV_DTO luong)
        {
            string sTruyVan = string.Format(@"INSERT INTO LuongGiangVien VALUES(N'{0}',N'{1}',N'{2}',N'{3}'
                    )", luong.SMaGiangVien, luong.DtNgayBD1, luong.FHSLuong, luong.SGhiChu);

            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        // Lấy thông tin quê quán có mã ma, trả về null nếu không thấy
        public static LuongGV_DTO TimLuongTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from LuongGiangVien where MaGiangVien=N'{0}'",
            ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            LuongGV_DTO luong = new LuongGV_DTO();
                luong.SMaGiangVien = dt.Rows[0]["MaGiangVien"].ToString();
                luong.DtNgayBD1 = DateTime.Parse(dt.Rows[0]["NgayBD"].ToString());
                luong.FHSLuong = float.Parse(dt.Rows[0]["HeSoLuong"].ToString());
                luong.SGhiChu = dt.Rows[0]["GhiChu"].ToString();

            DataProvider.DongKetNoi(con);
            return luong;
        }
        //Sửa bảng quá trình lương giảng viên
        public static bool SuaLuong(LuongGV_DTO luong)
        {
            string sTruyVan = string.Format(@"UPDATE LuongGiangVien SET NgayBD=N'{0}',HeSoLuong=N'{1}',
             GhiChu=N'{2}' WHERE MaGiangVien=N'{3}'",  luong.DtNgayBD1,luong.FHSLuong,luong.SGhiChu,luong.SMaGiangVien);
            con = DataProvider.MoKetNoi();
            bool result = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            return result;
        }
        //Xóa quá trình lương giảng viên
        public static bool XoaLuong(LuongGV_DTO luong)
        {
            string sTruyVan = string.Format(@"DELETE FROM LuongGiangVien  WHERE MaGiangVien=N'{0}'", luong.SMaGiangVien);
            con = DataProvider.MoKetNoi();
            bool result = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            return result;
        }
    }
}
