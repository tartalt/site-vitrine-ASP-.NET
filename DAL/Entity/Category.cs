using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    [Table("T_Category")]
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Image { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        
    }
}
