using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntityClass.Model;
using System.Threading.Tasks;

namespace EntityClass.Controller
{
	public class PessoaController
	{	//Realizo minha conexão com o banco de dados
		EntityContextDB contextDB = new EntityContextDB();

		public IQueryable/*Aqui temos nossa primeira Intarface com a classe
						 IQueryable essa classe contem varias funcionalidades 
						 prontas para usar igual ao banco de dados como os selects*/
			<Pessoa> //definimos o tipo que irar retornar
			GetPessoas() //Damos um nome ao nosso método
		{
			return contextDB.ListaDePessoas; //Retornamos nossa lista de pessoas
		}
		
		/// <summary>
		/// metodo adicionar Pessoa no banco de daddos
		/// </summary>
		/// <param name="item">Item Pessoa</param>		
		public void AddPessoa(Pessoa item)
		{
			contextDB.//Nosso banco de dados
				ListaDePessoas.//nossa tabela Pessoa
				Add(item); //Adicionamos o item
			contextDB.SaveChanges(); //Salvamos no banco
		}
	}
}
