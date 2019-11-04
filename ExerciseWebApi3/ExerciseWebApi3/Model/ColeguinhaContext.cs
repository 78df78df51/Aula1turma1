using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseWebApi3.Model
{
	public class ColeguinhaContext : DbContext 
	{
		public ColeguinhaContext(DbContextOptions<ColeguinhaContext> options)
			: base (options)
		{

		}
		public DbSet<Calcu> Calcus { get; set; }
	}
}
