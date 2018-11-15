namespace Pisti
{
    partial class InputName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputName));
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbInputNameTitle = new System.Windows.Forms.TextBox();
            this.tbFinalScore = new System.Windows.Forms.TextBox();
            this.tbScoreTitle = new System.Windows.Forms.TextBox();
            this.tbDifficultyTitle = new System.Windows.Forms.TextBox();
            this.tbDifficulty = new System.Windows.Forms.TextBox();
            this.bSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(25, 45);
            this.tbName.MaxLength = 10;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 0;
            this.tbName.TabStop = false;
            // 
            // tbInputNameTitle
            // 
            this.tbInputNameTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbInputNameTitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbInputNameTitle.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbInputNameTitle.Location = new System.Drawing.Point(33, 20);
            this.tbInputNameTitle.Name = "tbInputNameTitle";
            this.tbInputNameTitle.ReadOnly = true;
            this.tbInputNameTitle.Size = new System.Drawing.Size(81, 18);
            this.tbInputNameTitle.TabIndex = 0;
            this.tbInputNameTitle.TabStop = false;
            this.tbInputNameTitle.Text = "Input Name";
            this.tbInputNameTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbFinalScore
            // 
            this.tbFinalScore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFinalScore.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbFinalScore.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbFinalScore.Location = new System.Drawing.Point(160, 45);
            this.tbFinalScore.Name = "tbFinalScore";
            this.tbFinalScore.ReadOnly = true;
            this.tbFinalScore.Size = new System.Drawing.Size(40, 18);
            this.tbFinalScore.TabIndex = 0;
            this.tbFinalScore.TabStop = false;
            this.tbFinalScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbScoreTitle
            // 
            this.tbScoreTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbScoreTitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbScoreTitle.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbScoreTitle.Location = new System.Drawing.Point(155, 20);
            this.tbScoreTitle.Name = "tbScoreTitle";
            this.tbScoreTitle.ReadOnly = true;
            this.tbScoreTitle.Size = new System.Drawing.Size(52, 18);
            this.tbScoreTitle.TabIndex = 0;
            this.tbScoreTitle.TabStop = false;
            this.tbScoreTitle.Text = "Score";
            this.tbScoreTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbDifficultyTitle
            // 
            this.tbDifficultyTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDifficultyTitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbDifficultyTitle.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbDifficultyTitle.Location = new System.Drawing.Point(250, 20);
            this.tbDifficultyTitle.Name = "tbDifficultyTitle";
            this.tbDifficultyTitle.ReadOnly = true;
            this.tbDifficultyTitle.Size = new System.Drawing.Size(64, 18);
            this.tbDifficultyTitle.TabIndex = 0;
            this.tbDifficultyTitle.TabStop = false;
            this.tbDifficultyTitle.Text = "Difficulty";
            this.tbDifficultyTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbDifficulty
            // 
            this.tbDifficulty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDifficulty.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbDifficulty.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbDifficulty.Location = new System.Drawing.Point(230, 45);
            this.tbDifficulty.Name = "tbDifficulty";
            this.tbDifficulty.ReadOnly = true;
            this.tbDifficulty.Size = new System.Drawing.Size(107, 18);
            this.tbDifficulty.TabIndex = 8;
            this.tbDifficulty.TabStop = false;
            this.tbDifficulty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bSubmit
            // 
            this.bSubmit.Location = new System.Drawing.Point(370, 43);
            this.bSubmit.Name = "bSubmit";
            this.bSubmit.Size = new System.Drawing.Size(80, 23);
            this.bSubmit.TabIndex = 9;
            this.bSubmit.TabStop = false;
            this.bSubmit.Text = "Submit";
            this.bSubmit.UseVisualStyleBackColor = true;
            this.bSubmit.Click += new System.EventHandler(this.bSubmit_Click);
            // 
            // InputName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 91);
            this.Controls.Add(this.bSubmit);
            this.Controls.Add(this.tbDifficulty);
            this.Controls.Add(this.tbDifficultyTitle);
            this.Controls.Add(this.tbScoreTitle);
            this.Controls.Add(this.tbFinalScore);
            this.Controls.Add(this.tbInputNameTitle);
            this.Controls.Add(this.tbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InputName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputName";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbInputNameTitle;
        private System.Windows.Forms.TextBox tbFinalScore;
        private System.Windows.Forms.TextBox tbScoreTitle;
        private System.Windows.Forms.TextBox tbDifficultyTitle;
        private System.Windows.Forms.TextBox tbDifficulty;
        private System.Windows.Forms.Button bSubmit;
    }
}