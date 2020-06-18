using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNHA_SACH.Modules
{
    class XLKHACHHANG:XLBANG
    {
        public XLKHACHHANG() : base("KHACHHANG") { }
        public XLKHACHHANG(String pQuery) : base("KHACHHANG", pQuery) { }
    }
}
