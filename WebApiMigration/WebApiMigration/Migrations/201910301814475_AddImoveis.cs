namespace WebApiMigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddImoveis : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Imovels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CEP = c.String(),
                        Logradouro = c.String(),
                        Bairro = c.String(),
                        Municipio = c.String(),
                        Numero = c.String(),
                        Complemento = c.String(),
                        Proprietario = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Imovels");
        }
    }
}
