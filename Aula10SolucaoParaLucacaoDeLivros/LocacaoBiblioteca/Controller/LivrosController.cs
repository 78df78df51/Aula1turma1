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
		private LocacaoContext contextDB = new LocacaoContext();
		/// <summary>
		/// Metoo que adiciona o livro em nossa lista já "instanciado" criada dentro do construtor
		/// </summary>
		/// <param name="parametroLivro">informações do livro que vamos adicionar</param>
		/*public void AdicionarLivro(Livros parametroLivro)
		{
			parametroLivro.Id = contextDB.IdContadorLivros++;
			contextDB.ListaDeLivros.Add(parametroLivro);
		}
		public List<Livros> RetornaListaDeLivros()
		{
			return contextDB.ListaDeLivros.Where(x => x.Ativo).ToList<Livros>();
		}
		public void RemoverLivroPorID (int identificadorLivroID)
		{
			var livro = contextDB.ListaDeLivros.FirstOrDefault(x => x.Id == identificadorLivroID);
			if (livro != null)
				livro.Ativo = false;			
		}*/
		//Listar	
		public IQueryable<Livros> GetLivros()
		{
			return contextDB.ListaDeLivros.Where
				(x => x.Ativo == true);
		}
		//Inserir
		public bool InserirLivros(Livros i)
		{
			if (string.IsNullOrWhiteSpace(i.Nome))
				return false;
			contextDB.ListaDeLivros.Add(i);
			return true;
		}
		//Atualizar
		public bool AtualizarLivros(Livros i)
		{
			var livros = contextDB.ListaDeLivros.FirstOrDefault
				(x => x.Id == i.Id);
			if (livros == null)
				return false;
			else 
			{
				i.DataAlteracao = DateTime.Now;
			}
			contextDB.SaveChanges();
			return true;
		}
		//Remover
		public bool RemoverLivros (int id)
		{
			var livros = contextDB.ListaDeLivros.FirstOrDefault
			(x => x.Id == id);
			if (livros == null)
				return false;

			livros.Ativo = false;
			contextDB.SaveChanges();
			return true;
		}
	}
}
