using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace FriendInnerJoin.Controllers
{
	public partial class CarroesController
	{
		[HttpGet]
		[Route("Api/Carroes/CarrosComUsuarios")]
		public object CustomCarrosComUsuarios(int idCarro)
		{
			var listaDeCarros = db.Carros.ToList();
			var listaDeUsuarios = db.Usuarios.ToList();

			var conteudoRetorno = from car in listaDeCarros
								  join usu in listaDeUsuarios
								  on car.UsuInc equals usu.Id
								  where car.Id == idCarro
								  select new
								  {
									  NomeCarro = car.Modelo,
									  UsuCriacao = usu.Usuario1
								  };


			return conteudoRetorno;

		}

	}
}