using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CestaDeFrutas;

namespace CestaDeFrutas
{
	class Program
	{
		static void Main(string[] args)
		{
			var cestaDeFrutas = new List<Fruta>();

			cestaDeFrutas.Add(new Fruta()
			{
				Id = 0,
				Nome = "tomate",
				Cor = "Vermelho",
				Peso = 212

			});

			cestaDeFrutas.Add(new Fruta()
			{
				Id = 1,
				Nome = "Goiaba",
				Cor = "Verde sem bixinho",
				Peso = 95

			});
			cestaDeFrutas.Add(new Fruta()
			{
				Id = 2,
				Nome = "Manga",
				Cor = "amarela",
				Peso = 325

			});
			#region Codando
			cestaDeFrutas.OrderByDescending(x => x.Id).ToList<Fruta>().ForEach(i =>
			Console.WriteLine($"Id {i.Id} Nome: {i.Nome}"));

			Console.WriteLine("___________________________________");

			cestaDeFrutas.OrderBy(x => x.Id).ToList<Fruta>().ForEach(i =>
			Console.WriteLine($"Id {i.Id} Nome: {i.Nome} Peso {i.Peso}"));

			Console.WriteLine("___________Filtro Peso________________________ ");
			var filtroCesta = cestaDeFrutas.Where(x => x.Peso > 100).OrderBy(x => x.Nome);

			filtroCesta.ToList<Fruta>().ForEach(i => Console.WriteLine($"Id {i.Id} nome {i.Nome} Peso {i.Peso}"));
			//frutinha recebe cada fruta da nossa cesta
			(from frutinha in cestaDeFrutas // aqui temos a coleção de frutas
			 where frutinha.Peso > 100  //aqui escolhemos somentes frutas acima de 100 g
			 select frutinha).ToList<Fruta>().ForEach(i => Console.WriteLine($"Fruta Escolhida {i.Nome}"));

			Console.WriteLine("___________Filtro Cor________________________ ");
			//aqui criamos uma variavel que recebemos o valor bsucado
			var mostrandoFind = cestaDeFrutas.
				//aqui é feito o filtro das informações por uma "ou --> || <--" outra cor
				Find(x => x.Cor == "Amarelo" || x.Cor == "Vermelho");
			Console.WriteLine($" Id {mostrandoFind.Id} Nome {mostrandoFind.Nome}");
			//aqui criamos uma variavel que recebe a coleção que estamos
			var mostrandoFindAll = cestaDeFrutas.
				//find all com esta condição tras frutas de cor amarela "ou" vermelhas
				FindAll(x => x.Cor == "Amarelo" || x.Cor == "Vermelho");
			mostrandoFindAll.ForEach(i => Console.WriteLine($"id {i.Id} Nome {i.Nome}"));

			var listaOrdenada = mostrandoFindAll.OrderBy(x => x.Nome);

			foreach (var item in listaOrdenada) Console.WriteLine($"Id {item.Id} Nome {item.Nome}");

			Console.WriteLine("___________Find com oder by________________________ ");

			var cestaFrutasFindeOrder = cestaDeFrutas.OrderBy(x => x.Nome).ToList<Fruta>().Find(x => x.Cor == "Amarelo" || x.Cor == "Vermelho");
			Console.WriteLine($"Id {cestaFrutasFindeOrder.Id} Nome {cestaFrutasFindeOrder.Nome}");

			Console.ReadKey();
			#endregion
		}
	}
}
