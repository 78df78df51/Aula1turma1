using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CatalogoCelulares.Model;
using CatalogoCelulares.Controller;
using System.Threading.Tasks;

namespace CellDu
{
	class Program
	{
		//1 - Colocar console app 
		//2 - add referencia
		//3 - add Entity
		//4 - dicionar a model e controller
		static CelularesController celulares = new CelularesController();
		static void Main(string[] args)
		{
			//Definimos uma opcao de menu inicial
			var opcao = int.MinValue;
			while(opcao != 0)
			{
				Console.WriteLine("Escolha um menu");
				Console.WriteLine("1 - Inserir Celular");
				Console.WriteLine("2 - Atualizar Celular");
				Console.WriteLine("3 - Remover Celular");
				Console.WriteLine("4 - Listar Celular");
				Console.WriteLine("0 - sair");

				opcao = int.Parse(Console.ReadLine());
				switch (opcao)
				{
					
					case 1:
						InserirCelular();
						break;
					case 2:
						AtualizarCelular();
					break;
					case 3:
						RemoverCelular();
						break;
					case 4:
						ListarCelular();
						break;
					case 0:
						Console.WriteLine("Saindo do Sistema...");
						break;
					default://Caso o usuario add uma opçao não válida 
						Console.WriteLine("Opção inválida");
						break;
				}
				Console.WriteLine("	Pressione qualquer tecla para continuar");
				Console.ReadKey(true);
				Console.Clear();
			}
		}
		//Inserir
		public static void InserirCelular()
		{
			Console.WriteLine("---Inserir Celular---");
			Console.ReadKey();
			Console.WriteLine("--->Informe a Marca");
			var marca = Console.ReadLine();
			Console.WriteLine("--->Informe o Modelo");
			var modelo = Console.ReadLine();
			Console.WriteLine("--->Informe o Valor");
			var valor = double.Parse(Console.ReadLine());
			var resultado = celulares.InserirCelular(new Celular(){ Marca = marca, Modelo = modelo, Preco = valor});
			if(resultado)
				Console.WriteLine("Celular cadastrado com sucesso!!!");
			else
				Console.WriteLine("Erro ao cadastrar o aparelho!");
		}
		//Atualizar
		public static void AtualizarCelular()
		{
			Console.WriteLine("---Atuazlizar Celular---");
			ListarCelular();
			Console.WriteLine("Informe o Id");
			var celularId = int.Parse(Console.ReadLine());

			var celular = celulares.GetCelulares().FirstOrDefault((x => x.Id == celularId));

			if (celularId == null)
			{
				Console.WriteLine("Id inválido");
				return;
			}

			Console.ReadKey();
			Console.WriteLine("--->Informe a Marca");
		    celular.Marca = Console.ReadLine();
			Console.WriteLine("--->Informe o Modelo");
			celular.Modelo = Console.ReadLine();
			Console.WriteLine("--->Informe o Valor");
			celular.Preco = double.Parse(Console.ReadLine());

			var resultado = celulares.AtuazlizarCelular(celular);

			if (resultado)
				Console.WriteLine("Celular atualizado om sucesso!");
			else
				Console.WriteLine("Erro ao atualizar aparelho");
		}
		//Remover
		public static void RemoverCelular()
		{
			Console.WriteLine("---Remover Celular---");
			ListarCelular();
			Console.WriteLine("Informe o Id para remoção");
			var celularId = int.Parse(Console.ReadLine());

			var resultado = celulares.GetCelulares().FirstOrDefault((x => x.Id == celularId));

			if (resultado == null)
			
				Console.WriteLine("Celular removido com sucesso!");
				
			else
				Console.WriteLine("Erro ao remover aparelho");
			

		
		}
		//Listar
		public static void ListarCelular()
		{
			celulares.GetCelulares().ToList<Celular>().ForEach(x => Console.WriteLine($"Id: {x.Id} Marca: {x.Marca} Modelo: " +
			$"{x.Modelo} Valor {x.Preco}"));
		}
	}
}
