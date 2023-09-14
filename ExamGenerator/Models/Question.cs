namespace ExamGenerator.Models
{
	public class Question
	{
		public Guid Id { get; set; }
		public string Text { get; set; }
		public List<Choice> Choices { get; set; }
		public Guid SubjectId { get; set; }


		public Question()
		{
			Id = Guid.NewGuid();
			Text = "";
			Choices = new List<Choice>();
		}

		public Question(Guid id, string text, List<Choice> choices, Guid subjectId)
		{
			Id = id;
			Text = text;
			Choices = choices;
			SubjectId = subjectId;
		}

		public Choice GetCorrectAnswer()
		{
			return Choices.First(x => x.IsCorrectAnswer);
		}

		public string GetLetterForAnswer(Choice choice)
		{
			for (int i = 0; i < Choices.Count; i++)
			{
				if (Choices[i].Id == choice.Id)
				switch (i)
				{
					case 0: return "A";
					case 1: return "B";
					case 2: return "C";
					case 3: return "D";
				}
			}
			return "ERROR";
		}

		public string GetLetterOfCorrectAnswer()
		{
			for (int i = 0; i < Choices.Count; i++)
			{
				if (Choices[i].IsCorrectAnswer)
				{
					switch (i)
					{
						case 0: return "A";
						case 1: return "B";
						case 2: return "C";
						case 3: return "D";
					}
				}
			}
			return "ERROR";
		}
	}
}
