using ExamGenerator.Forms;
using ExamGenerator.Models;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace ExamGenerator
{
	public partial class Form1 : Form
	{
		// Fields
		private int borderSize = 1;
		private Size formSize; // Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders

		// Colors
		private Color DARKEST_GREY = Color.FromArgb(38, 50, 56);
		private Color DARK_GREY = Color.FromArgb(69, 90, 100);

		// Constructor
		public Form1()
		{
			InitializeComponent();

			#region Border

			this.Padding = new Padding(borderSize); // Border size
			this.BackColor = DARKEST_GREY; // Border color

			#endregion Border

			#region Remove menu buttons hover effect

			//btnSubjects.FlatAppearance.MouseOverBackColor = btnSubjects.BackColor;
			//btnSubjects.BackColorChanged += (s, e) =>
			//{
			//	btnSubjects.FlatAppearance.MouseOverBackColor = btnSubjects.BackColor;
			//};

			//btnTools.FlatAppearance.MouseOverBackColor = btnTools.BackColor;
			//btnTools.BackColorChanged += (s, e) =>
			//{
			//	btnTools.FlatAppearance.MouseOverBackColor = btnTools.BackColor;
			//};

			//btnStats.FlatAppearance.MouseOverBackColor = btnStats.BackColor;
			//btnStats.BackColorChanged += (s, e) =>
			//{
			//	btnStats.FlatAppearance.MouseOverBackColor = btnStats.BackColor;
			//};

			//btnSettings.FlatAppearance.MouseOverBackColor = btnSettings.BackColor;
			//btnSettings.BackColorChanged += (s, e) =>
			//{
			//	btnSettings.FlatAppearance.MouseOverBackColor = btnSettings.BackColor;
			//};

			//btnLogOut.FlatAppearance.MouseOverBackColor = btnLogOut.BackColor;
			//btnLogOut.BackColorChanged += (s, e) =>
			//{
			//	btnLogOut.FlatAppearance.MouseOverBackColor = btnLogOut.BackColor;
			//};

			btnMenu.FlatAppearance.MouseOverBackColor = btnMenu.BackColor;
			btnMenu.BackColorChanged += (s, e) =>
			{
				btnMenu.FlatAppearance.MouseOverBackColor = btnMenu.BackColor;
			};

			#endregion Remove menu buttons hover effect

			#region Remove menu buttons click effect

			btnSubjects.FlatAppearance.MouseDownBackColor = btnSubjects.BackColor;
			btnSubjects.BackColorChanged += (s, e) =>
			{
				btnSubjects.FlatAppearance.MouseDownBackColor = btnSubjects.BackColor;
			};

			btnTools.FlatAppearance.MouseDownBackColor = btnTools.BackColor;
			btnTools.BackColorChanged += (s, e) =>
			{
				btnTools.FlatAppearance.MouseDownBackColor = btnTools.BackColor;
			};

			btnStats.FlatAppearance.MouseDownBackColor = btnStats.BackColor;
			btnStats.BackColorChanged += (s, e) =>
			{
				btnStats.FlatAppearance.MouseDownBackColor = btnStats.BackColor;
			};

			btnSettings.FlatAppearance.MouseDownBackColor = btnSettings.BackColor;
			btnSettings.BackColorChanged += (s, e) =>
			{
				btnSettings.FlatAppearance.MouseDownBackColor = btnSettings.BackColor;
			};

			btnLogOut.FlatAppearance.MouseDownBackColor = btnLogOut.BackColor;
			btnLogOut.BackColorChanged += (s, e) =>
			{
				btnLogOut.FlatAppearance.MouseDownBackColor = btnLogOut.BackColor;
			};

			btnMenu.FlatAppearance.MouseDownBackColor = btnMenu.BackColor;
			btnMenu.BackColorChanged += (s, e) =>
			{
				btnMenu.FlatAppearance.MouseDownBackColor = btnMenu.BackColor;
			};

			#endregion Remove menu buttons click effect

			#region Initialize data from db

			#region Maths

			Subject subjectMaths = new Subject(Guid.NewGuid(), "Maths", "", new List<Question>());

			Question q1 = new Question(Guid.NewGuid(), "What is the result of the following expression: 2 + 3 ?", new List<Choice>(), subjectMaths.Id);
			Question q2 = new Question(Guid.NewGuid(), "What is the result of the following expression: 5 * 8 ?", new List<Choice>(), subjectMaths.Id);
			Question q3 = new Question(Guid.NewGuid(), "What is the result of the following expression: 123 - 45 ?", new List<Choice>(), subjectMaths.Id);
			Question q4 = new Question(Guid.NewGuid(), "What is the result of the following expression: 154 / 7 ?", new List<Choice>(), subjectMaths.Id);
			Question q5 = new Question(Guid.NewGuid(), "What do we use for calculating the hypotenuse of a right triangle?", new List<Choice>(), subjectMaths.Id);
			Question q6 = new Question(Guid.NewGuid(), "What is the square root of 144?", new List<Choice>(), subjectMaths.Id);
			Question q7 = new Question(Guid.NewGuid(), "What is the square root of 361?", new List<Choice>(), subjectMaths.Id);
			Question q8 = new Question(Guid.NewGuid(), "What is 2 to the power of 9?", new List<Choice>(), subjectMaths.Id);
			Question q9 = new Question(Guid.NewGuid(), "Calculate x if 2x + y = 31 and y - x = 4", new List<Choice>(), subjectMaths.Id);
			Question q10 = new Question(Guid.NewGuid(), "Calculate x if y/x = 2 and y * 2x = 36", new List<Choice>(), subjectMaths.Id);

			List<Choice> choicesQ1 = new List<Choice>
			{
				new Choice(Guid.NewGuid(), "8", false, q1.Id),
				new Choice(Guid.NewGuid(), "5", true, q1.Id),
				new Choice(Guid.NewGuid(), "-1", false, q1.Id),
				new Choice(Guid.NewGuid(), "1", false, q1.Id)
			};
			List<Choice> choicesQ2 = new List<Choice>
			{
				new Choice(Guid.NewGuid(), "13", false, q2.Id),
				new Choice(Guid.NewGuid(), "18", false, q2.Id),
				new Choice(Guid.NewGuid(), "40", true, q2.Id),
				new Choice(Guid.NewGuid(), "0", false, q2.Id)
			};
			List<Choice> choicesQ3 = new List<Choice>
			{
				new Choice(Guid.NewGuid(), "69", false, q3.Id),
				new Choice(Guid.NewGuid(), "78", true, q3.Id),
				new Choice(Guid.NewGuid(), "89", false, q3.Id),
				new Choice(Guid.NewGuid(), "81", false, q3.Id)
			};
			List<Choice> choicesQ4 = new List<Choice>
			{
				new Choice(Guid.NewGuid(), "Cannot be calulated", false, q4.Id),
				new Choice(Guid.NewGuid(), "22", true, q4.Id),
				new Choice(Guid.NewGuid(), "24", false, q4.Id),
				new Choice(Guid.NewGuid(), "Not a natural number", false, q4.Id)
			};
			List<Choice> choicesQ5 = new List<Choice>
			{
				new Choice(Guid.NewGuid(), "Calculator", false, q5.Id),
				new Choice(Guid.NewGuid(), "Computer", false, q5.Id),
				new Choice(Guid.NewGuid(), "Newton's first law", false, q5.Id),
				new Choice(Guid.NewGuid(), "Pythagorean Theorem", true, q5.Id)
			};
			List<Choice> choicesQ6 = new List<Choice>
			{
				new Choice(Guid.NewGuid(), "12", true, q6.Id),
				new Choice(Guid.NewGuid(), "2", false, q6.Id),
				new Choice(Guid.NewGuid(), "11", false, q6.Id),
				new Choice(Guid.NewGuid(), "14", false, q6.Id)
			};
			List<Choice> choicesQ7 = new List<Choice>
			{
				new Choice(Guid.NewGuid(), "18", false, q7.Id),
				new Choice(Guid.NewGuid(), "19", true, q7.Id),
				new Choice(Guid.NewGuid(), "17", false, q7.Id),
				new Choice(Guid.NewGuid(), "16", false, q7.Id)
			};
			List<Choice> choicesQ8 = new List<Choice>
			{
				new Choice(Guid.NewGuid(), "1024", false, q8.Id),
				new Choice(Guid.NewGuid(), "512", true, q8.Id),
				new Choice(Guid.NewGuid(), "256", false, q8.Id),
				new Choice(Guid.NewGuid(), "2048", false, q8.Id)
			};
			List<Choice> choicesQ9 = new List<Choice>
			{
				new Choice(Guid.NewGuid(), "7", false, q9.Id),
				new Choice(Guid.NewGuid(), "Cannot be calculated", false, q9.Id),
				new Choice(Guid.NewGuid(), "9", true, q9.Id),
				new Choice(Guid.NewGuid(), "Can be any of the above", false, q9.Id)
			};
			List<Choice> choicesQ10 = new List<Choice>
			{
				new Choice(Guid.NewGuid(), "2", false, q10.Id),
				new Choice(Guid.NewGuid(), "4", false, q10.Id),
				new Choice(Guid.NewGuid(), "3", true, q10.Id),
				new Choice(Guid.NewGuid(), "6", false, q10.Id)
			};

			q1.Choices = choicesQ1;
			q2.Choices = choicesQ2;
			q3.Choices = choicesQ3;
			q4.Choices = choicesQ4;
			q5.Choices = choicesQ5;
			q6.Choices = choicesQ6;
			q7.Choices = choicesQ7;
			q8.Choices = choicesQ8;
			q9.Choices = choicesQ9;
			q10.Choices = choicesQ10;

			List<Question> mathsQuestions = new List<Question>
			{
				q1, q2, q3, q4, q5, q6, q7, q8, q9, q10
			};

			subjectMaths.Questions = mathsQuestions;

			List<Choice> allChoicesForMaths = new List<Choice>();
			allChoicesForMaths.AddRange(choicesQ1);
			allChoicesForMaths.AddRange(choicesQ2);
			allChoicesForMaths.AddRange(choicesQ3);
			allChoicesForMaths.AddRange(choicesQ4);
			allChoicesForMaths.AddRange(choicesQ5);
			allChoicesForMaths.AddRange(choicesQ6);
			allChoicesForMaths.AddRange(choicesQ7);
			allChoicesForMaths.AddRange(choicesQ8);
			allChoicesForMaths.AddRange(choicesQ9);
			allChoicesForMaths.AddRange(choicesQ10);

			#endregion Maths

			#region Computer Science

			Subject subjectComputerScience = new Subject(Guid.NewGuid(), "Computer Science", "", new List<Question>());

			Question qCs1 = new Question(Guid.NewGuid(), "What numbers are all of the calculations in a computer based on?", new List<Choice>(), subjectComputerScience.Id);
			Question qCs2 = new Question(Guid.NewGuid(), "What does WWW mean?", new List<Choice>(), subjectComputerScience.Id);
			Question qCs3 = new Question(Guid.NewGuid(), "Which one of these is used for styling web pages?", new List<Choice>(), subjectComputerScience.Id);
			Question qCs4 = new Question(Guid.NewGuid(), "Which one of these is not a programming language?", new List<Choice>(), subjectComputerScience.Id);
			Question qCs5 = new Question(Guid.NewGuid(), "Which one of these is a programming language?", new List<Choice>(), subjectComputerScience.Id);
			Question qCs6 = new Question(Guid.NewGuid(), "Which one of these is not a computer component?", new List<Choice>(), subjectComputerScience.Id);
			Question qCs7 = new Question(Guid.NewGuid(), "What is a CPU", new List<Choice>(), subjectComputerScience.Id);

			List<Choice> choicesQCs1 = new List<Choice>
			{
				new Choice(Guid.NewGuid(), "Decimal", false, qCs1.Id),
				new Choice(Guid.NewGuid(), "Binary", true, qCs1.Id),
				new Choice(Guid.NewGuid(), "Hexadecimal", false, qCs1.Id),
				new Choice(Guid.NewGuid(), "None of the above", false, qCs1.Id)
			};
			List<Choice> choicesQCs2 = new List<Choice>
			{
				new Choice(Guid.NewGuid(), "World Wide Websites", false, qCs2.Id),
				new Choice(Guid.NewGuid(), "World Wide Wings", false, qCs2.Id),
				new Choice(Guid.NewGuid(), "World Wide Web", true, qCs2.Id),
				new Choice(Guid.NewGuid(), "World Wide Watch", false, qCs2.Id)
			};
			List<Choice> choicesQCs3 = new List<Choice>
			{
				new Choice(Guid.NewGuid(), "HTML", false, qCs3.Id),
				new Choice(Guid.NewGuid(), "CSS", true, qCs3.Id),
				new Choice(Guid.NewGuid(), "Java", false, qCs3.Id),
				new Choice(Guid.NewGuid(), "JavaScript", false, qCs3.Id)
			};
			List<Choice> choicesQCs4 = new List<Choice>
			{
				new Choice(Guid.NewGuid(), "Java", false, qCs4.Id),
				new Choice(Guid.NewGuid(), "HTML", true, qCs4.Id),
				new Choice(Guid.NewGuid(), "Python", false, qCs4.Id),
				new Choice(Guid.NewGuid(), "C#", false, qCs4.Id)
			};
			List<Choice> choicesQCs5 = new List<Choice>
			{
				new Choice(Guid.NewGuid(), "CSS", false, q5.Id),
				new Choice(Guid.NewGuid(), "SQL", false, q5.Id),
				new Choice(Guid.NewGuid(), ".NET", false, q5.Id),
				new Choice(Guid.NewGuid(), "C++", true, q5.Id)
			};
			List<Choice> choicesQCs6 = new List<Choice>
			{
				new Choice(Guid.NewGuid(), "DPU", true, q6.Id),
				new Choice(Guid.NewGuid(), "CPU", false, q6.Id),
				new Choice(Guid.NewGuid(), "RAM", false, q6.Id),
				new Choice(Guid.NewGuid(), "GPU", false, q6.Id)
			};
			List<Choice> choicesQCs7 = new List<Choice>
			{
				new Choice(Guid.NewGuid(), "Control Processing Unit", false, q7.Id),
				new Choice(Guid.NewGuid(), "Central Processing Unit", true, q7.Id),
				new Choice(Guid.NewGuid(), "Computer Processing Unit", false, q7.Id),
				new Choice(Guid.NewGuid(), "Computer Principle Unit", false, q7.Id)
			};

			qCs1.Choices = choicesQCs1;
			qCs2.Choices = choicesQCs2;
			qCs3.Choices = choicesQCs3;
			qCs4.Choices = choicesQCs4;
			qCs5.Choices = choicesQCs5;
			qCs6.Choices = choicesQCs6;
			qCs7.Choices = choicesQCs7;

			List<Question> computerScienceQuestions = new List<Question>
			{
				qCs1, qCs2, qCs3, qCs4, qCs5, qCs6, qCs7
			};

			subjectComputerScience.Questions = computerScienceQuestions;

			List<Choice> allChoicesForComputerScience = new List<Choice>();
			allChoicesForComputerScience.AddRange(choicesQCs1);
			allChoicesForComputerScience.AddRange(choicesQCs2);
			allChoicesForComputerScience.AddRange(choicesQCs3);
			allChoicesForComputerScience.AddRange(choicesQCs4);
			allChoicesForComputerScience.AddRange(choicesQCs5);
			allChoicesForComputerScience.AddRange(choicesQCs6);
			allChoicesForComputerScience.AddRange(choicesQCs7);

			#endregion Computer Science

			#region English Language

			Subject subjectEnglishLanguage = new Subject(Guid.NewGuid(), "English Language", "", new List<Question>());

			#endregion Computer Science

			List<Subject> listOfAllSubjects = new List<Subject> {
				subjectMaths, subjectComputerScience, subjectEnglishLanguage
			};

			List<Question> listOfAllQuestions = new List<Question>();
			listOfAllQuestions.AddRange(mathsQuestions);
			listOfAllQuestions.AddRange(computerScienceQuestions);

			List<Choice> listOfAllChoices = new List<Choice>();
			listOfAllChoices.AddRange(allChoicesForMaths);
			listOfAllChoices.AddRange(allChoicesForComputerScience);

			#region Save initial data to db

			XmlSerializer serializerSubjects = new XmlSerializer(typeof(List<Subject>));
			using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\subjects.xml", FileMode.Create, FileAccess.Write))
			{
				serializerSubjects.Serialize(fs, listOfAllSubjects);
			}

			XmlSerializer serializerQuestions = new XmlSerializer(typeof(List<Question>));
			using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\questions.xml", FileMode.Create, FileAccess.Write))
			{
				serializerQuestions.Serialize(fs, listOfAllQuestions);
			}

			XmlSerializer serializerChoices = new XmlSerializer(typeof(List<Choice>));
			using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\choices.xml", FileMode.Create, FileAccess.Write))
			{
				serializerChoices.Serialize(fs, listOfAllChoices);
			}

			#endregion Save initial data to db

			#endregion Initialize data from db
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			formSize = this.ClientSize;
		}

		//Drag Form
		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();

		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

		private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		// Overridden methods
		protected override void WndProc(ref Message m)
		{
			const int WM_NCCALCSIZE = 0x0083;// Standard Title Bar - Snap Window
			const int WM_SYSCOMMAND = 0x0112;
			const int SC_MINIMIZE = 0xF020; // Minimize form (Before)
			const int SC_RESTORE = 0xF120; // Restore form (Before)
			const int WM_NCHITTEST = 0x0084;// Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
			const int resizeAreaSize = 10;

			#region Form Resize
			// Resize /WM_NCHITTEST values
			const int HTCLIENT = 1; // Represents the client area of the window
			const int HTLEFT = 10;  // Left border of a window, allows resize horizontally to the left
			const int HTRIGHT = 11; // Right border of a window, allows resize horizontally to the right
			const int HTTOP = 12;   // Upper-horizontal border of a window, allows resize vertically up
			const int HTTOPLEFT = 13; // Upper-left corner of a window border, allows resize diagonally to the left
			const int HTTOPRIGHT = 14; // Upper-right corner of a window border, allows resize diagonally to the right
			const int HTBOTTOM = 15; // Lower-horizontal border of a window, allows resize vertically down
			const int HTBOTTOMLEFT = 16; // Lower-left corner of a window border, allows resize diagonally to the left
			const int HTBOTTOMRIGHT = 17; // Lower-right corner of a window border, allows resize diagonally to the right

			if (m.Msg == WM_NCHITTEST)
			{ // If the windows m is WM_NCHITTEST
				base.WndProc(ref m);
				if (this.WindowState == FormWindowState.Normal && (int)m.Result == HTCLIENT) // Resize the form if it is in normal state
				{
					Point screenPoint = new Point(m.LParam.ToInt32()); // Gets screen point coordinates(X and Y coordinate of the pointer)                           
					Point clientPoint = this.PointToClient(screenPoint); // Computes the location of the screen point into client coordinates                          
					if (clientPoint.Y <= resizeAreaSize) // If the pointer is at the top of the form (within the resize area- X coordinate)
					{
						if (clientPoint.X <= resizeAreaSize) // If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
							m.Result = (IntPtr)HTTOPLEFT;  // Resize diagonally to the left
						else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) // If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
							m.Result = (IntPtr)HTTOP;  // Resize vertically up
						else // Resize diagonally to the right
							m.Result = (IntPtr)HTTOPRIGHT;
					}
					else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) // If the pointer is inside the form at the Y coordinate(discounting the resize area size)
					{
						if (clientPoint.X <= resizeAreaSize) // Resize horizontally to the left
							m.Result = (IntPtr)HTLEFT;
						else if (clientPoint.X > (this.Width - resizeAreaSize)) // Resize horizontally to the right
							m.Result = (IntPtr)HTRIGHT;
					}
					else
					{
						if (clientPoint.X <= resizeAreaSize) // Resize diagonally to the left
							m.Result = (IntPtr)HTBOTTOMLEFT;
						else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) // Resize vertically down
							m.Result = (IntPtr)HTBOTTOM;
						else // Resize diagonally to the right
							m.Result = (IntPtr)HTBOTTOMRIGHT;
					}
				}
				return;
			}
			#endregion
			// Remove border and keep snap window
			if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
			{
				return;
			}
			// Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
			if (m.Msg == WM_SYSCOMMAND)
			{
				/// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
				/// Quote:
				/// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
				/// are used internally by the system.To obtain the correct result when testing 
				/// the value of wParam, an application must combine the value 0xFFF0 with the 
				/// wParam value by using the bitwise AND operator.
				int wParam = (m.WParam.ToInt32() & 0xFFF0);
				if (wParam == SC_MINIMIZE) // Before
					formSize = this.ClientSize;
				if (wParam == SC_RESTORE) // Restored form (Before)
					this.Size = formSize;
			}
			base.WndProc(ref m);
		}

		//Event methods
		private void Form1_Resize(object sender, EventArgs e)
		{
			AdjustForm();
		}

		private void btnMenu_Click(object sender, EventArgs e)
		{
			CollapseMenu();
		}

		private void btnMinimize_Click(object sender, EventArgs e)
		{
			formSize = this.ClientSize;
			this.WindowState = FormWindowState.Minimized;
		}

		private void btnMaximize_Click(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Normal)
			{
				formSize = this.ClientSize;
				this.WindowState = FormWindowState.Maximized;
			}
			else
			{
				this.WindowState = FormWindowState.Normal;
				this.Size = formSize;
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Private methods
		private void AdjustForm()
		{
			switch (this.WindowState)
			{
				case FormWindowState.Maximized: //Maximized form (After)
					this.Padding = new Padding(8, 8, 8, 0);
					break;
				case FormWindowState.Normal: //Restored form (After)
					if (this.Padding.Top != borderSize)
						this.Padding = new Padding(borderSize);
					break;
			}
		}

		private void CollapseMenu()
		{
			var collapsedMenuSize = 60;

			if (this.panelMenu.Width > collapsedMenuSize) // Collapse menu
			{
				panelChildForm.Width += panelMenu.Width - collapsedMenuSize;
				panelMenu.Width = collapsedMenuSize;
				pbxLogo.Visible = false;
				btnMenu.Dock = DockStyle.Top;
				foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
				{
					menuButton.Text = "";
					menuButton.ImageAlign = ContentAlignment.MiddleCenter;
					menuButton.Padding = new Padding(0);
				}
				btnMenu.ImageAlign = ContentAlignment.BottomCenter;
			}
			else
			{ // Expand menu
				panelChildForm.Width -= panelMenu.Width - collapsedMenuSize;
				panelMenu.Width = 201;
				pbxLogo.Visible = true;
				btnMenu.Dock = DockStyle.None;
				foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
				{
					menuButton.Text = "  " + menuButton.Tag.ToString();
					menuButton.ImageAlign = ContentAlignment.MiddleLeft;
					menuButton.Padding = new Padding(5, 0, 0, 0);
				}
				btnMenu.ImageAlign = ContentAlignment.BottomCenter;
			}
		}

		#region Menu buttons actions

		private void btnSubjects_Click(object sender, EventArgs e)
		{
			btnSubjects.BackColor = DARK_GREY;
			openChildForm(new SubjectsForm());
		}

		private void btnTools_Click(object sender, EventArgs e)
		{
			btnTools.BackColor = DARK_GREY;
		}

		private void btnStats_Click(object sender, EventArgs e)
		{
			btnStats.BackColor = DARK_GREY;
		}

		private void btnSettings_Click(object sender, EventArgs e)
		{
			btnSettings.BackColor = DARK_GREY;
		}

		private void btnSubjects_Leave(object sender, EventArgs e)
		{
			btnSubjects.BackColor = DARKEST_GREY;
		}

		private void btnTools_Leave(object sender, EventArgs e)
		{
			btnTools.BackColor = DARKEST_GREY;
		}

		private void btnStats_Leave(object sender, EventArgs e)
		{
			btnStats.BackColor = DARKEST_GREY;
		}

		private void btnSettings_Leave(object sender, EventArgs e)
		{
			btnSettings.BackColor = DARKEST_GREY;
		}

		#endregion Menu buttons actions

		private Form activeForm = null;
		private void openChildForm(Form childForm)
		{
			if (activeForm != null)
			{
				activeForm.Close();
			}
			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			panelChildForm.Controls.Add(childForm);
			panelChildForm.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
		}
	}
}