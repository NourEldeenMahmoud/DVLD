using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DVLD_DataAccess
{
    public class clsDataAccessSettings
    {

        public static string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
         
        
    }
}
