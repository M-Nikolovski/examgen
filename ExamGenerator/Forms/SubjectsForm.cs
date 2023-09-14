using ExamGenerator.Dialogs;
using ExamGenerator.Models;
using System.Data;
using System.Xml.Serialization;

namespace ExamGenerator.Forms
{
	public partial class SubjectsForm : Form
	{
		private List<Subject> subjectsList = new List<Subject>();
		private Subject currentlySelectedSubject = null;

		public SubjectsForm()
		{
			InitializeComponent();

			XmlSerializer serializerSubjects = new XmlSerializer(typeof(List<Subject>));
			using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\subjects.xml", FileMode.Open, FileAccess.Read))
			{
				subjectsList = serializerSubjects.Deserialize(fs) as List<Subject>;
			}

			foreach (var subject in subjectsList)
			{
				cmbSubjectPicker.Items.Add(subject.Name);
			}

			cmbSubjectPicker.Text = "Please select a subject...";
		}

		private void cmbSubjectPicker_TextChanged(object sender, EventArgs e)
		{
			cmbSubjectPicker.Text = cmbSubjectPicker.SelectedIndex < 0 ? "Please select a subject..." : cmbSubjectPicker.SelectedText;
		}

		private void cmbSubjectPicker_Click(object sender, EventArgs e)
		{
			cmbSubjectPicker.DroppedDown = true;
		}

		private void cmbSubjectPicker_SelectedIndexChanged(object sender, EventArgs e)
		{
			dgvQuestions.Rows.Clear();

			var selectedSubjectTitle = cmbSubjectPicker.SelectedItem.ToString();

			var selectedSubject = currentlySelectedSubject = subjectsList.Find(subject => subject.Name == selectedSubjectTitle);

			foreach (var question in selectedSubject.Questions)
			{
				var correctAnswer = question.Choices.Find(x => x.IsCorrectAnswer);
				var falseAnswers = question.Choices.Where(x => !x.IsCorrectAnswer).ToArray();
				dgvQuestions.Rows.Add(false, question.Id, question.Text, correctAnswer?.Text, falseAnswers[0]?.Text, falseAnswers[1]?.Text, falseAnswers[2]?.Text);
			}
		}

		private void btnGenerateExams_Click(object sender, EventArgs e)
		{
			List<Guid> selectedQuestionsIds = new List<Guid>();
			foreach (DataGridViewRow question in dgvQuestions.Rows)
			{
				if ((bool)question.Cells[0].Value)
				{
					selectedQuestionsIds.Add((Guid)question.Cells[1].Value);
				}
			}
			var selectedQuestions = selectedQuestionsIds.Any()
				? currentlySelectedSubject.Questions.Where(x => selectedQuestionsIds.Contains(x.Id)).ToList()
				: currentlySelectedSubject.Questions.ToList();

			GenerateExamsModal generateExamsModal = new GenerateExamsModal(selectedQuestions, currentlySelectedSubject.Name);
			generateExamsModal.ShowDialog();


			// do something with the selected questions
		}
	}
}
