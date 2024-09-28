using ProductsDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsBusnisseLayer
{
    public class clsDataBase
    {
        
        static public bool CreateBackup(string PathcreateBackup)
        {
            return clsDataBaseDataAccess.CreateBackup(PathcreateBackup);
        }
        static public bool RestoreBackup(string PathRestoreBackup)
        {
            return clsDataBaseDataAccess.RestoreBackup(PathRestoreBackup);
        }
    }
}
