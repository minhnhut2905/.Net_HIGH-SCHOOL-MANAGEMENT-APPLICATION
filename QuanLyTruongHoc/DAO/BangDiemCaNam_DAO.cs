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
    public class BangDiemCaNam_DAO
    {
        static SqlConnection con;

        // Lấy danh sách tất cả bảng điểm 
        public static List<BangDiemCaNam_DTO> LayDSBangDiemCaNam()
        {
            string sTruyVan = "select * from BangDiemCaNam";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<BangDiemCaNam_DTO> lstBangDiem = new List<DTO.BangDiemCaNam_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                BangDiemCaNam_DTO bangdiem = new BangDiemCaNam_DTO();
                bangdiem.SMaHS = dt.Rows[i]["MaHocSinh"].ToString();
                bangdiem.SMaLop = dt.Rows[i]["MaLop"].ToString();
                bangdiem.FDiemTB_HK1 = float.Parse(dt.Rows[i]["DiemTB_HK1"].ToString());
                bangdiem.FDiemTB_HK2 = float.Parse(dt.Rows[i]["DiemTB_HK2"].ToString());
                bangdiem.FDiemTbCaNam = float.Parse(dt.Rows[i]["DiemTB_CaNam"].ToString());
                bangdiem.SXepLoaiCaNam = dt.Rows[i]["XepLoai"].ToString();
                DataProvider.DongKetNoi(con);
                lstBangDiem.Add(bangdiem);
            }
            DataProvider.DongKetNoi(con);
            return lstBangDiem;
        }
        //Thêm bảng điểm cả năm
        public static bool ThemBangDiem(BangDiemCaNam_DTO bangdiem)
        {
            string sTruyVan = string.Format(@"INSERT INTO BangDiemCaNam VALUES(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}'
                    ,N'{5}')", bangdiem.SMaHS,
                    bangdiem.SMaLop, bangdiem.FDiemTB_HK1 , bangdiem.FDiemTB_HK2, bangdiem.FDiemTbCaNam,bangdiem.SXepLoaiCaNam);

            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        // Lấy thông tin bảng điểm có mã ma, trả về null nếu không tìm thấy
        public static BangDiemCaNam_DTO TimBangDiemTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from BangDiemCaNam where MaHocSinh=N'{0}' ",
            ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            BangDiemCaNam_DTO bangdiem = new BangDiemCaNam_DTO();
            bangdiem.SMaHS = dt.Rows[0]["MaHocSinh"].ToString();
            bangdiem.SMaLop = dt.Rows[0]["MaLop"].ToString();
            bangdiem.FDiemTB_HK1 = float.Parse(dt.Rows[0]["DiemTB_HK1"].ToString());
            bangdiem.FDiemTB_HK2 = float.Parse(dt.Rows[0]["DiemTB_HK2"].ToString());
            bangdiem.FDiemTbCaNam = float.Parse(dt.Rows[0]["DiemTB_CaNam"].ToString());
            bangdiem.SXepLoaiCaNam = dt.Rows[0]["XepLoai"].ToString();

            DataProvider.DongKetNoi(con);
            return bangdiem;
        }
        //Sửa bảng điểm
        public static bool SuaBangDiem(BangDiemCaNam_DTO bangdiem)
        {
            string sTruyVan = string.Format(@"UPDATE BangDiemCaNam SET MaLop=N'{0}',DiemTB_HK1=N'{1}',
                    DiemTB_HK2 = N'{2}',DiemTB_HK2=N'{3}',DiemTB_CaNam=N'{4}',
                    XepLoai=N'{5}'
                WHERE MaHocSinh=N'{6}'",
                    bangdiem.SMaLop, bangdiem.FDiemTB_HK1, bangdiem.FDiemTB_HK2,bangdiem.FDiemTbCaNam, bangdiem.SXepLoaiCaNam, bangdiem.SMaHS);
            con = DataProvider.MoKetNoi();
            bool result = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            return result;
        }
        //Xóa bảng điểm
        public static bool XoaBangDiem(BangDiemCaNam_DTO bangdiem)
        {
            string sTruyVan = string.Format(@"DELETE FROM BangDiemCaNam  WHERE MaHocSinh=N'{0}'", bangdiem.SMaHS);
            con = DataProvider.MoKetNoi();
            bool result = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            return result;
        }

    }
}
