using System.Web.Mvc;
using UrunYonetim6584.BL;
using UrunYonetim6584.Entities;

namespace UrunYonetim.MVCUI.Controllers
{
    public class ProductsController : Controller
    {
        Repository<Product> repositoryProduct = new Repository<Product>();
        // GET: Products
        public ActionResult Index()
        {
            return View(repositoryProduct.GetAll(p => p.IsActive));
        }
        public ActionResult Detail(int id)
        {
            var model = repositoryProduct.Find(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }
        public ActionResult Search(string q)
        {
            return View(repositoryProduct.GetAll(p => p.IsActive && p.Name.Contains(q)));
        }
    }
}