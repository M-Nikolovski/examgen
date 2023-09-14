namespace ExamGenerator.Dialogs
{
	partial class GenerateExamsModal
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
			label1 = new Label();
			lblNumberOfExams = new Label();
			label2 = new Label();
			label3 = new Label();
			btnGenerate = new FontAwesome.Sharp.IconButton();
			btnCancel = new FontAwesome.Sharp.IconButton();
			chkRandomizeAnswers = new CheckBox();
			nmbNumberOfExams = new NumericUpDown();
			txtExamTitle = new TextBox();
			((System.ComponentModel.ISupportInitialize)nmbNumberOfExams).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.FromArgb(38, 50, 56);
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(310, 25);
			label1.TabIndex = 0;
			label1.Text = "Please provide the following info:";
			// 
			// lblNumberOfExams
			// 
			lblNumberOfExams.AutoSize = true;
			lblNumberOfExams.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblNumberOfExams.ForeColor = Color.FromArgb(38, 50, 56);
			lblNumberOfExams.Location = new Point(21, 95);
			lblNumberOfExams.Name = "lblNumberOfExams";
			lblNumberOfExams.Size = new Size(250, 21);
			lblNumberOfExams.TabIndex = 1;
			lblNumberOfExams.Text = "Number of exams to be generated:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label2.ForeColor = Color.FromArgb(38, 50, 56);
			label2.Location = new Point(21, 124);
			label2.Name = "label2";
			label2.Size = new Size(264, 21);
			label2.TabIndex = 2;
			label2.Text = "Randomize the order of the answers:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label3.ForeColor = Color.FromArgb(38, 50, 56);
			label3.Location = new Point(21, 68);
			label3.Name = "label3";
			label3.Size = new Size(127, 21);
			label3.TabIndex = 3;
			label3.Text = "Title of the exam:";
			// 
			// btnGenerate
			// 
			btnGenerate.BackColor = Color.FromArgb(69, 90, 100);
			btnGenerate.FlatAppearance.BorderSize = 0;
			btnGenerate.FlatStyle = FlatStyle.Flat;
			btnGenerate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			btnGenerate.ForeColor = Color.WhiteSmoke;
			btnGenerate.IconChar = FontAwesome.Sharp.IconChar.None;
			btnGenerate.IconColor = Color.Black;
			btnGenerate.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnGenerate.Location = new Point(467, 207);
			btnGenerate.Name = "btnGenerate";
			btnGenerate.Size = new Size(130, 29);
			btnGenerate.TabIndex = 4;
			btnGenerate.Text = "Generate";
			btnGenerate.UseVisualStyleBackColor = false;
			btnGenerate.Click += btnGenerate_Click;
			// 
			// btnCancel
			// 
			btnCancel.BackColor = Color.FromArgb(69, 90, 100);
			btnCancel.FlatAppearance.BorderSize = 0;
			btnCancel.FlatStyle = FlatStyle.Flat;
			btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			btnCancel.ForeColor = Color.WhiteSmoke;
			btnCancel.IconChar = FontAwesome.Sharp.IconChar.None;
			btnCancel.IconColor = Color.Black;
			btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnCancel.Location = new Point(331, 207);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(130, 29);
			btnCancel.TabIndex = 5;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = false;
			btnCancel.Click += btnCancel_Click;
			// 
			// chkRandomizeAnswers
			// 
			chkRandomizeAnswers.AutoSize = true;
			chkRandomizeAnswers.FlatAppearance.BorderColor = Color.FromArgb(38, 50, 56);
			chkRandomizeAnswers.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			chkRandomizeAnswers.ForeColor = Color.FromArgb(38, 50, 56);
			chkRandomizeAnswers.Location = new Point(302, 130);
			chkRandomizeAnswers.Name = "chkRandomizeAnswers";
			chkRandomizeAnswers.Size = new Size(15, 14);
			chkRandomizeAnswers.TabIndex = 6;
			chkRandomizeAnswers.Tag = "chkRandomize";
			chkRandomizeAnswers.UseVisualStyleBackColor = true;
			// 
			// nmbNumberOfExams
			// 
			nmbNumberOfExams.ForeColor = Color.FromArgb(38, 50, 56);
			nmbNumberOfExams.Location = new Point(302, 93);
			nmbNumberOfExams.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
			nmbNumberOfExams.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			nmbNumberOfExams.Name = "nmbNumberOfExams";
			nmbNumberOfExams.Size = new Size(295, 23);
			nmbNumberOfExams.TabIndex = 7;
			nmbNumberOfExams.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// txtExamTitle
			// 
			txtExamTitle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			txtExamTitle.ForeColor = Color.FromArgb(38, 50, 56);
			txtExamTitle.Location = new Point(302, 64);
			txtExamTitle.Name = "txtExamTitle";
			txtExamTitle.Size = new Size(295, 25);
			txtExamTitle.TabIndex = 8;
			// 
			// GenerateExamsModal
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(144, 164, 174);
			ClientSize = new Size(617, 248);
			Controls.Add(txtExamTitle);
			Controls.Add(nmbNumberOfExams);
			Controls.Add(chkRandomizeAnswers);
			Controls.Add(btnCancel);
			Controls.Add(btnGenerate);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(lblNumberOfExams);
			Controls.Add(label1);
			Name = "GenerateExamsModal";
			Text = "GenerateExamsModal";
			((System.ComponentModel.ISupportInitialize)nmbNumberOfExams).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label lblNumberOfExams;
		private Label label2;
		private Label label3;
		private FontAwesome.Sharp.IconButton btnGenerate;
		private FontAwesome.Sharp.IconButton btnCancel;
		private CheckBox chkRandomizeAnswers;
		private NumericUpDown nmbNumberOfExams;
		private TextBox txtExamTitle;
	}
}