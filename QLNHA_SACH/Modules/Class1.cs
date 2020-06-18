using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace QLNHA_SACH.Modules
{
    class Class1
    {
        
            public static string cnnStr = "Data Source=DESKTOP-SR3BE2S\\SQLEXPRESS;Initial Catalog=QLNHASACH;Integrated Security=True";
            public static SqlConnection cnn = new SqlConnection(cnnStr);
        
    }
}
}
