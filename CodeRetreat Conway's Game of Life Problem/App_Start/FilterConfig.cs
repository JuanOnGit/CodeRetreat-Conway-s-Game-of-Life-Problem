using System.Web;
using System.Web.Mvc;

namespace CodeRetreat_Conway_s_Game_of_Life_Problem
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
