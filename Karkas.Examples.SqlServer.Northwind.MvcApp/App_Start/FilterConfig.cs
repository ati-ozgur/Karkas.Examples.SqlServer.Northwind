using System.Web;
using System.Web.Mvc;

namespace Karkas.Examples.SqlServer.Northwind.MvcApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}