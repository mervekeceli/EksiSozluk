using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repostories
{
    public class CategoryRepository : ICategoryDAL
    {
        Context c = new Context();
        DbSet<Category> _object;
        public void Delete(Category p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public void Insert(Category p)
        {
            _object.Add(p);
            c.SaveChanges(); //Değişiklikleri kaydetmek için kullanılır
        }

        public List<Category> List()
        {
            return _object.ToList();        
        }

        public void Update(Category p)
        {
            //Sadece değişiklikleri kaydeder çünkü zaten değişikliği ekrandan yapıp kaydet diyoruz.
            c.SaveChanges();
        }
    }
}
