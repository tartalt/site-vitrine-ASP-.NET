using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    [Table("T_Produit")]
    public class Produit
    {
        [Key]
        public int Id { get; set; }
        public string Image { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public int IdCategory { get; set; }

        public float Prix { get; set; }
    }
}
