
using GraphQLHotChocolate.Data;
using GraphQLHotChocolate.GraphQL;
using GraphQLHotChocolate.GraphQL.Filter;
using GraphQLHotChocolate.GraphQL.Mutations;
using Microsoft.EntityFrameworkCore;

namespace GraphQLHotChocolate
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.

			builder.Services.AddControllers();
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();

			builder.Services.AddDbContext<AppDbContext>(opt => opt.UseInMemoryDatabase("banco"));

			builder.Services
				.AddGraphQLServer()
				.AddQueryType<Query>()
				.AddMutationType<Mutation>()
				.AddType<AufgabeFilterType>()
				.AddFiltering();

			var app = builder.Build();
			app.MapGraphQL();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseHttpsRedirection();

			app.UseAuthorization();


			app.MapControllers();

			app.Run();
		}
	}
}
