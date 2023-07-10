using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class LSDN_DAO
    {
        static SqlConnection conn;
        public static List<LSDN_DTO> LayLSDN()
        {
            string sql = "select * from LSDN order by ThoiGian desc";
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sql, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<LSDN_DTO> lstLSDN = new List<LSDN_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LSDN_DTO ls = new LSDN_DTO();
                ls.TenDangNhap = dt.Rows[i]["TenDangNhap"].ToString();
                ls.ThoiGian = ((DateTime)dt.Rows[i]["ThoiGian"]);
                ls.TenNguoiDung = dt.Rows[i]["TenNguoiDung"].ToString();
                ls.QuyenHan = int.Parse(dt.Rows[i]["QuyenHan"].ToString());
                lstLSDN.Add(ls);
            }
            conn.Close();
            return lstLSDN;
        }
        public static bool ThemLS(LSDN_DTO ls)
        {
            string sql = string.Format(@"insert into LSDN values(N'{0}', '{1}', N'{2}', N'{3}')",
                ls.TenDangNhap, ls.ThoiGian, ls.TenNguoiDung, ls.QuyenHan);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sql, conn);
            conn.Close();
            return kq;
        }
        public static bool XoaLS()
        {
            string sTruyVan = string.Format(@"delete from LSDN");
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            conn.Close();
            return kq;
        }
        public static bool XoaLS(LSDN_DTO ls)
        {
            string sTruyVan = string.Format(@"delete from LSDN where TenDangNhap =N'{0}' and ThoiGian = N'{1}'", ls.TenDangNhap, ls.ThoiGian);
            conn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, conn);
            conn.Close();
            return kq;
        }
        public static List<LSDN_DTO> TimLSDN(string tukhoa)
        {
            string sTruyVan = string.Format(@"select *from LSDN where 
                   TenDangNhap like N'%{0}%' or Tennguoidung like N'%{0}%'  order by ThoiGian desc", tukhoa);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<LSDN_DTO> lstLSDN = new List<LSDN_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LSDN_DTO tk = new LSDN_DTO();
                tk.TenDangNhap = dt.Rows[i]["TenDangNhap"].ToString();
                tk.ThoiGian = (DateTime)dt.Rows[i]["ThoiGian"];
                tk.TenNguoiDung = dt.Rows[i]["TenNguoiDung"].ToString();
                tk.QuyenHan = int.Parse(dt.Rows[i]["QuyenHan"].ToString());
                lstLSDN.Add(tk);
            }
            conn.Close();
            return lstLSDN;
        }
        public static List<LSDN_DTO> TimLSDN(string fDate, string tDate)
        {
            string sTruyVan = string.Format(@"select *from LSDN where 
                   ThoiGian between '{0}' and '{1}'", fDate, tDate);
            conn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<LSDN_DTO> lstLSDN = new List<LSDN_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LSDN_DTO tk = new LSDN_DTO();
                tk.TenDangNhap = dt.Rows[i]["TenDangNhap"].ToString();
                tk.ThoiGian = (DateTime)dt.Rows[i]["ThoiGian"];
                tk.TenNguoiDung = dt.Rows[i]["TenNguoiDung"].ToString();
                tk.QuyenHan = int.Parse(dt.Rows[i]["QuyenHan"].ToString());
                lstLSDN.Add(tk);
            }
            conn.Close();
            return lstLSDN;
        }
    }
}

