namespace EfDemo160418_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addedeyes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Djurs", "AntalÖgon", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Djurs", "AntalÖgon");
        }
    }
}
