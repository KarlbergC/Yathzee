namespace Project_Yatzee
{
    partial class Form2
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
            this.textBoxUsernameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.labelHighscore = new System.Windows.Forms.Label();
            this.listBoxHighscores = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxUsernameInput
            // 
            this.textBoxUsernameInput.Location = new System.Drawing.Point(29, 54);
            this.textBoxUsernameInput.Name = "textBoxUsernameInput";
            this.textBoxUsernameInput.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsernameInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Username";
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(29, 97);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(75, 23);
            this.buttonPlay.TabIndex = 2;
            this.buttonPlay.Text = "Let\'s Play!";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // labelHighscore
            // 
            this.labelHighscore.AutoSize = true;
            this.labelHighscore.Location = new System.Drawing.Point(268, 30);
            this.labelHighscore.Name = "labelHighscore";
            this.labelHighscore.Size = new System.Drawing.Size(60, 13);
            this.labelHighscore.TabIndex = 3;
            this.labelHighscore.Text = "Highscores";
            // 
            // listBoxHighscores
            // 
            this.listBoxHighscores.FormattingEnabled = true;
            this.listBoxHighscores.Location = new System.Drawing.Point(271, 63);
            this.listBoxHighscores.Name = "listBoxHighscores";
            this.listBoxHighscores.Size = new System.Drawing.Size(120, 95);
            this.listBoxHighscores.TabIndex = 4;
            this.listBoxHighscores.SelectedIndexChanged += new System.EventHandler(this.listBoxHighscores_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 277);
            this.Controls.Add(this.listBoxHighscores);
            this.Controls.Add(this.labelHighscore);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUsernameInput);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsernameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Label labelHighscore;
        private System.Windows.Forms.ListBox listBoxHighscores;
    }
}