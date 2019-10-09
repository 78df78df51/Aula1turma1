using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Model
{
    public class Usuario
    {
		public static object Usuarios { get; set; }
		[Key]
		public   int Id { get; set; }
		[MaxLength(30)]
		[Required]
		public string Login { get; set; }

        public string Senha { get; set; }
		public bool Ativo { get; set; } = true;
        public int UsuarioCriacao { get; set; }
        public int UsuarioAlteracao { get; set; }
        public DateTime DataAlteracao { get; set; }

		public static void AdicionarUsuario(Usuario usuario)
		{
			throw new NotImplementedException();
		}
	}
}
