using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNHA_SACH.Modules
{
    class XLNHANVIEN:XLBANG
    {
        public XLNHANVIEN() : base("NHANVIEN") { }
        public XLNHANVIEN(String pQuery) : base("XLNHANVIEN", pQuery) { }
    }
}
