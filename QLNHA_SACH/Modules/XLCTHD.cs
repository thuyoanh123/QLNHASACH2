﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNHA_SACH.Modules
{
    class XLCTHD:XLBANG
    {
        public XLCTHD() : base("CTHD") { }
        public XLCTHD(String pQuery) : base("CTHD", pQuery) { }
    }
}
