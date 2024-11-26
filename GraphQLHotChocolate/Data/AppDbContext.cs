using GraphQLHotChocolate.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQLHotChocolate.Data
{
	public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
	{
		public DbSet<Aufgabe> Aufgaben{ get; set; }
	}
}
