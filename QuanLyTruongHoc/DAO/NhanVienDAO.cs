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
    public class NhanVienDAO
    {
        static SqlConnection con;

        // Lấy danh sách tất cả nhân viên
        public static List<NhanVien_DTO> LayDSNhanVien()
        {
            string sTruyVan = "select * from NhanVien";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NhanVien_DTO> lstNhanVien = new List<DTO.NhanVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.SMaNV = dt.Rows[i]["MaNhanVien"].ToString();
                nv.STenNV = dt.Rows[i]["TenNhanVien"].ToString();
                nv.DtNgaySinh = DateTime.Parse(dt.Rows[i]["NgaySinh"].ToString());
                nv.SGioiTinh = dt.Rows[i]["GioiTinh"].ToString();
                nv.SDiaChi = dt.Rows[i]["DiaChi"].ToString();
                nv.ISDT = int.Parse(dt.Rows[i]["SDT"].ToString());
                nv.SHinhAnh = dt.Rows[i]["HinhAnh"].ToString();


                nv.SMaQueQuan = dt.Rows[i]["MaQueQuan"].ToString();
                nv.SMaChucVu = dt.Rows[i]["MaChucVU"].ToString();
                nv.SMaPhongBan = dt.Rows[i]["MaPhongBan"].ToString();

                nv.FLuongCB = float.Parse(dt.Rows[i]["LuongCanBan"].ToString());
                DataProvider.DongKetNoi(con);
                lstNhanVien.Add(nv);
            }
            DataProvider.DongKetNoi(con);
            return lstNhanVien;
        }
        public static bool ThemNhanVien(NhanVien_DTO nv)
        {
            string sTruyVan = string.Format(@"INSERT INTO NhanVien VALUES(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}'
                    ,N'{5}',N'{6}',N'{7}',N'{8}',N'{9}',N'{10}')", nv.SMaNV, nv.STenNV, nv.DtNgaySinh, nv.SGioiTinh, nv.SDiaChi, nv.ISDT, nv.SHinhAnh, nv.SMaQueQuan, nv.SMaChucVu, nv.SMaPhongBan, nv.FLuongCB);

            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        // Lấy thông tin học sinh có mã ma, trả về null nếu không thấy
        public static NhanVien_DTO TimNhanVienTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from NhanVien where MaNhanVien=N'{0}'",
            ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.SMaNV = dt.Rows[0]["MaNhanVien"].ToString();
            nv.STenNV = dt.Rows[0]["TenNhanVien"].ToString();
            nv.DtNgaySinh = DateTime.Parse(dt.Rows[0]["NgaySinh"].ToString());
            nv.SGioiTinh = dt.Rows[0]["GioiTinh"].ToString();
            nv.SDiaChi = dt.Rows[0]["DiaChi"].ToString();
            nv.ISDT = int.Parse(dt.Rows[0]["SDT"].ToString());
            nv.SHinhAnh = dt.Rows[0]["HinhAnh"].ToString();

            nv.SMaQueQuan = dt.Rows[0]["MaQueQuan"].ToString();
            nv.SMaChucVu = dt.Rows[0]["MaChucVu"].ToString();
            nv.SMaQueQuan = dt.Rows[0]["MaPhongBan"].ToString();
            nv.FLuongCB = float.Parse(dt.Rows[0]["LuongCanBan"].ToString());
            DataProvider.DongKetNoi(con);
            return nv;
        }
        public static bool SuaNhanvien(NhanVien_DTO nv)
        {
            string sTruyVan = string.Format(@"UPDATE NhanVien SET TenNhanVien=N'{0}',NgaySinh=N'{1}',
             GioiTinh=N'{2}',DiaChi=N'{3}', SDT=N'{4}',HinhAnh=N'{5}', MaQueQuan=N'{6}',MaChucVu=N'{7}',MaPhongBan=N'{8}', LuongCanBan=N'{9}' WHERE MaNhanVien=N'{10}'", nv.STenNV, nv.DtNgaySinh, nv.SGioiTinh, nv.SDiaChi, nv.ISDT, nv.SHinhAnh, nv.SMaQueQuan, nv.SMaChucVu, nv.SMaPhongBan, nv.FLuongCB, nv.SMaNV);
            con = DataProvider.MoKetNoi();
            bool result = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            return result;
        }
        public static bool XoaNhanVien(NhanVien_DTO nv)
        {
            string sTruyVan = string.Format(@"DELETE FROM NhanVien  WHERE MaNhanVien=N'{0}'", nv.SMaNV);
            con = DataProvider.MoKetNoi();
            bool result = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            return result;
        }
    }
}
