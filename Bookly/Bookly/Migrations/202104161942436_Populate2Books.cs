namespace Bookly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Populate2Books : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Books ON Insert into Books(ID, Name, Genre, NumberInStock) values(2, 'The King', 'Action', 10)");
            Sql("SET IDENTITY_INSERT Books ON Insert into Books(ID, Name, Genre, NumberInStock) values(3, 'Black Hole', 'science', 3)");
            Sql("SET IDENTITY_INSERT Books ON Insert into Books(ID, Name, Genre, NumberInStock) values(4, 'Valves', 'Horror', 3)");
            Sql("SET IDENTITY_INSERT Books ON Insert into Books(ID, Name, Genre, NumberInStock) values(5, 'White House', 'Story', 5)");
        }
        
        public override void Down()
        {
        }
    }
}
