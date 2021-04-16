namespace Bookly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateClients : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Clients ON Insert into Clients(ID, Name, DateOfBirth, Type) values(1, 'Hadi Hakim', '1-4-1999', 'Monthly')");
             Sql("SET IDENTITY_INSERT Clients ON Insert into Clients(ID, Name, DateOfBirth, Type) values(2, 'Wajih', '1-2-1990', 'Weekly')");
             Sql("SET IDENTITY_INSERT Clients ON Insert into Clients(ID, Name, DateOfBirth, Type) values(3, 'Talal', '16-4-2000', 'Monthly')");
             Sql("SET IDENTITY_INSERT Clients ON Insert into Clients(ID, Name, DateOfBirth, Type) values(4, 'Samir', '1-4-2003', 'Monthly')");
             Sql("SET IDENTITY_INSERT Clients ON Insert into Clients(ID, Name, DateOfBirth, Type) values(5, 'Jamil', '2-6-1997', 'Dayly')");
        }
    
        
        public override void Down()
        {
        }
    }
}
