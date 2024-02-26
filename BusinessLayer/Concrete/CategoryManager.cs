using DataAccessLayer.Concrete.Repostories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();

        public List<Category> GetAllBL()
        {
            return repo.List();
        }

        public void CategoryAddBL(Category p)
        {
            repo.Insert(p);
            //if (p.CategoryName == "" || p.CategoryName.Length <= 3 || p.CategoryDescription == "" || p.CategoryName.Length >= 51)
            //{
            //    //Hata mesajı
            //}
            //else
            //{
            //    repo.Insert(p);
            //}
        }
    }
}

// ctrl + k + d --> kodları düzenli hale getirmek için kullanılır.
