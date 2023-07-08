using System.Web.Mvc;

namespace UrunYonetim.MVCUI.Areas.Admin.Controllers
{
    public class MainController : Controller
    {
        // GET: Admin/Main
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
    }
}