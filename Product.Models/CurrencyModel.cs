using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("Currency")]
    public class CurrencyModel
    {
        [Key]
        public int CurrencyID { get; set; }
        [Display(Name = "Currency")]
        [Required]
        public string CurrencyName { get; set; }
        public ICollection<ProductModel> Products { get; set; }
    }
}
