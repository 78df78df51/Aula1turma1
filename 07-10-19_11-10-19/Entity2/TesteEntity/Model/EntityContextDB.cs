using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteEntity.Model
{
	public class EntityContextDB : DbContext
	{
		public DbSet<Pessoa> ListaDePessoa { get; set; }
	}
}
