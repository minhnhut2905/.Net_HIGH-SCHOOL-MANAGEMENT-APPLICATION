using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LopHocDAO
    {
        static SqlConnection con;

        // Lấy danh sách tất cả lớp học
        public static List<LopHocDTO> LayDSLopHoc()
        {
            string sTruyVan = "select * from LopHoc";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<LopHocDTO> lstLopHoc = new List<DTO.LopHocDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LopHocDTO lh = new LopHocDTO();
                lh.SMaLop = dt.Rows[i]["MaLop"].ToString();
                lh.STenLop = dt.Rows[i]["TenLop"].ToString();
                lstLopHoc.Add(lh);
            }
            DataProvider.DongKetNoi(con);
            return lstLopHoc;
        }
        public static bool ThemLopHoc(LopHocDTO lh)
        {
            string sTruyVan = string.Format(@"INSERT INTO LopHoc VALUES(N'{0}',N'{1}'
                    )", lh.SMaLop, lh.STenLop);

            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        // Lấy thông tin quê quán có mã ma, trả về null nếu không thấy
        public static LopHocDTO TimLopHocTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from LopHoc where MaLop=N'{0}'",
            ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            LopHocDTO lh = new LopHocDTO();
            lh.SMaLop = dt.Rows[0]["MaLop"].ToString();
            lh.STenLop = dt.Rows[0]["TenLop"].ToString();

            DataProvider.DongKetNoi(con);
            return lh;
        }
        public static bool SuaLopHoc(LopHocDTO lh)
        {
            string sTruyVan = string.Format(@"UPDATE LopHoc SET TenLop=N'{0}'
              WHERE MaLop=N'{1}'", lh.STenLop, lh.STenLop);
            con = DataProvider.MoKetNoi();
            bool result = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            return result;
        }
        public static bool XoaLopHoc(LopHocDTO lh)
        {
            string sTruyVan = string.Format(@"DELETE FROM LopHoc  WHERE MaLop=N'{0}'", lh.SMaLop);
            con = DataProvider.MoKetNoi();
            bool result = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            return result;
        }
    }
}
