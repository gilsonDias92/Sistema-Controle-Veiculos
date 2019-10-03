namespace ControleVeiculos2019.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomers : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers VALUES ('Joao da Silva', 0, 1);");
            Sql("INSERT INTO Customers VALUES ('Maria Souza', 1, 3);");
            Sql("INSERT INTO Customers VALUES ('Jonathan Gomes', 1, 2);");
            Sql("INSERT INTO Customers VALUES ('Fabio Oliveira', 1, 4);");
            Sql("INSERT INTO Customers VALUES ('Eduardo Pires', 0, 2);");
            Sql("INSERT INTO Customers VALUES ('Joana Maria', 1, 1);");
            Sql("INSERT INTO Customers VALUES ('Marcos Junior', 0, 4);");
        }
        
        public override void Down()
        {
        }
    }
}
