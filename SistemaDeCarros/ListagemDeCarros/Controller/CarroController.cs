using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCarros.Model;

namespace ListagemDeCarros.Controller
{
	public class CarroController
	{
		SistemaCarrosContext car = new SistemaCarrosContext();
		/// <summary>
		/// /Metodo que retorna nossa lista de carros completa
		/// </summary>
		/// <returns></returns>
		public List<Carro> GetCarros()
		{
			return car.ListaDeCarros;
			
		}
	}
}
