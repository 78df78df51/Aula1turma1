using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{

    public class LivrosController
    {
		private int IdContador = 1;
        public LivrosController()
        {
            ListaDeLivros = new List<Livros>();

            ListaDeLivros.Add(new Livros()
            {
                Nome = "Meu Primeiro livro"
            });
            ListaDeLivros.Add(new Livros()
            {
                Nome = "Meu Segundo livro"
            });
        }
        private List<Livros> ListaDeLivros { get; set; }
		/// <summary>
		/// Metoo que adiciona o livro em nossa lista já "instanciado" criada dentro do construtor
		/// </summary>
		/// <param name="parametroLivro">informações do livro que vamos adicionar</param>
		public void AdicionarLivro(Livros parametroLivro)
		{
			parametroLivro.Id = IdContador++;
			ListaDeLivros.Add(parametroLivro);

		}
		public List<Livros> RetornaListaDeLivros()
		{
			return ListaDeLivros;  
		}
    }
}
