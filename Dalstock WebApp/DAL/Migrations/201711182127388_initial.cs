namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        ItemId = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        Amount = c.Int(nullable: false),
                        StartAmount = c.Int(),
                        EndAmount = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.ItemId);
            
            CreateTable(
                "dbo.Debits",
                c => new
                    {
                        DebitId = c.Int(nullable: false, identity: true),
                        Amount = c.Int(nullable: false),
                        dateTime = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.DebitId);
            
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        StaffId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(unicode: false),
                        LastName = c.String(unicode: false),
                        Debit_DebitId = c.Int(),
                        Deposit_DepositId = c.Int(),
                    })
                .PrimaryKey(t => t.StaffId)
                .ForeignKey("dbo.Debits", t => t.Debit_DebitId)
                .ForeignKey("dbo.Deposits", t => t.Deposit_DepositId)
                .Index(t => t.Debit_DebitId)
                .Index(t => t.Deposit_DepositId);
            
            CreateTable(
                "dbo.Workplaces",
                c => new
                    {
                        WorkplaceId = c.Int(nullable: false, identity: true),
                        Address = c.String(unicode: false),
                        Zip = c.Int(nullable: false),
                        City = c.String(unicode: false),
                        Debit_DebitId = c.Int(),
                    })
                .PrimaryKey(t => t.WorkplaceId)
                .ForeignKey("dbo.Debits", t => t.Debit_DebitId)
                .Index(t => t.Debit_DebitId);
            
            CreateTable(
                "dbo.Deposits",
                c => new
                    {
                        DepositId = c.Int(nullable: false, identity: true),
                        Amount = c.Int(nullable: false),
                        dateTime = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.DepositId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Staffs", "Deposit_DepositId", "dbo.Deposits");
            DropForeignKey("dbo.Workplaces", "Debit_DebitId", "dbo.Debits");
            DropForeignKey("dbo.Staffs", "Debit_DebitId", "dbo.Debits");
            DropIndex("dbo.Workplaces", new[] { "Debit_DebitId" });
            DropIndex("dbo.Staffs", new[] { "Deposit_DepositId" });
            DropIndex("dbo.Staffs", new[] { "Debit_DebitId" });
            DropTable("dbo.Deposits");
            DropTable("dbo.Workplaces");
            DropTable("dbo.Staffs");
            DropTable("dbo.Debits");
            DropTable("dbo.Items");
        }
    }
}
