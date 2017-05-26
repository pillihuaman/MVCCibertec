using System.Web;
using System.Web.Mvc;

namespace Administracion_Cliente_PEV
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
