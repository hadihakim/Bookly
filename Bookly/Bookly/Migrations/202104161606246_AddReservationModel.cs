namespace Bookly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReservationModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        ReservationID = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        BookID = c.Int(nullable: false),
                        CustomerID = c.Int(nullable: false),
                        Client_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ReservationID)
                .ForeignKey("dbo.Books", t => t.BookID, cascadeDelete: true)
                .ForeignKey("dbo.Clients", t => t.Client_ID)
                .Index(t => t.BookID)
                .Index(t => t.Client_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "Client_ID", "dbo.Clients");
            DropForeignKey("dbo.Reservations", "BookID", "dbo.Books");
            DropIndex("dbo.Reservations", new[] { "Client_ID" });
            DropIndex("dbo.Reservations", new[] { "BookID" });
            DropTable("dbo.Reservations");
        }
    }
}
