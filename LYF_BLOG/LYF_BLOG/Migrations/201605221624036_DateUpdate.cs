namespace LYF_BLOG.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateUpdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "CreateDate", c => c.DateTime());
            AlterColumn("dbo.AspNetUsers", "LastActivityDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "LastActivityDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.AspNetUsers", "CreateDate", c => c.DateTime(nullable: false));
        }
    }
}
