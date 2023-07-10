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
    public class GiangVienDAO
    {
        static SqlConnection con;

        // Lấy danh sách tất cả giảng viên
        public static List<GiangVienDTO> LayDSGiangVien()
        {
            string sTruyVan = "select * from GiangVien";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<GiangVienDTO> lstGiangVien = new List<DTO.GiangVienDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                GiangVienDTO gv = new GiangVienDTO();
                gv.SMaGV = dt.Rows[i]["MaGiangVien"].ToString();
                gv.STenGV = dt.Rows[i]["TenGiangVien"].ToString();
                gv.DtNgaySinh = DateTime.Parse(dt.Rows[i]["NgaySinh"].ToString());
                gv.SGioiTinh = dt.Rows[i]["GioiTinh"].ToString();
                gv.SDiaChi = dt.Rows[i]["DiaChi"].ToString();
                gv.ISDT = int.Parse(dt.Rows[i]["SDT"].ToString());
                gv.SHinhAnh = dt.Rows[i]["HinhAnh"].ToString();


                gv.SMaQueQuan = dt.Rows[i]["MaQueQuan"].ToString();
                gv.SMaChucVu = dt.Rows[i]["MaChucVu"].ToString();
                gv.SMaPhongBan = dt.Rows[i]["MaPhongBan"].ToString();
                gv.FLuongCanBan = float.Parse(dt.Rows[i]["LuongCanBan"].ToString());
                DataProvider.DongKetNoi(con);
                lstGiangVien.Add(gv);
            }
            DataProvider.DongKetNoi(con);
            return lstGiangVien;
        }
        //Thêm giảng viên
        public static bool ThemGiangVien(GiangVienDTO gv)
        {
            string sTruyVan = string.Format(@"INSERT INTO GiangVien VALUES(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}'
                    ,N'{5}',N'{6}',N'{7}',N'{8}',N'{9}',N'{10}')", gv.SMaGV, gv.STenGV, gv.DtNgaySinh, gv.SGioiTinh, gv.SDiaChi,gv.ISDT, gv.SHinhAnh, gv.SMaQueQuan, gv.SMaChucVu, gv.SMaPhongBan, gv.FLuongCanBan);

            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        // Lấy thông tin giảng viên có mã ma, trả về null nếu không tìm thấy
        public static GiangVienDTO TimGiangVienTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from GiangVien where MaGiangVien=N'{0}' OR TenGiangVien=N'{0}'",
            ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            GiangVienDTO gv = new GiangVienDTO();
            gv.SMaGV = dt.Rows[0]["MaGiangVien"].ToString();
            gv.STenGV = dt.Rows[0]["TenGiangVien"].ToString();
            gv.DtNgaySinh = DateTime.Parse(dt.Rows[0]["NgaySinh"].ToString());
            gv.SGioiTinh = dt.Rows[0]["GioiTinh"].ToString();
            gv.SDiaChi = dt.Rows[0]["DiaChi"].ToString();
            gv.ISDT = int.Parse(dt.Rows[0]["SDT"].ToString());
            gv.SHinhAnh = dt.Rows[0]["HinhAnh"].ToString();

            gv.SMaQueQuan = dt.Rows[0]["MaQueQuan"].ToString();
            gv.SMaChucVu = dt.Rows[0]["MaChucVu"].ToString();
            gv.SMaQueQuan = dt.Rows[0]["MaPhongBan"].ToString();
            gv.FLuongCanBan = float.Parse(dt.Rows[0]["LuongCanBan"].ToString());

            DataProvider.DongKetNoi(con);
            return gv;
        } 
        //Sửa giảng viên
        public static bool SuaGiangVien(GiangVienDTO gv)
        {
            string sTruyVan = string.Format(@"UPDATE GiangVien SET TenGiangVien=N'{0}',NgaySinh=N'{1}',
             GioiTinh=N'{2}',DiaChi=N'{3}', SDT=N'{4}',HinhAnh=N'{5}', MaQueQuan=N'{6}',MaChucVu=N'{7}',MaPhongBan=N'{8}', LuongCanBan=N'{9}' WHERE MaGiangVien=N'{10}'",  gv.STenGV, gv.DtNgaySinh, gv.SGioiTinh,  gv.SDiaChi, gv.ISDT, gv.SHinhAnh, gv.SMaQueQuan,gv.SMaChucVu, gv.SMaPhongBan ,gv.FLuongCanBan,gv.SMaGV);
            con = DataProvider.MoKetNoi();
            bool result = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            return result;
        }
        //Xóa giảng viên
        public static bool XoaGiangVien(GiangVienDTO gv)
        {
            string sTruyVan = string.Format(@"DELETE FROM GiangVien  WHERE MaGiangVien=N'{0}'", gv.SMaGV);
            con = DataProvider.MoKetNoi();
            bool result = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            return result;
        }
    }
}
