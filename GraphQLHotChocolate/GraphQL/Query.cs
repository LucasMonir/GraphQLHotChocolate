using GraphQLHotChocolate.Data;
using GraphQLHotChocolate.Data.Models;
using GraphQLHotChocolate.GraphQL.Filter;

namespace GraphQLHotChocolate.GraphQL
{
	public class Query
	{
		[UseFiltering(typeof(AufgabeFilterType))]
		public IQueryable<Aufgabe> GetAufgaben([Service] AppDbContext context) => context.Aufgaben;
	}
}
