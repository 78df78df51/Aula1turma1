using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Model
{
	public class LocacaoContext
	{
		public int IdContadorLivros  { get; set; } =  1;
		public int IdContadorUsuarios { get; set; } = 1;
		public LocacaoContext()
		{
			ListaDeLivros = new List<Livros>();
			//criamos uma lista de usuarios em memoria
			ListaDeUsuarios = new List<Usuario>();
			//Adicionamos os livros
			ListaDeLivros.Add(new Livros()
			{
				Nome = "Meu Primeiro livro",
				Id = IdContadorLivros++,

			});
			ListaDeLivros.Add(new Livros()
			{
				Nome = "Meu Segundo livro",
				Id = IdContadorLivros++,

			});
			ListaDeLivros.Add(new Livros()
			{
				Id = IdContadorLivros++,
				Nome = "Pokemóm"
			});
			//Adicionamos o usuario
			ListaDeUsuarios.Add(new Usuario(){
				Id = IdContadorUsuarios++,
				Login = "admin",
				Senha = "admin"
			});
			ListaDeUsuarios.Add(new Usuario()
			{
				Id = IdContadorUsuarios++,
				Login = "admin",
				Senha = "123"
			});

		}
		public List<Livros> ListaDeLivros { get; set; }

		public List<Usuario> ListaDeUsuarios { get; set; }
	}
}
