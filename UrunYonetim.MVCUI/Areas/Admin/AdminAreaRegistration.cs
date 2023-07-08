using System.Web.Mvc;

namespace UrunYonetim.MVCUI.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { controller="Main", action = "Index", id = UrlParameter.Optional } // Adres çubuğundan siteadi/admin yazınca main controller ve index action u varsayılan olarak açılsın diye
            );
        }
    }
}