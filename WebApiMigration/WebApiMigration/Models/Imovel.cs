using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApiMigration.Models
{
	public class Imovel
	{
		[Key]
		public int Id { get; set; }
		public string CEP { get; set; }
		public string Logradouro { get; set; }
		public string Bairro { get; set; }
		public string Municipio { get; set; }
		public string Numero { get; set; }
		public string Complemento { get; set; }
		public string Proprietario { get; set; }
	}
}