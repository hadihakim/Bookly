﻿namespace Bookly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotateToBook : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Books", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Books", "Name", c => c.String());
        }
    }
}
