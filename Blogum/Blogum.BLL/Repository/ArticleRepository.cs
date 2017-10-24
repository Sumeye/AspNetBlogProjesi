using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Blogum.DAL;

namespace Blogum.BLL.Repository
{
  
   public class ArticleRepository:IRepository<Articles>
    {
        BlogumDBEntities db = new BlogumDBEntities();
        public void Insert(Articles item)
        {
            db.Articles.Add(item);
            db.SaveChanges();
        }
        public void Update(Articles item)
        {
            Articles Updated = db.Articles.Find(item.ArticleId);
            db.Entry(Updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
        public void Delete(int itemId)
        {
            db.Articles.Remove(db.Articles.Find(itemId));
            db.SaveChanges();
        }
        public List<Articles> SelectAll()
        {
           return db.Articles.ToList();
        }

        public Articles SelectById(int itemId)
        {
            return db.Articles.Find(itemId);
        }

  
    }
}
