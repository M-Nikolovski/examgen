namespace ExamGenerator.Forms
{
	partial class SubjectsForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			panelMain = new Panel();
			btnDeleteQuestion = new FontAwesome.Sharp.IconButton();
			btnDeleteSubject = new FontAwesome.Sharp.IconButton();
			btnAddSubject = new FontAwesome.Sharp.IconButton();
			cmbSubjectPicker = new ComboBox();
			gboxQuestions = new GroupBox();
			dgvQuestions = new DataGridView();
			Checked = new DataGridViewCheckBoxColumn();
			QuestionId = new DataGridViewTextBoxColumn();
			QuestionText = new DataGridViewTextBoxColumn();
			CorrectAnswer = new DataGridViewTextBoxColumn();
			FalseAnswer1 = new DataGridViewTextBoxColumn();
			FalseAnswer2 = new DataGridViewTextBoxColumn();
			FalseAnswer3 = new DataGridViewTextBoxColumn();
			Save = new DataGridViewButtonColumn();
			Delete = new DataGridViewButtonColumn();
			btnAddQuestion = new FontAwesome.Sharp.IconButton();
			btnGenerateExams = new FontAwesome.Sharp.IconButton();
			panelMain.SuspendLayout();
			gboxQuestions.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvQuestions).BeginInit();
			SuspendLayout();
			// 
			// panelMain
			// 
			panelMain.Controls.Add(btnDeleteQuestion);
			panelMain.Controls.Add(btnDeleteSubject);
			panelMain.Controls.Add(btnAddSubject);
			panelMain.Controls.Add(cmbSubjectPicker);
			panelMain.Controls.Add(gboxQuestions);
			panelMain.Controls.Add(btnAddQuestion);
			panelMain.Controls.Add(btnGenerateExams);
			panelMain.Dock = DockStyle.Fill;
			panelMain.Location = new Point(0, 0);
			panelMain.Name = "panelMain";
			panelMain.Size = new Size(697, 492);
			panelMain.TabIndex = 0;
			// 
			// btnDeleteQuestion
			// 
			btnDeleteQuestion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			btnDeleteQuestion.BackColor = Color.FromArgb(69, 90, 100);
			btnDeleteQuestion.FlatAppearance.BorderSize = 0;
			btnDeleteQuestion.FlatStyle = FlatStyle.Flat;
			btnDeleteQuestion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			btnDeleteQuestion.ForeColor = Color.WhiteSmoke;
			btnDeleteQuestion.IconChar = FontAwesome.Sharp.IconChar.None;
			btnDeleteQuestion.IconColor = Color.Black;
			btnDeleteQuestion.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnDeleteQuestion.Location = new Point(148, 451);
			btnDeleteQuestion.Name = "btnDeleteQuestion";
			btnDeleteQuestion.Size = new Size(130, 29);
			btnDeleteQuestion.TabIndex = 6;
			btnDeleteQuestion.Tag = "Delete Question";
			btnDeleteQuestion.Text = "Delete Selected";
			btnDeleteQuestion.UseVisualStyleBackColor = false;
			// 
			// btnDeleteSubject
			// 
			btnDeleteSubject.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnDeleteSubject.BackColor = Color.FromArgb(69, 90, 100);
			btnDeleteSubject.FlatAppearance.BorderSize = 0;
			btnDeleteSubject.FlatStyle = FlatStyle.Flat;
			btnDeleteSubject.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			btnDeleteSubject.ForeColor = Color.WhiteSmoke;
			btnDeleteSubject.IconChar = FontAwesome.Sharp.IconChar.None;
			btnDeleteSubject.IconColor = Color.Black;
			btnDeleteSubject.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnDeleteSubject.Location = new Point(555, 12);
			btnDeleteSubject.Name = "btnDeleteSubject";
			btnDeleteSubject.Size = new Size(130, 29);
			btnDeleteSubject.TabIndex = 5;
			btnDeleteSubject.Tag = "Delete Subject";
			btnDeleteSubject.Text = "Delete Subject";
			btnDeleteSubject.UseVisualStyleBackColor = false;
			// 
			// btnAddSubject
			// 
			btnAddSubject.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnAddSubject.BackColor = Color.FromArgb(69, 90, 100);
			btnAddSubject.FlatAppearance.BorderSize = 0;
			btnAddSubject.FlatStyle = FlatStyle.Flat;
			btnAddSubject.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			btnAddSubject.ForeColor = Color.WhiteSmoke;
			btnAddSubject.IconChar = FontAwesome.Sharp.IconChar.None;
			btnAddSubject.IconColor = Color.Black;
			btnAddSubject.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnAddSubject.Location = new Point(419, 12);
			btnAddSubject.Name = "btnAddSubject";
			btnAddSubject.Size = new Size(130, 29);
			btnAddSubject.TabIndex = 4;
			btnAddSubject.Tag = "Add Subject";
			btnAddSubject.Text = "Add Subject";
			btnAddSubject.UseVisualStyleBackColor = false;
			// 
			// cmbSubjectPicker
			// 
			cmbSubjectPicker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			cmbSubjectPicker.FlatStyle = FlatStyle.Flat;
			cmbSubjectPicker.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			cmbSubjectPicker.FormattingEnabled = true;
			cmbSubjectPicker.ItemHeight = 21;
			cmbSubjectPicker.Location = new Point(12, 12);
			cmbSubjectPicker.Name = "cmbSubjectPicker";
			cmbSubjectPicker.Size = new Size(401, 29);
			cmbSubjectPicker.TabIndex = 3;
			cmbSubjectPicker.SelectedIndexChanged += cmbSubjectPicker_SelectedIndexChanged;
			cmbSubjectPicker.TextChanged += cmbSubjectPicker_TextChanged;
			cmbSubjectPicker.Click += cmbSubjectPicker_Click;
			// 
			// gboxQuestions
			// 
			gboxQuestions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			gboxQuestions.Controls.Add(dgvQuestions);
			gboxQuestions.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			gboxQuestions.Location = new Point(12, 47);
			gboxQuestions.Name = "gboxQuestions";
			gboxQuestions.Size = new Size(673, 397);
			gboxQuestions.TabIndex = 2;
			gboxQuestions.TabStop = false;
			gboxQuestions.Tag = "Questions";
			gboxQuestions.Text = "Questions";
			// 
			// dgvQuestions
			// 
			dgvQuestions.AllowUserToAddRows = false;
			dgvQuestions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvQuestions.Columns.AddRange(new DataGridViewColumn[] { Checked, QuestionId, QuestionText, CorrectAnswer, FalseAnswer1, FalseAnswer2, FalseAnswer3, Save, Delete });
			dgvQuestions.Dock = DockStyle.Fill;
			dgvQuestions.Location = new Point(3, 25);
			dgvQuestions.Name = "dgvQuestions";
			dgvQuestions.RowTemplate.Height = 25;
			dgvQuestions.Size = new Size(667, 369);
			dgvQuestions.TabIndex = 0;
			// 
			// Checked
			// 
			Checked.FlatStyle = FlatStyle.Flat;
			Checked.HeaderText = "";
			Checked.Name = "Checked";
			Checked.Width = 20;
			// 
			// QuestionId
			// 
			QuestionId.HeaderText = "QuestionId";
			QuestionId.Name = "QuestionId";
			QuestionId.Visible = false;
			// 
			// QuestionText
			// 
			QuestionText.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			QuestionText.HeaderText = "Question Text";
			QuestionText.MinimumWidth = 150;
			QuestionText.Name = "QuestionText";
			// 
			// CorrectAnswer
			// 
			dataGridViewCellStyle1.BackColor = Color.FromArgb(178, 223, 219);
			dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 121, 107);
			CorrectAnswer.DefaultCellStyle = dataGridViewCellStyle1;
			CorrectAnswer.HeaderText = "Correct Answer";
			CorrectAnswer.Name = "CorrectAnswer";
			CorrectAnswer.Width = 150;
			// 
			// FalseAnswer1
			// 
			FalseAnswer1.HeaderText = "False Answer";
			FalseAnswer1.Name = "FalseAnswer1";
			FalseAnswer1.Width = 150;
			// 
			// FalseAnswer2
			// 
			FalseAnswer2.HeaderText = "False Answer";
			FalseAnswer2.Name = "FalseAnswer2";
			FalseAnswer2.Width = 150;
			// 
			// FalseAnswer3
			// 
			FalseAnswer3.HeaderText = "False Answer";
			FalseAnswer3.Name = "FalseAnswer3";
			FalseAnswer3.Width = 150;
			// 
			// Save
			// 
			Save.FlatStyle = FlatStyle.Flat;
			Save.HeaderText = "";
			Save.MinimumWidth = 30;
			Save.Name = "Save";
			Save.Text = "💾";
			Save.ToolTipText = "Saves/updates the question";
			Save.UseColumnTextForButtonValue = true;
			Save.Width = 30;
			// 
			// Delete
			// 
			Delete.FlatStyle = FlatStyle.Flat;
			Delete.HeaderText = "";
			Delete.MinimumWidth = 30;
			Delete.Name = "Delete";
			Delete.Text = "❌";
			Delete.ToolTipText = "Deletes the question";
			Delete.UseColumnTextForButtonValue = true;
			Delete.Width = 30;
			// 
			// btnAddQuestion
			// 
			btnAddQuestion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			btnAddQuestion.BackColor = Color.FromArgb(69, 90, 100);
			btnAddQuestion.FlatAppearance.BorderSize = 0;
			btnAddQuestion.FlatStyle = FlatStyle.Flat;
			btnAddQuestion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			btnAddQuestion.ForeColor = Color.WhiteSmoke;
			btnAddQuestion.IconChar = FontAwesome.Sharp.IconChar.None;
			btnAddQuestion.IconColor = Color.Black;
			btnAddQuestion.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnAddQuestion.Location = new Point(12, 451);
			btnAddQuestion.Name = "btnAddQuestion";
			btnAddQuestion.Size = new Size(130, 29);
			btnAddQuestion.TabIndex = 1;
			btnAddQuestion.Tag = "Add Question";
			btnAddQuestion.Text = "Add Question";
			btnAddQuestion.UseVisualStyleBackColor = false;
			// 
			// btnGenerateExams
			// 
			btnGenerateExams.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnGenerateExams.BackColor = Color.FromArgb(69, 90, 100);
			btnGenerateExams.FlatAppearance.BorderSize = 0;
			btnGenerateExams.FlatStyle = FlatStyle.Flat;
			btnGenerateExams.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			btnGenerateExams.ForeColor = Color.WhiteSmoke;
			btnGenerateExams.IconChar = FontAwesome.Sharp.IconChar.None;
			btnGenerateExams.IconColor = Color.Black;
			btnGenerateExams.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnGenerateExams.Location = new Point(555, 451);
			btnGenerateExams.Name = "btnGenerateExams";
			btnGenerateExams.Size = new Size(130, 29);
			btnGenerateExams.TabIndex = 0;
			btnGenerateExams.Tag = "Generate Exams";
			btnGenerateExams.Text = "Generate Exams";
			btnGenerateExams.UseVisualStyleBackColor = false;
			btnGenerateExams.Click += btnGenerateExams_Click;
			// 
			// SubjectsForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(144, 164, 174);
			ClientSize = new Size(697, 492);
			Controls.Add(panelMain);
			Name = "SubjectsForm";
			Text = "SubjectsForm";
			panelMain.ResumeLayout(false);
			gboxQuestions.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvQuestions).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panelMain;
		private FontAwesome.Sharp.IconButton btnAddQuestion;
		private FontAwesome.Sharp.IconButton btnGenerateExams;
		private ComboBox cmbSubjectPicker;
		private GroupBox gboxQuestions;
		private FontAwesome.Sharp.IconButton btnAddSubject;
		private FontAwesome.Sharp.IconButton btnDeleteSubject;
		private FontAwesome.Sharp.IconButton btnDeleteQuestion;
		private DataGridView dgvQuestions;
		private DataGridViewCheckBoxColumn Checked;
		private DataGridViewTextBoxColumn QuestionId;
		private DataGridViewTextBoxColumn QuestionText;
		private DataGridViewTextBoxColumn CorrectAnswer;
		private DataGridViewTextBoxColumn FalseAnswer1;
		private DataGridViewTextBoxColumn FalseAnswer2;
		private DataGridViewTextBoxColumn FalseAnswer3;
		private DataGridViewButtonColumn Save;
		private DataGridViewButtonColumn Delete;
	}
}