using System;
using System.Web.Security;
using UrunYonetim6584.BL;
using UrunYonetim6584.Entities;

namespace UrunYonetim.WebFormUI.Admin
{
    public partial class Login : System.Web.UI.Page
    {
        Repository<User> repository = new Repository<User>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGiris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(floatingInput.Value) || string.IsNullOrWhiteSpace(floatingPassword.Value))
            {
                Response.Write("<script>alert('Email ve Şifre Boş Geçilemez!')</script>");
            }
            else
            {
                var kullanici = repository.Get(u => u.IsActive && u.IsAdmin && u.Email == floatingInput.Value && u.Password == floatingPassword.Value);
                if (kullanici != null)
                {
                    FormsAuthentication.SetAuthCookie(kullanici.Email, true);
                    if (Request.QueryString["ReturnUrl"] != null)
                    {
                        Response.Redirect(Request.QueryString["ReturnUrl"]);
                    }
                    Response.Redirect("/Admin");
                }
                else
                {
                    Response.Write("<script>alert('Giriş Başarısız!')</script>");
                }
            }
        }
    }
}