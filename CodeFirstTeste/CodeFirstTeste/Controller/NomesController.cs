using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstTeste.Model;
namespace CodeFirstTeste.Controller
{
	public class NomesController
	{
		NomeContextDB contextDB = new NomeContextDB();


		public
			IQueryable // Aqui temos nossa primeira Interface com a classe
					   // IQueryable essa classe contem varioas funcionalidades
					   // prontas para usar igual ao banco de dados como os selects
			<NomePessoal> //Definimos o tipo que ira retornar 
			GetPessoas() // Damos um nome ao nosso metodo
		{
			return contextDB.ListaDePessoa;//retornamos nossa lista de pessoas
		}

		/// <summary>
		/// Metodo para adicionar Pessoa no banco de dados
		/// </summary>
		/// <param name="item">Item Pessoa</param>
		public void AddPessoa(NomePessoal item)
		{
			contextDB //Nosso banco de dados 
				.ListaDePessoa //nossa tabela Pessoa
				.Add(item); //Adicionamos o item

			contextDB.SaveChanges(); //Salvamos no banco
		}
	}
}
