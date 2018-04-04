using System.Web.Mvc;

namespace FirstABP.Web.Controllers
{
    public class AboutController : FirstABPControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}