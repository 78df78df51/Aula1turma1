using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Model
{
	class Carro
	{
		public int Id { get; set; }
		public string Marca { get; set; }
		public string Modelo { get; set; }
		public DateTime Ano { get; set; }
		public double Cilindradas { get; set; }
		public int Portas { get; set; }
	}
}
