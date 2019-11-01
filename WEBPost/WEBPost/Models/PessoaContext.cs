using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WEBPost.Models
{
	public class PessoaContext : DbContext
	{
		public DbSet<Pessoa> ListaDePessoas { get; set; }
	}
}