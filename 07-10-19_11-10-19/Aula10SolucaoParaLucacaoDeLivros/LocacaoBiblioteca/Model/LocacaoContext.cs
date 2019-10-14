using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Model
{
	public class LocacaoContext :DbContext
	{
		//setar nos informação no banco
		public DbSet<Livros> ListaDeLivros { get; set; }
		public DbSet<Usuario> ListaDeUsuarios { get; set; }
	}
}
