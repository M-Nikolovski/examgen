namespace ExamGenerator.Models
{
	public class Subject
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string? Description { get; set; }
		public List<Question> Questions { get; set; }

		public Subject()
		{
			Id = Guid.NewGuid();
			Name = "";
			Questions = new List<Question>();
		}

		public Subject(Guid id, string name, string description, List<Question> questions)
		{
			Id = id;
			Name = name;
			Description = description;
			Questions = questions;
		}
	}
}
