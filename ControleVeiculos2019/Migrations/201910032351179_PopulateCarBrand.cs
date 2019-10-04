namespace ControleVeiculos2019.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCarBrand : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CARBRAND VALUES ('Volkswagen', 'VW')");
            Sql("INSERT INTO CARBRAND VALUES ('Chevrolet', 'GM')");
            Sql("INSERT INTO CARBRAND VALUES ('Fiat', 'FIAT')");
            Sql("INSERT INTO CARBRAND VALUES ('Ford', 'FORD')");
            Sql("INSERT INTO CARBRAND VALUES ('Honda', 'HONDA')");
            Sql("INSERT INTO CARBRAND VALUES ('Toyota', 'TOY')");
            Sql("INSERT INTO CARBRAND VALUES ('Renault', 'REN')");
            Sql("INSERT INTO CARBRAND VALUES ('Cherry', 'CHR')");
            Sql("INSERT INTO CARBRAND VALUES ('BMW', 'BMW')");
            Sql("INSERT INTO CARBRAND VALUES ('Mercedes Benz', 'MB')");
            Sql("INSERT INTO CARBRAND VALUES ('Jeep', 'JP')");
        }
        
        public override void Down()
        {
        }
    }
}
