using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Culture.Model
{
	public class FloriContextDB : DbContext
	{		
		public DbSet<Flores> Flores { get; set; }
	}
}
