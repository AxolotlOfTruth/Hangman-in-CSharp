namespace WindowsFormsApp1
{
    partial class window
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
            this.rope = new System.Windows.Forms.PictureBox();
            this.buttonNewgame = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textAttempt = new System.Windows.Forms.TextBox();
            this.buttonTry = new System.Windows.Forms.Button();
            this.lbLives = new System.Windows.Forms.Label();
            this.ttbAttempt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.secretWord = new System.Windows.Forms.TextBox();
            this.btStart = new System.Windows.Forms.Button();
            this.secretLetter1 = new System.Windows.Forms.TextBox();
            this.secretLetter2 = new System.Windows.Forms.TextBox();
            this.secretLetter3 = new System.Windows.Forms.TextBox();
            this.secretLetter4 = new System.Windows.Forms.TextBox();
            this.secretLetter5 = new System.Windows.Forms.TextBox();
            this.secretLetter6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rope)).BeginInit();
            this.SuspendLayout();
            // 
            // rope
            // 
            this.rope.Image = global::WindowsFormsApp1.Properties.Resources.pendu0;
            this.rope.Location = new System.Drawing.Point(12, 11);
            this.rope.Name = "rope";
            this.rope.Size = new System.Drawing.Size(244, 249);
            this.rope.TabIndex = 0;
            this.rope.TabStop = false;
            // 
            // buttonNewgame
            // 
            this.buttonNewgame.Location = new System.Drawing.Point(12, 326);
            this.buttonNewgame.Name = "buttonNewgame";
            this.buttonNewgame.Size = new System.Drawing.Size(121, 47);
            this.buttonNewgame.TabIndex = 2;
            this.buttonNewgame.Text = "New Game";
            this.buttonNewgame.UseVisualStyleBackColor = true;
            this.buttonNewgame.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(135, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 47);
            this.button2.TabIndex = 3;
            this.button2.Text = "Quit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textAttempt
            // 
            this.textAttempt.Location = new System.Drawing.Point(297, 148);
            this.textAttempt.Name = "textAttempt";
            this.textAttempt.ReadOnly = true;
            this.textAttempt.Size = new System.Drawing.Size(220, 20);
            this.textAttempt.TabIndex = 4;
            this.textAttempt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonTry
            // 
            this.buttonTry.Location = new System.Drawing.Point(429, 175);
            this.buttonTry.Name = "buttonTry";
            this.buttonTry.Size = new System.Drawing.Size(88, 26);
            this.buttonTry.TabIndex = 5;
            this.buttonTry.Text = "Try!";
            this.buttonTry.UseVisualStyleBackColor = true;
            this.buttonTry.Click += new System.EventHandler(this.buttonTry_Click);
            // 
            // lbLives
            // 
            this.lbLives.AutoSize = true;
            this.lbLives.Location = new System.Drawing.Point(12, 283);
            this.lbLives.Name = "lbLives";
            this.lbLives.Size = new System.Drawing.Size(67, 13);
            this.lbLives.TabIndex = 12;
            this.lbLives.Text = "Lives left: 10";
            // 
            // ttbAttempt
            // 
            this.ttbAttempt.Location = new System.Drawing.Point(297, 264);
            this.ttbAttempt.Multiline = true;
            this.ttbAttempt.Name = "ttbAttempt";
            this.ttbAttempt.ReadOnly = true;
            this.ttbAttempt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ttbAttempt.Size = new System.Drawing.Size(220, 32);
            this.ttbAttempt.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Attempted letters:";
            // 
            // secretWord
            // 
            this.secretWord.Location = new System.Drawing.Point(297, 78);
            this.secretWord.Name = "secretWord";
            this.secretWord.Size = new System.Drawing.Size(220, 20);
            this.secretWord.TabIndex = 15;
            this.secretWord.Text = "Insert the secret word(6 letters)";
            this.secretWord.TextChanged += new System.EventHandler(this.secretWord_TextChanged);
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(429, 104);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(88, 26);
            this.btStart.TabIndex = 16;
            this.btStart.Text = "Start!";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // secretLetter1
            // 
            this.secretLetter1.Location = new System.Drawing.Point(77, 264);
            this.secretLetter1.Name = "secretLetter1";
            this.secretLetter1.ReadOnly = true;
            this.secretLetter1.Size = new System.Drawing.Size(13, 20);
            this.secretLetter1.TabIndex = 17;
            this.secretLetter1.TextChanged += new System.EventHandler(this.secretLetter1_TextChanged);
            // 
            // secretLetter2
            // 
            this.secretLetter2.Location = new System.Drawing.Point(96, 264);
            this.secretLetter2.Name = "secretLetter2";
            this.secretLetter2.ReadOnly = true;
            this.secretLetter2.Size = new System.Drawing.Size(13, 20);
            this.secretLetter2.TabIndex = 18;
            // 
            // secretLetter3
            // 
            this.secretLetter3.Location = new System.Drawing.Point(115, 264);
            this.secretLetter3.Name = "secretLetter3";
            this.secretLetter3.ReadOnly = true;
            this.secretLetter3.Size = new System.Drawing.Size(13, 20);
            this.secretLetter3.TabIndex = 19;
            // 
            // secretLetter4
            // 
            this.secretLetter4.Location = new System.Drawing.Point(134, 264);
            this.secretLetter4.Name = "secretLetter4";
            this.secretLetter4.ReadOnly = true;
            this.secretLetter4.Size = new System.Drawing.Size(13, 20);
            this.secretLetter4.TabIndex = 20;
            // 
            // secretLetter5
            // 
            this.secretLetter5.Location = new System.Drawing.Point(153, 264);
            this.secretLetter5.Name = "secretLetter5";
            this.secretLetter5.ReadOnly = true;
            this.secretLetter5.Size = new System.Drawing.Size(13, 20);
            this.secretLetter5.TabIndex = 21;
            // 
            // secretLetter6
            // 
            this.secretLetter6.Location = new System.Drawing.Point(172, 264);
            this.secretLetter6.Name = "secretLetter6";
            this.secretLetter6.ReadOnly = true;
            this.secretLetter6.Size = new System.Drawing.Size(13, 20);
            this.secretLetter6.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Insert a word and have someone guess it";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "one character at a time. Have fun!";
            // 
            // window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secretLetter6);
            this.Controls.Add(this.secretLetter5);
            this.Controls.Add(this.secretLetter4);
            this.Controls.Add(this.secretLetter3);
            this.Controls.Add(this.secretLetter2);
            this.Controls.Add(this.secretLetter1);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.secretWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ttbAttempt);
            this.Controls.Add(this.lbLives);
            this.Controls.Add(this.buttonTry);
            this.Controls.Add(this.textAttempt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonNewgame);
            this.Controls.Add(this.rope);
            this.Name = "window";
            this.Text = "Hangman";
            ((System.ComponentModel.ISupportInitialize)(this.rope)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox rope;
        private System.Windows.Forms.Button buttonNewgame;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textAttempt;
        private System.Windows.Forms.Button buttonTry;
        private System.Windows.Forms.Label lbLives;
        private System.Windows.Forms.TextBox ttbAttempt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox secretWord;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.TextBox secretLetter1;
        private System.Windows.Forms.TextBox secretLetter2;
        private System.Windows.Forms.TextBox secretLetter3;
        private System.Windows.Forms.TextBox secretLetter4;
        private System.Windows.Forms.TextBox secretLetter5;
        private System.Windows.Forms.TextBox secretLetter6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

