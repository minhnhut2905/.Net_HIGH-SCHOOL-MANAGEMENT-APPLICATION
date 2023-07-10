using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LopHocDTO
    {
        private string sMaLop;
        private string sTenLop;

        public string SMaLop { get => sMaLop; set => sMaLop = value; }
        public string STenLop { get => sTenLop; set => sTenLop = value; }
    }
}
