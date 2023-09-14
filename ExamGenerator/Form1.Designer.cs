namespace ExamGenerator
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			panelMenu = new Panel();
			btnLogOut = new FontAwesome.Sharp.IconButton();
			btnSettings = new FontAwesome.Sharp.IconButton();
			btnStats = new FontAwesome.Sharp.IconButton();
			btnTools = new FontAwesome.Sharp.IconButton();
			btnSubjects = new FontAwesome.Sharp.IconButton();
			panelLogo = new Panel();
			pbxLogo = new PictureBox();
			btnMenu = new FontAwesome.Sharp.IconButton();
			iconButton6 = new FontAwesome.Sharp.IconButton();
			panelTitleBar = new Panel();
			btnMinimize = new FontAwesome.Sharp.IconButton();
			btnMaximize = new FontAwesome.Sharp.IconButton();
			btnClose = new FontAwesome.Sharp.IconButton();
			iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
			iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
			panelChildForm = new Panel();
			panelMenu.SuspendLayout();
			panelLogo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbxLogo).BeginInit();
			panelTitleBar.SuspendLayout();
			SuspendLayout();
			// 
			// panelMenu
			// 
			panelMenu.BackColor = Color.FromArgb(38, 50, 56);
			panelMenu.Controls.Add(btnLogOut);
			panelMenu.Controls.Add(btnSettings);
			panelMenu.Controls.Add(btnStats);
			panelMenu.Controls.Add(btnTools);
			panelMenu.Controls.Add(btnSubjects);
			panelMenu.Controls.Add(panelLogo);
			panelMenu.Dock = DockStyle.Left;
			panelMenu.Location = new Point(0, 25);
			panelMenu.Margin = new Padding(3, 2, 3, 2);
			panelMenu.Name = "panelMenu";
			panelMenu.Size = new Size(201, 492);
			panelMenu.TabIndex = 1;
			// 
			// btnLogOut
			// 
			btnLogOut.Dock = DockStyle.Bottom;
			btnLogOut.FlatAppearance.BorderSize = 0;
			btnLogOut.FlatStyle = FlatStyle.Flat;
			btnLogOut.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnLogOut.ForeColor = Color.WhiteSmoke;
			btnLogOut.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
			btnLogOut.IconColor = Color.WhiteSmoke;
			btnLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnLogOut.IconSize = 40;
			btnLogOut.ImageAlign = ContentAlignment.MiddleLeft;
			btnLogOut.Location = new Point(0, 442);
			btnLogOut.Name = "btnLogOut";
			btnLogOut.Padding = new Padding(6, 0, 0, 0);
			btnLogOut.Size = new Size(201, 50);
			btnLogOut.TabIndex = 5;
			btnLogOut.Tag = "Log Out";
			btnLogOut.Text = "  Log Out";
			btnLogOut.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnLogOut.UseVisualStyleBackColor = true;
			// 
			// btnSettings
			// 
			btnSettings.Dock = DockStyle.Top;
			btnSettings.FlatAppearance.BorderSize = 0;
			btnSettings.FlatStyle = FlatStyle.Flat;
			btnSettings.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnSettings.ForeColor = Color.WhiteSmoke;
			btnSettings.IconChar = FontAwesome.Sharp.IconChar.Gear;
			btnSettings.IconColor = Color.WhiteSmoke;
			btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnSettings.IconSize = 40;
			btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
			btnSettings.Location = new Point(0, 206);
			btnSettings.Name = "btnSettings";
			btnSettings.Padding = new Padding(5, 0, 0, 0);
			btnSettings.Size = new Size(201, 50);
			btnSettings.TabIndex = 4;
			btnSettings.Tag = "Settings";
			btnSettings.Text = "  Settings";
			btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnSettings.UseVisualStyleBackColor = true;
			btnSettings.Click += btnSettings_Click;
			btnSettings.Leave += btnSettings_Leave;
			// 
			// btnStats
			// 
			btnStats.Dock = DockStyle.Top;
			btnStats.FlatAppearance.BorderSize = 0;
			btnStats.FlatStyle = FlatStyle.Flat;
			btnStats.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnStats.ForeColor = Color.WhiteSmoke;
			btnStats.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
			btnStats.IconColor = Color.WhiteSmoke;
			btnStats.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnStats.IconSize = 40;
			btnStats.ImageAlign = ContentAlignment.MiddleLeft;
			btnStats.Location = new Point(0, 156);
			btnStats.Name = "btnStats";
			btnStats.Padding = new Padding(5, 0, 0, 0);
			btnStats.Size = new Size(201, 50);
			btnStats.TabIndex = 3;
			btnStats.Tag = "Stats";
			btnStats.Text = "  Stats";
			btnStats.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnStats.UseVisualStyleBackColor = true;
			btnStats.Click += btnStats_Click;
			btnStats.Leave += btnStats_Leave;
			// 
			// btnTools
			// 
			btnTools.Dock = DockStyle.Top;
			btnTools.FlatAppearance.BorderSize = 0;
			btnTools.FlatStyle = FlatStyle.Flat;
			btnTools.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnTools.ForeColor = Color.WhiteSmoke;
			btnTools.IconChar = FontAwesome.Sharp.IconChar.Wrench;
			btnTools.IconColor = Color.WhiteSmoke;
			btnTools.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnTools.IconSize = 40;
			btnTools.ImageAlign = ContentAlignment.MiddleLeft;
			btnTools.Location = new Point(0, 106);
			btnTools.Name = "btnTools";
			btnTools.Padding = new Padding(5, 0, 0, 0);
			btnTools.Size = new Size(201, 50);
			btnTools.TabIndex = 2;
			btnTools.Tag = "Tools";
			btnTools.Text = "  Tools";
			btnTools.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnTools.UseVisualStyleBackColor = true;
			btnTools.Click += btnTools_Click;
			btnTools.Leave += btnTools_Leave;
			// 
			// btnSubjects
			// 
			btnSubjects.Dock = DockStyle.Top;
			btnSubjects.FlatAppearance.BorderSize = 0;
			btnSubjects.FlatStyle = FlatStyle.Flat;
			btnSubjects.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnSubjects.ForeColor = Color.WhiteSmoke;
			btnSubjects.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
			btnSubjects.IconColor = Color.WhiteSmoke;
			btnSubjects.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnSubjects.IconSize = 40;
			btnSubjects.ImageAlign = ContentAlignment.MiddleLeft;
			btnSubjects.Location = new Point(0, 56);
			btnSubjects.Name = "btnSubjects";
			btnSubjects.Padding = new Padding(5, 0, 0, 0);
			btnSubjects.Size = new Size(201, 50);
			btnSubjects.TabIndex = 1;
			btnSubjects.Tag = "Subjects";
			btnSubjects.Text = "  Subjects";
			btnSubjects.TextImageRelation = TextImageRelation.ImageBeforeText;
			btnSubjects.UseVisualStyleBackColor = true;
			btnSubjects.Click += btnSubjects_Click;
			btnSubjects.Leave += btnSubjects_Leave;
			// 
			// panelLogo
			// 
			panelLogo.BackColor = Color.FromArgb(38, 50, 56);
			panelLogo.Controls.Add(pbxLogo);
			panelLogo.Controls.Add(btnMenu);
			panelLogo.Controls.Add(iconButton6);
			panelLogo.Dock = DockStyle.Top;
			panelLogo.Location = new Point(0, 0);
			panelLogo.Margin = new Padding(3, 2, 3, 2);
			panelLogo.Name = "panelLogo";
			panelLogo.Size = new Size(201, 56);
			panelLogo.TabIndex = 0;
			// 
			// pbxLogo
			// 
			pbxLogo.Image = (Image)resources.GetObject("pbxLogo.Image");
			pbxLogo.Location = new Point(18, -3);
			pbxLogo.Margin = new Padding(3, 2, 3, 2);
			pbxLogo.Name = "pbxLogo";
			pbxLogo.Size = new Size(131, 57);
			pbxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
			pbxLogo.TabIndex = 0;
			pbxLogo.TabStop = false;
			// 
			// btnMenu
			// 
			btnMenu.BackColor = Color.Transparent;
			btnMenu.FlatAppearance.BorderSize = 0;
			btnMenu.FlatStyle = FlatStyle.Flat;
			btnMenu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnMenu.ForeColor = Color.WhiteSmoke;
			btnMenu.IconChar = FontAwesome.Sharp.IconChar.CaretDown;
			btnMenu.IconColor = Color.WhiteSmoke;
			btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnMenu.IconSize = 32;
			btnMenu.ImageAlign = ContentAlignment.BottomCenter;
			btnMenu.Location = new Point(133, -4);
			btnMenu.Name = "btnMenu";
			btnMenu.Padding = new Padding(5, 0, 0, 0);
			btnMenu.Size = new Size(66, 56);
			btnMenu.TabIndex = 2;
			btnMenu.Tag = "Home";
			btnMenu.UseVisualStyleBackColor = false;
			btnMenu.Click += btnMenu_Click;
			// 
			// iconButton6
			// 
			iconButton6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			iconButton6.FlatAppearance.BorderSize = 0;
			iconButton6.FlatStyle = FlatStyle.Flat;
			iconButton6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			iconButton6.ForeColor = Color.FromArgb(38, 50, 56);
			iconButton6.IconChar = FontAwesome.Sharp.IconChar.CaretDown;
			iconButton6.IconColor = Color.WhiteSmoke;
			iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
			iconButton6.IconSize = 36;
			iconButton6.Location = new Point(-333, 0);
			iconButton6.Name = "iconButton6";
			iconButton6.Size = new Size(39, 56);
			iconButton6.TabIndex = 1;
			iconButton6.Tag = "Home";
			iconButton6.UseVisualStyleBackColor = true;
			// 
			// panelTitleBar
			// 
			panelTitleBar.BackColor = Color.FromArgb(38, 50, 56);
			panelTitleBar.Controls.Add(btnMinimize);
			panelTitleBar.Controls.Add(btnMaximize);
			panelTitleBar.Controls.Add(btnClose);
			panelTitleBar.Dock = DockStyle.Top;
			panelTitleBar.Location = new Point(0, 0);
			panelTitleBar.Margin = new Padding(3, 2, 3, 2);
			panelTitleBar.Name = "panelTitleBar";
			panelTitleBar.Size = new Size(898, 25);
			panelTitleBar.TabIndex = 2;
			panelTitleBar.MouseDown += panelTitleBar_MouseDown;
			// 
			// btnMinimize
			// 
			btnMinimize.BackColor = Color.FromArgb(38, 166, 154);
			btnMinimize.Dock = DockStyle.Right;
			btnMinimize.FlatAppearance.BorderSize = 0;
			btnMinimize.FlatStyle = FlatStyle.Flat;
			btnMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
			btnMinimize.IconColor = Color.White;
			btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnMinimize.IconSize = 20;
			btnMinimize.Location = new Point(781, 0);
			btnMinimize.Margin = new Padding(3, 2, 3, 2);
			btnMinimize.Name = "btnMinimize";
			btnMinimize.Size = new Size(39, 25);
			btnMinimize.TabIndex = 3;
			btnMinimize.UseVisualStyleBackColor = false;
			btnMinimize.Click += btnMinimize_Click;
			// 
			// btnMaximize
			// 
			btnMaximize.BackColor = Color.FromArgb(3, 155, 229);
			btnMaximize.Dock = DockStyle.Right;
			btnMaximize.FlatAppearance.BorderSize = 0;
			btnMaximize.FlatStyle = FlatStyle.Flat;
			btnMaximize.IconChar = FontAwesome.Sharp.IconChar.UpRightFromSquare;
			btnMaximize.IconColor = Color.White;
			btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnMaximize.IconSize = 20;
			btnMaximize.Location = new Point(820, 0);
			btnMaximize.Margin = new Padding(3, 2, 3, 2);
			btnMaximize.Name = "btnMaximize";
			btnMaximize.Size = new Size(39, 25);
			btnMaximize.TabIndex = 2;
			btnMaximize.UseVisualStyleBackColor = false;
			btnMaximize.Click += btnMaximize_Click;
			// 
			// btnClose
			// 
			btnClose.BackColor = Color.FromArgb(229, 57, 53);
			btnClose.Dock = DockStyle.Right;
			btnClose.FlatAppearance.BorderSize = 0;
			btnClose.FlatStyle = FlatStyle.Flat;
			btnClose.IconChar = FontAwesome.Sharp.IconChar.X;
			btnClose.IconColor = Color.White;
			btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
			btnClose.IconSize = 20;
			btnClose.Location = new Point(859, 0);
			btnClose.Margin = new Padding(3, 2, 3, 2);
			btnClose.Name = "btnClose";
			btnClose.Size = new Size(39, 25);
			btnClose.TabIndex = 1;
			btnClose.UseVisualStyleBackColor = false;
			btnClose.Click += btnClose_Click;
			// 
			// iconMenuItem1
			// 
			iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
			iconMenuItem1.IconColor = Color.Black;
			iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
			iconMenuItem1.Name = "iconMenuItem1";
			iconMenuItem1.Size = new Size(32, 19);
			iconMenuItem1.Text = "iconMenuItem1";
			// 
			// iconMenuItem2
			// 
			iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.None;
			iconMenuItem2.IconColor = Color.Black;
			iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
			iconMenuItem2.Name = "iconMenuItem2";
			iconMenuItem2.Size = new Size(32, 19);
			iconMenuItem2.Text = "iconMenuItem2";
			// 
			// panelChildForm
			// 
			panelChildForm.BackColor = Color.FromArgb(144, 164, 174);
			panelChildForm.Dock = DockStyle.Fill;
			panelChildForm.Location = new Point(201, 25);
			panelChildForm.Name = "panelChildForm";
			panelChildForm.Size = new Size(697, 492);
			panelChildForm.TabIndex = 3;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(898, 517);
			Controls.Add(panelChildForm);
			Controls.Add(panelMenu);
			Controls.Add(panelTitleBar);
			Margin = new Padding(3, 2, 3, 2);
			MinimumSize = new Size(800, 400);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			Resize += Form1_Resize;
			panelMenu.ResumeLayout(false);
			panelLogo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pbxLogo).EndInit();
			panelTitleBar.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion
		private Panel panelTitleBar;
		private FontAwesome.Sharp.IconButton btnMaximize;
		private FontAwesome.Sharp.IconButton btnClose;
		private FontAwesome.Sharp.IconButton btnMinimize;
		private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
		private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
		private Panel panelMenu;
		private FontAwesome.Sharp.IconButton btnLogOut;
		private FontAwesome.Sharp.IconButton btnSettings;
		private FontAwesome.Sharp.IconButton btnStats;
		private FontAwesome.Sharp.IconButton btnTools;
		private FontAwesome.Sharp.IconButton btnSubjects;
		private Panel panelLogo;
		private FontAwesome.Sharp.IconButton iconButton6;
		private PictureBox pbxLogo;
		private FontAwesome.Sharp.IconButton btnMenu;
		private Panel panelChildForm;
	}
}