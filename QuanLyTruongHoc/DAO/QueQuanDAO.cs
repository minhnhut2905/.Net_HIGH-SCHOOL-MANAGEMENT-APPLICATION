using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class QueQuanDAO
    {
        static SqlConnection con;

        // Lấy danh sách tất cả quê quán
        public static List<QueQuanDTO>  LayDSQueQuan() {
            string sTruyVan = "select * from QueQuan";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<QueQuanDTO> lstQueQuan = new List<DTO.QueQuanDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                QueQuanDTO qq=new QueQuanDTO();
                qq.SMaQueQuan  = dt.Rows[i]["MaQueQuan"].ToString();
                qq.STenQueQuan  = dt.Rows[i]["TenQueQuan"].ToString();
                lstQueQuan.Add(qq);
            }
            DataProvider.DongKetNoi(con);
            return lstQueQuan;
        }
        public static bool ThemQueQuan(QueQuanDTO qq)
        {
            string sTruyVan = string.Format(@"INSERT INTO QueQuan VALUES(N'{0}',N'{1}'
                    )", qq.SMaQueQuan,qq.STenQueQuan);

            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        // Lấy thông tin quê quán có mã ma, trả về null nếu không thấy
        public static QueQuanDTO TimQueQuanTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from QueQuan where MaQueQuan=N'{0}'",
            ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            QueQuanDTO qq = new QueQuanDTO();
            qq.SMaQueQuan = dt.Rows[0]["MaQueQuan"].ToString();
            qq.STenQueQuan = dt.Rows[0]["TenQueQuan"].ToString();
            
            DataProvider.DongKetNoi(con);
            return qq;
        }
        public static bool SuaQueQuan(QueQuanDTO qq)
        {
            string sTruyVan = string.Format(@"UPDATE QueQuan SET TenQueQuan=N'{0}'
              WHERE MaQueQuan=N'{1}'", qq.STenQueQuan, qq.SMaQueQuan);
            con = DataProvider.MoKetNoi();
            bool result = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            return result;
        }
        public static bool XoaQueQuan(QueQuanDTO qq)
        {
            string sTruyVan = string.Format(@"DELETE FROM QueQuan  WHERE MaQueQuan=N'{0}'", qq.SMaQueQuan);
            con = DataProvider.MoKetNoi();
            bool result = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            return result;
        }

    }
}
