using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakBazar.Entites;

namespace TakBazar.DataBase
{
    public class CbContext : DbContext
    {
        public CbContext() : base("TakBazarConnection")
        {

        }
        public DbSet<Product> products { get; set; }

        public DbSet<Category>  categories { get; set; }
        
    }
}
