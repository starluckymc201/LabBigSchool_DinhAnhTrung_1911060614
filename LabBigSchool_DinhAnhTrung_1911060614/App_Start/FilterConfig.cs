using System.Web;
using System.Web.Mvc;

namespace LabBigSchool_DinhAnhTrung_1911060614
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
