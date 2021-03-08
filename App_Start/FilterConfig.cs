using System.Web;
using System.Web.Mvc;

namespace Gestion_Des_Abscences
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
