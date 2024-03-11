using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repos;
using DAL.Entity;
using MODEL.Produit;

namespace BLL
{
    public class ProduitService
    {
        public List<ProduitListVM> Listservices()
        {
            ProduitRepo servicerepo = new ProduitRepo();
            var ls = new List<ProduitListVM>();
            foreach (var item in servicerepo.All())
            {
                ProduitListVM slvm = new ProduitListVM
                {
                    Name = item.Name,
                    Prix = item.Prix,
                    Image = item.Image,
                    Id = item.Id,
                    Description = item.Description,

                };
                ls.Add(slvm);
            }
            return ls;
        }

        public List<ProduitListVM> ListCategory(int id)
        {
            ProduitRepo servicerepo = new ProduitRepo();
            var ls = new List<ProduitListVM>();
            foreach (var item in servicerepo.All())
            {
                if (item.IdCategory == id)
                {
                    ProduitListVM slvm = new ProduitListVM
                    {
                        Name = item.Name,
                        Prix = item.Prix,
                        Image = item.Image,
                        Id = item.Id,
                        Description = item.Description,
                        IdCategory = item.IdCategory,
                    };
                    ls.Add(slvm);
                }
            }
            return ls;
        }
    }

}