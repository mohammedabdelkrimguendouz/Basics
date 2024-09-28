using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork_Test
{
    public static class Connection
    {
        public static string ConnectionString = @"
              Server=DESKTOP-SFPCDET;
              Database=DB_Test_EF;
              User Id=sa;
              Password=sa123456;
              TrustServerCertificate=true;
        ";
    }
}
