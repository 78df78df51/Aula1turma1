using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCerveja.Model;
using ListagemDeCerveja.Controller;

namespace ListagemDeCerveja.Controller
{
	public class CervejaController
	{
	
		SistemaCervejaContext cervejaContext = new SistemaCervejaContext();

		public List<Cerveja> GetCervejas()
		{
			return cervejaContext.ListaComCerveja;
		}
		public void adicionarCerveja2(Cerveja cerveja)
		{
			cervejaContext.ListaComCerveja.Add(cerveja);
		}

		public void CadastrarCerveja (Cerveja cerveja)
		{
			cerveja.Id = cervejaContext.listaCerveja.Count() + 1;
			cervejaContext.listaCerveja.Add(cerveja);
		}
		public double SomarTotalLista()
		{

		     return cervejaContext.ListaComCerveja.Sum(X => X.Valor);
			
		}
		public double SomarTotalDeLitros()
		{
			return cervejaContext.ListaComCerveja.Sum(X => X.Litros);
		}
	}
}
