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
    public class BangDiemHK1_DAO
    {
        static SqlConnection con;

        // Lấy danh sách tất cả bảng điểm 
        public static List<BangDiemHK1_DTO> LayDSBangDiemHK1()
        {
            string sTruyVan = "select * from BangDiem_HK1";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<BangDiemHK1_DTO> lstBangDiem = new List<DTO.BangDiemHK1_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                BangDiemHK1_DTO bangdiem = new BangDiemHK1_DTO();
                bangdiem.SMaHS = dt.Rows[i]["MaHocSinh"].ToString();
                bangdiem.SMaLop = dt.Rows[i]["MaLop"].ToString();
                bangdiem.DtNamHoc = DateTime.Parse(dt.Rows[i]["NamHoc"].ToString());
                bangdiem.FDiemToan = float.Parse(dt.Rows[i]["DiemToan"].ToString());
                bangdiem.FDiemVan = float.Parse(dt.Rows[i]["DiemVan"].ToString());
                bangdiem.FDiemAnh = float.Parse(dt.Rows[i]["DiemAnh"].ToString());
                bangdiem.FDiemSinh = float.Parse(dt.Rows[i]["DiemSinh"].ToString());
                bangdiem.FDiemHoa = float.Parse(dt.Rows[i]["DiemHoa"].ToString());
                bangdiem.FDiemLi = float.Parse(dt.Rows[i]["DiemLi"].ToString());
                bangdiem.FDiemSu = float.Parse(dt.Rows[i]["DiemSu"].ToString());
                bangdiem.FDiemDia = float.Parse(dt.Rows[i]["DiemDia"].ToString());
                bangdiem.FDiemGDCD = float.Parse(dt.Rows[i]["DiemGDCD"].ToString());
                bangdiem.FCongNghe = float.Parse(dt.Rows[i]["DiemCongNghe"].ToString());
                bangdiem.FDiemTinHoc = float.Parse(dt.Rows[i]["DiemTinHoc"].ToString());
                bangdiem.FDiem_TB_HK1 = float.Parse(dt.Rows[i]["DiemTB_HK1"].ToString());
                bangdiem.SXepLoaiHk1 = dt.Rows[i]["XepLoai_HK1"].ToString();
                DataProvider.DongKetNoi(con);
                lstBangDiem.Add(bangdiem);
            }
            DataProvider.DongKetNoi(con);
            return lstBangDiem;
        }
        //Thêm bảng điểm 
        public static bool ThemBangDiem(BangDiemHK1_DTO bangdiem)
        {
            string sTruyVan = string.Format(@"INSERT INTO BangDiem_HK1 VALUES(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}'
                    ,N'{5}',N'{6}',N'{7}',N'{8}',N'{9}',N'{10}',N'{11}',N'{12}',N'{13}',N'{14}',N'{15}')", bangdiem.SMaHS, 
                    bangdiem.SMaLop, bangdiem.DtNamHoc, bangdiem.FDiemToan, bangdiem.FDiemVan, bangdiem.FDiemAnh, bangdiem.FDiemSinh, bangdiem.FDiemHoa, 
                    bangdiem.FDiemLi, bangdiem.FDiemSu, bangdiem.FDiemDia, bangdiem.FDiemGDCD, bangdiem.FCongNghe, bangdiem.FDiemTinHoc, bangdiem.FDiem_TB_HK1, bangdiem.SXepLoaiHk1);

            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        // Lấy thông tin bảng điểm có mã ma, trả về null nếu không tìm thấy
        public static BangDiemHK1_DTO TimBangDiemTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from BangDiem_HK1 where MaHocSinh=N'{0}'",
            ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            BangDiemHK1_DTO bangdiem = new BangDiemHK1_DTO();
            bangdiem.SMaHS = dt.Rows[0]["MaHocSinh"].ToString();
            bangdiem.SMaLop = dt.Rows[0]["MaLop"].ToString();
            bangdiem.DtNamHoc = DateTime.Parse(dt.Rows[0]["NamHoc"].ToString());
            bangdiem.FDiemToan = float.Parse(dt.Rows[0]["DiemToan"].ToString());
            bangdiem.FDiemVan = float.Parse(dt.Rows[0]["DiemVan"].ToString());
            bangdiem.FDiemAnh = float.Parse(dt.Rows[0]["DiemAnh"].ToString());
            bangdiem.FDiemSinh = float.Parse(dt.Rows[0]["DiemSinh"].ToString());
            bangdiem.FDiemHoa = float.Parse(dt.Rows[0]["DiemHoa"].ToString());
            bangdiem.FDiemLi = float.Parse(dt.Rows[0]["DiemLi"].ToString());
            bangdiem.FDiemSu = float.Parse(dt.Rows[0]["DiemSu"].ToString());
            bangdiem.FDiemDia = float.Parse(dt.Rows[0]["DiemDia"].ToString());
            bangdiem.FDiemGDCD = float.Parse(dt.Rows[0]["DiemGDCD"].ToString());
            bangdiem.FCongNghe = float.Parse(dt.Rows[0]["DiemCongNghe"].ToString());
            bangdiem.FDiemTinHoc = float.Parse(dt.Rows[0]["DiemTinHoc"].ToString());
            bangdiem.FDiem_TB_HK1 = float.Parse(dt.Rows[0]["DiemTB_HK1"].ToString());
            bangdiem.SXepLoaiHk1 = dt.Rows[0]["XepLoai_HK1"].ToString();

            DataProvider.DongKetNoi(con);
            return bangdiem;
        }
        //Sửa bảng điểm
        public static bool SuaBangDiem(BangDiemHK1_DTO bangdiem)
        {
            string sTruyVan = string.Format(@"UPDATE BangDiem_HK1 SET MaLop=N'{0}',NamHoc=N'{1}',
                    DiemToan=N'{2}',DiemVan=N'{3}', DiemAnh=N'{4}',DiemSinh=N'{5}', DiemHoa=N'{6}',DiemLi=N'{7}',
                    DiemSu=N'{8}', DiemDia=N'{9}', DiemGDCD=N'{10}',DiemCongNghe=N'{11}',DiemTinHoc=N'{12}',DiemTB_HK1=N'{13}',
                    XepLoai_HK1=N'{14}'
                WHERE MaHocSinh=N'{15}'",
                    bangdiem.SMaLop, bangdiem.DtNamHoc, bangdiem.FDiemToan, bangdiem.FDiemVan, bangdiem.FDiemAnh, 
                    bangdiem.FDiemSinh, bangdiem.FDiemHoa, bangdiem.FDiemLi, bangdiem.FDiemSu, bangdiem.FDiemDia, 
                    bangdiem.FDiemGDCD, bangdiem.FCongNghe, bangdiem.FDiemTinHoc, bangdiem.FDiem_TB_HK1, bangdiem.SXepLoaiHk1, bangdiem.SMaHS);
            con = DataProvider.MoKetNoi();
            bool result = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            return result;
        }
        //Xóa bảng điểm
        public static bool XoaBangDiem(BangDiemHK1_DTO bangdiem)
        {
            string sTruyVan = string.Format(@"DELETE FROM BangDiem_HK1  WHERE MaHocSinh=N'{0}'", bangdiem.SMaHS);
            con = DataProvider.MoKetNoi();
            bool result = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            return result;
        }
    }
}
