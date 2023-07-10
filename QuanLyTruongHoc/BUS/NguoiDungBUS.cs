using System.Text;
using DTO;
using DAO;
using System.Security.Cryptography;
using System.Collections.Generic;

namespace BUS
{
    public class NguoiDungBUS
    {
        public static NguoiDungDTO LayNguoiDung(string ten, string matkhau)
        {
            MD5 md5Hash = MD5.Create();
            string matkhauMH = NguoiDungBUS.GetMd5Hash(md5Hash, matkhau);
            return NguoiDungDAO.KiemTraNguoiDung(ten, matkhauMH);
        
        }
        public static List<NguoiDungDTO> LayDSNguoiDung()
        {
            return NguoiDungDAO.LayDSNguoiDung();
        }

        // Hàm mã hóa
        // Tham khảo tại https://msdn.microsoft.com/enus/library/system.security.cryptography.md5.aspx
        public static string GetMd5Hash(MD5 md5Hash, string input)
        {
            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();
            // Loop through each byte of the hashed data
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
        public static NguoiDungDTO KiemTraTaiKhoan(string sten, string smatkhau)
        {
            MD5 hashmd5 = MD5.Create();
            string MatKhauMH = NguoiDungBUS.GetMd5Hash(hashmd5, smatkhau);
            return NguoiDungDAO.LayTaiKhoanDangNhap(sten, MatKhauMH);
        }
        public static bool ThemNguoiDung(NguoiDungDTO nd)
        {
            return NguoiDungDAO.ThemNguoiDung(nd);
        }
        public static bool CapNhatMatKhau(NguoiDungDTO nd)
        {
            //Mã hóa mật khẩu mới 
            MD5 md5Hash = MD5.Create();
            string matkhauMH = NguoiDungBUS.GetMd5Hash(md5Hash, nd.SMatKhau);
            nd.SMatKhau = matkhauMH; 
            return NguoiDungDAO.CapNhatMatKhau(nd);
        }
        public static bool XoaNguoiDung(NguoiDungDTO nd)
        {
            return NguoiDungDAO.XoaNguoiDung(nd);
        }
        public static bool SuaNguoiDung(NguoiDungDTO nd)
        {
            return NguoiDungDAO.SuaNguoiDung(nd);
        }
    }
}
