using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocacaoBiblioteca.Model;

namespace LocacaoBiblioteca.Controller { 
    //classe que contem os metodos de usuarios do sistema
	//Criando piado para impedir o programador de adicinar um ID ou alterar fora da class
	public class UsuarioController
    ///<sumary>
    ///metedo que realiza o login dentro do nosso sistema para realizar o login padrão use:
    ///login: admin
    ///senha: admin
    /// ///</sumary>
    {
		private LocacaoContext contextDB = new LocacaoContext();
		public UsuarioController()
		{
			
		}
		public bool LoginSistema(Usuario usuarios)
        {

            /* if (usuarios.Login == "admin" && usuarios.Senha == "admin")
                 return true;
             else
                 return false;*/
            return RetornaListaDeUsuarios().Exists(x =>
            x.Login == usuarios.Login &&
            x.Senha == usuarios.Senha);

        }


		public void AdicionarUsuario(Usuario parametroUsuario)
		{
			parametroUsuario.Id = contextDB.IdContadorUsuarios++;
			contextDB.ListaDeUsuarios.Add(parametroUsuario);
		
		}
		public List<Usuario> RetornaListaDeUsuarios()
		{
			return contextDB.ListaDeUsuarios.Where(x =>x.Ativo).ToList<Usuario>();
		}
		/// <summary>
		/// Metodo que desativa um registro de usuario cadastrado em nossa lista
		/// </summary>
		/// <param name="identificadoID">Parametro que identifica o usuario que sera desativado</param>
		public void RemoverUsuariosPorID(int identificadoID)
		{
			//aqui usamos o metodo firstOrDefaul para localizar nosso usuario dentro da lista
			//com isso conseguimos acessar as propriedade dele e desativar o registro
			contextDB.ListaDeUsuarios.FirstOrDefault(x => x.Id == identificadoID).Ativo = false;
		}
	}
 }
