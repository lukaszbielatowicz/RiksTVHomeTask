using System.Web;
using System.Web.Mvc;

namespace RiksTV.HomeTaskApplication {
    public class FilterConfig {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
