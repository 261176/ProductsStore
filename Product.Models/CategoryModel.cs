using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    [Table("Category")]
    public class CategoryModel
    {[Key]
        public int CategoryID { get; set; }
        [Display(Name = "Category")]
        [Required]
        public string CategoryName { get; set; }
        public ICollection<ProductModel> Products { get; set; }

    }
}
