using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCerveja.Model
{
	public class SistemaCervejaContext
	{
		public List<Cerveja> listaCerveja { get; set; }

		public SistemaCervejaContext() 
		{
			listaCerveja = new List<Cerveja>();

			listaCerveja.Add(new Cerveja(){ Id = 1,Nome = "Brahma Chopp Pilsen",Litros = 1.0,  Alcool = 4.8,Valor = 10});
			listaCerveja.Add(new Cerveja(){ Id = 2,Nome = "Antarctica Pilsen"  ,Litros = 1.0,  Alcool = 4.7,Valor = 10});
			listaCerveja.Add(new Cerveja(){ Id = 3,Nome = "Bohemia 14 - Weiss" ,Litros = 0.300,Alcool = 4.3,Valor = 4.99});
			listaCerveja.Add(new Cerveja(){ Id = 4,Nome = "Budweiser"          ,Litros = 0.550,Alcool = 5,Valor = 6.99});
			listaCerveja.Add(new Cerveja(){ Id = 5,Nome = "Franziskaner Dunkel",Litros = 0.500,Alcool = 6,Valor = 13.98});
		}
		public List<Cerveja> ListaComCerveja { get { return listaCerveja; } }
	}

}
