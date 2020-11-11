namespace EF优化.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Title = c.String(),
                        Descr = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        BookTypeId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BookTypes", t => t.BookTypeId)
                .Index(t => t.BookTypeId);
            
            CreateTable(
                "dbo.BookTypes",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "BookTypeId", "dbo.BookTypes");
            DropIndex("dbo.Books", new[] { "BookTypeId" });
            DropTable("dbo.BookTypes");
            DropTable("dbo.Books");
        }
    }
}
