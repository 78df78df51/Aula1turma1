namespace WebApiMigration.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApiMigration.Models.MigrationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApiMigration.Models.MigrationContext context)
        {
			context.Proprietarios.AddOrUpdate(p => p.Nome, new Models.Proprietario() 
				{
					Nome ="Daniel",
					DataDeNascimento = DateTime.Parse("03/07/1994"),
					Email="Daniel.Vieira@HBSIS.com"
				});
			context.SaveChanges();

			var usuarioId = context.Proprietarios.FirstOrDefault(p => p.Nome == "Daniel").Id;

			context.Imoveis.AddOrUpdate(p => p.Proprietario, new Models.Imovel()
			{
				CEP = "66690-440",
				Bairro = "Águas-Lindas",
				Complemento = "Px ao posto de saúde",
				Logradouro = "Cj verdejante I",
				Municipio = "Belém",
				Proprietario = $"{ usuarioId }",
				Numero = "21",
			}) ;
			context.SaveChanges();
		}
    }
}
