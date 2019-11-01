namespace SistemaPessoa.Models
{
	using System;
	using System.Data.Entity;
	using System.Linq;

	public class PessoaContext : DbContext
	{
		// Your context has been configured to use a 'PessoaContext' connection string from your application's 
		// configuration file (App.config or Web.config). By default, this connection string targets the 
		// 'SistemaPessoa.Models.PessoaContext' database on your LocalDb instance. 
		// 
		// If you wish to target a different database and/or database provider, modify the 'PessoaContext' 
		// connection string in the application configuration file.
		public PessoaContext()
			: base("name=PessoaContext")
		{
		}


		 public virtual DbSet<Pessoa> Pessoas { get; set; }
	}
}