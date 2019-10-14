using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
	class Program
	{
		static List<string> Nome = new List<string>();
		static void Main(string[] args)
		{
			Menu();
			Console.Clear();
		}
		public static void Menu()
		{
			Console.WriteLine("Escolha uma opção: ");
			Console.WriteLine("1 - Listar Nomes");
			Console.WriteLine("2 - Adicionar Nomes");
			Console.WriteLine("0 - Sair");
			var opcao = int.MinValue;
			while (opcao != 0)
			{
				opcao = int.Parse(Console.ReadLine());
				switch (opcao)
				{
					case 1:
						{
							ListarNomes(); Menu();
						}
						break;
					case 2:
						{
							AdicionarNomes(); Menu();

						}
						break;
					case 0:
						{
							Console.WriteLine("Saindo...");
						}
						break;
				}
				

			}
		}
		public static void ListarNomes()
		{
			if (Nome.Count == 0)
			{
				Console.Clear();
				Nome.Add("João");
				Nome.Add("Marcos");
				Nome.Add("Lucas");
				Nome.Add("André");
				Nome.Add("Carlos");
				Nome.Add("Marcio");
				Nome.Add("Jorge");
				Nome.Add("Joas");
				Nome.Add("Jonias");
				Nome.Add("Maria");
			}
			Nome.OrderBy(i => i).ToList<string>().ForEach(i => Console.WriteLine(i));
			
			Console.ReadKey();
			Console.Clear();
		}
		public static void AdicionarNomes()			
		{
			Console.Clear();
			Console.WriteLine("Informe um novo nome para adicionar a listar");
			var novoNome = Console.ReadLine();
			Nome.Add(novoNome);
		}

	}
}
