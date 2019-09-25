using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaregeLinq
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Vendas> vendas = new List<Vendas>()
			{
			new Vendas()
			{
				Produto = "XIAOMI Lite 6 quad Core 128 GB 32px frontal",
				Quantidade = 8,
				Valor = 1200.75
			},
			new Vendas()
			{
				Produto = "SLIM 3500 APP",
				Quantidade = 5,
				 Valor = 2800.96
				
			},
			new Vendas()
			{
				Produto = "Motorola z3 edition project",
				Quantidade = 1,
				Valor = 1999.99
			}
			};
			Console.WriteLine("Media de produtos vendidos este mês: ");
			Console.WriteLine(vendas.Average(x => x.Quantidade));
			Console.WriteLine("Média total de vendas neste mês em R$: ");
			Console.WriteLine(vendas.
				//Aqui realizamos o calculo de quatidade * valor = total de venda do produto
				Average(x => (x.Quantidade * x.Valor)));
				//Avarege divide o valor total pela quantidade de itens em nossa lista

			Console.ReadKey();
		}
	}
}
