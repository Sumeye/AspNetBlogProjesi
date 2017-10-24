using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Blogum.DAL;

namespace Blogum.BLL.Repository
{
    public class CommentRepository : IRepository<Comments>
    {
        BlogumDBEntities db = new BlogumDBEntities();
        public void Insert(Comments item)
        {
            db.Comments.Add(item);
            db.SaveChanges();
        }
        public void Update(Comments item)
        {
            Comments updated = db.Comments.Find(item.CommentId);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
         }
        public void Delete(int itemId)
        {
            db.Comments.Remove(db.Comments.Find(itemId));
            db.SaveChanges();
        }
        public List<Comments> SelectAll()
        {
            return db.Comments.ToList();
        }

        public Comments SelectById(int itemId)
        {
            return db.Comments.Find(itemId);
        }

  
    }
}
