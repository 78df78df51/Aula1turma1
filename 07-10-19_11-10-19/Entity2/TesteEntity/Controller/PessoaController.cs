using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteEntity.Model;

namespace TesteEntity.Controller
{
	public class PessoaController
	{
		EntityContextDB contextDB = new EntityContextDB();
		public IQueryable<Pessoa>GetPessoas()
		{
			return contextDB.ListaDePessoa;
		}
		public void AddPessoa(Pessoa item)
		{
			contextDB.ListaDePessoa.Add(item);
			contextDB.SaveChanges();
		}
	}
}
