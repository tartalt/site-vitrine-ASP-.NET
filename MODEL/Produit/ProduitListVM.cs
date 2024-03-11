using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Produit
{
    public class ProduitListVM
    {
        public  string Name { get; set; } = string.Empty;  
        public float Prix { get; set; }
        public int Id { get; set; }
        public string Image { get; set; } = string.Empty;
        public int IdCategory { get; set; }
        public string Description { get; set; } = string.Empty;

    }
}
