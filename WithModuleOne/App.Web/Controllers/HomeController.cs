using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace App.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : AppControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}