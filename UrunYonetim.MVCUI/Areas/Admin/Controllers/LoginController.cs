using System.Web.Mvc;
using System.Web.Security;
using UrunYonetim6584.BL;
using UrunYonetim6584.Entities;

namespace UrunYonetim.MVCUI.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        Repository<User> repository = new Repository<User>();
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string email, string password, bool beniHatirla = true)
        {
            try
            {
                var kullanici = repository.Get(u => u.IsActive && u.IsAdmin && u.Email == email && u.Password == password);
                if (kullanici != null)
                {
                    Session["Admin"] = kullanici;
                    FormsAuthentication.SetAuthCookie(email, beniHatirla);
                    if (Request.QueryString["ReturnUrl"] != null) // eğer adres çubuğunda ReturnUrl diye bir değer varsa
                    {
                        return Redirect(Request.QueryString["ReturnUrl"]); // oturum açıldıktan sonra kullanıcıyı kaldığı yere dönürmek için returnurl deki adrese yönlendir
                    }
                    return Redirect("/Admin"); // ReturnUrl boşsa direk admin anasayfaya yönlendir
                }
                else
                {
                    TempData["Message"] = "<div class='alert alert-danger'>Giriş Başarısız!</div>";
                }
            }
            catch (System.Exception hata)
            {
                TempData["Message"] = "<div class='alert alert-danger'>Hata Oluştu!</div>";
                //Todo: burada loglama yapılıp hata kaydedilmeli!
                //throw;
            }
            return View();
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            //Session["Admin"] = null;
            Session.Remove("Admin");
            return Redirect("/Admin/Login");
        }
    }
}