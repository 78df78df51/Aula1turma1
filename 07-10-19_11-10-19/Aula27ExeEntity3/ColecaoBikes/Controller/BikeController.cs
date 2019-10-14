using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColecaoBikes.Model;

namespace ColecaoBikes.Controller
{
	public class BikeController
	{
		BikeContextDB contextDB = new BikeContextDB();

		//Listar	
		public IQueryable<Bike> GetBikes()
		{
			return contextDB.Bikes.Where
				(x => x.Ativo == true);
		}
		//Inserir
		public bool InserirBike(Bike i)
		{
			contextDB.Bikes.Add(i);
			contextDB.SaveChanges();
			return true;
		}
		//Atualizar
		public bool AtualizarBike(Bike i)
		{
			var livros = contextDB.Bikes.FirstOrDefault
				(x => x.Id == i.Id);
			if (livros == null)
				return false;
			contextDB.SaveChanges();
			return true;
		}
		//Remover
		public bool RemoverBike(int id)
		{
			var livros = contextDB.Bikes.FirstOrDefault
			(x => x.Id == id);
			if (livros == null)
				return false;

			livros.Ativo = false;
			contextDB.SaveChanges();
			return true;
		}
	}
}

