using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCelulares.Model
{
	public class CelularesContextDB : DbContext
	{
		//Definindo nossa primeira tabela no banco de dados
		public DbSet<Usuario> Usuarios { get; set; }
		//Definindo nossa tabela de celulares
		public DbSet<Celular> Celulares { get; set; }
	}
}
