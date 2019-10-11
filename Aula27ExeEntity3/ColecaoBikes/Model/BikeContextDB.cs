using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColecaoBikes.Model
{
	public class BikeContextDB : DbContext
	{
		public DbSet<Bike> Bikes { get; set; }
	}
}
