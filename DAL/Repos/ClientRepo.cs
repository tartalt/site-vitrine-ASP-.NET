using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class ClientRepo
    {
        public int Create(Client client)
        {
            MyDbContexte db = new MyDbContexte();
            db.Clients.Add(client);
            return db.SaveChanges();
        }
        public List<Client> All()
        {
            MyDbContexte dbContext = new MyDbContexte();
            return dbContext.Clients.ToList();
        }
        public Client Read(int id)
        {
            MyDbContexte dbContext = new MyDbContexte();
            return dbContext.Clients.Find(id);
        }
        public void Delete(int id)
        {
            MyDbContexte dbContext = new MyDbContexte();
            var obj = dbContext.Clients.Find(id);
            dbContext.Clients.Remove(obj);
            dbContext.SaveChanges();
        }

        public void Update(Client entity)
        {
            MyDbContexte dbContext = new MyDbContexte();
            dbContext.Clients.Update(entity);
            dbContext.SaveChanges();
        }
    }
}
