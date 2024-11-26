using GraphQLHotChocolate.Data;
using GraphQLHotChocolate.Data.Models;

namespace GraphQLHotChocolate.GraphQL
{
	public class Query
	{
		[UseFiltering]
		[UseSorting]
		public IQueryable<Aufgabe> GetAufgaben([Service] AppDbContext context) => context.Aufgaben;
	}
}
