
namespace TrackerUI
{
	partial class CreateTournamentForm
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
			this.headerLabel = new System.Windows.Forms.Label();
			this.tournamentNameValue = new System.Windows.Forms.TextBox();
			this.tournamentNameLabel = new System.Windows.Forms.Label();
			this.entryFeeValue = new System.Windows.Forms.TextBox();
			this.entryFeeLabel = new System.Windows.Forms.Label();
			this.selectTeamDropDown = new System.Windows.Forms.ComboBox();
			this.selectTeamLabel = new System.Windows.Forms.Label();
			this.createNewTeamLink = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// headerLabel
			// 
			this.headerLabel.AutoSize = true;
			this.headerLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.headerLabel.Location = new System.Drawing.Point(76, 104);
			this.headerLabel.Name = "headerLabel";
			this.headerLabel.Size = new System.Drawing.Size(253, 38);
			this.headerLabel.TabIndex = 1;
			this.headerLabel.Text = "Create Tournament";
			// 
			// tournamentNameValue
			// 
			this.tournamentNameValue.Location = new System.Drawing.Point(76, 251);
			this.tournamentNameValue.Name = "tournamentNameValue";
			this.tournamentNameValue.Size = new System.Drawing.Size(331, 43);
			this.tournamentNameValue.TabIndex = 10;
			// 
			// tournamentNameLabel
			// 
			this.tournamentNameLabel.AutoSize = true;
			this.tournamentNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.tournamentNameLabel.Location = new System.Drawing.Point(76, 190);
			this.tournamentNameLabel.Name = "tournamentNameLabel";
			this.tournamentNameLabel.Size = new System.Drawing.Size(247, 38);
			this.tournamentNameLabel.TabIndex = 9;
			this.tournamentNameLabel.Text = "Tournament Name";
			// 
			// entryFeeValue
			// 
			this.entryFeeValue.Location = new System.Drawing.Point(232, 330);
			this.entryFeeValue.Name = "entryFeeValue";
			this.entryFeeValue.Size = new System.Drawing.Size(125, 43);
			this.entryFeeValue.TabIndex = 12;
			this.entryFeeValue.Text = "0";
			// 
			// entryFeeLabel
			// 
			this.entryFeeLabel.AutoSize = true;
			this.entryFeeLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.entryFeeLabel.Location = new System.Drawing.Point(76, 330);
			this.entryFeeLabel.Name = "entryFeeLabel";
			this.entryFeeLabel.Size = new System.Drawing.Size(132, 38);
			this.entryFeeLabel.TabIndex = 11;
			this.entryFeeLabel.Text = "Entry Fee";
			// 
			// selectTeamDropDown
			// 
			this.selectTeamDropDown.FormattingEnabled = true;
			this.selectTeamDropDown.Location = new System.Drawing.Point(76, 479);
			this.selectTeamDropDown.Name = "selectTeamDropDown";
			this.selectTeamDropDown.Size = new System.Drawing.Size(331, 45);
			this.selectTeamDropDown.TabIndex = 14;
			// 
			// selectTeamLabel
			// 
			this.selectTeamLabel.AutoSize = true;
			this.selectTeamLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.selectTeamLabel.Location = new System.Drawing.Point(76, 429);
			this.selectTeamLabel.Name = "selectTeamLabel";
			this.selectTeamLabel.Size = new System.Drawing.Size(161, 38);
			this.selectTeamLabel.TabIndex = 13;
			this.selectTeamLabel.Text = "select Team";
			// 
			// createNewTeamLink
			// 
			this.createNewTeamLink.AutoSize = true;
			this.createNewTeamLink.Location = new System.Drawing.Point(284, 429);
			this.createNewTeamLink.Name = "createNewTeamLink";
			this.createNewTeamLink.Size = new System.Drawing.Size(230, 38);
			this.createNewTeamLink.TabIndex = 15;
			this.createNewTeamLink.TabStop = true;
			this.createNewTeamLink.Text = "create New Team";
			// 
			// CreateTournamentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1500, 832);
			this.Controls.Add(this.createNewTeamLink);
			this.Controls.Add(this.selectTeamDropDown);
			this.Controls.Add(this.selectTeamLabel);
			this.Controls.Add(this.entryFeeValue);
			this.Controls.Add(this.entryFeeLabel);
			this.Controls.Add(this.tournamentNameValue);
			this.Controls.Add(this.tournamentNameLabel);
			this.Controls.Add(this.headerLabel);
			this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.Name = "CreateTournamentForm";
			this.Text = "Create Tournament";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label headerLabel;
		private System.Windows.Forms.TextBox tournamentNameValue;
		private System.Windows.Forms.Label tournamentNameLabel;
		private System.Windows.Forms.TextBox entryFeeValue;
		private System.Windows.Forms.Label entryFeeLabel;
		private System.Windows.Forms.ComboBox selectTeamDropDown;
		private System.Windows.Forms.Label selectTeamLabel;
		private System.Windows.Forms.LinkLabel createNewTeamLink;
	}
}