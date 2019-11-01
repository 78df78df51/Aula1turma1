namespace WepApiExistente.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicioneiOCampoCPFNoUsuario : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuarios", "CPF", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usuarios", "CPF");
        }
    }
}
