using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WepApiExistente.Models;

namespace WepApiExistente.Controllers
{
	public partial class MarcasController
	{
		[HttpGet]
		[Route("Api/Marcas/CustomQuery")] // define a rota a ser usada quando puxar essas informações
		public object CustomMarcasQuery()
		{
			var listaDeMarcas = db.Marcas.ToList();
			var retornoMarcas = from mar in listaDeMarcas
								select new
								{
									IdMarca = mar.Id,
									NomeMarca = mar.Nome
								};

			return retornoMarcas;
		}
	}
}