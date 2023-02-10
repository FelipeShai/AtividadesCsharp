using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesCurso
{
    internal class Migration
    {
        public partial class AddOrdersTable : DbMigration
        {
            public override void Up()
            {
                CreateTable(
                    "dbo.Orders",
                    c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        OrderDate = c.DateTime(nullable: false),
                        TotalPrice = c.Decimal(nullable: false, precision: 10, scale: 2),
                    })
                    .PrimaryKey(t => t.Id)
                    .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                    .Index(t => t.CustomerId);
            }

            public override void Down()
            {
                DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
                DropIndex("dbo.Orders", new[] { "CustomerId" });
                DropTable("dbo.Orders");
            }
        }
    }
}
