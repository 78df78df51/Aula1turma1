using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Model;

namespace Entity.Controller
{
	public class PessoasController
	{
		private PessoaContextDB contextDB = new PessoaContextDB();
		public bool InserirNomes(NomePessoa i)
		{
			if (string.IsNullOrWhiteSpace(i.Nome))
				return false;
			contextDB.NomePessoas.Add(i);
			contextDB.SaveChanges();
			return true;
		}
		public List<NomePessoa> RetornaListaDeUsuarios() 
		{
			return contextDB.NomePessoas.ToList<NomePessoa>();
		}
	}
}
