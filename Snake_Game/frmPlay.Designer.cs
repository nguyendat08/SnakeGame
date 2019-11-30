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
            this.pnlPlay = new System.Windows.Forms.Panel();
            this.pnlScore = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlPlay
            // 
            this.pnlPlay.Location = new System.Drawing.Point(2, 50);
            this.pnlPlay.Name = "pnlPlay";
            this.pnlPlay.Size = new System.Drawing.Size(500, 500);
            this.pnlPlay.TabIndex = 0;
            // 
            // pnlScore
            // 
            this.pnlScore.Location = new System.Drawing.Point(2, 0);
            this.pnlScore.Name = "pnlScore";
            this.pnlScore.Size = new System.Drawing.Size(497, 53);
            this.pnlScore.TabIndex = 1;
            // 
            // frmPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 552);
            this.Controls.Add(this.pnlScore);
            this.Controls.Add(this.pnlPlay);
            this.Name = "frmPlay";
            this.Text = "frmPlay";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPlay;
        private System.Windows.Forms.Panel pnlScore;
    }
}