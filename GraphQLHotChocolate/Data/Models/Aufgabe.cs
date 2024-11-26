namespace GraphQLHotChocolate.Data.Models
{
	[GraphQLDescription("Represents an Aufgabe in the system.")]
	public class Aufgabe
	{
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Status { get; set; }
        public DateTime Deadline { get; set; }
    }
}
