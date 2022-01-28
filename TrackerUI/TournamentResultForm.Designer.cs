
namespace TrackerUI
{
    partial class TournamentResultForm
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
            this.whoWonText = new System.Windows.Forms.Label();
            this.prizeOneText = new System.Windows.Forms.Label();
            this.prizeTwoText = new System.Windows.Forms.Label();
            this.thanksForPlayingLabel = new System.Windows.Forms.Label();
            this.runnerUpText = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // whoWonText
            // 
            this.whoWonText.AutoSize = true;
            this.whoWonText.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whoWonText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.whoWonText.Location = new System.Drawing.Point(59, 118);
            this.whoWonText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.whoWonText.Name = "whoWonText";
            this.whoWonText.Size = new System.Drawing.Size(133, 37);
            this.whoWonText.TabIndex = 6;
            this.whoWonText.Text = "<winner>";
            // 
            // prizeOneText
            // 
            this.prizeOneText.AutoSize = true;
            this.prizeOneText.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizeOneText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.prizeOneText.Location = new System.Drawing.Point(59, 258);
            this.prizeOneText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prizeOneText.Name = "prizeOneText";
            this.prizeOneText.Size = new System.Drawing.Size(196, 37);
            this.prizeOneText.TabIndex = 7;
            this.prizeOneText.Text = "<prizeWinner>";
            this.prizeOneText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.prizeOneText.Visible = false;
            // 
            // prizeTwoText
            // 
            this.prizeTwoText.AutoSize = true;
            this.prizeTwoText.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prizeTwoText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.prizeTwoText.Location = new System.Drawing.Point(59, 318);
            this.prizeTwoText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prizeTwoText.Name = "prizeTwoText";
            this.prizeTwoText.Size = new System.Drawing.Size(230, 37);
            this.prizeTwoText.TabIndex = 8;
            this.prizeTwoText.Text = "<prizeRunnerUp>";
            this.prizeTwoText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.prizeTwoText.Visible = false;
            // 
            // thanksForPlayingLabel
            // 
            this.thanksForPlayingLabel.AutoSize = true;
            this.thanksForPlayingLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thanksForPlayingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.thanksForPlayingLabel.Location = new System.Drawing.Point(267, 488);
            this.thanksForPlayingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.thanksForPlayingLabel.Name = "thanksForPlayingLabel";
            this.thanksForPlayingLabel.Size = new System.Drawing.Size(282, 37);
            this.thanksForPlayingLabel.TabIndex = 9;
            this.thanksForPlayingLabel.Text = "Thank you for playing!";
            this.thanksForPlayingLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // runnerUpText
            // 
            this.runnerUpText.AutoSize = true;
            this.runnerUpText.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runnerUpText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.runnerUpText.Location = new System.Drawing.Point(57, 178);
            this.runnerUpText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.runnerUpText.Name = "runnerUpText";
            this.runnerUpText.Size = new System.Drawing.Size(165, 37);
            this.runnerUpText.TabIndex = 10;
            this.runnerUpText.Text = "<runnerUp>";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.headerLabel.Location = new System.Drawing.Point(248, 25);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(301, 50);
            this.headerLabel.TabIndex = 11;
            this.headerLabel.Text = "Congratulations!!!";
            // 
            // TournamentResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 612);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.runnerUpText);
            this.Controls.Add(this.thanksForPlayingLabel);
            this.Controls.Add(this.prizeTwoText);
            this.Controls.Add(this.prizeOneText);
            this.Controls.Add(this.whoWonText);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TournamentResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TournamentResultForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label whoWonText;
        private System.Windows.Forms.Label prizeOneText;
        private System.Windows.Forms.Label prizeTwoText;
        private System.Windows.Forms.Label thanksForPlayingLabel;
        private System.Windows.Forms.Label runnerUpText;
        private System.Windows.Forms.Label headerLabel;
    }
}