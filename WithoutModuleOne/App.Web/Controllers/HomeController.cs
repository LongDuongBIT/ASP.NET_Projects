using System.Web.Mvc;

namespace App.Web.Controllers
{
    public class HomeController : AppControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}