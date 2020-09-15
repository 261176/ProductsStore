using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("Units")]
    public class UnitModel
    {
        [Key]
        public int UnitID { get; set; }
        [Display(Name = "Unit")]
        [Required]
        public string UnitName { get; set; }
        public ICollection<ProductModel> Products { get; set; }

    }
}
