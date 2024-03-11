using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entity;
using DAL.Repos;
using MODEL.Produit;
using MODEL.Client;
using MODEL.Category;

namespace BLL
{

    public class CategoryService
    {
      
        public List<CategoryListVM> List()
        {
            CategoryRepo ctgr = new CategoryRepo();
            var ls = new List<CategoryListVM>();
            foreach (var item in ctgr.All())
            {
                var srvc = ctgr.Read(item.Id);

                CategoryListVM categoryListVM = new CategoryListVM
                {
                    Id = item.Id,
                    Name = srvc.Name,
                    Image = srvc.Image
                };
                ls.Add(categoryListVM);
            }
            return ls;
        }
        
    }
}
