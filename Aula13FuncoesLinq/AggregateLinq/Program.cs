using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregateLinq
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> listaDeNomes = new List<string>()
			{
				"Felipe",
				"Giomar",
				"Euricledson",
				"Adagaberto",
				"Ezebio",
				"Irineudson"
			};

			var texto = listaDeNomes
				//No aggregate temos o nome atula que estamos lendo
				//e o proxim nome da lista
				.Aggregate((nome1, nome2) => nome1 + ";\r\n " + nome2);
				//No passo seguinte temos o nome  'próximo' vira o atual
				//e pega o proximo da lista apos o atual
			Console.WriteLine(texto);
			Console.ReadKey();
		}
	}
}
