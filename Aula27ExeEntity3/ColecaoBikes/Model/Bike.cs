﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColecaoBikes.Model
{
	public class Bike
	{
		[Key]
		public int Id { get; set; }
		public string Modelo { get; set; }
		public string Marca { get; set; }
		public double Valor { get; set; }
		public bool Ativo { get; set; } = true;
	}
}
