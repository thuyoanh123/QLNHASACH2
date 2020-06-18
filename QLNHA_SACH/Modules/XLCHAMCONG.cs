using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNHA_SACH.Modules
{
    class XLCHAMCONG:XLBANG
    {
        public XLCHAMCONG() : base("CHAMCONG") { }
        public XLCHAMCONG(String pQuery) : base("CHAMCONG", pQuery) { }
    }
}
