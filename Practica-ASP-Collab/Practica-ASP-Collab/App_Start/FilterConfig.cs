using System.Web;
using System.Web.Mvc;

namespace Practica_ASP_Collab
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
