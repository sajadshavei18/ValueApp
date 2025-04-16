using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ValueApp.Entitis;

namespace ValueApp.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(
                "Data Source=.;Initial Catalog=ValueApp_DB;TrustServerCertificate = True;MultipleActiveResultSets = True;Integrated Security = SSPI;");
        }

        public Context()
        {
            Database.EnsureCreated();
        }

        public DbSet<Value> values { get; set; }

    }
}
