using System.Net;
using System.Web.Mvc;
using UrunYonetim6584.BL;
using UrunYonetim6584.Entities;

namespace UrunYonetim.MVCUI.Controllers
{
    public class CategoriesController : Controller
    {

        Repository<Category> repositoryCategory = new Repository<Category>();
        // GET: Categories
        public ActionResult Index(int? id) // ? int i nullable yapar
        {
            if (id == null) // eğer adres çubuğundan id yazılmamışsa
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest); // geriye geçersiz istek hatası döndür
            }
            var model = repositoryCategory.Find(id.Value); // id varsa find ile kategoriyi bul. id yi nullable yapınca id.value yazmalıyız
            if (model == null) // gelen id ye sahip kategori db de yoksa
            {
                return HttpNotFound(); // geriye bulunamadı hatası dön
            }
            return View(model); // eğer her şey normalse ekrana bulunan kategoriyi model olarak yolla
        }
    }
}