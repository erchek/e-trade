using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETradeSite.Entities.DbEntities;

namespace ETradeSite.DataAccess.EntityFramework
{
    public class DatabaseContext : DbContext
    {
        public DbSet<EProducts> EProducts { get; set; }
        public DbSet<EOrders> EOrders { get; set; }
        public DbSet<EOrdersDetail> EOrdersDetail { get; set; }
        public DbSet<EUser> EUsers { get; set; }
        public DbSet<ECategories> ECategories { get; set; }

        public DatabaseContext()
        {
            Database.SetInitializer(new MyInitializer());
        }
    }
}
