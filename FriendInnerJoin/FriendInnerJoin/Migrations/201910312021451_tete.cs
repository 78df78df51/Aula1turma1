namespace FriendInnerJoin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tete : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Usuarios", "CPF");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Usuarios", "CPF", c => c.String());
        }
    }
}
