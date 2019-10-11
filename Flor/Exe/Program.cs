using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Culture.Controller;
using Culture.Model;

namespace Exe
{
	class Program
	{
		static FloriController floriController = new FloriController();
		static void Main(string[] args)
		{
			var opcao = "1";
			while (opcao != "0")
			{
				Console.Clear();
				Console.WriteLine("Menu sistema");
				Console.WriteLine("1 - Cadastrar Flores");
				Console.WriteLine("2 - Listar Flores");
				Console.WriteLine("3 - Lista Ordenada das minhas Flores");
				Console.WriteLine("4 - Total de Flores");
				Console.WriteLine("0 - Sair");

				opcao = Console.ReadLine();
				switch (opcao)
				{
					case "1":
						GravarFlores();
						break;
					case "2":
						ListaFlores();
						break;
					case "3":
						Ordernar();
						break;
					case "4":
						Total();
						break;
					case "0":
						Console.Clear();
						Console.WriteLine("Saindo... até a próxima ");
						break;
				}
			}
		}
		public static void GravarFlores()
		{
			Console.WriteLine("Cadastrar uma nova flor no sistema:");
			Console.WriteLine("Informe o nome de uma flor");
			var nome = Console.ReadLine();
			Console.WriteLine("Informe a quantidade de flores:");
			var quant = int.Parse(Console.ReadLine());
			var gravado = floriController.InserirFlores(new Flores()
			{ Nome = nome, Quantidade = quant });
			if (gravado)
				Console.WriteLine("Flor cadastrada com sucesso!");
			else
				Console.WriteLine("Errou, tente novamente!!!!!!!");
			Console.ReadKey();
		}
		public static void ListaFlores()
		{
			floriController.RetornaListaDeFlores().ForEach(i => Console.WriteLine($"Flores:{i.Nome} Quantidade: {i.Quantidade}"));
			Console.ReadKey();
			Console.Clear();
		}
		public static void Ordernar()
		{
			floriController.RetornaListaDeFlores().OrderByDescending(p => p.Quantidade)
				.ToList<Flores>().ForEach(p => Console.WriteLine($"Nome da flor:{p.Nome}   Quantidade desta flor:{p.Quantidade}"));
			Console.ReadKey();
		}
		public static void Total()
		{
			var total = floriController.RetornaListaDeFlores().Sum(x => x.Quantidade);
			Console.WriteLine($"Total de Flores no sistema:{total}");
			Console.ReadKey();
		}
	}
}

