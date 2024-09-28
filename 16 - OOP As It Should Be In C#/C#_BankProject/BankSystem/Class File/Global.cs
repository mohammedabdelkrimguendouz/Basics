using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class Global
    {
        static public clsUser CurrentUser = clsUser.Find("", "");
    }
}
