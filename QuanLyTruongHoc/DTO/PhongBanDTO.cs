using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhongBanDTO
    {
        private string sMaPhongBan;
        private string sTenPhongBan;

        public string SMaPhongBan { get => sMaPhongBan; set => sMaPhongBan = value; }
        public string STenPhongBan { get => sTenPhongBan; set => sTenPhongBan = value; }
    }
}
