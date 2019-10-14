using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColecaoBikes.Model;
using ColecaoBikes.Controller;

namespace Exe
{
	class Program
	{
		static BikeController context = new BikeController();
		static void Main(string[] args)
		{
			var opcao = "1";
			while (opcao != "0")
			{
				Console.Clear();
				Console.WriteLine("Menu sistema");
				Console.WriteLine("1 - Inserir Bicicletas");
				Console.WriteLine("2 - Listar Bicicletas");
				Console.WriteLine("3 - Atualizar uma Bicicleta");
				Console.WriteLine("4 - Remover uma Bicicleta");
				Console.WriteLine("0 - Sair");

				opcao = Console.ReadLine();
				switch (opcao)
				{
					case "1":
						InserirBike();
						break;
					case "2":
						ListaBikes();
						break;
					case "3":
						AtualizarBike();
						break;
					case "4":
						RemoverBike();
						break;
					case "0":
						Console.Clear();
						Console.WriteLine("Saindo... até a próxima ");
						break;
				}
			}
		}
		private static void InserirBike()
		{
			Console.WriteLine("Cadastrar Bike no sistema:");
			Console.WriteLine("Modelo da Bicicleta:");
			var modeloDaBike = Console.ReadLine();
			Console.WriteLine("Marca da Bicicleta:");
			var marcaDaBike = Console.ReadLine();
			Console.WriteLine("Informe o valor da Bicicleta:");
			var valorDaBike = double.Parse(Console.ReadLine());
			var gravado = context.InserirBike(new Bike() { Modelo = modeloDaBike, Marca = marcaDaBike, Valor = valorDaBike });
			if (gravado)
				Console.WriteLine("Biciclita cadastrado com sucesso!");
			else
				Console.WriteLine("Bicicleta não cadastrada");
			Console.ReadKey();
		}
		private static void ListaBikes()
		{
			context.GetBikes().ToList<Bike>().ForEach(i => Console.WriteLine($"Bicicleta: Id:{i.Id}, Modelo:{i.Modelo}, Marca:{i.Marca} e valor de:{i.Valor}"));
			Console.ReadKey();
			Console.Clear();
		}
		private static void AtualizarBike()
		{
			Console.WriteLine("---Atualizar informações de uma bicicleta---");
			context.GetBikes().ToList<Bike>().ForEach(i => Console.WriteLine($"Bicicleta: Id:{i.Id}, Modelo:{i.Modelo}, Marca:{i.Marca} e valor de:{i.Valor}"));
			Console.ReadKey();
			Console.WriteLine("Informe o Id da Bicicleta");
			var bikeId = int.Parse(Console.ReadLine());

			var bike = context.GetBikes().FirstOrDefault(x => x.Id == bikeId);
			if (bike == null)
			{
				Console.WriteLine("Id informado é inválido");
				return;
			}
			Console.WriteLine("Informe o Id da Bicicleta: ");
			bike.Id = int.Parse(Console.ReadLine());

			var resultado = context.AtualizarBike(bike);

			if (resultado)
				Console.WriteLine("Sucesso!!!!!!!!!!!!");
			else
				Console.WriteLine("Erro!!!!!!");
			Console.ReadKey();
		}
		private static void RemoverBike()
		{
			Console.WriteLine("Remover uma Bicicleta do sistema");
			ListaBikes();
			Console.WriteLine("Informe o ID para desativar do sistema");
			var bikeId = int.Parse(Console.ReadLine());

			var bikeRemover = context.RemoverBike(bikeId);
			if (bikeRemover)
				Console.WriteLine("Bicicleta removida com sucesso");
			else
				Console.WriteLine("ID da Bicicleta incorreto");
			Console.ReadKey();
		}
	}
}
