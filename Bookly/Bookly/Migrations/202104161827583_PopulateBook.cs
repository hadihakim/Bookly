namespace Bookly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBook : DbMigration
    {
        public override void Up()
        {
            //Seeding the Book Table
            
            Sql("SET IDENTITY_INSERT Books ON Insert into Books(ID, Name, Genre, NumberInStock) values(1,'The Queen','Drama',2)");

            
        }
        
        public override void Down()
        {
        }
    }
}
