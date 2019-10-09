using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstTeste.Model
{
	public class NomeContextDB : DbContext 
	{
		public DbSet<NomePessoal>
		   ListaDePessoa { get; set; } 
	}
}
