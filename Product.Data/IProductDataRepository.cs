using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Product.Data
{
    public interface IProductDataRepository
    {
        int Add(ProductModel model);
        int Update(int productID, ProductModel model);
        int Delete(int productID);
        IEnumerable<ProductModel> GetAll(string searchBy, string search, int? page);
        ProductModel Get(int productID);
       
    }
}
