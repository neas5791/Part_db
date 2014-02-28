namespace Part_db.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Parts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PartNumber = c.String(),
                        Description = c.String(),
                        PartType_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Types", t => t.PartType_ID)
                .Index(t => t.PartType_ID);
            
            CreateTable(
                "dbo.Types",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TypeCode = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Parts", "PartType_ID", "dbo.Types");
            DropIndex("dbo.Parts", new[] { "PartType_ID" });
            DropTable("dbo.Types");
            DropTable("dbo.Parts");
        }
    }
}
