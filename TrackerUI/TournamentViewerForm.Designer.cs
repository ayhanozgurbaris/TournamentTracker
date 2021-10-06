
namespace TrackerUI
{
	partial class TournamentViewerForm
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
			this.headerLabel = new System.Windows.Forms.Label();
			this.TournamentName = new System.Windows.Forms.Label();
			this.roundLabel = new System.Windows.Forms.Label();
			this.roundDropDown = new System.Windows.Forms.ComboBox();
			this.unplayedOnlyCheckbox = new System.Windows.Forms.CheckBox();
			this.matchupListBox = new System.Windows.Forms.ListBox();
			this.teamOneName = new System.Windows.Forms.Label();
			this.teamOneScoreLabel = new System.Windows.Forms.Label();
			this.teamOneScoreValue = new System.Windows.Forms.TextBox();
			this.teamTwoScoreValue = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.teamTwoName = new System.Windows.Forms.Label();
			this.versusLabel = new System.Windows.Forms.TextBox();
			this.scoreButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// headerLabel
			// 
			this.headerLabel.AutoSize = true;
			this.headerLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.headerLabel.Location = new System.Drawing.Point(38, 35);
			this.headerLabel.Name = "headerLabel";
			this.headerLabel.Size = new System.Drawing.Size(171, 38);
			this.headerLabel.TabIndex = 0;
			this.headerLabel.Text = "Tournament:";
			// 
			// TournamentName
			// 
			this.TournamentName.AutoSize = true;
			this.TournamentName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.TournamentName.Location = new System.Drawing.Point(248, 35);
			this.TournamentName.Name = "TournamentName";
			this.TournamentName.Size = new System.Drawing.Size(118, 38);
			this.TournamentName.TabIndex = 1;
			this.TournamentName.Text = "<none>";
			// 
			// roundLabel
			// 
			this.roundLabel.AutoSize = true;
			this.roundLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.roundLabel.Location = new System.Drawing.Point(38, 101);
			this.roundLabel.Name = "roundLabel";
			this.roundLabel.Size = new System.Drawing.Size(103, 38);
			this.roundLabel.TabIndex = 2;
			this.roundLabel.Text = "Round:";
			// 
			// roundDropDown
			// 
			this.roundDropDown.FormattingEnabled = true;
			this.roundDropDown.Location = new System.Drawing.Point(165, 101);
			this.roundDropDown.Name = "roundDropDown";
			this.roundDropDown.Size = new System.Drawing.Size(201, 45);
			this.roundDropDown.TabIndex = 3;
			// 
			// unplayedOnlyCheckbox
			// 
			this.unplayedOnlyCheckbox.AutoSize = true;
			this.unplayedOnlyCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.unplayedOnlyCheckbox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.unplayedOnlyCheckbox.Location = new System.Drawing.Point(165, 174);
			this.unplayedOnlyCheckbox.Name = "unplayedOnlyCheckbox";
			this.unplayedOnlyCheckbox.Size = new System.Drawing.Size(218, 42);
			this.unplayedOnlyCheckbox.TabIndex = 4;
			this.unplayedOnlyCheckbox.Text = "Unplayed Only";
			this.unplayedOnlyCheckbox.UseVisualStyleBackColor = true;
			// 
			// matchupListBox
			// 
			this.matchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.matchupListBox.FormattingEnabled = true;
			this.matchupListBox.ItemHeight = 37;
			this.matchupListBox.Location = new System.Drawing.Point(38, 267);
			this.matchupListBox.Name = "matchupListBox";
			this.matchupListBox.Size = new System.Drawing.Size(328, 150);
			this.matchupListBox.TabIndex = 5;
			// 
			// teamOneName
			// 
			this.teamOneName.AutoSize = true;
			this.teamOneName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.teamOneName.Location = new System.Drawing.Point(443, 267);
			this.teamOneName.Name = "teamOneName";
			this.teamOneName.Size = new System.Drawing.Size(172, 38);
			this.teamOneName.TabIndex = 6;
			this.teamOneName.Text = "<team one>";
			// 
			// teamOneScoreLabel
			// 
			this.teamOneScoreLabel.AutoSize = true;
			this.teamOneScoreLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.teamOneScoreLabel.Location = new System.Drawing.Point(443, 308);
			this.teamOneScoreLabel.Name = "teamOneScoreLabel";
			this.teamOneScoreLabel.Size = new System.Drawing.Size(83, 38);
			this.teamOneScoreLabel.TabIndex = 7;
			this.teamOneScoreLabel.Text = "score";
			// 
			// teamOneScoreValue
			// 
			this.teamOneScoreValue.Location = new System.Drawing.Point(567, 308);
			this.teamOneScoreValue.Name = "teamOneScoreValue";
			this.teamOneScoreValue.Size = new System.Drawing.Size(125, 43);
			this.teamOneScoreValue.TabIndex = 8;
			// 
			// teamTwoScoreValue
			// 
			this.teamTwoScoreValue.Location = new System.Drawing.Point(567, 473);
			this.teamTwoScoreValue.Name = "teamTwoScoreValue";
			this.teamTwoScoreValue.Size = new System.Drawing.Size(125, 43);
			this.teamTwoScoreValue.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label1.Location = new System.Drawing.Point(443, 473);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 38);
			this.label1.TabIndex = 10;
			this.label1.Text = "score";
			// 
			// teamTwoName
			// 
			this.teamTwoName.AutoSize = true;
			this.teamTwoName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.teamTwoName.Location = new System.Drawing.Point(443, 432);
			this.teamTwoName.Name = "teamTwoName";
			this.teamTwoName.Size = new System.Drawing.Size(170, 38);
			this.teamTwoName.TabIndex = 9;
			this.teamTwoName.Text = "<team two>";
			// 
			// versusLabel
			// 
			this.versusLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.versusLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.versusLabel.Location = new System.Drawing.Point(511, 375);
			this.versusLabel.Name = "versusLabel";
			this.versusLabel.Size = new System.Drawing.Size(125, 36);
			this.versusLabel.TabIndex = 12;
			this.versusLabel.Text = "-VS-";
			this.versusLabel.TextChanged += new System.EventHandler(this.versusLabel_TextChanged);
			// 
			// scoreButton
			// 
			this.scoreButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.scoreButton.Location = new System.Drawing.Point(748, 375);
			this.scoreButton.Name = "scoreButton";
			this.scoreButton.Size = new System.Drawing.Size(131, 51);
			this.scoreButton.TabIndex = 13;
			this.scoreButton.Text = "Score";
			this.scoreButton.UseVisualStyleBackColor = true;
			// 
			// TournamentViewerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(931, 630);
			this.Controls.Add(this.scoreButton);
			this.Controls.Add(this.versusLabel);
			this.Controls.Add(this.teamTwoScoreValue);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.teamTwoName);
			this.Controls.Add(this.teamOneScoreValue);
			this.Controls.Add(this.teamOneScoreLabel);
			this.Controls.Add(this.teamOneName);
			this.Controls.Add(this.matchupListBox);
			this.Controls.Add(this.unplayedOnlyCheckbox);
			this.Controls.Add(this.roundDropDown);
			this.Controls.Add(this.roundLabel);
			this.Controls.Add(this.TournamentName);
			this.Controls.Add(this.headerLabel);
			this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "TournamentViewerForm";
			this.Text = "Tournament Viewer";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label headerLabel;
		private System.Windows.Forms.Label TournamentName;
		private System.Windows.Forms.Label roundLabel;
		private System.Windows.Forms.ComboBox roundDropDown;
		private System.Windows.Forms.CheckBox unplayedOnlyCheckbox;
		private System.Windows.Forms.ListBox matchupListBox;
		private System.Windows.Forms.Label teamOneName;
		private System.Windows.Forms.Label teamOneScoreLabel;
		private System.Windows.Forms.TextBox teamOneScoreValue;
		private System.Windows.Forms.TextBox teamTwoScoreValue;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label teamTwoName;
		private System.Windows.Forms.TextBox versusLabel;
		private System.Windows.Forms.Button scoreButton;
	}
}

