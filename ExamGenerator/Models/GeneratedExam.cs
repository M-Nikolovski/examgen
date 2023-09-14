using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamGenerator.Models
{
	public class GeneratedExam
	{
		public string Title { get; set; }
		public DateTime Date { get; set; }
		public List<Exam> Exams { get; set; }

		public GeneratedExam() { 
			Date = DateTime.Now;
			Exams = new List<Exam>();
		}

		public GeneratedExam(string title, List<Exam> exams)
		{
			Title = title;
			Date = DateTime.Now;
			Exams = exams;
		}

	}
}
