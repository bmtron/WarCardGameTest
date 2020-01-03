namespace WarGameTest1
{
    partial class War
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
            this.gameBox = new System.Windows.Forms.RichTextBox();
            this.playerCountLabel = new System.Windows.Forms.Label();
            this.compCardLabel = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.pCardActual = new System.Windows.Forms.Label();
            this.cCardActual = new System.Windows.Forms.Label();
            this.restartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameBox
            // 
            this.gameBox.Location = new System.Drawing.Point(310, 83);
            this.gameBox.Name = "gameBox";
            this.gameBox.Size = new System.Drawing.Size(352, 219);
            this.gameBox.TabIndex = 0;
            this.gameBox.Text = "";
            // 
            // playerCountLabel
            // 
            this.playerCountLabel.AutoSize = true;
            this.playerCountLabel.Location = new System.Drawing.Point(12, 86);
            this.playerCountLabel.Name = "playerCountLabel";
            this.playerCountLabel.Size = new System.Drawing.Size(95, 13);
            this.playerCountLabel.TabIndex = 1;
            this.playerCountLabel.Text = "Player Card Count:";
            // 
            // compCardLabel
            // 
            this.compCardLabel.AutoSize = true;
            this.compCardLabel.Location = new System.Drawing.Point(700, 83);
            this.compCardLabel.Name = "compCardLabel";
            this.compCardLabel.Size = new System.Drawing.Size(111, 13);
            this.compCardLabel.TabIndex = 2;
            this.compCardLabel.Text = "Computer Card Count:";
            this.compCardLabel.Click += new System.EventHandler(this.Label2_Click);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(404, 341);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(152, 23);
            this.playButton.TabIndex = 3;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(440, 25);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start Game";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // pCardActual
            // 
            this.pCardActual.AutoSize = true;
            this.pCardActual.Location = new System.Drawing.Point(123, 86);
            this.pCardActual.Name = "pCardActual";
            this.pCardActual.Size = new System.Drawing.Size(0, 13);
            this.pCardActual.TabIndex = 5;
            // 
            // cCardActual
            // 
            this.cCardActual.AutoSize = true;
            this.cCardActual.Location = new System.Drawing.Point(835, 83);
            this.cCardActual.Name = "cCardActual";
            this.cCardActual.Size = new System.Drawing.Size(0, 13);
            this.cCardActual.TabIndex = 6;
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(418, 370);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(124, 23);
            this.restartButton.TabIndex = 7;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // War
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 450);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.cCardActual);
            this.Controls.Add(this.pCardActual);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.compCardLabel);
            this.Controls.Add(this.playerCountLabel);
            this.Controls.Add(this.gameBox);
            this.Name = "War";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.War_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox gameBox;
        private System.Windows.Forms.Label playerCountLabel;
        private System.Windows.Forms.Label compCardLabel;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label pCardActual;
        private System.Windows.Forms.Label cCardActual;
        private System.Windows.Forms.Button restartButton;
    }
}

