using Aspose.Pdf;
using ExamGenerator.Models;
using System.Windows.Documents;

namespace ExamGenerator.Dialogs
{
	public partial class GenerateExamsModal : Form
	{
		private List<Question> Questions;
		private string SubjectTitle;

		public GenerateExamsModal(List<Question> questions, string subjectTitle)
		{
			InitializeComponent();

			Questions = questions;
			SubjectTitle = subjectTitle;
		}

		private void btnGenerate_Click(object sender, EventArgs e)
		{
			string examTitle = txtExamTitle.Text != null ? txtExamTitle.Text : SubjectTitle + " Exam";
			int numberOfExamsToGenerate = (int)nmbNumberOfExams.Value;
			bool randomizeAnswers = chkRandomizeAnswers.Checked;

			List<Exam> exams = new List<Exam>();
			
			for (int i = 0; i < numberOfExamsToGenerate; i++)
			{
				Dictionary<int, Question> questionsDictionary = new Dictionary<int, Question>();
				for (int j = 0; j < Questions.Count(); j++)
				{
					questionsDictionary.Add(j, new Question(Guid.NewGuid(), Questions[j].Text, Questions[j].Choices, Questions[j].SubjectId));
				}
				exams.Add(new Exam(questionsDictionary, randomizeAnswers));
			}

			GenerateExam(exams, examTitle);
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void GenerateExam(List<Exam> exams, string examTitle)
		{
			Document examDocument = new Document();
			Document keysDocument = new Document();

			foreach (Exam exam in exams)
			{
				// one page is one exam
				Page pageExams = examDocument.Pages.Add();

				var title = new Aspose.Pdf.Text.TextFragment(examTitle);
				title.TextState.HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Center;
				title.TextState.FontSize = 16;

				pageExams.Paragraphs.Add(title);
				pageExams.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("\nExam number: " + exam.Id + "\n"));

				foreach (var question in exam.Questions)
				{
					pageExams.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("\n" + (question.Key + 1) + ". " + question.Value.Text));

					string choices = "";
					foreach (var choice in question.Value.Choices)
					{
						choices += question.Value.GetLetterForAnswer(choice) + ") " + choice.Text + "     ";
					}
					pageExams.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(choices + "\n"));
				}

				// one page is keys for one exam
				Page pageKeys = keysDocument.Pages.Add();
				
				var title1 = new Aspose.Pdf.Text.TextFragment(examTitle + " - Answer Keys");
				title1.TextState.HorizontalAlignment = Aspose.Pdf.HorizontalAlignment.Center;
				title1.TextState.FontSize = 16;

				pageKeys.Paragraphs.Add(title1);
				pageKeys.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("\nExam number: " + exam.Id + "\n"));

				foreach(var question in exam.Questions)
				{
					pageKeys.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("\n" + (question.Key + 1) + " - " + question.Value.GetLetterOfCorrectAnswer() + "\n"));
				}

			}

			var outputFileNameExam = Path.Combine("..\\..\\..\\", SubjectTitle + "_exam.pdf");
			examDocument.Save(outputFileNameExam);

			var outputFileNameKeys = Path.Combine("..\\..\\..\\", SubjectTitle + "_keys.pdf");
			keysDocument.Save(outputFileNameKeys);


			var result = MessageBox.Show("The exams were generated successfully!", "", MessageBoxButtons.OK);
			if (result == DialogResult.OK)
			{
				this.Close();
			}
		}
	}
}
