using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCerveja.Controller;

namespace ApresentandoOsAlcoolatras
{
	class Program
	{
		static CervejaController cervejaController = new CervejaController();
		static void Main(string[] args)
		{
			cervejaController.CadastrarCerveja(new ListagemDeCerveja.Model.Cerveja() 
			{
				Id = cervejaController.GetCervejas().Count + 1,
				Nome = "Giomar",
				Litros = 0.600,
				Alcool = 7.5,
				Valor = 0.98
			});


			cervejaController.GetCervejas().ForEach(x => Console.WriteLine($"Id:{x.Id} Cerveja:{x.Nome} de Litros:{x.Litros} " +
				$"de valor:{x.Valor} e com {x.Alcool}de teor alcoolico"));
			Console.WriteLine("Total litros" + cervejaController.ValorTotalEmLitros());
			Console.WriteLine("Total Valor" + cervejaController.ValorTotalDaLista());
			Console.ReadKey();
		}
	}
}
