using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCarros.Controller;
using ListagemDeCarros.Model;

namespace ListarCarrosDoAmigo
{
	class Program
	{
		static CarroController controller = new CarroController();
		static void Main(string[] args)
		{
			controller.GetCarros().ForEach(x => Console.WriteLine($"Marca {x.Marca}"));
			Console.ReadKey();
		}
	}
}
