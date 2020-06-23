using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNHASACH.Moduls
{
    class XLSANPHAM : XLBANG
    {
        private string pQuery1;

        public XLSANPHAM() : base("SANPHAM") {}
        public XLSANPHAM(string pQuery): base("SANPHAM", pQuery) { }

    }
}
