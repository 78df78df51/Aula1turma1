using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Controller;
using Entity.Model;

namespace Exec
{
	class Program
	{
		static PessoasController pessoasController = new PessoasController();
		static void Main(string[] args)
		{
			var opcao = "1";
			while (opcao != "0")
			{
				Console.Clear();
				Console.WriteLine("Menu sistema");
				Console.WriteLine("1 - Cadastrar usuário");
				Console.WriteLine("2 - Listar usuários");
				Console.WriteLine("0 - Sair");

			opcao = Console.ReadLine();
				switch (opcao)
				{
					case "1":
						GravarNome();
						break;
					case "2":
						ListaNomes();
						break;
					case "0":
						Console.Clear();
						Console.WriteLine("Saindo... até a próxima ");
						break;
				}
			}
		}
		private static void GravarNome()
		{
			Console.WriteLine("Cadastrar novo usuario no sistema:");
			Console.WriteLine("Informe um nome");
			var nome = Console.ReadLine();
			var gravado = pessoasController.InserirNomes(new NomePessoa()
			{ Nome = nome});
			if (gravado)
				Console.WriteLine("usuario cadastrado com sucesso!");
			else
				Console.WriteLine("Errou, tente novamente!!!!!!!");
			Console.ReadKey();
		}
		private static void ListaNomes()
		{
			pessoasController.RetornaListaDeUsuarios().ForEach(i => Console.WriteLine($"{i.Nome}"));
			Console.ReadKey();
			Console.Clear();
		}
	}
}
