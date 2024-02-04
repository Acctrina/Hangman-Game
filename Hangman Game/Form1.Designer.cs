namespace Hangman_Game
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guessTextBox = new System.Windows.Forms.TextBox();
            this.hintButton = new System.Windows.Forms.Button();
            this.newGameButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.wordLabel = new System.Windows.Forms.Label();
            this.guessButton = new System.Windows.Forms.Button();
            this.lettersGuessedBox = new System.Windows.Forms.ListBox();
            this.guessesLeftLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hintLabel = new System.Windows.Forms.Label();
            this.hangImage = new System.Windows.Forms.PictureBox();
            this.outcomeLabel = new System.Windows.Forms.Label();
            this.answerTitle = new System.Windows.Forms.Label();
            this.answerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hangImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hangman Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Letter to guess";
            // 
            // guessTextBox
            // 
            this.guessTextBox.Location = new System.Drawing.Point(102, 49);
            this.guessTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.guessTextBox.MaxLength = 1;
            this.guessTextBox.Name = "guessTextBox";
            this.guessTextBox.Size = new System.Drawing.Size(81, 20);
            this.guessTextBox.TabIndex = 2;
            this.guessTextBox.TextChanged += new System.EventHandler(this.guessTextBox_TextChanged);
            // 
            // hintButton
            // 
            this.hintButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hintButton.Location = new System.Drawing.Point(358, 51);
            this.hintButton.Margin = new System.Windows.Forms.Padding(2);
            this.hintButton.Name = "hintButton";
            this.hintButton.Size = new System.Drawing.Size(56, 25);
            this.hintButton.TabIndex = 3;
            this.hintButton.Text = "Hint";
            this.hintButton.UseVisualStyleBackColor = true;
            this.hintButton.Click += new System.EventHandler(this.hintButton_Click);
            // 
            // newGameButton
            // 
            this.newGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGameButton.Location = new System.Drawing.Point(347, 81);
            this.newGameButton.Margin = new System.Windows.Forms.Padding(2);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(77, 31);
            this.newGameButton.TabIndex = 4;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(347, 128);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(77, 26);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Letters guessed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 227);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Word to guess";
            // 
            // wordLabel
            // 
            this.wordLabel.BackColor = System.Drawing.Color.White;
            this.wordLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordLabel.Location = new System.Drawing.Point(26, 242);
            this.wordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wordLabel.Name = "wordLabel";
            this.wordLabel.Size = new System.Drawing.Size(331, 36);
            this.wordLabel.TabIndex = 9;
            // 
            // guessButton
            // 
            this.guessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessButton.Location = new System.Drawing.Point(187, 45);
            this.guessButton.Margin = new System.Windows.Forms.Padding(2);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(50, 26);
            this.guessButton.TabIndex = 10;
            this.guessButton.Text = "Guess";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            // 
            // lettersGuessedBox
            // 
            this.lettersGuessedBox.FormattingEnabled = true;
            this.lettersGuessedBox.Location = new System.Drawing.Point(253, 73);
            this.lettersGuessedBox.Margin = new System.Windows.Forms.Padding(2);
            this.lettersGuessedBox.Name = "lettersGuessedBox";
            this.lettersGuessedBox.Size = new System.Drawing.Size(86, 82);
            this.lettersGuessedBox.TabIndex = 11;
            // 
            // guessesLeftLabel
            // 
            this.guessesLeftLabel.BackColor = System.Drawing.Color.White;
            this.guessesLeftLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guessesLeftLabel.Location = new System.Drawing.Point(102, 73);
            this.guessesLeftLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.guessesLeftLabel.Name = "guessesLeftLabel";
            this.guessesLeftLabel.Size = new System.Drawing.Size(22, 18);
            this.guessesLeftLabel.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Guesses Left:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(215, 220);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Hint:";
            // 
            // hintLabel
            // 
            this.hintLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hintLabel.Location = new System.Drawing.Point(256, 220);
            this.hintLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hintLabel.Name = "hintLabel";
            this.hintLabel.Size = new System.Drawing.Size(168, 22);
            this.hintLabel.TabIndex = 15;
            // 
            // hangImage
            // 
            this.hangImage.Image = global::Hangman_Game_v2.Properties.Resources.hang1;
            this.hangImage.Location = new System.Drawing.Point(68, 95);
            this.hangImage.Margin = new System.Windows.Forms.Padding(2);
            this.hangImage.Name = "hangImage";
            this.hangImage.Size = new System.Drawing.Size(130, 119);
            this.hangImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hangImage.TabIndex = 16;
            this.hangImage.TabStop = false;
            // 
            // outcomeLabel
            // 
            this.outcomeLabel.Location = new System.Drawing.Point(254, 167);
            this.outcomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.outcomeLabel.Name = "outcomeLabel";
            this.outcomeLabel.Size = new System.Drawing.Size(170, 53);
            this.outcomeLabel.TabIndex = 17;
            // 
            // answerTitle
            // 
            this.answerTitle.AutoSize = true;
            this.answerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerTitle.Location = new System.Drawing.Point(215, 278);
            this.answerTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.answerTitle.Name = "answerTitle";
            this.answerTitle.Size = new System.Drawing.Size(61, 18);
            this.answerTitle.TabIndex = 18;
            this.answerTitle.Text = "Answer:";
            // 
            // answerLabel
            // 
            this.answerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerLabel.Location = new System.Drawing.Point(271, 278);
            this.answerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(153, 22);
            this.answerLabel.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 320);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.answerTitle);
            this.Controls.Add(this.outcomeLabel);
            this.Controls.Add(this.hangImage);
            this.Controls.Add(this.hintLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guessesLeftLabel);
            this.Controls.Add(this.lettersGuessedBox);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.wordLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.hintButton);
            this.Controls.Add(this.guessTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hangImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox guessTextBox;
        private System.Windows.Forms.Button hintButton;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label wordLabel;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.ListBox lettersGuessedBox;
        private System.Windows.Forms.Label guessesLeftLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label hintLabel;
        private System.Windows.Forms.PictureBox hangImage;
        private System.Windows.Forms.Label outcomeLabel;
        private System.Windows.Forms.Label answerTitle;
        private System.Windows.Forms.Label answerLabel;
    }
}

