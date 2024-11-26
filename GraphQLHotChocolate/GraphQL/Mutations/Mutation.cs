using GraphQLHotChocolate.Data;
using GraphQLHotChocolate.Data.Models;
using System.Reflection.Metadata.Ecma335;

namespace GraphQLHotChocolate.GraphQL.Mutations
{
	public class Mutation
	{
		[GraphQLDescription("Create an Aufgabe.")]
		public async Task<Aufgabe> AddAufgabe(string title, string status, DateTime deadline, [Service] AppDbContext context)
		{
			var aufgabe = new Aufgabe
			{
				Title = title,
				Status = status,
				Deadline = deadline
			};

			context.Aufgaben.Add(aufgabe);
			await context.SaveChangesAsync();

			return aufgabe;
		}
	}
}