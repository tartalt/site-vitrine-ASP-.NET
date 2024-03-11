using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class CategoryRepo
    {
        public int Create(Category abonnement)
        {
            MyDbContexte db = new MyDbContexte();
            db.Categories.Add(abonnement);
            return db.SaveChanges();
        }
        public List<Category> All()
        {
            MyDbContexte dbContext = new MyDbContexte();
            return dbContext.Categories.ToList();
        }
        public Category Read(int id)
        {
            MyDbContexte dbContext = new MyDbContexte();
            return dbContext.Categories.Find(id);
        }
        public void Delete(int id)
        {
            MyDbContexte dbContext = new MyDbContexte();
            var obj = dbContext.Categories.Find(id);
            dbContext.Categories.Remove(obj);
            dbContext.SaveChanges();
        }

        public void Update(Category entity)
        {
            MyDbContexte dbContext = new MyDbContexte();
            dbContext.Categories.Update(entity);
            dbContext.SaveChanges();
        }
    }
}
