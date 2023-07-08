using System;
using System.Web.Mvc;
using UrunYonetim6584.BL;
using UrunYonetim6584.Entities;

namespace UrunYonetim.MVCUI.Areas.Admin.Controllers
{
    [Authorize] // bu controller daki tüm actionları korumaya al, sadece oturum açanlar görebilsin
    public class KategoriYonetimiController : Controller
    {
        CategoryManager manager = new CategoryManager();
        // GET: Admin/KategoriYonetimi
        public ActionResult Index()
        {
            var model = manager.GetCategories();
            return View(model); // içi dolu kategori listesini parantez içerisinde sayfaya yolluyoruz
        }

        // GET: Admin/KategoriYonetimi/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/KategoriYonetimi/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/KategoriYonetimi/Create
        [HttpPost]
        public ActionResult Create(Category collection)
        {
            try
            {
                // TODO: Add insert logic here
                manager.Add(collection);
                var sonuc = manager.Save();
                if (sonuc > 0)
                    return RedirectToAction("Index");
            }
            catch (Exception hata)
            {
                ModelState.AddModelError("", "Hata Oluştu! " + hata.Message); // ekranda hata oluştu mesajı ver
            }
            return View(collection);
        }

        // GET: Admin/KategoriYonetimi/Edit/5
        public ActionResult Edit(int id)
        {
            var model = manager.GetCategory(id);
            return View(model);
        }

        // POST: Admin/KategoriYonetimi/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Category collection)
        {
            try
            {
                // TODO: Add update logic here
                manager.Update(collection);
                var sonuc = manager.Save();
                if (sonuc > 0)
                    return RedirectToAction("Index");
            }
            catch (Exception hata)
            {
                ModelState.AddModelError("", "Hata Oluştu! " + hata.Message); // ekranda hata oluştu mesajı ver
            }
            return View(collection);
        }

        // GET: Admin/KategoriYonetimi/Delete/5
        public ActionResult Delete(int id)
        {
            var model = manager.GetCategory(id);
            return View(model);
        }

        // POST: Admin/KategoriYonetimi/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Category collection)
        {
            try
            {
                // TODO: Add delete logic here
                var model = manager.GetCategory(id);
                manager.Delete(model);
                var sonuc = manager.Save();
                if (sonuc > 0)
                    return RedirectToAction("Index");
            }
            catch
            {
                ModelState.AddModelError("", "Hata Oluştu!");
            }
            return View();
        }
    }
}
