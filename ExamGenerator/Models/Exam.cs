namespace ExamGenerator.Models
{
	public class Exam
	{
		public Guid Id { get; set; }
		public Dictionary<int, Question> Questions { get; set; }
		public Dictionary<int, string> AnswersKey { get; set; }

		public Exam()
		{
			Id = Guid.NewGuid();
			Questions = new Dictionary<int, Question>();
			AnswersKey = new Dictionary<int, string>();
		}
		
		public Exam(Dictionary<int, Question> questions, bool randomizeAnswersOrder = true)
		{
			Id = Guid.NewGuid();
			Questions = questions;
			AnswersKey = new Dictionary<int, string>();

			if (randomizeAnswersOrder)
			{
				foreach (var question in questions)
				{
					question.Value.Choices = ShuffleChoices(question.Value.Choices);
				}
			}

			foreach (var question in Questions)
			{
				AnswersKey.Add(question.Key, question.Value.GetLetterOfCorrectAnswer());
			}
		}

		private static void Shuffle<T>(IList<T> list)
		{
			Random rng = new Random();

			int n = list.Count;
			while (n > 1)
			{
				n--;
				int k = rng.Next(n + 1);
				T value = list[k];
				list[k] = list[n];
				list[n] = value;
			}
		}

		private static List<Choice> ShuffleChoices(List<Choice> choices)
		{
			List<Choice> newList = choices.Select(choice => new Choice(Guid.NewGuid(), choice.Text, choice.IsCorrectAnswer, choice.QuestionId)).ToList();
			Random rng = new Random();

			int n = newList.Count;
			while (n > 1)
			{
				n--;
				int k = rng.Next(n + 1);
				Choice value = newList[k];
				newList[k] = newList[n];
				newList[n] = value;
			}

			return newList;
		}
	}
}
