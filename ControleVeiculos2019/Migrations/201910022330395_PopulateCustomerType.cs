namespace ControleVeiculos2019.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomerType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CustomerTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (1, 0, 0, 0)");
            Sql("INSERT INTO CustomerTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (2, 30, 1, 10)");
            Sql("INSERT INTO CustomerTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (3, 90, 3, 15)");
            Sql("INSERT INTO CustomerTypes (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (4, 150, 12, 20)");
        }
        
        public override void Down()
        {
        }
    }
}
