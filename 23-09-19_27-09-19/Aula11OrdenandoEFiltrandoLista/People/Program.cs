using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
	class Program
	{
		static void Main(string[] args)
		{
			var listarPessoas = new List<Gente>();

			listarPessoas.Add(new Gente() {
				Id = 1,
				Nome = "Spears",
				DataDeNascimento = DateTime.Parse("07/11/ 2004"),
				Carteira = 846.96
			});
			listarPessoas.Add(new Gente()
			{
				Id = 2,
				Nome = "Swanson",
				DataDeNascimento = DateTime.Parse("20/06/2003"),
				Carteira = 233.09
			});

			listarPessoas.OrderBy(x => x.Nome).ToList<Gente>()
				.ForEach(i => Console.WriteLine($"Id:{i.Id} Nome: {i.Nome} Data nascimento: " +
				$"{i.DataDeNascimento.ToShortDateString()} sálario: {i.Carteira}"));
			Console.WriteLine("______________________________________");

			listarPessoas.OrderByDescending(x => x.DataDeNascimento).ToList<Gente>()
				.ForEach(i => Console.WriteLine($"Id: {i.Id} Nome: {i.Nome}" +
				$" Data de Nascimento: {i.DataDeNascimento.ToShortDateString()}"));
			Console.ReadKey();
		}
		
		
	}
}


