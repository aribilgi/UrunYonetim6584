using System.Web.Mvc;
using UrunYonetim6584.BL;
using UrunYonetim6584.Entities;

namespace UrunYonetim.MVCUI.Areas.Admin.Controllers
{
    [Authorize]
    public class ContactsController : Controller
    {
        Repository<Contact> repository = new Repository<Contact>();
        // GET: Admin/Contacts
        public ActionResult Index()
        {
            return View(repository.GetAll());
        }

        // GET: Admin/Contacts/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Contacts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Contacts/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Contacts/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Contacts/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Contacts/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Contacts/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
