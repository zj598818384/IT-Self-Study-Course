namespace EF优化.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeBookType_CreateTime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BookTypes", "CreateTime", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.BookTypes", "CreateTime");
        }
    }
}
