using System;
using System.Collections.Generic;
using System.Linq.Expressions; // veri sorgulama işlemleri yapabilmek için

namespace UrunYonetim6584.BL
{
    public interface IRepository<T> // interface i yanına <T> ekleyerek generic-genel kullanılabilir hale getirdik
    {
        List<T> GetAll();
        List<T> GetAll(Expression<Func<T, bool>> expression); // x=>x.name == "elektronik". Geriye sorgu sonucunda gönderilen class ın db deki listesini döner
        void Add(T entity);
        T Find(int id);
        T Get(Expression<Func<T, bool>> expression); // geriye sorgu sunucunda 1 kayıt döner
        void Update(T entity);
        void Delete(T entity);
        int Save();
    }
}
