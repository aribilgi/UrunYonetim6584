using System;
using System.Collections.Generic;

namespace UrunYonetim6584.Entities
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }
        public virtual List<Product> Products { get; set; } // burada Category ile Product class ları arasında 1 e çok bir ilişki kurduk. Yani 1 kategorinin 1 den çok ürünü olabilir.
    }
}
