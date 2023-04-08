using System.Collections.Generic;
using System.Linq;
using UrunYonetim6584.Entities.DTOs;

namespace UrunYonetim6584.BL
{
    public class ProductManager : Repository<Entities.Product> // repository e product classı nı gönderdik böylece ProductManager ı kullandığımızda repository deki tüm metotlar product class ı için çalışacak
    {
        public List<ProductListDto> GetProducts()
        {
            var proucts = context.Products.Include("Category") // veritabanından ürünleri içine kategorileri de dahil ederek çek
                .Select(x => new ProductListDto // db den gelen ürünlerden aşağıdaki alanları seç
                {
                    CategoryName = x.Category.Name,
                    Brand = x.Brand,
                    Name = x.Name,
                    CreateDate = x.CreateDate,
                    Id = x.Id,
                    IsActive = x.IsActive,
                    Price = x.Price,
                    Stock = x.Stock
                }).ToList(); // seçtiğin verileri listele
            return proucts; // listeyi bu metodun kullanılacağı yere döndür
        }
    }
}
