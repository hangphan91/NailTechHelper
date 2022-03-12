using Microsoft.EntityFrameworkCore;
using NailTechHelper.Data.Definitions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NailTechHelper.Data.Persistence.DataAccessors
{
    public class DataContext : DbContext
    {
        public DataContext()
        {

        }
        public DbSet<BeautySalonBusiness> BeautySalonBussinesses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=NailTechHelper");
        }
    }
}
