using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaRelatorio.Controller;
using SistemaRelatorio.Model;


namespace InterfaceSistemaRelatorio
{
	class Program

	{
		static VendasController vendasController = new VendasController();
		static void Main(string[] args)
		{
			Console.WriteLine("Informações das vendas realizadas durante o ano de 2019");
			vendasController.GetVendas().ForEach(i => ImprimeInformacoes(i));
			MostraMenuRelatorio();
			Console.ReadKey();
		}
		private static void MostraMenuRelatorio()
		{
			Console.Clear();
			Console.WriteLine("Menu de relatórios");
			Console.WriteLine("1 - Menu por periodo mensal");
			Console.WriteLine("0 - Sair");
			var menuEscolhido = int.MinValue;
			while(menuEscolhido != 0)
			{
				menuEscolhido = int.Parse(Console.ReadLine());
				switch (menuEscolhido)
				{
					case 1:
						Console.WriteLine("Informe o mês para realizar o filtro");
						//Obtemos a informação do mês
						var mesEscolhido = int.Parse(Console.ReadLine());
						//Passemos o mês na mesma função para obter as vendas
						var listaDoPeriodoEscolhido = vendasController.GetVendas(mesEscolhido);

						//Aqui imprimimo as informações para o usuario
						listaDoPeriodoEscolhido.ForEach(i => ImprimeInformacoes(i));

						var totalMes = listaDoPeriodoEscolhido
							//Somamos todos os registro multiplicando os valores de venda veze a quantidade
							.Sum(x => x.Valor * x.Quantidade);

						var mediaPeriodo = listaDoPeriodoEscolhido
							//Média de todos os registro multiplicando os valores de venda vezes a quantidade
							.Average(x => x.Valor * x.Quantidade);

						Console.WriteLine($"\r\nTotal do mês {mesEscolhido} é {totalMes.ToString("C")}");

						Console.ReadKey();
						break;
				}
			}
		}
		public static void ImprimeInformacoes (Venda vendas)
		{
			Console.WriteLine(string.Format("id:{0,3}  Carro: {1,-35}Valor: {2,-10}  Quantidade:{3,3}  Data:{4,12}", 
				vendas.Id, vendas.Carro, vendas.Valor.ToString("C"), vendas.Quantidade,vendas.Data.ToShortDateString()));
		}
	}
}
