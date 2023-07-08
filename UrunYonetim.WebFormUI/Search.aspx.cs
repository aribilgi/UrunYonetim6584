using System;
using UrunYonetim6584.BL;

namespace UrunYonetim.WebFormUI
{
    public partial class Search : System.Web.UI.Page
    {
        ProductManager manager = new ProductManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            var kelime = Request.QueryString["q"];
            rptUrunler.DataSource = manager.GetAll(p => p.IsActive && p.Name.Contains(kelime) || p.Description.Contains(kelime));
            rptUrunler.DataBind();
        }
    }
}