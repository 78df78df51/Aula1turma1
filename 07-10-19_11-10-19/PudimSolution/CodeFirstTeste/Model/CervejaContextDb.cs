using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace CodeFirstTeste.Model
{
	public partial class CervejaContextDb : DbContext
	{
		public CervejaContextDb(string conexao)
			: base(conexao)
		{

		}

		public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
		public virtual DbSet<Cerveja> Cervejas { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
		}
	}
}
