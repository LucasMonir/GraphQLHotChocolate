using GraphQLHotChocolate.Data.Models;
using HotChocolate.Data.Filters;

namespace GraphQLHotChocolate.GraphQL.Filter
{
	public class AufgabeFilterType : FilterInputType<Aufgabe> 
	{
		protected override void Configure(IFilterInputTypeDescriptor<Aufgabe> descriptor)
		{
			descriptor.BindFieldsExplicitly();
			descriptor.Field(t => t.Status).Type<CustomStringOperationFilterInputType>();
		}

		public class CustomStringOperationFilterInputType : StringOperationFilterInputType
		{
			protected override void Configure(IFilterInputTypeDescriptor descriptor)
			{
				descriptor.Operation(DefaultFilterOperations.Equals).Type<StringType>();
				descriptor.Operation(DefaultFilterOperations.NotEquals).Type<StringType>();
			}
		}

		
	}
}
