using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass.Model
{
	public class EntityContextDB : 
		DbContext /*DbContext classe que esta pronta e contem todos os processos de conexão
		com o banco de dados.*/
	{		
			public DbSet/*palavra reservada para o Entity que indicaque vamos 
			definir uma tabela do nosso banco de dados*/
			<Pessoa> /*Especificamos a classe que será referência para uma tabela no 
			banco de dados, ela vai ao banco com o nome que definimos em nossa classe*/
			ListaDePessoas { get; set; }/*neste parte liberamos nossa tabela para acessar*/
	}
}
