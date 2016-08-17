using System.Web;
using System.Web.Mvc;

namespace Wha_Ever_I_Want
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
