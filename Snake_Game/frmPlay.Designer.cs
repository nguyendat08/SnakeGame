namespace Snake_Game
{
    partial class frmPlay
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
            this.components = new System.ComponentModel.Container();
            this.pnlScore = new System.Windows.Forms.Panel();
            this.pnlPlay = new System.Windows.Forms.Panel();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.lblSocre2 = new System.Windows.Forms.Label();
            this.pnlPlay.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlScore
            // 
            this.pnlScore.Location = new System.Drawing.Point(2, 0);
            this.pnlScore.Margin = new System.Windows.Forms.Padding(2);
            this.pnlScore.Name = "pnlScore";
            this.pnlScore.Size = new System.Drawing.Size(500, 43);
            this.pnlScore.TabIndex = 1;
            // 
            // pnlPlay
            // 
            this.pnlPlay.Controls.Add(this.lblGameOver);
            this.pnlPlay.Location = new System.Drawing.Point(2, 48);
            this.pnlPlay.Name = "pnlPlay";
            this.pnlPlay.Size = new System.Drawing.Size(500, 500);
            this.pnlPlay.TabIndex = 2;
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Location = new System.Drawing.Point(22, 16);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(58, 13);
            this.lblGameOver.TabIndex = 0;
            this.lblGameOver.Text = "GameOver";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(507, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(76, 31);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "Score";
            // 
            // lblSocre2
            // 
            this.lblSocre2.AutoSize = true;
            this.lblSocre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSocre2.Location = new System.Drawing.Point(604, 9);
            this.lblSocre2.Name = "lblSocre2";
            this.lblSocre2.Size = new System.Drawing.Size(0, 31);
            this.lblSocre2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 561);
            this.Controls.Add(this.lblSocre2);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pnlPlay);
            this.Controls.Add(this.pnlScore);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "frmPlay";
            //this.Load += new System.EventHandler(this.Form1_Load_1);
            this.pnlPlay.ResumeLayout(false);
            this.pnlPlay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlScore;
        private System.Windows.Forms.Panel pnlPlay;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblSocre2;
        private System.Windows.Forms.Label lblGameOver;
    }
}