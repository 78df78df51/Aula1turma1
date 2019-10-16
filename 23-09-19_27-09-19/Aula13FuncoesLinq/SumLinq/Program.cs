using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumLinq
{
	class Program
	{
		static void Main(string[] args)
		{
			//chamar nossa função
			SomarInteiroPrimitivo();
			SomarInteirosLista();
			SomaBalasListaDeCriancas();
			Console.ReadKey();
		}
		/// <summary>
		/// Metodo que mostra numeros inteiros por um tipo primitivo
		/// </summary>
		private static void SomarInteiroPrimitivo()
		{
			//Quando utilizamos "[]" em um tipo "primitivo" podemos criar uma coleção destes valores
			int[] colecaoInteiros =
				//Alocamos memoria para nossa coleção de valor e informamos a quantidade de memoria que vamos
				//ocupa
				//memoriaOcupadaInt * quantidadeInformada
				new int[5]
			//Aqui carregamos nossa coleção de valore
		
				{ 1,2,3,4,5};

			Console.WriteLine(colecaoInteiros.Sum());
			
		}
		/// <summary>
		/// Metodo que soma valores de um em um dentro duma lista
		/// </summary>
		private static void SomarInteirosLista()
		{
			List<int> listaDeInteiro = new List<int>
			{
				//nossa coleção de valores
				1,2,3,4,5,6,7,8,9,10,11,12
			};

			Console.WriteLine(listaDeInteiro.Sum()); 
		}
		/// <summary>
		/// Metodo que soma a quantidade de bala das crianças
		/// </summary>
		private static void SomaBalasListaDeCriancas()
		{
			//Nossa lista de crianças foi criada e carregada em  memoria
			List<Crianca> criancas = new List<Crianca>()
			{
				//criando uma nova criança dentro da minha lista
				new Crianca()
				{
					Nome = "Matheus", //neste caso apenas uma propriedade de outra
					Balas = 9
				}, //virgula separa um obejto do outro
				new Crianca()
				{
					Nome = "Júlio",
					Balas = 68
				}
			};
			Console.WriteLine("Quantidade total de balas que as criancinhas levaram da venda : ");
			//Soma nossa quantidades de balas
			Console.WriteLine(criancas.Sum(x => x.Balas));
		}
	}
}
