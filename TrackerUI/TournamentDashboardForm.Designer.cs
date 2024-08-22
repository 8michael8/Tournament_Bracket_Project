namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            CreatePrize = new Label();
            LoadTournament = new Label();
            RoundDropBox = new ComboBox();
            LoadTournamentButton = new Button();
            CreateTournament = new Button();
            SuspendLayout();
            // 
            // CreatePrize
            // 
            CreatePrize.AutoSize = true;
            CreatePrize.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreatePrize.ForeColor = Color.CornflowerBlue;
            CreatePrize.Location = new Point(317, 74);
            CreatePrize.Name = "CreatePrize";
            CreatePrize.Size = new Size(166, 38);
            CreatePrize.TabIndex = 16;
            CreatePrize.Text = "Create Prize";
            // 
            // LoadTournament
            // 
            LoadTournament.AutoSize = true;
            LoadTournament.Font = new Font("Microsoft Sans Serif", 14F);
            LoadTournament.ForeColor = Color.CornflowerBlue;
            LoadTournament.Location = new Point(252, 210);
            LoadTournament.Name = "LoadTournament";
            LoadTournament.Size = new Size(293, 29);
            LoadTournament.TabIndex = 22;
            LoadTournament.Text = "Load Existing Tournament";
            // 
            // RoundDropBox
            // 
            RoundDropBox.FormattingEnabled = true;
            RoundDropBox.Location = new Point(224, 254);
            RoundDropBox.Name = "RoundDropBox";
            RoundDropBox.Size = new Size(352, 28);
            RoundDropBox.TabIndex = 21;
            // 
            // LoadTournamentButton
            // 
            LoadTournamentButton.Font = new Font("Segoe UI", 14F);
            LoadTournamentButton.ForeColor = Color.Crimson;
            LoadTournamentButton.Location = new Point(281, 298);
            LoadTournamentButton.Name = "LoadTournamentButton";
            LoadTournamentButton.Size = new Size(233, 64);
            LoadTournamentButton.TabIndex = 33;
            LoadTournamentButton.Text = "Load Tornament";
            LoadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournament
            // 
            CreateTournament.Font = new Font("Segoe UI", 14F);
            CreateTournament.ForeColor = Color.Crimson;
            CreateTournament.Location = new Point(245, 387);
            CreateTournament.Name = "CreateTournament";
            CreateTournament.Size = new Size(304, 91);
            CreateTournament.TabIndex = 34;
            CreateTournament.Text = "Create Tournament";
            CreateTournament.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 490);
            Controls.Add(CreateTournament);
            Controls.Add(LoadTournamentButton);
            Controls.Add(LoadTournament);
            Controls.Add(RoundDropBox);
            Controls.Add(CreatePrize);
            Name = "TournamentDashboardForm";
            Text = "Tournament Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CreatePrize;
        private Label LoadTournament;
        private ComboBox RoundDropBox;
        private Button LoadTournamentButton;
        private Button CreateTournament;
    }
}