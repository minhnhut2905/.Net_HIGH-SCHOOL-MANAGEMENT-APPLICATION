using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class ChucVuDAO
    {
        static SqlConnection con;
        //lấy danh sách chức vụ
        public static List<ChucVuDTO> LayChucVu()
        {
            string sTruyVan = "select * from ChucVu";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ChucVuDTO> lstChucVu = new List<ChucVuDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChucVuDTO cv = new ChucVuDTO();
                cv.SMaCV = dt.Rows[i]["MaChucVu"].ToString();
                cv.STenCV = dt.Rows[i]["TenChucVu"].ToString();
                lstChucVu.Add(cv);
            }
            DataProvider.DongKetNoi(con);
            return lstChucVu;
        }
        //Thêm chức vụ
        public static bool ThemChucVu(ChucVuDTO cv)
        {
            string sTruyVan = string.Format(@"INSERT INTO ChucVu VALUES(N'{0}',N'{1}'
                    )", cv.SMaCV, cv.STenCV);

            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        // Lấy thông tin chức vụ có mã ma, trả về null nếu không thấy
        public static ChucVuDTO TimChucVuTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from ChucVu where MaChucVu=N'{0}' or TenChucVu=N'{0}'",
            ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            ChucVuDTO cv = new ChucVuDTO();
            cv.SMaCV = dt.Rows[0]["MaChucVu"].ToString();
            cv.STenCV = dt.Rows[0]["TenChucVu"].ToString();

            DataProvider.DongKetNoi(con);
            return cv;
        }
        //Sửa chức vụ
        public static bool SuaChucVu(ChucVuDTO cv)
        {
            string sTruyVan = string.Format(@"UPDATE ChucVu SET TenChucVu=N'{0}'
              WHERE MaChucVu=N'{1}'", cv.STenCV, cv.SMaCV);
            con = DataProvider.MoKetNoi();
            bool result = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            return result;
        }
        //Xóa chức vụ
        public static bool XoaChucVu(ChucVuDTO cv)
        {
            string sTruyVan = string.Format(@"DELETE FROM ChucVu  WHERE MaChucVu=N'{0}'", cv.SMaCV);
            con = DataProvider.MoKetNoi();
            bool result = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            return result;
        }
    }
}
