namespace NinjaDomain.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDOB : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ninjas", "DOB", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ninjas", "DOB");
        }
    }
}
