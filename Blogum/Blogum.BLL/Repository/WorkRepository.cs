using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blogum.DAL;
namespace Blogum.BLL.Repository
{
    public class WorkRepository:IRepository<Project>
    {
        BlogumDBEntities db = new BlogumDBEntities();
        public void Insert(Project item)
        {
            db.Project.Add(item);
            db.SaveChanges();

        }
        public void Update(Project item)
        {
            Project updated = db.Project.Find(item.ProjeId);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();


        }
        public void Delete(int itemId)
        {
            db.Project.Remove(db.Project.Find(itemId));
            db.SaveChanges();
        }

        public List<Project> SelectAll()
        {
            return db.Project.ToList();
        }

        public Project SelectById(int itemId)
        {
            return db.Project.Find(itemId);
        }


    }
}
