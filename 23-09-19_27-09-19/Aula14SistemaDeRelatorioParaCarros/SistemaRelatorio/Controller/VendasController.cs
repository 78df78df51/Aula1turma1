using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaRelatorio.Model;

namespace SistemaRelatorio.Controller
{
	
	public class VendasController
	{
		SistemasVendasContext vendasContext = new SistemasVendasContext();

		public List<Venda> GetVendas(int mes = 0)
		{
			//retornamos nossa lista de vendas sem nenhum filtro nesto momento
			if (mes != 0)
			{
				return vendasContext.ListaVendasPublica.FindAll(x => x.Data.Month == mes);
			}
			return vendasContext.ListaVendasPublica;
		}
	}
}
