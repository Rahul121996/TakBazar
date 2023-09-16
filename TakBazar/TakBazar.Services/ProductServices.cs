using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakBazar.DataBase;
using TakBazar.Entites;

namespace TakBazar.Services
{
    public class ProductServices
    {
        public void SaveProduct(Product product)
        {
            using (var context = new CbContext())
            {
                context.products.Add(product);
                context.SaveChanges();
            }
        }

        public List<Product> GetProduct()
        {
            using (var context = new CbContext())
            {
                return context.products.ToList();
            }
        }

        public Product GetProduct(int ID)
        {
            using (var context = new CbContext())
            {
                return context.products.Where(model => model.ID == ID).FirstOrDefault();
            }
        }

        public bool Updateproduct(Product product)
        {
            using (var context = new CbContext())
            {
                context.Entry(product).State = System.Data.Entity.EntityState.Modified;
                int a = context.SaveChanges();
                if (a != 0)
                    return true;
                else
                    return false;
            }
        }

        public bool DeleteCategories(int ID)
        {
            using (var context = new CbContext())
            {
                var product = context.products.Find(ID);
                context.products.Remove(product);
                int a = context.SaveChanges();
                if (a != 0)
                    return true;
                else
                    return false;
            }
        }
    }
}
