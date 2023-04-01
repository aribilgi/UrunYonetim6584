using System;

namespace UrunYonetim6584.Entities
{
    public interface IEntity
    {
        int Id { get; set; }
        DateTime CreateDate { get; set; }
    }
}
