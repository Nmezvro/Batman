using System.Globalization;
using System.Threading;
using System.Web.Mvc;

namespace Batman.Controllers
{
    public class BaseController : Controller
    {
        protected string Language { get; set; }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);

            if (filterContext.RouteData.Values.ContainsKey("language"))
                Language = filterContext.RouteData.Values["language"].ToString().ToLower();
            else
                Language = "ka";

            ViewBag.language = Language;

            Thread.CurrentThread.CurrentCulture = new CultureInfo(Language);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Language);
        }
    }
}