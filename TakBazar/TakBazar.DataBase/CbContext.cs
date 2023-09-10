using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TakBazar.Entites;

namespace TakBazar.DataBase
{
    public class CbContext : DbContext,IDisposable
    {
        public CbContext() : base("name=TakBazarConnection")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }
        public DbSet<Product> products { get; set; }

        public DbSet<Category>  categories { get; set; }
        
    }
}
