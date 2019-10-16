using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCerveja.Controller;
using ListagemDeCerveja.Model;

namespace Executar
{
	class Program
	{
		 static CervejaController cervejaController = new CervejaController();
		static void Main(string[] args)
		{
			//mostrarListaDeCerveja();
			adicionarCerveja();

			//Console.WriteLine($" total {cervejaController.SomarTotalLista()}");
			//Console.WriteLine($" total {cervejaController.SomarTotalDeLitros()}");
			//Console.ReadKey();
		}
		private static void mostrarListaDeCerveja()
		{
			cervejaController.GetCervejas().ForEach(x => formataLista(x));
   			Console.ReadLine();
			
		}

		private static void formataLista(Cerveja cerveja)
		{
			var texto = string.Format("id:{0, 2}   Nome:{1,-15}    Litros:{2,3}   Álcool:{3,2}    Valor:{4,3}",
				cerveja.Id, cerveja.Nome, cerveja.Litros, cerveja.Alcool, cerveja.Valor);
			Console.WriteLine(texto);
		}
		private static void adicionarCerveja()
		{
			Console.WriteLine("adicionar cerveja a lista");
			 
			var ID = int.Parse(Console.ReadLine());
			Console.WriteLine("Informe o nome da cerveja:");
			var Nome = Console.ReadLine();
			Console.WriteLine("Informe a quantidade do líquido em Litros:");
			var Litros = int.Parse(Console.ReadLine());
			Console.WriteLine("Informe a quantidade de teor alcólico:");
			var Alcool = int.Parse(Console.ReadLine());
			Console.WriteLine("Informe o preço da cerveja");
			var Valor = int.Parse(Console.ReadLine());
			cervejaController.adicionarCerveja2(new Cerveja() { Id = ID, Nome = Nome, Litros = Litros, Alcool = Alcool, Valor = Valor });
		}


	}
}
