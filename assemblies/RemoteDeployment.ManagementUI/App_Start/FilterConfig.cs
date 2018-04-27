using System.Web;
using System.Web.Mvc;

namespace RemoteDeployment.ManagementUI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
