using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blogum.DAL;
using System.Data.Entity;
namespace Blogum.BLL.Repository
{
    public class AdminRepository : IRepository<Admin>
    {
        BlogumDBEntities db = new BlogumDBEntities();
        public void Insert(Admin item)
        {
            db.Admin.Add(item);
            db.SaveChanges();
        }
        public void Update(Admin item)
        {
            Admin updated = db.Admin.Find(item.AdminId);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
        public void Delete(int itemId)
        {
            db.Admin.Remove(db.Admin.Find(itemId));
            db.SaveChanges();
        }


        public List<Admin> SelectAll()
        {
            return db.Admin.ToList();


        }

        public Admin SelectById(int itemId)
        {
            return db.Admin.Find(itemId);
        }


    }
}
