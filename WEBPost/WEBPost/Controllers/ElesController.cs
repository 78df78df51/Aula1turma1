using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WEBPost.Models;

namespace WEBPost.Controllers
{
	
    public class ElesController : ApiController
    {
		public PessoaContext contextDB = new PessoaContext();
		List<Pessoa> ListaDePessoas = new List<Pessoa>()
		{
			new Pessoa(){Nome = "Felipe", Idade = 20},
			new Pessoa(){Nome = "Marcos", Idade = 22},
			new Pessoa(){Nome = "Luis",   Idade = 21},
			new Pessoa(){Nome = "Pedro",   Idade = 29},
			new Pessoa(){Nome = "Anna",   Idade = 41},
			new Pessoa(){Nome = "Tio",   Idade = 40},
			new Pessoa(){Nome = "Marcelo",   Idade = 10},
			new Pessoa(){Nome = "Laís",   Idade = 28},
			new Pessoa(){Nome = "Tais",   Idade = 24},
			new Pessoa(){Nome = "Brenda",   Idade = 19},
			new Pessoa(){Nome = "Geovana",   Idade = 29},
			new Pessoa(){Nome = "Fabio",   Idade = 31},
			new Pessoa(){Nome = "Carlos",   Idade = 24},
		 };
		public List<Pessoa> Get()
		{
			List<Pessoa> pessoasQuery = ListaDePessoas.OrderByDescending(p => p.Idade).ToList();
			return pessoasQuery;
		}
		public List<Pessoa> Post(Pessoa pessoa)
		{
			ListaDePessoas.Add(pessoa);
			return ListaDePessoas;
		}
	}
}
