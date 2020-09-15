using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using PagedList;
using PagedList.Mvc;
namespace Product.Data
{
    public class ProductDataRepository : IProductDataRepository
    {

        public int Add(ProductModel model)
        {
            using (var context = new ProductDataContext())
            {
                context.Products.Add(model);
                var rowsAffected = context.SaveChanges();

                return rowsAffected;
            }
        }

        public int Delete(int productID)
        {
            using (var context = new ProductDataContext())
            {

                var product = context.Products.Find(productID);
                context.Products.Remove(product);
                var rowsAffected = context.SaveChanges();

                return rowsAffected;
            }

        }
        public ProductModel Get(int productID)
        {
            using (var context = new ProductDataContext())
            {
                var model = context.Products.Where(c => c.ProductID == productID).FirstOrDefault();
                return model;
            }
        }

        public IEnumerable<ProductModel> GetAll(string searchBy, string search, int? page)
        {
            using (var context = new ProductDataContext())
            {
                dynamic model;

                if (searchBy == "Category")
                {
                    model = context.Products.Include(x => x.Category).Include(y => y.Currency).Include(z => z.Units).
                        Where(p => p.Category.CategoryName.StartsWith(search) || search == null).ToList().ToPagedList(page ?? 1, 5);
                }
                else
                {
                    model = context.Products.Include(x => x.Category).Include(y => y.Currency).Include(z => z.Units).
                        Where(p => p.ProductName.StartsWith(search) || search == null).ToList().ToPagedList(page ?? 1, 5); ;
                }
                return model;
            }

        }

        public int Update(int ProductId, ProductModel model)
        {
            using (var context = new ProductDataContext())
            {

                context.Entry(model).State = EntityState.Modified;
                var rowsAffected = context.SaveChanges();
                return rowsAffected;


            }
        }
    }
}
