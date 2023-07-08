using System.Web;
using System.Web.Mvc;
using UrunYonetim6584.BL;
using UrunYonetim6584.Entities;

namespace UrunYonetim.MVCUI.Areas.Admin.Controllers
{
    [Authorize]
    public class UrunYonetimiController : Controller
    {
        Repository<Product> repository = new Repository<Product>();
        Repository<Category> repositoryKategori = new Repository<Category>();
        // GET: Admin/UrunYonetimi
        public ActionResult Index()
        {
            var model = repository.GetAll();
            return View(model);
        }

        // GET: Admin/UrunYonetimi/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/UrunYonetimi/Create
        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(repositoryKategori.GetAll(), "Id", "Name");
            return View();
        }

        // POST: Admin/UrunYonetimi/Create
        [HttpPost]
        public ActionResult Create(Product collection, HttpPostedFileBase Image, HttpPostedFileBase Image2)
        {
            ViewBag.CategoryId = new SelectList(repositoryKategori.GetAll(), "Id", "Name");
            if (!ModelState.IsValid)
            {
                return View(collection);
            }
            try
            {
                // TODO: Add insert logic here
                if (Image != null)
                {
                    Image.SaveAs(Server.MapPath("/Images/" + Image.FileName));
                    collection.Image = Image.FileName;
                }
                if (Image2 != null)
                {
                    Image2.SaveAs(Server.MapPath("/Images/" + Image2.FileName));
                    collection.Image2 = Image2.FileName;
                }
                repository.Add(collection);
                var sonuc = repository.Save();
                if (sonuc > 0)
                    return RedirectToAction("Index");
            }
            catch
            {
                ModelState.AddModelError("", "Hata Oluştu!");
            }
            
            return View(collection);
        }

        // GET: Admin/UrunYonetimi/Edit/5
        public ActionResult Edit(int id)
        {
            var model = repository.Find(id);
            ViewBag.CategoryId = new SelectList(repositoryKategori.GetAll(), "Id", "Name", model.CategoryId);
            return View(model);
        }

        // POST: Admin/UrunYonetimi/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Product collection, HttpPostedFileBase Image, HttpPostedFileBase Image2, bool resmiSil, bool resmiSil2 = false)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (resmiSil)
                    {
                        collection.Image = "";
                    }
                    if (resmiSil2)
                        collection.Image2 = "";
                    // TODO: Add update logic here
                    if (Image != null)
                    {
                        Image.SaveAs(Server.MapPath("/Images/" + Image.FileName));
                        collection.Image = Image.FileName;
                    }
                    if (Image2 != null)
                    {
                        Image2.SaveAs(Server.MapPath("/Images/" + Image2.FileName));
                        collection.Image2 = Image2.FileName;
                    }
                    repository.Update(collection);
                    var sonuc = repository.Save();
                    if (sonuc > 0)
                        return RedirectToAction("Index");
                }
                catch
                {
                    ModelState.AddModelError("", "Hata Oluştu!");
                }
            }
            ViewBag.CategoryId = new SelectList(repositoryKategori.GetAll(), "Id", "Name", collection.CategoryId);
            return View(collection);
        }

        // GET: Admin/UrunYonetimi/Delete/5
        public ActionResult Delete(int id)
        {
            var model = repository.Find(id);
            return View(model);
        }

        // POST: Admin/UrunYonetimi/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var model = repository.Find(id);
                repository.Delete(model);
                repository.Save();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
