namespace TrackerUI
{
    partial class TournamentDashboard
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
            this.lblTournamentDashboard = new System.Windows.Forms.Label();
            this.cbSelectTeamMember = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoadTournament = new System.Windows.Forms.Button();
            this.btnCreateTournament = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTournamentDashboard
            // 
            this.lblTournamentDashboard.AutoSize = true;
            this.lblTournamentDashboard.Location = new System.Drawing.Point(164, 46);
            this.lblTournamentDashboard.Name = "lblTournamentDashboard";
            this.lblTournamentDashboard.Size = new System.Drawing.Size(240, 26);
            this.lblTournamentDashboard.TabIndex = 0;
            this.lblTournamentDashboard.Text = "Tournament Dashboard";
            // 
            // cbSelectTeamMember
            // 
            this.cbSelectTeamMember.FormattingEnabled = true;
            this.cbSelectTeamMember.Location = new System.Drawing.Point(12, 168);
            this.cbSelectTeamMember.Name = "cbSelectTeamMember";
            this.cbSelectTeamMember.Size = new System.Drawing.Size(544, 33);
            this.cbSelectTeamMember.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Load Existing Tournament";
            // 
            // btnLoadTournament
            // 
            this.btnLoadTournament.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnLoadTournament.FlatAppearance.BorderSize = 2;
            this.btnLoadTournament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnLoadTournament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnLoadTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadTournament.Location = new System.Drawing.Point(105, 222);
            this.btnLoadTournament.Name = "btnLoadTournament";
            this.btnLoadTournament.Size = new System.Drawing.Size(358, 59);
            this.btnLoadTournament.TabIndex = 21;
            this.btnLoadTournament.Text = "Load Tournament";
            this.btnLoadTournament.UseVisualStyleBackColor = true;
            // 
            // btnCreateTournament
            // 
            this.btnCreateTournament.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCreateTournament.FlatAppearance.BorderSize = 2;
            this.btnCreateTournament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnCreateTournament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCreateTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTournament.Location = new System.Drawing.Point(105, 327);
            this.btnCreateTournament.Name = "btnCreateTournament";
            this.btnCreateTournament.Size = new System.Drawing.Size(358, 59);
            this.btnCreateTournament.TabIndex = 22;
            this.btnCreateTournament.Text = "Create Tournament";
            this.btnCreateTournament.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(582, 502);
            this.Controls.Add(this.btnCreateTournament);
            this.Controls.Add(this.btnLoadTournament);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSelectTeamMember);
            this.Controls.Add(this.lblTournamentDashboard);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "TournamentDashboard";
            this.Text = "TournamentDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTournamentDashboard;
        private System.Windows.Forms.ComboBox cbSelectTeamMember;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLoadTournament;
        private System.Windows.Forms.Button btnCreateTournament;
    }
}