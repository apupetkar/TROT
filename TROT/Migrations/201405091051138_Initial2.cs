namespace TROT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Agents", "Country", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Agents", "Country");
        }
    }
}
