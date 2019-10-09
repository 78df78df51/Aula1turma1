using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteEntity.Controller;
using TesteEntity.Model;

namespace AcessandoOEntity
{
	class Program
	{
		static PessoaController pessoa = new PessoaController();

		static void Main(string[] args)
		{
			var escolha = int.MinValue;
			while (escolha != 0)
			{
				Console.Clear();
				Console.WriteLine("Menu sistema");
				Console.WriteLine("1 - Listar usuários");
				Console.WriteLine("2 - Cadrastrar usuário");
				Console.WriteLine("0 - Sair");
				var opcao = Console.ReadLine();
				Console.Clear();
				switch (opcao)
				{
					case "1":
						pessoa.GetPessoas().ToList<Pessoa>()
							.ForEach(x => Console.WriteLine($"nome:{x.Nome}, idade: {x.Idade}"));

						Console.WriteLine("Aperte qualquer tecla para continuar...");
						Console.ReadKey();
						Console.Clear();
						break;
					case "2":
						Console.WriteLine("Digite um nome para adicionar a lista:");
						pessoa.AddPessoa(
				   new Pessoa()
				   {
					   Nome = Console.ReadLine(),

				   });

						Console.WriteLine("Aperte qualquer tecla para continuar...");
						Console.ReadKey();
						Console.Clear();
						break;
					case "0":
						Console.WriteLine("Saindo... até a próxima ");
						Console.ReadKey();
						break;
				}
			}
		}
	}
}
