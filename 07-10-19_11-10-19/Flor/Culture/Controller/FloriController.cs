using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Culture.Model;

namespace Culture.Controller
{
	public class FloriController
	{
		private FloriContextDB ContextDB = new FloriContextDB();
		public List<Flores> RetornaListaDeFlores()	
		{
			return ContextDB.Flores.ToList<Flores>();
		}
		public bool InserirFlores(Flores i) 
		{
			if (string.IsNullOrWhiteSpace(i.Nome))
				return false;
			ContextDB.Flores.Add(i);
			ContextDB.SaveChanges();
			return true;
		}

	}
}
