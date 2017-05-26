using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace PA.Adapters
{
  public class SqlDBAdapter
    {
        public static String GetConexion()
        {
            return ConfigurationManager.ConnectionStrings["ConexionPEV"].ConnectionString;


        }

        public static String GetConexionAdventureWorks2014()
        {
            return ConfigurationManager.ConnectionStrings["ConexionAdventureWorks2014"].ConnectionString;


        }

    }
}
