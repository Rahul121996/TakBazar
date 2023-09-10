using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakBazar.DataBase;
using TakBazar.Entites;

namespace TakBazar.Services
{
    public class CategoriesServices
    {
        public void SaveCategory(Category category)
        {
            using(var context = new CbContext())
            {
                context.categories.Add(category);
                context.SaveChanges();
            }
        }

        public List<Category> GetCategories()
        {
            using (var context = new CbContext())
            {
                return context.categories.ToList();
            }
        }

        public Category GetCategories(int ID)
        {
            using (var context = new CbContext())
            {
                return context.categories.Where(model=>model.ID == ID).FirstOrDefault();
            }
        }

        public bool UpdateCategories(Category category)
        {
            using (var context = new CbContext())
            {
                context.Entry(category).State = System.Data.Entity.EntityState.Modified;
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
                var category = context.categories.Find(ID);
                context.categories.Remove(category);
                int a = context.SaveChanges();
                if (a != 0)
                    return true;
                else
                    return false;
            }
        }
    }
}
