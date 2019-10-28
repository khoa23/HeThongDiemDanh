using System.Web;
using System.Web.Mvc;

namespace WEB_DIEM_DANH
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
