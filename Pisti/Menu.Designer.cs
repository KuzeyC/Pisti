namespace Pisti
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.bEasyMode = new System.Windows.Forms.Button();
            this.bMediumMode = new System.Windows.Forms.Button();
            this.bHardMode = new System.Windows.Forms.Button();
            this.bHowToPlay = new System.Windows.Forms.Button();
            this.bAchievements = new System.Windows.Forms.Button();
            this.bExtreme = new System.Windows.Forms.Button();
            this.bLeaderboard = new System.Windows.Forms.Button();
            this.tbMenuTitle = new System.Windows.Forms.TextBox();
            this.bCardDesign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bEasyMode
            // 
            this.bEasyMode.Location = new System.Drawing.Point(140, 65);
            this.bEasyMode.Name = "bEasyMode";
            this.bEasyMode.Size = new System.Drawing.Size(80, 23);
            this.bEasyMode.TabIndex = 4;
            this.bEasyMode.TabStop = false;
            this.bEasyMode.Text = "Easy";
            this.bEasyMode.UseVisualStyleBackColor = true;
            this.bEasyMode.Click += new System.EventHandler(this.bEasyMode_Click);
            // 
            // bMediumMode
            // 
            this.bMediumMode.Location = new System.Drawing.Point(225, 65);
            this.bMediumMode.Name = "bMediumMode";
            this.bMediumMode.Size = new System.Drawing.Size(80, 23);
            this.bMediumMode.TabIndex = 5;
            this.bMediumMode.TabStop = false;
            this.bMediumMode.Text = "Medium";
            this.bMediumMode.UseVisualStyleBackColor = true;
            this.bMediumMode.Click += new System.EventHandler(this.bMediumMode_Click);
            // 
            // bHardMode
            // 
            this.bHardMode.Location = new System.Drawing.Point(310, 65);
            this.bHardMode.Name = "bHardMode";
            this.bHardMode.Size = new System.Drawing.Size(80, 23);
            this.bHardMode.TabIndex = 6;
            this.bHardMode.TabStop = false;
            this.bHardMode.Text = "Hard";
            this.bHardMode.UseVisualStyleBackColor = true;
            this.bHardMode.Click += new System.EventHandler(this.bHardMode_Click);
            // 
            // bHowToPlay
            // 
            this.bHowToPlay.Location = new System.Drawing.Point(20, 65);
            this.bHowToPlay.Name = "bHowToPlay";
            this.bHowToPlay.Size = new System.Drawing.Size(82, 23);
            this.bHowToPlay.TabIndex = 3;
            this.bHowToPlay.TabStop = false;
            this.bHowToPlay.Text = "How To Play";
            this.bHowToPlay.UseVisualStyleBackColor = true;
            this.bHowToPlay.Click += new System.EventHandler(this.bHowToPlay_Click);
            // 
            // bAchievements
            // 
            this.bAchievements.Location = new System.Drawing.Point(20, 35);
            this.bAchievements.Name = "bAchievements";
            this.bAchievements.Size = new System.Drawing.Size(82, 23);
            this.bAchievements.TabIndex = 1;
            this.bAchievements.TabStop = false;
            this.bAchievements.Text = "Achievements";
            this.bAchievements.UseVisualStyleBackColor = true;
            this.bAchievements.Click += new System.EventHandler(this.bAchievements_Click);
            // 
            // bExtreme
            // 
            this.bExtreme.Location = new System.Drawing.Point(395, 65);
            this.bExtreme.Name = "bExtreme";
            this.bExtreme.Size = new System.Drawing.Size(80, 23);
            this.bExtreme.TabIndex = 101;
            this.bExtreme.TabStop = false;
            this.bExtreme.Text = "Extreme";
            this.bExtreme.UseVisualStyleBackColor = true;
            this.bExtreme.Click += new System.EventHandler(this.bExtreme_Click);
            // 
            // bLeaderboard
            // 
            this.bLeaderboard.Location = new System.Drawing.Point(515, 35);
            this.bLeaderboard.Name = "bLeaderboard";
            this.bLeaderboard.Size = new System.Drawing.Size(82, 23);
            this.bLeaderboard.TabIndex = 2;
            this.bLeaderboard.TabStop = false;
            this.bLeaderboard.Text = "Leaderboard";
            this.bLeaderboard.UseVisualStyleBackColor = true;
            this.bLeaderboard.Click += new System.EventHandler(this.bLeaderboard_Click);
            // 
            // tbMenuTitle
            // 
            this.tbMenuTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMenuTitle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbMenuTitle.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbMenuTitle.Location = new System.Drawing.Point(250, 30);
            this.tbMenuTitle.Name = "tbMenuTitle";
            this.tbMenuTitle.ReadOnly = true;
            this.tbMenuTitle.Size = new System.Drawing.Size(130, 18);
            this.tbMenuTitle.TabIndex = 100;
            this.tbMenuTitle.TabStop = false;
            this.tbMenuTitle.Text = "Select Bot Difficulty";
            this.tbMenuTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bCardDesign
            // 
            this.bCardDesign.Location = new System.Drawing.Point(515, 65);
            this.bCardDesign.Name = "bCardDesign";
            this.bCardDesign.Size = new System.Drawing.Size(82, 23);
            this.bCardDesign.TabIndex = 102;
            this.bCardDesign.TabStop = false;
            this.bCardDesign.Text = "Card Design";
            this.bCardDesign.UseVisualStyleBackColor = true;
            this.bCardDesign.Click += new System.EventHandler(this.bCardDesign_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 111);
            this.Controls.Add(this.bCardDesign);
            this.Controls.Add(this.bExtreme);
            this.Controls.Add(this.bAchievements);
            this.Controls.Add(this.bLeaderboard);
            this.Controls.Add(this.bHowToPlay);
            this.Controls.Add(this.tbMenuTitle);
            this.Controls.Add(this.bHardMode);
            this.Controls.Add(this.bMediumMode);
            this.Controls.Add(this.bEasyMode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bEasyMode;
        private System.Windows.Forms.Button bMediumMode;
        private System.Windows.Forms.Button bHardMode;
        private System.Windows.Forms.Button bHowToPlay;
        private System.Windows.Forms.Button bAchievements;
        private System.Windows.Forms.Button bExtreme;
        private System.Windows.Forms.Button bLeaderboard;
        private System.Windows.Forms.Button bCardDesign;
        private System.Windows.Forms.TextBox tbMenuTitle;
    }
}