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
    public class NguoiDungDAO
    {
        static SqlConnection con;
        public static NguoiDungDTO KiemTraNguoiDung(string ten, string matkhau)
        {
            string sTruyVan = string.Format("select * from NguoiDung1 where TenDangNhap=N'{0}' and MatKhau='{1}'",ten,matkhau);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            NguoiDungDTO nd = new NguoiDungDTO();
            nd.STenDN = dt.Rows[0]["TenDangNhap"].ToString();
            nd.SHoTen = dt.Rows[0]["HoTen"].ToString();
            nd.SMatKhau = dt.Rows[0]["MatKhau"].ToString();
            nd.SHinhAnh = dt.Rows[0]["HinhAnh"].ToString();
            nd.IQuyen = int.Parse(dt.Rows[0]["QuyenHan"].ToString());
            
            DataProvider.DongKetNoi(con);
            return nd;
        }
        public static List<NguoiDungDTO> LayDSNguoiDung()
        {
            string sTruyVan = "select * from NguoiDung1";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NguoiDungDTO> lstNguoiDung = new List<DTO.NguoiDungDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NguoiDungDTO nd = new NguoiDungDTO();
                nd.STenDN = dt.Rows[i]["TenDangNhap"].ToString();
                nd.SHoTen = dt.Rows[i]["HoTen"].ToString();
                nd.SMatKhau = dt.Rows[i]["MatKhau"].ToString();
                nd.SHinhAnh = dt.Rows[i]["HinhAnh"].ToString();
                nd.IQuyen = int.Parse(dt.Rows[i]["QuyenHan"].ToString());
                lstNguoiDung.Add(nd);
            }
            return lstNguoiDung;
        }

        public static NguoiDungDTO LayTaiKhoanDangNhap(string sTen, string sMatKhau)
        {
            string sTruyVan = string.Format("select * from NguoiDung1 where TenDangNhap=N'{0}' and MatKhau='{1}'", sTen, sMatKhau);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            NguoiDungDTO nd = new NguoiDungDTO();
            nd.STenDN = dt.Rows[0]["TenDangNhap"].ToString();
            nd.SHoTen = dt.Rows[0]["HoTen"].ToString();
            nd.SMatKhau = dt.Rows[0]["MatKhau"].ToString();
            nd.SHinhAnh = dt.Rows[0]["HinhAnh"].ToString();
            nd.IQuyen = int.Parse(dt.Rows[0]["QuyenHan"].ToString());
            DataProvider.DongKetNoi(con);
            return nd;
        }
        public static bool ThemNguoiDung(NguoiDungDTO nd)
        {
            string sTruyVan = string.Format(@"INSERT INTO NguoiDung1 VALUES(N'{0}',N'{1}',
                    N'{2}',N'{3}',N'{4}')", nd.STenDN,nd.SHoTen, nd.SMatKhau,nd.SHinhAnh, nd.IQuyen);

            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool SuaNguoiDung(NguoiDungDTO nd)
        {
            string sTruyVan = string.Format(@"UPDATE NguoiDung1 SET TenDangNhap=N'{0}',HoTen=N'{1}', MatKhau =N'{2}',
            HinhAnh=N'{3}',QuyenHan=N'{4}'", nd.STenDN, nd.SHoTen, nd.SMatKhau, nd.SHinhAnh, nd.IQuyen);
            con = DataProvider.MoKetNoi();
            bool result = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            return result;
        }
        public static bool XoaNguoiDung(NguoiDungDTO nd)
        {
            string sTruyVan = string.Format(@"DELETE FROM NguoiDung1  WHERE TenDangNhap=N'{0}'", nd.STenDN);
            con = DataProvider.MoKetNoi();
            bool result = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            return result;
        }
        public static bool CapNhatMatKhau(NguoiDungDTO nd)
        {
            string sTruyVan = string.Format(@"UPDATE NguoiDung1 SET MatKhau=N'{0}' where TenDangNhap =N'{1}' ",  nd.SMatKhau, nd.STenDN);
            con = DataProvider.MoKetNoi();
            bool result = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            return result;
        }
    }
}
