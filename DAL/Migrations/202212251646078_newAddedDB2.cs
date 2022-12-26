﻿namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newAddedDB2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Specialists", "Verified", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Specialists", "Verified");
        }
    }
}
