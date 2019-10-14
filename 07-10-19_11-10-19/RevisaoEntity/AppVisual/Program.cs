using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using RevisandoEntity.Model;
using RevisandoEntity.Controller;

namespace AppVisual
{
	class Program
	{
		/*
		 1 - Setar a 'SET AS STARUP PROJECT'
		 2 - Vamos add EntityFramework ao console
		 3 - Colocar o using	
		 4 - 
			 */
		//static CervejaContextDB Cerveja = new CervejaContextDB();
		static CervejaController cerveja = new CervejaController();
		static void Main(string[] args)
		{
			cerveja.AddCerveja(new Cerveja() { Nome  = "Cerveja Skol Beats"});
			cerveja.GetCervejas().ToList<Cerveja>().ForEach(x => Console.WriteLine(x.Nome));
			Console.ReadKey();

			/*Cerveja.Cervejas.Add(new Cerveja() { Nome = "Nicolas" });
			Cerveja.SaveChanges();
			Cerveja.Cervejas.ToList<Cerveja>().ForEach(i => Console.WriteLine(i.Nome));
			Console.ReadKey();*/
		}
	}
}
