using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Blogum.DAL;
namespace Blogum.BLL.Repository
{
     public class CategoryRepository : IRepository<Categories>
    {
        BlogumDBEntities db = new BlogumDBEntities();
        public void Insert(Categories item)
        {
            db.Categories.Add(item);
            db.SaveChanges();
        }
        public void Update(Categories item)
        {
            Categories updated = db.Categories.Find(item.CatId);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
        public void Delete(int itemId)
        {
            db.Categories.Remove(db.Categories.Find(itemId));
            db.SaveChanges();
        }
        public List<Categories> SelectAll()
        {
            return db.Categories.ToList();
        }

        public Categories SelectById(int itemId)
        {
            return db.Categories.Find(itemId);
        
        }


    }
}
