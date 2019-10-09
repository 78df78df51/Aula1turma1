using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoCelulares.Model;


namespace CatalogoCelulares.Controller
{
	/*
	  1 - usar nossa pasta model
	  2 - Criar uma instancia  nova da nossa Context
	 */
	public class CelularesController
	{
		CelularesContextDB contextDB = new CelularesContextDB();
		//Filtragem
		/// <summary>
		/// Metodo que retorna nossa lista de celulares somentes os celures ativos
		/// </summary>
		/// <returns>QueryList de celulares filtrado por ativo</returns>
		public IQueryable<Celular> GetCelulares()
		{
			return contextDB //Nosso acesso ao banco de dados
				.Celulares //Nossa tabela do banco de dados
				.Where //Indicamos que vamos fazer um filtro 
				(x => x.Ativo == true); //As condições do filtro
		}
		//Atualização
		/// <summary>
		/// Metodo que atualiza um registro valido do nosso sistema
		/// </summary>
		/// <param name="i">i que vamos atualizar</param>
		/// <returns>Retorna o verdadeiro caso i existe</returns>
		public bool AtuazlizarCelular(Celular i)
		{
			var celular //Definimos uma variavel para o celular
				= contextDB //Usamos o banco de dados
				.Celulares. // Nossa tabela que tem os celulares
				FirstOrDefault //Buscamos em nossa tabela o celular
				(x => x.Id == i.Id); //Regra que realiza a busca
			if (celular == null) //Verificamos se celular é igual a null
				return false;//Caso não tenha encontrado retornamos falso
			else
			{
				i.DataAlteracao = DateTime.Now; //Atualizamos a data de alteração do nosso celular
			}
			contextDB.SaveChanges();
			return true; //Retornamos que foi atualizado

		}
		//Inserção
		/// <summary>
		/// Metodo que valida e insera os registros dentro do sistema
		/// </summary>
		/// <param name="i">Nosso novo celular</param>
		/// <returns>Retorna verdadeiro para um i valido</returns>
		public bool InserirCelular(Celular i)
		{
			if (string.//Nosso tipo que contem varios metodos prontos para string
				IsNullOrWhiteSpace //Metodo que identifica espaços em branco ou valor null 
				(i.Marca)) //Nosso campo que vamos validar
				return false;
			if (string.IsNullOrWhiteSpace(i.Modelo)) return false;
			if (i.Preco <= 0)//Verificamos se o valor recebido é maior que 0
				return false; //Caso não, ele ja retorna para fora do metodo
			contextDB.Celulares.Add(i);
			contextDB.SaveChanges();
			return true;
		}
		//Remoção
		/// <summary>
		/// Metodo utilizado para apenas desativar o i dentro do nosso sistema
		/// </summary>
		/// <param name="Id">Id que vamos desativar</param>
		/// <returns>Retorna verdadeiro</returns>
		public bool RemoverCelular(int Id)
		{
			var celular = contextDB.Celulares.FirstOrDefault
				(x => x.Id == Id);
			if (celular == null)
				return false;
			celular.Ativo = false;
			contextDB.SaveChanges();
			return true;
		}
	}
}
