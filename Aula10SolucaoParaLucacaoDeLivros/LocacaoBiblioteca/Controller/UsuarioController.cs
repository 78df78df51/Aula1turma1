using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocacaoBiblioteca.Model;

namespace LocacaoBiblioteca.Controller
{
	public class UsuarioController
	{
		private LocacaoContext contextDB = new LocacaoContext();
		public UsuarioController()
		{   //como criar um admin no banco toda vez que ele for iniciado
			var defaultUser = contextDB.ListaDeUsuarios
				//informação sobre o usuario admin
				.FirstOrDefault(x => x.Login == "admin" && x.Senha == "admin");

			if (defaultUser == null)
			{	//validação
				contextDB.ListaDeUsuarios.Add(
					new Usuario()
					{
						Login = "admin",
						Senha = "admin"
					});
				//salvar no banco
				contextDB.SaveChanges();
			}
		}
		public bool LoginSistema(Usuario usuarios)
		{
			var login = contextDB.ListaDeUsuarios.FirstOrDefault
				(x => x.Login == usuarios.Login && x.Senha == usuarios.Senha && x.Ativo == true);
			if (login == null)
				return false;
			else
			Console.Clear();
			Console.WriteLine($"_____________________Bem vindo {login.Login}______________________");
			Console.ReadKey();
			return true;
		}
		public bool AdicionarUsuario(Usuario parametroUsuario)
		{
			contextDB.ListaDeUsuarios.Add(parametroUsuario);
			contextDB.SaveChanges();
			return true;
		}
		public List<Usuario> RetornaListaDeUsuarios()
		{
			return contextDB.ListaDeUsuarios.Where(x => x.Ativo).ToList<Usuario>();
		}
		public bool RemoverUsuariosPorID(int identificadoID)
		{
			contextDB.ListaDeUsuarios.FirstOrDefault(x => x.Id == identificadoID).Ativo = false;
			contextDB.SaveChanges();
			return true;
		}
	}
}
