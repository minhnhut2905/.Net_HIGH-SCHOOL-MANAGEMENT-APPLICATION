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
    public class HocSinhDAO
    {
        static SqlConnection con;

        // Lấy danh sách tất cả học sinh
        public static List<HocSinhDTO> LayDSHocSinh()
        {
            string sTruyVan = "select * from HocSinh";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HocSinhDTO> lstHocSinh = new List<DTO.HocSinhDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HocSinhDTO hs = new HocSinhDTO();
                hs.SMaHS = dt.Rows[i]["MaHocSinh"].ToString();
                hs.STenHS = dt.Rows[i]["TenHocSinh"].ToString();
                hs.DNgaySinh = DateTime.Parse(dt.Rows[i]["NgaySinh"].ToString());
                hs.SGioiTinh = dt.Rows[i]["GioiTinh"].ToString();
                hs.SDiaChi = dt.Rows[i]["DiaChi"].ToString();
                hs.ISDT = int.Parse(dt.Rows[i]["SDT"].ToString());
                hs.SAnh = dt.Rows[i]["HinhAnh"].ToString();

                
                hs.SMaQueQuan = dt.Rows[i]["MaQueQuan"].ToString();
                DataProvider.DongKetNoi(con);
                lstHocSinh.Add(hs);
            }
            DataProvider.DongKetNoi(con);
            return lstHocSinh;
        }

        public static List<HocSinhDTO> ReportHocSinh()
        {
            string sTruyVan = "select * from HocSinh";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HocSinhDTO> lst = new List<DTO.HocSinhDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HocSinhDTO hs = new HocSinhDTO();
                hs.SMaHS = dt.Rows[i]["MaHocSinh"].ToString();
                hs.STenHS = dt.Rows[i]["TenHocSinh"].ToString();
                hs.DNgaySinh = DateTime.Parse(dt.Rows[i]["NgaySinh"].ToString());
                hs.SGioiTinh = dt.Rows[i]["GioiTinh"].ToString();
                hs.SDiaChi = dt.Rows[i]["DiaChi"].ToString();
                hs.ISDT = int.Parse(dt.Rows[i]["SDT"].ToString());
                hs.SAnh = dt.Rows[i]["HinhAnh"].ToString();


                hs.SMaQueQuan = dt.Rows[i]["MaQueQuan"].ToString();
                DataProvider.DongKetNoi(con);
                lst.Add(hs);
            }
            DataProvider.DongKetNoi(con);
            return lst;
        }

            //Thêm học sinh
            public static bool ThemHocSinh(HocSinhDTO hs)
        {
            string sTruyVan = string.Format(@"INSERT INTO HocSinh VALUES(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}'
                    ,N'{5}',N'{6}',N'{7}')", hs.SMaHS,hs.STenHS,hs.DNgaySinh, hs.SGioiTinh, hs.SDiaChi, hs.ISDT,hs.SAnh,hs.SMaQueQuan);

            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        // Lấy thông tin học sinh có mã ma, trả về null nếu không tìm thấy mã học sinh.
        public static HocSinhDTO TimHocSinhTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from HocSinh where MaHocSinh=N'{0}'",
            ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            HocSinhDTO hs = new HocSinhDTO();
            hs.SMaHS = dt.Rows[0]["MaHocSinh"].ToString();
            hs.STenHS = dt.Rows[0]["TenHocSinh"].ToString();
            hs.DNgaySinh = DateTime.Parse(dt.Rows[0]["NgaySinh"].ToString());
            hs.SGioiTinh = dt.Rows[0]["GioiTinh"].ToString();
            hs.SDiaChi = dt.Rows[0]["DiaChi"].ToString();
            hs.ISDT = int.Parse(dt.Rows[0]["SDT"].ToString());
            hs.SAnh = dt.Rows[0]["HinhAnh"].ToString();

            hs.SMaQueQuan = dt.Rows[0]["MaQueQuan"].ToString();
            DataProvider.DongKetNoi(con);
            return hs;
        }
        //Sửa học sinh
        public static bool SuaHocSinh(HocSinhDTO hs)
        {
            string sTruyVan = string.Format(@"UPDATE HocSinh SET TenHocSinh=N'{0}',NgaySinh=N'{1}',
             GioiTinh=N'{2}',DiaChi=N'{3}',SDT=N'{4}',HinhAnh=N'{5}', MaQueQuan=N'{6}' WHERE MaHocSinh=N'{7}'", hs.STenHS, hs.DNgaySinh, hs.SGioiTinh, hs.SDiaChi, hs.ISDT, hs.SAnh, hs.SMaQueQuan,hs.SMaHS);
            con = DataProvider.MoKetNoi();
            bool result = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            return result;
        }
        //Xóa Học sinh
        public static bool XoaHocSinh(HocSinhDTO hs)
        {
            string sTruyVan = string.Format(@"DELETE FROM HocSinh  WHERE MaHocSinh=N'{0}'", hs.SMaHS);
            con = DataProvider.MoKetNoi();
            bool result = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            return result;
        }
    }
}
