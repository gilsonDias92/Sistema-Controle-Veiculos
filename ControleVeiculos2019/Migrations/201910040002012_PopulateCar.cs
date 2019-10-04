namespace ControleVeiculos2019.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCar : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CAR (ModelName, CarBrandId, Year, Price, Description, DateAdded) VALUES ('Gol G6 1.0', 1, 2015, 23900, 'Opcionais: Ar condicionado', GETDATE())");
            Sql("INSERT INTO CAR (ModelName, CarBrandId, Year, Price, Description, DateAdded) VALUES ('Saveiro G5 1.6', 1, 2011, 22500, 'Básica', '01/09/2019')");
            Sql("INSERT INTO CAR (ModelName, CarBrandId, Year, Price, Description, DateAdded) VALUES ('Sandero Expression 1.0', 7, 2011, 21500, 'Opcionais: Direção hidráulica, Vidro elétrico, Trava elétrica', '06/09/2019')");
            Sql("INSERT INTO CAR (ModelName, CarBrandId, Year, Price, Description, DateAdded) VALUES ('Civic EXS 1.6', 5, 2003, 17900, 'Opcionais: Completo, automático', GETDATE())");
            

        }
        
        public override void Down()
        {
        }
    }
}
