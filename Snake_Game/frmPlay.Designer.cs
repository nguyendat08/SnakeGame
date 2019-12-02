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
            this.pnlPlay = new System.Windows.Forms.Panel();
            this.pnlScore = new System.Windows.Forms.Panel();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pnlPlay
            // 
            this.pnlPlay.Location = new System.Drawing.Point(2, 41);
            this.pnlPlay.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPlay.Name = "pnlPlay";
            this.pnlPlay.Size = new System.Drawing.Size(375, 406);
            this.pnlPlay.TabIndex = 0;
            this.pnlPlay.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlPlay_Paint);
            // 
            // pnlScore
            // 
            this.pnlScore.Location = new System.Drawing.Point(2, 0);
            this.pnlScore.Margin = new System.Windows.Forms.Padding(2);
            this.pnlScore.Name = "pnlScore";
            this.pnlScore.Size = new System.Drawing.Size(375, 43);
            this.pnlScore.TabIndex = 1;
            // 
            // GameTimer
            // 
            this.GameTimer.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // frmPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 448);
            this.Controls.Add(this.pnlScore);
            this.Controls.Add(this.pnlPlay);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPlay";
            this.Text = "frmPlay";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPlay;
        private System.Windows.Forms.Panel pnlScore;
        private System.Windows.Forms.Timer GameTimer;
    }
}