using Domain;
using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class DalstockDbContext : DbContext
    {
        public DalstockDbContext() : base("DalstockDatabase")
        {
        }
        public DbSet<Item> Items { get; set; }
        public DbSet<Bobbin> Bobbins { get; set; }
        public DbSet<Deposit> Deposits { get; set; }
        public DbSet<Debit> Debits { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Workplace> Workplaces { get; set; }
        public DbSet<BobbinDebit> BobbinDebits { get; set; }
        public DbSet<CableType> CableTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
