using System.Web.Mvc;

namespace App.Web.Controllers
{
    public class AboutController : AppControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}