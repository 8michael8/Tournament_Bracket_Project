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
            Header = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            RoundDropBox = new ComboBox();
            label3 = new Label();
            createNewTeamLink = new LinkLabel();
            addTeam = new Button();
            button1 = new Button();
            TournamentPlayers = new ListBox();
            label4 = new Label();
            deleteSelected = new Button();
            label5 = new Label();
            PrizesListBox = new ListBox();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // Header
            // 
            Header.AutoSize = true;
            Header.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Header.ForeColor = Color.CornflowerBlue;
            Header.Location = new Point(8, 22);
            Header.Name = "Header";
            Header.Size = new Size(253, 38);
            Header.TabIndex = 1;
            Header.Text = "Create Tournament";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 114);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(253, 27);
            textBox1.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14F);
            label2.ForeColor = Color.CornflowerBlue;
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(214, 29);
            label2.TabIndex = 10;
            label2.Text = "Tournament Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(140, 188);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 13;
            textBox2.Text = "0";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(18, 184);
            label1.Name = "label1";
            label1.Size = new Size(116, 29);
            label1.TabIndex = 12;
            label1.Text = "Entry Fee";
            // 
            // RoundDropBox
            // 
            RoundDropBox.FormattingEnabled = true;
            RoundDropBox.Location = new Point(18, 278);
            RoundDropBox.Name = "RoundDropBox";
            RoundDropBox.Size = new Size(247, 28);
            RoundDropBox.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14F);
            label3.ForeColor = Color.CornflowerBlue;
            label3.Location = new Point(18, 246);
            label3.Name = "label3";
            label3.Size = new Size(150, 29);
            label3.TabIndex = 14;
            label3.Text = "Select Team";
            // 
            // createNewTeamLink
            // 
            createNewTeamLink.AutoSize = true;
            createNewTeamLink.Location = new Point(189, 253);
            createNewTeamLink.Name = "createNewTeamLink";
            createNewTeamLink.Size = new Size(86, 20);
            createNewTeamLink.TabIndex = 16;
            createNewTeamLink.TabStop = true;
            createNewTeamLink.Text = "Create New";
            // 
            // addTeam
            // 
            addTeam.Font = new Font("Segoe UI", 14F);
            addTeam.ForeColor = Color.CornflowerBlue;
            addTeam.Location = new Point(43, 312);
            addTeam.Name = "addTeam";
            addTeam.Size = new Size(183, 38);
            addTeam.TabIndex = 17;
            addTeam.Text = "Add Team";
            addTeam.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F);
            button1.ForeColor = Color.CornflowerBlue;
            button1.Location = new Point(43, 370);
            button1.Name = "button1";
            button1.Size = new Size(183, 38);
            button1.TabIndex = 18;
            button1.Text = "Create Prize";
            button1.UseVisualStyleBackColor = true;
            // 
            // TournamentPlayers
            // 
            TournamentPlayers.AllowDrop = true;
            TournamentPlayers.BorderStyle = BorderStyle.FixedSingle;
            TournamentPlayers.FormattingEnabled = true;
            TournamentPlayers.Location = new Point(384, 106);
            TournamentPlayers.Name = "TournamentPlayers";
            TournamentPlayers.Size = new Size(286, 122);
            TournamentPlayers.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14F);
            label4.ForeColor = Color.CornflowerBlue;
            label4.Location = new Point(377, 69);
            label4.Name = "label4";
            label4.Size = new Size(187, 29);
            label4.TabIndex = 20;
            label4.Text = "Teams / Players";
            // 
            // deleteSelected
            // 
            deleteSelected.Font = new Font("Segoe UI", 14F);
            deleteSelected.ForeColor = Color.CornflowerBlue;
            deleteSelected.Location = new Point(676, 312);
            deleteSelected.Name = "deleteSelected";
            deleteSelected.Size = new Size(120, 78);
            deleteSelected.TabIndex = 24;
            deleteSelected.Text = "Delete Selected";
            deleteSelected.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 14F);
            label5.ForeColor = Color.CornflowerBlue;
            label5.Location = new Point(377, 249);
            label5.Name = "label5";
            label5.Size = new Size(187, 29);
            label5.TabIndex = 23;
            label5.Text = "Teams / Players";
            // 
            // PrizesListBox
            // 
            PrizesListBox.AllowDrop = true;
            PrizesListBox.BorderStyle = BorderStyle.FixedSingle;
            PrizesListBox.FormattingEnabled = true;
            PrizesListBox.Location = new Point(384, 286);
            PrizesListBox.Name = "PrizesListBox";
            PrizesListBox.Size = new Size(286, 122);
            PrizesListBox.TabIndex = 22;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F);
            button2.ForeColor = Color.CornflowerBlue;
            button2.Location = new Point(676, 135);
            button2.Name = "button2";
            button2.Size = new Size(120, 78);
            button2.TabIndex = 25;
            button2.Text = "Delete Selected";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14F);
            button3.ForeColor = Color.Crimson;
            button3.Location = new Point(289, 430);
            button3.Name = "button3";
            button3.Size = new Size(233, 64);
            button3.TabIndex = 26;
            button3.Text = "Create Tournament";
            button3.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(824, 529);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(deleteSelected);
            Controls.Add(label5);
            Controls.Add(PrizesListBox);
            Controls.Add(label4);
            Controls.Add(TournamentPlayers);
            Controls.Add(button1);
            Controls.Add(addTeam);
            Controls.Add(createNewTeamLink);
            Controls.Add(RoundDropBox);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(Header);
            Name = "CreateTournamentForm";
            Text = "Create Tournament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Header;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private ComboBox RoundDropBox;
        private Label label3;
        private LinkLabel createNewTeamLink;
        private Button addTeam;
        private Button button1;
        private ListBox TournamentPlayers;
        private Label label4;
        private Button deleteSelected;
        private Label label5;
        private ListBox PrizesListBox;
        private Button button2;
        private Button button3;
    }
}