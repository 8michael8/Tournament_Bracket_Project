namespace TrackerUI
{
    partial class CreateTeamForm
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
            textBox1 = new TextBox();
            label2 = new Label();
            Header = new Label();
            addTeam = new Button();
            RoundDropBox = new ComboBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            button1 = new Button();
            checkedListBox1 = new CheckedListBox();
            TeamPlayers = new ListBox();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(25, 101);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(354, 43);
            textBox1.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14F);
            label2.ForeColor = Color.CornflowerBlue;
            label2.Location = new Point(25, 56);
            label2.Name = "label2";
            label2.Size = new Size(147, 29);
            label2.TabIndex = 13;
            label2.Text = "Team Name";
            // 
            // Header
            // 
            Header.AutoSize = true;
            Header.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Header.ForeColor = Color.CornflowerBlue;
            Header.Location = new Point(21, 9);
            Header.Name = "Header";
            Header.Size = new Size(170, 38);
            Header.TabIndex = 12;
            Header.Text = "Create Team";
            // 
            // addTeam
            // 
            addTeam.Font = new Font("Segoe UI", 14F);
            addTeam.ForeColor = Color.CornflowerBlue;
            addTeam.Location = new Point(112, 303);
            addTeam.Name = "addTeam";
            addTeam.Size = new Size(183, 38);
            addTeam.TabIndex = 19;
            addTeam.Text = "Add Team";
            addTeam.UseVisualStyleBackColor = true;
            // 
            // RoundDropBox
            // 
            RoundDropBox.FormattingEnabled = true;
            RoundDropBox.Location = new Point(27, 218);
            RoundDropBox.Name = "RoundDropBox";
            RoundDropBox.Size = new Size(352, 45);
            RoundDropBox.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14F);
            label3.ForeColor = Color.CornflowerBlue;
            label3.Location = new Point(22, 173);
            label3.Name = "label3";
            label3.Size = new Size(150, 29);
            label3.TabIndex = 20;
            label3.Text = "Select Team";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10F);
            groupBox1.Location = new Point(27, 359);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(352, 275);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add New Member";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(166, 29);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 30);
            textBox2.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(15, 26);
            label1.Name = "label1";
            label1.Size = new Size(131, 29);
            label1.TabIndex = 22;
            label1.Text = "First Name";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(166, 94);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 30);
            textBox3.TabIndex = 25;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14F);
            label4.ForeColor = Color.CornflowerBlue;
            label4.Location = new Point(15, 91);
            label4.Name = "label4";
            label4.Size = new Size(128, 29);
            label4.TabIndex = 24;
            label4.Text = "Last Name";
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(166, 164);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 30);
            textBox4.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 14F);
            label5.ForeColor = Color.CornflowerBlue;
            label5.Location = new Point(15, 161);
            label5.Name = "label5";
            label5.Size = new Size(74, 29);
            label5.TabIndex = 26;
            label5.Text = "Email";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F);
            button1.ForeColor = Color.Crimson;
            button1.Location = new Point(44, 219);
            button1.Name = "button1";
            button1.Size = new Size(224, 38);
            button1.TabIndex = 28;
            button1.Text = "Create Member";
            button1.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(648, 170);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(8, 4);
            checkedListBox1.TabIndex = 22;
            // 
            // TeamPlayers
            // 
            TeamPlayers.AllowDrop = true;
            TeamPlayers.BorderStyle = BorderStyle.FixedSingle;
            TeamPlayers.FormattingEnabled = true;
            TeamPlayers.ItemHeight = 37;
            TeamPlayers.Location = new Point(449, 100);
            TeamPlayers.Name = "TeamPlayers";
            TeamPlayers.Size = new Size(303, 520);
            TeamPlayers.TabIndex = 23;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F);
            button2.ForeColor = Color.CornflowerBlue;
            button2.Location = new Point(790, 303);
            button2.Name = "button2";
            button2.Size = new Size(120, 78);
            button2.TabIndex = 26;
            button2.Text = "Delete Selected";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14F);
            button3.ForeColor = Color.Crimson;
            button3.Location = new Point(329, 662);
            button3.Name = "button3";
            button3.Size = new Size(233, 64);
            button3.TabIndex = 27;
            button3.Text = "Create Team";
            button3.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1500, 832);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(TeamPlayers);
            Controls.Add(checkedListBox1);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(addTeam);
            Controls.Add(RoundDropBox);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(Header);
            Font = new Font("Segoe UI", 16F);
            Margin = new Padding(6, 6, 6, 6);
            Name = "CreateTeamForm";
            Text = "Create Team";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label2;
        private Label Header;
        private Button addTeam;
        private ComboBox RoundDropBox;
        private Label label3;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox3;
        private Label label4;
        private Button button1;
        private TextBox textBox4;
        private Label label5;
        private CheckedListBox checkedListBox1;
        private ListBox TeamPlayers;
        private Button button2;
        private Button button3;
    }
}