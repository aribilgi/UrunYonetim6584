using System.Web.Mvc;
using UrunYonetim6584.BL;
using UrunYonetim6584.Entities;

namespace UrunYonetim.MVCUI.Areas.Admin.Controllers
{
    [Authorize]
    public class KullaniciYonetimiController : Controller
    {
        Repository<User> repository = new Repository<User>();
        // GET: Admin/KullaniciYonetimi
        public ActionResult Index()
        {
            var model = repository.GetAll();
            return View(model);
        }

        // GET: Admin/KullaniciYonetimi/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/KullaniciYonetimi/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/KullaniciYonetimi/Create
        [HttpPost]
        public ActionResult Create(User collection)
        {
            if (!ModelState.IsValid) // eğer model nesnesinde kurallara uyulmamışsa
            {
                return View(collection); // sayfaya geri dön
            }
            try
            {
                // TODO: Add insert logic here
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

        // GET: Admin/KullaniciYonetimi/Edit/5
        public ActionResult Edit(int id)
        {
            var model = repository.Find(id);
            return View(model);
        }

        // POST: Admin/KullaniciYonetimi/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, User collection)
        {
            try
            {
                // TODO: Add update logic here
                repository.Update(collection);
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

        // GET: Admin/KullaniciYonetimi/Delete/5
        public ActionResult Delete(int id)
        {
            var model = repository.Find(id);
            return View(model);
        }

        // POST: Admin/KullaniciYonetimi/Delete/5
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
