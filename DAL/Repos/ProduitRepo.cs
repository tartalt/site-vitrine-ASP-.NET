using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class ProduitRepo
    {
        public int Create(Produit Service)
        {
            MyDbContexte db = new MyDbContexte();
            db.Produits.Add(Service);
            return db.SaveChanges();
        }
        public List<Produit> All()
        {
            MyDbContexte dbContext = new MyDbContexte();
            return dbContext.Produits.ToList();
        }
        public Produit Read(int id)
        {
            MyDbContexte dbContext = new MyDbContexte();
            return dbContext.Produits.Find(id);
        }
        public void Delete(int id)
        {
            MyDbContexte dbContext = new MyDbContexte();
            var obj = dbContext.Produits.Find(id);
            dbContext.  Produits.Remove(obj);
            dbContext.SaveChanges();
        }

        public void Update(Produit entity)
        {
            MyDbContexte dbContext = new MyDbContexte();
            dbContext.Produits.Update(entity);
            dbContext.SaveChanges();
        }
    }
}
