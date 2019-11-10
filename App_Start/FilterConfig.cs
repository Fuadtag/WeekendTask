using System.Web;
using System.Web.Mvc;

namespace _08_11_2019WeekendTask
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
