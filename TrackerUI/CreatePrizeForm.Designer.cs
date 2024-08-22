namespace TrackerUI
{
    partial class CreatePrizeForm
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
            PlaceNumber = new Label();
            Header = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            PlaceName = new Label();
            textBox3 = new TextBox();
            PrizeAmount = new Label();
            textBox4 = new TextBox();
            PrizePercentage = new Label();
            label1 = new Label();
            CreatePrize = new Button();
            SuspendLayout();
            // 
            // PlaceNumber
            // 
            PlaceNumber.AutoSize = true;
            PlaceNumber.Font = new Font("Microsoft Sans Serif", 14F);
            PlaceNumber.ForeColor = Color.CornflowerBlue;
            PlaceNumber.Location = new Point(12, 83);
            PlaceNumber.Name = "PlaceNumber";
            PlaceNumber.Size = new Size(167, 29);
            PlaceNumber.TabIndex = 16;
            PlaceNumber.Text = "Place Number";
            // 
            // Header
            // 
            Header.AutoSize = true;
            Header.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Header.ForeColor = Color.CornflowerBlue;
            Header.Location = new Point(12, 9);
            Header.Name = "Header";
            Header.Size = new Size(166, 38);
            Header.TabIndex = 15;
            Header.Text = "Create Prize";
            Header.Click += Header_Click;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(216, 88);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(138, 27);
            textBox2.TabIndex = 24;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(216, 144);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(138, 27);
            textBox1.TabIndex = 26;
            // 
            // PlaceName
            // 
            PlaceName.AutoSize = true;
            PlaceName.Font = new Font("Microsoft Sans Serif", 14F);
            PlaceName.ForeColor = Color.CornflowerBlue;
            PlaceName.Location = new Point(12, 139);
            PlaceName.Name = "PlaceName";
            PlaceName.Size = new Size(145, 29);
            PlaceName.TabIndex = 25;
            PlaceName.Text = "Place Name";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(216, 200);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(138, 27);
            textBox3.TabIndex = 28;
            // 
            // PrizeAmount
            // 
            PrizeAmount.AutoSize = true;
            PrizeAmount.Font = new Font("Microsoft Sans Serif", 14F);
            PrizeAmount.ForeColor = Color.CornflowerBlue;
            PrizeAmount.Location = new Point(12, 195);
            PrizeAmount.Name = "PrizeAmount";
            PrizeAmount.Size = new Size(155, 29);
            PrizeAmount.TabIndex = 27;
            PrizeAmount.Text = "Prize Amount";
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(216, 315);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(138, 27);
            textBox4.TabIndex = 30;
            // 
            // PrizePercentage
            // 
            PrizePercentage.AutoSize = true;
            PrizePercentage.Font = new Font("Microsoft Sans Serif", 14F);
            PrizePercentage.ForeColor = Color.CornflowerBlue;
            PrizePercentage.Location = new Point(12, 313);
            PrizePercentage.Name = "PrizePercentage";
            PrizePercentage.Size = new Size(198, 29);
            PrizePercentage.TabIndex = 29;
            PrizePercentage.Text = "Prize Percentage";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(162, 254);
            label1.Name = "label1";
            label1.Size = new Size(77, 29);
            label1.TabIndex = 31;
            label1.Text = "- OR -";
            label1.Click += label1_Click;
            // 
            // CreatePrize
            // 
            CreatePrize.Font = new Font("Segoe UI", 14F);
            CreatePrize.ForeColor = Color.Crimson;
            CreatePrize.Location = new Point(162, 405);
            CreatePrize.Name = "CreatePrize";
            CreatePrize.Size = new Size(233, 64);
            CreatePrize.TabIndex = 32;
            CreatePrize.Text = "Create Prize";
            CreatePrize.UseVisualStyleBackColor = true;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 569);
            Controls.Add(CreatePrize);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(PrizePercentage);
            Controls.Add(textBox3);
            Controls.Add(PrizeAmount);
            Controls.Add(textBox1);
            Controls.Add(PlaceName);
            Controls.Add(textBox2);
            Controls.Add(PlaceNumber);
            Controls.Add(Header);
            Name = "CreatePrizeForm";
            Text = "CreatePrizeForm";
            Load += CreatePrizeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label PlaceNumber;
        private Label Header;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label PlaceName;
        private TextBox textBox3;
        private Label PrizeAmount;
        private TextBox textBox4;
        private Label PrizePercentage;
        private Label label1;
        private Button CreatePrize;
    }
}