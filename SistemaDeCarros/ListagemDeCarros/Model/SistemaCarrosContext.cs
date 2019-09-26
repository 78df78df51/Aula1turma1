using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCarros.Model
{
	class SistemaCarrosContext
	{
		public List<Carro> ListaDeCarros { get; set; }
		public SistemaCarrosContext()
		{
			ListaDeCarros = new List<Carro>();
			ListaDeCarros.Add(new Carro() { Id = 0, Marca = "Fiat", Modelo = "", Ano = int.Parse("2014"), Cilindradas = int.Parse("2.6"), Portas = 4 });
			ListaDeCarros.Add(new Carro() { Id = 1, Marca = "Fiat", Modelo = "", Ano = int.Parse("2014"), Cilindradas = int.Parse("2.6"), Portas = 4 });
			ListaDeCarros.Add(new Carro() { Id = 2, Marca = "Fiat", Modelo = "", Ano = int.Parse("2014"), Cilindradas = int.Parse("2.6"), Portas = 4 });
			ListaDeCarros.Add(new Carro() { Id = 3, Marca = "Fiat", Modelo = "", Ano = int.Parse("2014"), Cilindradas = int.Parse("2.6"), Portas = 4 });
			ListaDeCarros.Add(new Carro() { Id = 4, Marca = "Fiat", Modelo = "", Ano = int.Parse("2014"), Cilindradas = int.Parse("2.6"), Portas = 4 });
			ListaDeCarros.Add(new Carro() { Id = 5, Marca = "Fiat", Modelo = "", Ano = int.Parse("2014"), Cilindradas = int.Parse("2.6"), Portas = 4 });
			ListaDeCarros.Add(new Carro() { Id = 6, Marca = "Fiat", Modelo = "", Ano = int.Parse("2014"), Cilindradas = int.Parse("2.6"), Portas = 4 });
			ListaDeCarros.Add(new Carro() { Id = 7, Marca = "Fiat", Modelo = "", Ano = int.Parse("2014"), Cilindradas = int.Parse("2.6"), Portas = 4 });
			ListaDeCarros.Add(new Carro() { Id = 8, Marca = "Fiat", Modelo = "", Ano = int.Parse("2014"), Cilindradas = int.Parse("2.6"), Portas = 4 });
			ListaDeCarros.Add(new Carro() { Id = 9, Marca = "Fiat", Modelo = "", Ano = int.Parse("2014"), Cilindradas = int.Parse("2.6"), Portas = 4 });

		}
	}

	}			
			