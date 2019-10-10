using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
	public class PessoaContextDB : DbContext
	{
		public DbSet<NomePessoa> NomePessoas { get; set; }
	}
}
