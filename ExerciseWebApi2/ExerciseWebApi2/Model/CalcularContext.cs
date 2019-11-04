using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseWebApi2.Model
{
	public class CalcularContext : DbContext 
	{
		public CalcularContext(DbContextOptions<CalcularContext> options)
			: base(options)
		{

		}
		public DbSet<Calcular> Calculars { get; set; }
	}
}
