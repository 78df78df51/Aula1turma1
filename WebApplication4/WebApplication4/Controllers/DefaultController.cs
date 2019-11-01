using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
	[EnableCors(origins: "*", headers: "*", methods: "*")]
	public class DefaultController : ApiController
	{
		List<ObjetoIMC> listaDeObjetos = new List<ObjetoIMC>() 
		{ 
			new ObjetoIMC(){Nome = "Felipe"},
			new ObjetoIMC(){Nome = "Marcos"},
			new ObjetoIMC(){Nome = "João"}

		 };
		public List<ObjetoIMC> Get()
		{
			return listaDeObjetos;
		}
		public string Get(string nome, double peso, double altura)
		{
			var imc = peso / Math.Pow(altura, 2);
			return $"Olá {nome} seu IMC é:{imc}";
		}
		public ObjetoIMC Post(ObjetoIMC values)
		{
			ObjetoIMC imcCalc = values;
			imcCalc.ImcValue = imcCalc.Peso / (imcCalc.Altura * imcCalc.Altura);
			listaDeObjetos.Add(imcCalc);
			return imcCalc;
		}
    }
}
