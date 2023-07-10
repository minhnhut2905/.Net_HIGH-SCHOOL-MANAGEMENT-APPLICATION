using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QueQuanDTO
    {
        private string sMaQueQuan;

        private string sTenQueQuan;

        public string SMaQueQuan { get => sMaQueQuan; set => sMaQueQuan = value; }
        public string STenQueQuan { get => sTenQueQuan; set => sTenQueQuan = value; }
    }
}
