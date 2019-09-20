using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocacaoBiblioteca.Model;

namespace LocacaoBiblioteca.Controller
    ///classe que contem os metodos de usuarios do sistema
{
   public class UsuarioController
    ///<sumary>
    ///metedo que realiza o login dentro do nosso sistema para realizar o login padrão use:
    ///login: admin
    ///senha: admin
    /// ///</sumary>
    {
        public bool LoginSistema(Usuario usuarios)
        {

            /* if (usuarios.Login == "admin" && usuarios.Senha == "admin")
                 return true;
             else
                 return false;*/
            return Usuarios.Exists(x =>
            x.Login == usuarios.Login &&
            x.Senha == usuarios.Senha);

        }

       public UsuarioController()
        {
            //cria dois usuarios igual os dois livros
            Usuarios = new List<Usuario>();

            Usuarios.Add(new Usuario()
            {
                Login = "admin",
                Senha = "admin"
            });
            Usuarios.Add(new Usuario()
            {
                Login = "man",
                Senha = "1234"
               
            });
        }
     
        public List<Usuario> Usuarios { get; set; }
    }
          

       

    
}
