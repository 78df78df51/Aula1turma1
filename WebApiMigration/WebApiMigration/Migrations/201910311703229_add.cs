namespace WebApiMigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Proprietarios", "DataDeNascimento", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Proprietarios", "DataDeNascimento", c => c.String());
        }
    }
}
