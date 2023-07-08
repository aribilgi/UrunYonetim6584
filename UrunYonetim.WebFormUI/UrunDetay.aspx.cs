using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UrunYonetim6584.BL;

namespace UrunYonetim.WebFormUI
{
    public partial class UrunDetay : System.Web.UI.Page
    {
        ProductManager manager = new ProductManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            var id = Request.QueryString["id"];
            if (id != null)
            {
                try
                {
                    var urun = manager.Find(Convert.ToInt32(id));
                    Resim.ImageUrl = "/Images/" + urun.Image;
                    baslik.InnerText = urun.Name;
                    marka.InnerText = "Marka : " + urun.Brand;
                    fiyat.InnerText = "Fiyat : " + urun.Price + " ₺";
                    stok.InnerText = "Stok : " + urun.Stock;
                    aciklama.InnerText = urun.Description;
                }
                catch (Exception)
                {
                    baslik.InnerText = "Hata Oluştu!";
                }
                
            }
        }
    }
}