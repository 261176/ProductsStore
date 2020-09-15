using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("Products")]
    public class ProductModel
    {
        [Key]
        public int ProductID { get; set; }
        [Required]

        public string ProductName { get; set; }
        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        [ForeignKey("Currency")]
        public int CurrencyID { get; set; }
        [ForeignKey("Units")]
        public int UnitID { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter Valid price in number")]
        public decimal Price { get; set; }

        public virtual CategoryModel Category { get; set; }
        public virtual CurrencyModel Currency { get; set; }
        public virtual UnitModel Units { get; set; }





    }
}
