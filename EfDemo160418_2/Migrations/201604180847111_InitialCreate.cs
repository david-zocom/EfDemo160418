namespace EfDemo160418_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Djurs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Namn = c.String(),
                        AntalBen = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Frenemies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Relation = c.String(),
                        Djur1_Id = c.Int(),
                        Djur2_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Djurs", t => t.Djur1_Id)
                .ForeignKey("dbo.Djurs", t => t.Djur2_Id)
                .Index(t => t.Djur1_Id)
                .Index(t => t.Djur2_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Frenemies", "Djur2_Id", "dbo.Djurs");
            DropForeignKey("dbo.Frenemies", "Djur1_Id", "dbo.Djurs");
            DropIndex("dbo.Frenemies", new[] { "Djur2_Id" });
            DropIndex("dbo.Frenemies", new[] { "Djur1_Id" });
            DropTable("dbo.Frenemies");
            DropTable("dbo.Djurs");
        }
    }
}
