using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCarros.Controller;

namespace testarApi
{
	class Program
	{
		static void Main(string[] args)
		{
			CarroController carroController = new CarroController();
			carroController.GetCarros().ForEach(x => Console.WriteLine($" Marca {x.Marca}, Modelo: {x.Modelo}, Portas: {x.Portas}, Id: {x.Id}"));
			Console.ReadKey();
		}
	}
}
