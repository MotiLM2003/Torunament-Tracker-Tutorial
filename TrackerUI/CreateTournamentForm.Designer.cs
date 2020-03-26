namespace TrackerUI
{
    partial class CreateTournament
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
            this.txbEntryFee = new System.Windows.Forms.TextBox();
            this.lblEntryFee = new System.Windows.Forms.Label();
            this.roundDropDown = new System.Windows.Forms.ComboBox();
            this.lblRound = new System.Windows.Forms.Label();
            this.btnCreateTournament = new System.Windows.Forms.Button();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.tournamentTeamList = new System.Windows.Forms.ListBox();
            this.lbltpl = new System.Windows.Forms.Label();
            this.btnDeleteSelectedPlayers = new System.Windows.Forms.Button();
            this.btnDeleteSelectedPrizes = new System.Windows.Forms.Button();
            this.lblPrizes = new System.Windows.Forms.Label();
            this.PrizesListBox = new System.Windows.Forms.ListBox();
            this.TeamOneName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTNValue = new System.Windows.Forms.TextBox();
            this.lbSelectTeam2 = new System.Windows.Forms.Label();
            this.llCreateNew = new System.Windows.Forms.LinkLabel();
            this.cmbSelectedTeam = new System.Windows.Forms.ComboBox();
            this.btnCreatePrize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbEntryFee
            // 
            this.txbEntryFee.Location = new System.Drawing.Point(139, 131);
            this.txbEntryFee.Name = "txbEntryFee";
            this.txbEntryFee.Size = new System.Drawing.Size(150, 32);
            this.txbEntryFee.TabIndex = 11;
            this.txbEntryFee.Text = "0";
            this.txbEntryFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEntryFee
            // 
            this.lblEntryFee.AutoSize = true;
            this.lblEntryFee.Location = new System.Drawing.Point(24, 133);
            this.lblEntryFee.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEntryFee.Name = "lblEntryFee";
            this.lblEntryFee.Size = new System.Drawing.Size(106, 26);
            this.lblEntryFee.TabIndex = 10;
            this.lblEntryFee.Text = "Entry Fee";
            // 
            // roundDropDown
            // 
            this.roundDropDown.FormattingEnabled = true;
            this.roundDropDown.Location = new System.Drawing.Point(106, 171);
            this.roundDropDown.Name = "roundDropDown";
            this.roundDropDown.Size = new System.Drawing.Size(183, 33);
            this.roundDropDown.TabIndex = 13;
            this.roundDropDown.Text = "l";
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Location = new System.Drawing.Point(24, 174);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(76, 26);
            this.lblRound.TabIndex = 12;
            this.lblRound.Text = "Round";
            // 
            // btnCreateTournament
            // 
            this.btnCreateTournament.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCreateTournament.FlatAppearance.BorderSize = 2;
            this.btnCreateTournament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnCreateTournament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCreateTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTournament.Location = new System.Drawing.Point(164, 703);
            this.btnCreateTournament.Name = "btnCreateTournament";
            this.btnCreateTournament.Size = new System.Drawing.Size(279, 55);
            this.btnCreateTournament.TabIndex = 18;
            this.btnCreateTournament.Text = "Create Tournament";
            this.btnCreateTournament.UseVisualStyleBackColor = true;
            this.btnCreateTournament.Click += new System.EventHandler(this.btnCreateTournament_Click);
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAddTeam.FlatAppearance.BorderSize = 2;
            this.btnAddTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnAddTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAddTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTeam.Location = new System.Drawing.Point(29, 299);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(260, 43);
            this.btnAddTeam.TabIndex = 17;
            this.btnAddTeam.Text = "Add Team";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // tournamentTeamList
            // 
            this.tournamentTeamList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentTeamList.FormattingEnabled = true;
            this.tournamentTeamList.ItemHeight = 25;
            this.tournamentTeamList.Location = new System.Drawing.Point(404, 93);
            this.tournamentTeamList.Name = "tournamentTeamList";
            this.tournamentTeamList.Size = new System.Drawing.Size(353, 227);
            this.tournamentTeamList.TabIndex = 19;
            // 
            // lbltpl
            // 
            this.lbltpl.AutoSize = true;
            this.lbltpl.Location = new System.Drawing.Point(399, 63);
            this.lbltpl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbltpl.Name = "lbltpl";
            this.lbltpl.Size = new System.Drawing.Size(169, 26);
            this.lbltpl.TabIndex = 20;
            this.lbltpl.Text = "Teams / Players";
            // 
            // btnDeleteSelectedPlayers
            // 
            this.btnDeleteSelectedPlayers.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDeleteSelectedPlayers.FlatAppearance.BorderSize = 2;
            this.btnDeleteSelectedPlayers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnDeleteSelectedPlayers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnDeleteSelectedPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSelectedPlayers.Location = new System.Drawing.Point(763, 153);
            this.btnDeleteSelectedPlayers.Name = "btnDeleteSelectedPlayers";
            this.btnDeleteSelectedPlayers.Size = new System.Drawing.Size(176, 107);
            this.btnDeleteSelectedPlayers.TabIndex = 21;
            this.btnDeleteSelectedPlayers.Text = "Delete Selected ";
            this.btnDeleteSelectedPlayers.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedPlayers.Click += new System.EventHandler(this.btnDeleteSelectedPlayers_Click);
            // 
            // btnDeleteSelectedPrizes
            // 
            this.btnDeleteSelectedPrizes.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDeleteSelectedPrizes.FlatAppearance.BorderSize = 2;
            this.btnDeleteSelectedPrizes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnDeleteSelectedPrizes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnDeleteSelectedPrizes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSelectedPrizes.Location = new System.Drawing.Point(763, 453);
            this.btnDeleteSelectedPrizes.Name = "btnDeleteSelectedPrizes";
            this.btnDeleteSelectedPrizes.Size = new System.Drawing.Size(176, 116);
            this.btnDeleteSelectedPrizes.TabIndex = 24;
            this.btnDeleteSelectedPrizes.Text = "Delete Selected";
            this.btnDeleteSelectedPrizes.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedPrizes.Click += new System.EventHandler(this.btnDeleteSelectedPrizes_Click);
            // 
            // lblPrizes
            // 
            this.lblPrizes.AutoSize = true;
            this.lblPrizes.Location = new System.Drawing.Point(399, 376);
            this.lblPrizes.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPrizes.Name = "lblPrizes";
            this.lblPrizes.Size = new System.Drawing.Size(73, 26);
            this.lblPrizes.TabIndex = 23;
            this.lblPrizes.Text = "Prizes";
            // 
            // PrizesListBox
            // 
            this.PrizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrizesListBox.FormattingEnabled = true;
            this.PrizesListBox.ItemHeight = 25;
            this.PrizesListBox.Location = new System.Drawing.Point(404, 405);
            this.PrizesListBox.Name = "PrizesListBox";
            this.PrizesListBox.Size = new System.Drawing.Size(353, 227);
            this.PrizesListBox.TabIndex = 22;
            // 
            // TeamOneName
            // 
            this.TeamOneName.AutoSize = true;
            this.TeamOneName.Location = new System.Drawing.Point(24, 17);
            this.TeamOneName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TeamOneName.Name = "TeamOneName";
            this.TeamOneName.Size = new System.Drawing.Size(199, 26);
            this.TeamOneName.TabIndex = 7;
            this.TeamOneName.Text = "Create Tournament";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tournament Name";
            // 
            // txbTNValue
            // 
            this.txbTNValue.Location = new System.Drawing.Point(29, 93);
            this.txbTNValue.Name = "txbTNValue";
            this.txbTNValue.Size = new System.Drawing.Size(260, 32);
            this.txbTNValue.TabIndex = 9;
            this.txbTNValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbSelectTeam2
            // 
            this.lbSelectTeam2.AutoSize = true;
            this.lbSelectTeam2.Location = new System.Drawing.Point(24, 218);
            this.lbSelectTeam2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbSelectTeam2.Name = "lbSelectTeam2";
            this.lbSelectTeam2.Size = new System.Drawing.Size(134, 26);
            this.lbSelectTeam2.TabIndex = 25;
            this.lbSelectTeam2.Text = "Select Team";
            // 
            // llCreateNew
            // 
            this.llCreateNew.AutoSize = true;
            this.llCreateNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llCreateNew.Location = new System.Drawing.Point(199, 221);
            this.llCreateNew.Name = "llCreateNew";
            this.llCreateNew.Size = new System.Drawing.Size(90, 20);
            this.llCreateNew.TabIndex = 27;
            this.llCreateNew.TabStop = true;
            this.llCreateNew.Text = "Create new";
            this.llCreateNew.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llCreateNew_LinkClicked);
            // 
            // cmbSelectedTeam
            // 
            this.cmbSelectedTeam.FormattingEnabled = true;
            this.cmbSelectedTeam.Location = new System.Drawing.Point(29, 247);
            this.cmbSelectedTeam.Name = "cmbSelectedTeam";
            this.cmbSelectedTeam.Size = new System.Drawing.Size(260, 33);
            this.cmbSelectedTeam.TabIndex = 28;
            // 
            // btnCreatePrize
            // 
            this.btnCreatePrize.BackColor = System.Drawing.Color.White;
            this.btnCreatePrize.Location = new System.Drawing.Point(29, 357);
            this.btnCreatePrize.Name = "btnCreatePrize";
            this.btnCreatePrize.Size = new System.Drawing.Size(260, 45);
            this.btnCreatePrize.TabIndex = 29;
            this.btnCreatePrize.Text = "Create Prize";
            this.btnCreatePrize.UseVisualStyleBackColor = false;
            this.btnCreatePrize.Click += new System.EventHandler(this.btnCreatePrize_Click);
            // 
            // CreateTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(951, 776);
            this.Controls.Add(this.btnCreatePrize);
            this.Controls.Add(this.cmbSelectedTeam);
            this.Controls.Add(this.llCreateNew);
            this.Controls.Add(this.lbSelectTeam2);
            this.Controls.Add(this.btnDeleteSelectedPrizes);
            this.Controls.Add(this.lblPrizes);
            this.Controls.Add(this.PrizesListBox);
            this.Controls.Add(this.btnDeleteSelectedPlayers);
            this.Controls.Add(this.lbltpl);
            this.Controls.Add(this.tournamentTeamList);
            this.Controls.Add(this.btnCreateTournament);
            this.Controls.Add(this.btnAddTeam);
            this.Controls.Add(this.roundDropDown);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.txbEntryFee);
            this.Controls.Add(this.lblEntryFee);
            this.Controls.Add(this.txbTNValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TeamOneName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CreateTournament";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbEntryFee;
        private System.Windows.Forms.Label lblEntryFee;
        private System.Windows.Forms.ComboBox roundDropDown;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.Button btnCreateTournament;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.ListBox tournamentTeamList;
        private System.Windows.Forms.Label lbltpl;
        private System.Windows.Forms.Button btnDeleteSelectedPlayers;
        private System.Windows.Forms.Button btnDeleteSelectedPrizes;
        private System.Windows.Forms.Label lblPrizes;
        private System.Windows.Forms.ListBox PrizesListBox;
        private System.Windows.Forms.Label TeamOneName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTNValue;
        private System.Windows.Forms.Label lbSelectTeam2;
        private System.Windows.Forms.LinkLabel llCreateNew;
        private System.Windows.Forms.ComboBox cmbSelectedTeam;
        private System.Windows.Forms.Button btnCreatePrize;
    }
}