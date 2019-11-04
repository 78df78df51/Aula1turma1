using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreWebApi.Models
{
	public class FirstCodeContext : DbContext
	{
		public FirstCodeContext() : base()
		{

		}

	public DbSet<Carro> Carros { get; }
	}
}
