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
    public class PhongBanDAO
    {
        static SqlConnection con;
        public static List<PhongBanDTO> LayDSPhongBan()
        {
            string sTruyVan = "select * from PhongBan";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<PhongBanDTO> lstPhongBan = new List<PhongBanDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PhongBanDTO pb = new PhongBanDTO();
                pb.SMaPhongBan = dt.Rows[i]["MaPhongBan"].ToString();
                pb.STenPhongBan = dt.Rows[i]["TenPhongBan"].ToString();
                lstPhongBan.Add(pb);
            }
            DataProvider.DongKetNoi(con);
            return lstPhongBan;
        }
        public static bool ThemPhongBan(PhongBanDTO pb)
        {
            string sTruyVan = string.Format(@"INSERT INTO PhongBan VALUES(N'{0}',N'{1}'
                    )", pb.SMaPhongBan, pb.STenPhongBan);

            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        // Lấy thông tin mã phòng ban có mã ma, trả về null nếu không tìm thấy
        public static PhongBanDTO TimPhongBanTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from PhongBan where MaPhongBan=N'{0}' or TenPhongBan=N'{0}'",
            ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            //List<PhongBanDTO> lstPhongBan = new List<PhongBanDTO>();
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
                PhongBanDTO pb = new PhongBanDTO();
                pb.SMaPhongBan = dt.Rows[0]["MaPhongBan"].ToString();
                pb.STenPhongBan = dt.Rows[0]["TenPhongBan"].ToString();
                //lstPhongBan.Add(pb);
            //}
            DataProvider.DongKetNoi(con);
            //return lstPhongBan;
            return pb;
        }
        public static bool SuaPhongBan(PhongBanDTO pb)
        {
            string sTruyVan = string.Format(@"UPDATE PhongBan SET TenPhongBan=N'{0}'
              WHERE MaPhongBan=N'{1}'", pb.STenPhongBan, pb.SMaPhongBan);
            con = DataProvider.MoKetNoi();
            bool result = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            return result;
        }
        public static bool XoaPhongBan(PhongBanDTO pb)
        {
            string sTruyVan = string.Format(@"DELETE FROM PhongBan  WHERE MaPhongBan=N'{0}'", pb.SMaPhongBan);
            con = DataProvider.MoKetNoi();
            bool result = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            return result;
        }
    }
}
