using System;
using UrunYonetim6584.BL;
using UrunYonetim6584.Entities;

namespace UrunYonetim.WebFormUI
{
    public partial class Default : System.Web.UI.Page
    {
        ProductManager manager = new ProductManager();
        Repository<Slide> repository = new Repository<Slide>();
        protected void Page_Load(object sender, EventArgs e)
        {
            rptUrunler.DataSource = manager.GetAll(p => p.IsActive && p.IsHome);
            rptUrunler.DataBind();

            rptSlider.DataSource = repository.GetAll();
            rptSlider.DataBind();
        }
    }
}