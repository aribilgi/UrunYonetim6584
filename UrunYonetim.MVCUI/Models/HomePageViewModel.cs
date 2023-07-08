using System.Collections.Generic;
using UrunYonetim6584.Entities;

namespace UrunYonetim.MVCUI.Models
{
    public class HomePageViewModel
    {
        public IEnumerable<Slide> Slides { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}