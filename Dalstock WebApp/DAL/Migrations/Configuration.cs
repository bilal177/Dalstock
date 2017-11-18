namespace DAL.Migrations
{
    using Domain;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DalstockDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            SetSqlGenerator("MySql.Data.MySqlClient", new MySql.Data.Entity.MySqlMigrationSqlGenerator());
        }

        protected override void Seed(DalstockDbContext context)
        {
            Item item = new Item
            {
                ItemId = 2016768,
                Name = "test"
            };
            context.Items.Add(item);
            context.SaveChanges();
            //base.Seed(context);
        }
    }
}
