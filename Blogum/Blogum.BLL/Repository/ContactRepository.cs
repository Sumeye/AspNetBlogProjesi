using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Blogum.DAL;
namespace Blogum.BLL.Repository
{
    public class ContactRepository : IRepository<Contact>
    {
        BlogumDBEntities db = new BlogumDBEntities();
        public void Insert(Contact item)
        {
            db.Contact.Add(item);
            db.SaveChanges();
        }
        public void Update(Contact item)
        {
            Contact updated = db.Contact.Find(item.ContactId);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
        public void Delete(int itemId)
        {
            db.Contact.Remove(db.Contact.Find(itemId));
            db.SaveChanges();
        }
        public List<Contact> SelectAll()
        {
            return db.Contact.ToList();
        }

        public Contact SelectById(int itemId)
        {
            return db.Contact.Find(itemId);

        }
    }
}
