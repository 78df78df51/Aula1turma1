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
	public partial class UsuariosController
	{
		[HttpGet]
		[Route("Api/Usuarios/CustomQuery")] // define a rota a ser usada quando puxar essas informações
		public object CustomUsuariosQuery()
		{
			var listaDeUsuarios = db.Usuarios.ToList();

			var retornoUsuarios = from usu in listaDeUsuarios
								  select new
								  {
									  IdUsuario = usu.Id,
									  NomeUsuario = usu.Usuario1
								  };

			return retornoUsuarios;
		}
	}
}