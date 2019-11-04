using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseWebApi3.Model
{
	public class Calcu
	{
		[Key]
		public int Id { get; set; }
		public double Peso { get; set; }
		public double Densidade { get; set; }
		public double Volume { get; set; }
	}
}
