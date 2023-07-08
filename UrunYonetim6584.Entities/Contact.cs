using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace UrunYonetim6584.Entities
{
    public class Contact : IEntity
    {
        public int Id { get; set; }
        [StringLength(50), DisplayName("Müşteri Adı"), Required]
        public string Name { get; set; }
        [DisplayName("Müşteri Soyadı")]
        public string Surname { get; set; }
        [DisplayName("Telefon")]
        public int Telephone { get; set; }
        [StringLength(50), DisplayName("Email"), Required]
        public string Email { get; set; }
        [StringLength(1500), DisplayName("Mesaj"), Required]
        public string Message { get; set; }
        [DisplayName("Mesaj Tarihi"), ScaffoldColumn(false)]
        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}
