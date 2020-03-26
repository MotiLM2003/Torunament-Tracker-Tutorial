namespace TrackerUI
{
    partial class TournamentViewerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.roundDropDown = new System.Windows.Forms.ComboBox();
            this.unplayedOnlyCheckbox = new System.Windows.Forms.CheckBox();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.TeamOneName = new System.Windows.Forms.Label();
            this.lblTeamOne = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblScoreTeamTwo = new System.Windows.Forms.Label();
            this.lblTeamTwo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tournament:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(142, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "<none>";
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Location = new System.Drawing.Point(12, 80);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(73, 30);
            this.lblRound.TabIndex = 2;
            this.lblRound.Text = "Round";
            // 
            // roundDropDown
            // 
            this.roundDropDown.FormattingEnabled = true;
            this.roundDropDown.Location = new System.Drawing.Point(91, 76);
            this.roundDropDown.Name = "roundDropDown";
            this.roundDropDown.Size = new System.Drawing.Size(241, 38);
            this.roundDropDown.TabIndex = 3;
            // 
            // unplayedOnlyCheckbox
            // 
            this.unplayedOnlyCheckbox.AutoSize = true;
            this.unplayedOnlyCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.unplayedOnlyCheckbox.Location = new System.Drawing.Point(91, 120);
            this.unplayedOnlyCheckbox.Name = "unplayedOnlyCheckbox";
            this.unplayedOnlyCheckbox.Size = new System.Drawing.Size(174, 35);
            this.unplayedOnlyCheckbox.TabIndex = 4;
            this.unplayedOnlyCheckbox.Text = "Unplayed Only";
            this.unplayedOnlyCheckbox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            this.matchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.ItemHeight = 30;
            this.matchupListBox.Location = new System.Drawing.Point(17, 197);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(315, 302);
            this.matchupListBox.TabIndex = 5;
            // 
            // TeamOneName
            // 
            this.TeamOneName.AutoSize = true;
            this.TeamOneName.Location = new System.Drawing.Point(423, 121);
            this.TeamOneName.Name = "TeamOneName";
            this.TeamOneName.Size = new System.Drawing.Size(129, 30);
            this.TeamOneName.TabIndex = 6;
            this.TeamOneName.Text = "<team one>";
            // 
            // lblTeamOne
            // 
            this.lblTeamOne.AutoSize = true;
            this.lblTeamOne.Location = new System.Drawing.Point(455, 167);
            this.lblTeamOne.Name = "lblTeamOne";
            this.lblTeamOne.Size = new System.Drawing.Size(64, 30);
            this.lblTeamOne.TabIndex = 7;
            this.lblTeamOne.Text = "Score";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(525, 167);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 35);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(526, 303);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 35);
            this.textBox2.TabIndex = 11;
            // 
            // lblScoreTeamTwo
            // 
            this.lblScoreTeamTwo.AutoSize = true;
            this.lblScoreTeamTwo.Location = new System.Drawing.Point(456, 308);
            this.lblScoreTeamTwo.Name = "lblScoreTeamTwo";
            this.lblScoreTeamTwo.Size = new System.Drawing.Size(64, 30);
            this.lblScoreTeamTwo.TabIndex = 10;
            this.lblScoreTeamTwo.Text = "Score";
            // 
            // lblTeamTwo
            // 
            this.lblTeamTwo.AutoSize = true;
            this.lblTeamTwo.Location = new System.Drawing.Point(424, 262);
            this.lblTeamTwo.Name = "lblTeamTwo";
            this.lblTeamTwo.Size = new System.Drawing.Size(128, 30);
            this.lblTeamTwo.TabIndex = 9;
            this.lblTeamTwo.Text = "<team two>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 30);
            this.label3.TabIndex = 12;
            this.label3.Text = "- VS -";
            // 
            // btnScore
            // 
            this.btnScore.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnScore.FlatAppearance.BorderSize = 2;
            this.btnScore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnScore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScore.Location = new System.Drawing.Point(460, 362);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(122, 59);
            this.btnScore.TabIndex = 13;
            this.btnScore.Text = "Score";
            this.btnScore.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(727, 755);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblScoreTeamTwo);
            this.Controls.Add(this.lblTeamTwo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTeamOne);
            this.Controls.Add(this.TeamOneName);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.unplayedOnlyCheckbox);
            this.Controls.Add(this.roundDropDown);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentViewerForm";
            this.Text = "j";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.ComboBox roundDropDown;
        private System.Windows.Forms.CheckBox unplayedOnlyCheckbox;
        private System.Windows.Forms.ListBox matchupListBox;
        private System.Windows.Forms.Label TeamOneName;
        private System.Windows.Forms.Label lblTeamOne;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblScoreTeamTwo;
        private System.Windows.Forms.Label lblTeamTwo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnScore;
    }
}

