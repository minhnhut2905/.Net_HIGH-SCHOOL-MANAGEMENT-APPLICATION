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
    public class PhanLopDAO
    {
        static SqlConnection con;

        // Lấy danh sách tất cả lớp học
        public static List<PhanLopDTO> LayDSPhanLop()
        {
            string sTruyVan = "select * from PhanLop";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<PhanLopDTO> lstPhanLop = new List<DTO.PhanLopDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                PhanLopDTO pl = new PhanLopDTO();
                pl.SMaHocSinh = dt.Rows[i]["MaHocSinh"].ToString();
                pl.SMaLop = dt.Rows[i]["MaLop"].ToString();
                pl.DtNamHoc = DateTime.Parse(dt.Rows[i]["NamHoc"].ToString());
                DataProvider.DongKetNoi(con);
                lstPhanLop.Add(pl);
            }
            DataProvider.DongKetNoi(con);
            return lstPhanLop;
        }
        public static bool ThemPhanLop(PhanLopDTO pl)
        {
            string sTruyVan = string.Format(@"INSERT INTO PhanLop VALUES(N'{0}',N'{1}',N'{2}'
                    )",pl.SMaHocSinh,pl.SMaLop,pl.DtNamHoc);

            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        // Lấy thông tin học sinh có mã ma, trả về null nếu không thấy
        public static PhanLopDTO TimPhanLopTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from PhanLop where MaHocSinh=N'{0}' OR MaLop=N'{0}'",
            ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            PhanLopDTO pl = new PhanLopDTO();
            pl.SMaHocSinh = dt.Rows[0]["MaHocSinh"].ToString();
            pl.SMaLop = dt.Rows[0]["MaLop"].ToString();
            pl.DtNamHoc = DateTime.Parse(dt.Rows[0]["NamHoc"].ToString());

            DataProvider.DongKetNoi(con);
            return pl;
        }
        public static bool SuaPhanLop(PhanLopDTO pl)
        {
            string sTruyVan = string.Format(@"UPDATE PhanLop SET MaLop=N'{0}',
             NamHoc=N'{1}' WHERE MaHocSinh=N'{2}'", pl.SMaLop , pl.DtNamHoc, pl.SMaHocSinh);
            con = DataProvider.MoKetNoi();
            bool result = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            return result;
        }
        public static bool XoaPhanLop(PhanLopDTO pl)
        {
            string sTruyVan = string.Format(@"DELETE FROM PhanLop  WHERE MaHocSinh=N'{0}'", pl.SMaHocSinh);
            con = DataProvider.MoKetNoi();
            bool result = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            return result;
        }
    }
}

