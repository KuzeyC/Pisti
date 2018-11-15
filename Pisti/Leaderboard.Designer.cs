namespace Pisti
{
    partial class Leaderboard
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
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Leaderboard));
                this.dgDisplay = new System.Windows.Forms.DataGridView();
                this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.cScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.cTimestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
                this.rbEasy = new System.Windows.Forms.RadioButton();
                this.rbMedium = new System.Windows.Forms.RadioButton();
                this.rbHard = new System.Windows.Forms.RadioButton();
                this.bMenu = new System.Windows.Forms.Button();
                this.rbExtreme = new System.Windows.Forms.RadioButton();
                this.tbSelectDifficulty = new System.Windows.Forms.TextBox();
                ((System.ComponentModel.ISupportInitialize)(this.dgDisplay)).BeginInit();
                this.SuspendLayout();
            // 
            // dgDisplay
            // 
            this.dgDisplay.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgDisplay.AllowUserToAddRows = false;
            this.dgDisplay.AllowUserToDeleteRows = false;
            this.dgDisplay.AllowUserToResizeColumns = false;
            this.dgDisplay.AllowUserToResizeRows = false;
            this.dgDisplay.BackgroundColor = System.Drawing.Color.Aqua;
            this.dgDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.cName,
            this.cScore,
            this.cTimestamp});
            this.dgDisplay.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgDisplay.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgDisplay.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgDisplay.Location = new System.Drawing.Point(0, 60);
            this.dgDisplay.MultiSelect = false;
            this.dgDisplay.Name = "dgDisplay";
            this.dgDisplay.ReadOnly = true;
            this.dgDisplay.RowHeadersVisible = false;
            this.dgDisplay.ShowEditingIcon = false;
            this.dgDisplay.Size = new System.Drawing.Size(370, 243);
            this.dgDisplay.TabIndex = 0;
            this.dgDisplay.TabStop = false;
            // 
            // cID
            // 
            this.cID.DataPropertyName = "id";
            this.cID.Frozen = true;
            this.cID.HeaderText = "ID";
            this.cID.MaxInputLength = 3;
            this.cID.Name = "cID";
            this.cID.ReadOnly = true;
            this.cID.Width = 70;
            // 
            // cName
            // 
            this.cName.DataPropertyName = "name";
            this.cName.Frozen = true;
            this.cName.HeaderText = "Name";
            this.cName.Name = "cName";
            this.cName.ReadOnly = true;
            // 
            // cScore
            // 
            this.cScore.DataPropertyName = "score";
            this.cScore.Frozen = true;
            this.cScore.HeaderText = "Score";
            this.cScore.Name = "cScore";
            this.cScore.ReadOnly = true;
            this.cScore.Width = 90;
            // 
            // cTimestamp
            // 
            this.cTimestamp.DataPropertyName = "ts";
            this.cTimestamp.Frozen = true;
            this.cTimestamp.HeaderText = "Timestamp";
            this.cTimestamp.Name = "cTimestamp";
            this.cTimestamp.ReadOnly = true;
            this.cTimestamp.Width = 107;
            // 
            // rbEasy
            // 
            this.rbEasy.BackColor = System.Drawing.Color.Transparent;
            this.rbEasy.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rbEasy.ForeColor = System.Drawing.Color.Black;
            this.rbEasy.Location = new System.Drawing.Point(12, 35);
            this.rbEasy.Name = "rbEasy";
            this.rbEasy.Size = new System.Drawing.Size(66, 17);
            this.rbEasy.TabIndex = 0;
            this.rbEasy.Text = "Easy";
            this.rbEasy.UseVisualStyleBackColor = false;
            this.rbEasy.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.BackColor = System.Drawing.Color.Transparent;
            this.rbMedium.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rbMedium.ForeColor = System.Drawing.Color.Black;
            this.rbMedium.Location = new System.Drawing.Point(67, 35);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(72, 17);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = false;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbHard
            // 
            this.rbHard.BackColor = System.Drawing.Color.Transparent;
            this.rbHard.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rbHard.ForeColor = System.Drawing.Color.Black;
            this.rbHard.Location = new System.Drawing.Point(135, 35);
            this.rbHard.Name = "rbHard";
            this.rbHard.Size = new System.Drawing.Size(72, 17);
            this.rbHard.TabIndex = 2;
            this.rbHard.Text = "Hard";
            this.rbHard.UseVisualStyleBackColor = false;
            this.rbHard.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // bMenu
            // 
            this.bMenu.Location = new System.Drawing.Point(283, 8);
            this.bMenu.Name = "bMenu";
            this.bMenu.Size = new System.Drawing.Size(75, 23);
            this.bMenu.TabIndex = 3;
            this.bMenu.TabStop = false;
            this.bMenu.Text = "Menu";
            this.bMenu.UseVisualStyleBackColor = true;
            this.bMenu.Click += new System.EventHandler(this.bMenu_Click);
            // 
            // rbExtreme
            // 
            this.rbExtreme.BackColor = System.Drawing.Color.Transparent;
            this.rbExtreme.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbExtreme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rbExtreme.ForeColor = System.Drawing.Color.Black;
            this.rbExtreme.Location = new System.Drawing.Point(190, 35);
            this.rbExtreme.Name = "rbExtreme";
            this.rbExtreme.Size = new System.Drawing.Size(72, 17);
            this.rbExtreme.TabIndex = 4;
            this.rbExtreme.Text = "Extreme";
            this.rbExtreme.UseVisualStyleBackColor = false;
            this.rbExtreme.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // tbSelectDifficulty
            // 
            this.tbSelectDifficulty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSelectDifficulty.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbSelectDifficulty.Font = new System.Drawing.Font("Arial", 11.25F);
            this.tbSelectDifficulty.Location = new System.Drawing.Point(10, 10);
            this.tbSelectDifficulty.Name = "tbSelectDifficulty";
            this.tbSelectDifficulty.ReadOnly = true;
            this.tbSelectDifficulty.Size = new System.Drawing.Size(249, 18);
            this.tbSelectDifficulty.TabIndex = 0;
            this.tbSelectDifficulty.TabStop = false;
            this.tbSelectDifficulty.Text = "Select a Difficulty to Change the Table";
            this.tbSelectDifficulty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Leaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 303);
            this.Controls.Add(this.rbExtreme);
            this.Controls.Add(this.bMenu);
            this.Controls.Add(this.tbSelectDifficulty);
            this.Controls.Add(this.rbHard);
            this.Controls.Add(this.rbMedium);
            this.Controls.Add(this.rbEasy);
            this.Controls.Add(this.dgDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Leaderboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leaderboard";
            ((System.ComponentModel.ISupportInitialize)(this.dgDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDisplay;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbHard;
        private System.Windows.Forms.RadioButton rbEasy;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTimestamp;
        private System.Windows.Forms.Button bMenu;
        private System.Windows.Forms.RadioButton rbExtreme;
        private System.Windows.Forms.TextBox tbSelectDifficulty;
    }
}