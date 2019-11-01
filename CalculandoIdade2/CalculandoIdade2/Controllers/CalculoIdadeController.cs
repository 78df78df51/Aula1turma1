using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CalculandoIdade2.Controllers
{
	public class CalculoIdadeController : ApiController
	{
		/// <summary>
		/// Retorna nome da aplicação e o que ela faz
		/// </summary>
		/// <returns>Retorna o que o nosso app faz</returns>
		public string Get()
		{
			return "App para poder beber hoje";
		}

		public string Get(int anoNascimento,string nomeUsuario =  "Default")
		{
			if ((DateTime.Now.Year - anoNascimento) >= 18)
			{
				return $"ola {nomeUsuario} maior de 18 liberado";
			}
			else
			{
				return $"E aí {nomeUsuario} Volta daqui ha alguns anos";
			}
		}

    }

}
