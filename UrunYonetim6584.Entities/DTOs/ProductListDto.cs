using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace UrunYonetim6584.Entities.DTOs
{
    public class ProductListDto
    {
        public int Id { get; set; }
        [StringLength(50), DisplayName("Ürün Adı"), Required]
        public string Name { get; set; }        
        [StringLength(50), DisplayName("Marka")]
        public string Brand { get; set; }
        [DisplayName("Durum")]
        public bool IsActive { get; set; }
        [DisplayName("Stok")]
        public int Stock { get; set; }
        [DisplayName("Ürün Fiyatı")]
        public decimal Price { get; set; }        
        [DisplayName("Eklenme Tarihi")]
        public DateTime CreateDate { get; set; }
        [DisplayName("Kategori")]
        public string CategoryName { get; set; }
    }
}
