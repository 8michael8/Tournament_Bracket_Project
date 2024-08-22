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
            Header = new Label();
            TournamentName = new Label();
            label1 = new Label();
            RoundDropBox = new ComboBox();
            UnplayedOnlyCheckbox = new CheckBox();
            MatchupListBox = new ListBox();
            team1 = new Label();
            team2 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            Score = new Button();
            SuspendLayout();
            // 
            // Header
            // 
            Header.AutoSize = true;
            Header.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Header.ForeColor = Color.CornflowerBlue;
            Header.Location = new Point(12, 9);
            Header.Name = "Header";
            Header.Size = new Size(171, 38);
            Header.TabIndex = 0;
            Header.Text = "Tournament:";
            Header.Click += label1_Click;
            // 
            // TournamentName
            // 
            TournamentName.AutoSize = true;
            TournamentName.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TournamentName.ForeColor = Color.CornflowerBlue;
            TournamentName.Location = new Point(189, 9);
            TournamentName.Name = "TournamentName";
            TournamentName.Size = new Size(123, 38);
            TournamentName.TabIndex = 1;
            TournamentName.Text = "<None>";
            TournamentName.TextAlign = ContentAlignment.BottomRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(12, 64);
            label1.Name = "label1";
            label1.Size = new Size(84, 29);
            label1.TabIndex = 2;
            label1.Text = "Round";
            // 
            // RoundDropBox
            // 
            RoundDropBox.FormattingEnabled = true;
            RoundDropBox.Location = new Point(102, 64);
            RoundDropBox.Name = "RoundDropBox";
            RoundDropBox.Size = new Size(196, 28);
            RoundDropBox.TabIndex = 3;
            // 
            // UnplayedOnlyCheckbox
            // 
            UnplayedOnlyCheckbox.AutoSize = true;
            UnplayedOnlyCheckbox.Font = new Font("Segoe UI", 16F);
            UnplayedOnlyCheckbox.ForeColor = Color.CornflowerBlue;
            UnplayedOnlyCheckbox.Location = new Point(102, 98);
            UnplayedOnlyCheckbox.Name = "UnplayedOnlyCheckbox";
            UnplayedOnlyCheckbox.Size = new Size(215, 41);
            UnplayedOnlyCheckbox.TabIndex = 4;
            UnplayedOnlyCheckbox.Text = "Unplayed Only";
            UnplayedOnlyCheckbox.UseVisualStyleBackColor = true;
            UnplayedOnlyCheckbox.CheckedChanged += UnplayedOnlyCheckbox_CheckedChanged;
            // 
            // MatchupListBox
            // 
            MatchupListBox.AllowDrop = true;
            MatchupListBox.BorderStyle = BorderStyle.FixedSingle;
            MatchupListBox.FormattingEnabled = true;
            MatchupListBox.Location = new Point(12, 145);
            MatchupListBox.Name = "MatchupListBox";
            MatchupListBox.Size = new Size(286, 282);
            MatchupListBox.TabIndex = 5;
            // 
            // team1
            // 
            team1.AutoSize = true;
            team1.Font = new Font("Microsoft Sans Serif", 14F);
            team1.ForeColor = Color.CornflowerBlue;
            team1.Location = new Point(351, 145);
            team1.Name = "team1";
            team1.Size = new Size(123, 29);
            team1.TabIndex = 6;
            team1.Text = "<Team 1>";
            // 
            // team2
            // 
            team2.AutoSize = true;
            team2.Font = new Font("Microsoft Sans Serif", 14F);
            team2.ForeColor = Color.CornflowerBlue;
            team2.Location = new Point(351, 309);
            team2.Name = "team2";
            team2.Size = new Size(123, 29);
            team2.TabIndex = 7;
            team2.Text = "<Team 2>";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14F);
            label2.ForeColor = Color.CornflowerBlue;
            label2.Location = new Point(351, 199);
            label2.Name = "label2";
            label2.Size = new Size(77, 29);
            label2.TabIndex = 8;
            label2.Text = "Score";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(445, 203);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(445, 358);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14F);
            label3.ForeColor = Color.CornflowerBlue;
            label3.Location = new Point(351, 354);
            label3.Name = "label3";
            label3.Size = new Size(77, 29);
            label3.TabIndex = 10;
            label3.Text = "Score";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14F);
            label4.ForeColor = Color.CornflowerBlue;
            label4.Location = new Point(445, 260);
            label4.Name = "label4";
            label4.Size = new Size(72, 29);
            label4.TabIndex = 12;
            label4.Text = "- VS -";
            // 
            // Score
            // 
            Score.Font = new Font("Segoe UI", 14F);
            Score.ForeColor = Color.CornflowerBlue;
            Score.Location = new Point(606, 243);
            Score.Name = "Score";
            Score.Size = new Size(120, 68);
            Score.TabIndex = 13;
            Score.Text = "Score";
            Score.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(Score);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(team2);
            Controls.Add(team1);
            Controls.Add(MatchupListBox);
            Controls.Add(UnplayedOnlyCheckbox);
            Controls.Add(RoundDropBox);
            Controls.Add(label1);
            Controls.Add(TournamentName);
            Controls.Add(Header);
            Name = "TournamentViewerForm";
            Text = "Tournament Viewer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Header;
        private Label TournamentName;
        private Label label1;
        private ComboBox RoundDropBox;
        private CheckBox UnplayedOnlyCheckbox;
        private ListBox MatchupListBox;
        private Label team1;
        private Label team2;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Button Score;
    }
}
