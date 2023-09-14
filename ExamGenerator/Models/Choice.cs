namespace ExamGenerator.Models
{
	public class Choice
	{
		public Guid Id { get; set; }
		public string Text { get; set; }
		public bool IsCorrectAnswer { get; set; }
		public Guid QuestionId { get; set; }

		public Choice()
		{
			Id = Guid.NewGuid();
			Text = "";
		}

		public Choice(Guid id, string text, bool isCorrectAnswer, Guid questionId)
		{
			Id = id;
			Text = text;
			IsCorrectAnswer = isCorrectAnswer;
			QuestionId = questionId;
		}
	}
}
