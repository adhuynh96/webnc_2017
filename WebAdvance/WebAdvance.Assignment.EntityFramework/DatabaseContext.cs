using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAdvance.Assignment.Core.Membership;

namespace WebAdvance.Assignment.EntityFramework
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DbContext")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<DatabaseContext, Default.Migrations.Configuration>());
        }
        public DbSet<Tester> Testers { get; set; }
    }
}
