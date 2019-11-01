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
	public partial class VendasController
	{
		[HttpGet]
		[Route("Api/Vendas/CustomQuery")] // define a rota a ser usada quando puxar essas informações
		public object CustomVendasQuery()
		{
			var listaDeVendas = db.Vendas.ToList();
			var listaDeCarros = db.Carros.ToList();

			var retornoVendas = from ven in listaDeVendas
								join car in listaDeCarros
								on ven.Carro equals car.Id
								select new
								{
									IdVenda = ven.Id,
									NomeCarro = car.Modelo
								};

			return retornoVendas;
		}
	}
}