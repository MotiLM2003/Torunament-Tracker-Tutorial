namespace TrackerUI
{
    partial class CreateTeam
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
            this.tbTeamNAme = new System.Windows.Forms.TextBox();
            this.lbTeamName = new System.Windows.Forms.Label();
            this.TeamOneName = new System.Windows.Forms.Label();
            this.lblAddMember = new System.Windows.Forms.Label();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.cbAddMember = new System.Windows.Forms.ComboBox();
            this.gbAddNewMember = new System.Windows.Forms.GroupBox();
            this.btnCreateMember = new System.Windows.Forms.Button();
            this.txbCellphoneNumber = new System.Windows.Forms.TextBox();
            this.lblCellphone = new System.Windows.Forms.Label();
            this.txbEmailAddress = new System.Windows.Forms.TextBox();
            this.lblEMail = new System.Windows.Forms.Label();
            this.txbLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txbFirstName = new System.Windows.Forms.TextBox();
            this.lblTeamOne = new System.Windows.Forms.Label();
            this.teamMembersListBox = new System.Windows.Forms.ListBox();
            this.btnCreateTeam = new System.Windows.Forms.Button();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.gbAddNewMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbTeamNAme
            // 
            this.tbTeamNAme.Location = new System.Drawing.Point(20, 95);
            this.tbTeamNAme.Name = "tbTeamNAme";
            this.tbTeamNAme.Size = new System.Drawing.Size(260, 32);
            this.tbTeamNAme.TabIndex = 12;
            this.tbTeamNAme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbTeamName
            // 
            this.lbTeamName.AutoSize = true;
            this.lbTeamName.Location = new System.Drawing.Point(15, 65);
            this.lbTeamName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTeamName.Name = "lbTeamName";
            this.lbTeamName.Size = new System.Drawing.Size(128, 26);
            this.lbTeamName.TabIndex = 11;
            this.lbTeamName.Text = "Team name";
            // 
            // TeamOneName
            // 
            this.TeamOneName.AutoSize = true;
            this.TeamOneName.Location = new System.Drawing.Point(15, 19);
            this.TeamOneName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TeamOneName.Name = "TeamOneName";
            this.TeamOneName.Size = new System.Drawing.Size(138, 26);
            this.TeamOneName.TabIndex = 10;
            this.TeamOneName.Text = "Create Team";
            // 
            // lblAddMember
            // 
            this.lblAddMember.AutoSize = true;
            this.lblAddMember.Location = new System.Drawing.Point(15, 144);
            this.lblAddMember.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAddMember.Name = "lblAddMember";
            this.lblAddMember.Size = new System.Drawing.Size(220, 26);
            this.lblAddMember.TabIndex = 27;
            this.lblAddMember.Text = "Select Team Member";
            // 
            // btnAddMember
            // 
            this.btnAddMember.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAddMember.FlatAppearance.BorderSize = 2;
            this.btnAddMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnAddMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMember.Location = new System.Drawing.Point(20, 222);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(260, 43);
            this.btnAddMember.TabIndex = 29;
            this.btnAddMember.Text = "Add Member";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // cbAddMember
            // 
            this.cbAddMember.FormattingEnabled = true;
            this.cbAddMember.Location = new System.Drawing.Point(20, 174);
            this.cbAddMember.Name = "cbAddMember";
            this.cbAddMember.Size = new System.Drawing.Size(260, 33);
            this.cbAddMember.TabIndex = 30;
            // 
            // gbAddNewMember
            // 
            this.gbAddNewMember.Controls.Add(this.btnCreateMember);
            this.gbAddNewMember.Controls.Add(this.txbCellphoneNumber);
            this.gbAddNewMember.Controls.Add(this.lblCellphone);
            this.gbAddNewMember.Controls.Add(this.txbEmailAddress);
            this.gbAddNewMember.Controls.Add(this.lblEMail);
            this.gbAddNewMember.Controls.Add(this.txbLastName);
            this.gbAddNewMember.Controls.Add(this.lblLastName);
            this.gbAddNewMember.Controls.Add(this.txbFirstName);
            this.gbAddNewMember.Controls.Add(this.lblTeamOne);
            this.gbAddNewMember.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbAddNewMember.Location = new System.Drawing.Point(20, 286);
            this.gbAddNewMember.Name = "gbAddNewMember";
            this.gbAddNewMember.Size = new System.Drawing.Size(404, 255);
            this.gbAddNewMember.TabIndex = 31;
            this.gbAddNewMember.TabStop = false;
            this.gbAddNewMember.Text = "Add New Member";
            // 
            // btnCreateMember
            // 
            this.btnCreateMember.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCreateMember.FlatAppearance.BorderSize = 2;
            this.btnCreateMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnCreateMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCreateMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateMember.Location = new System.Drawing.Point(74, 206);
            this.btnCreateMember.Name = "btnCreateMember";
            this.btnCreateMember.Size = new System.Drawing.Size(260, 43);
            this.btnCreateMember.TabIndex = 30;
            this.btnCreateMember.Text = "Create Member";
            this.btnCreateMember.UseVisualStyleBackColor = true;
            this.btnCreateMember.Click += new System.EventHandler(this.btnCreateMember_Click);
            // 
            // txbCellphoneNumber
            // 
            this.txbCellphoneNumber.Location = new System.Drawing.Point(154, 145);
            this.txbCellphoneNumber.Name = "txbCellphoneNumber";
            this.txbCellphoneNumber.Size = new System.Drawing.Size(180, 32);
            this.txbCellphoneNumber.TabIndex = 16;
            // 
            // lblCellphone
            // 
            this.lblCellphone.AutoSize = true;
            this.lblCellphone.Location = new System.Drawing.Point(6, 148);
            this.lblCellphone.Name = "lblCellphone";
            this.lblCellphone.Size = new System.Drawing.Size(110, 26);
            this.lblCellphone.TabIndex = 15;
            this.lblCellphone.Text = "Cellphone";
            // 
            // txbEmailAddress
            // 
            this.txbEmailAddress.Location = new System.Drawing.Point(154, 107);
            this.txbEmailAddress.Name = "txbEmailAddress";
            this.txbEmailAddress.Size = new System.Drawing.Size(180, 32);
            this.txbEmailAddress.TabIndex = 14;
            // 
            // lblEMail
            // 
            this.lblEMail.AutoSize = true;
            this.lblEMail.Location = new System.Drawing.Point(6, 110);
            this.lblEMail.Name = "lblEMail";
            this.lblEMail.Size = new System.Drawing.Size(68, 26);
            this.lblEMail.TabIndex = 13;
            this.lblEMail.Text = "Email";
            // 
            // txbLastName
            // 
            this.txbLastName.Location = new System.Drawing.Point(154, 69);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.Size = new System.Drawing.Size(180, 32);
            this.txbLastName.TabIndex = 12;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(6, 72);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(118, 26);
            this.lblLastName.TabIndex = 11;
            this.lblLastName.Text = "Last Name";
            // 
            // txbFirstName
            // 
            this.txbFirstName.Location = new System.Drawing.Point(154, 28);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Size = new System.Drawing.Size(180, 32);
            this.txbFirstName.TabIndex = 10;
            // 
            // lblTeamOne
            // 
            this.lblTeamOne.AutoSize = true;
            this.lblTeamOne.Location = new System.Drawing.Point(6, 31);
            this.lblTeamOne.Name = "lblTeamOne";
            this.lblTeamOne.Size = new System.Drawing.Size(119, 26);
            this.lblTeamOne.TabIndex = 9;
            this.lblTeamOne.Text = "First Name";
            // 
            // teamMembersListBox
            // 
            this.teamMembersListBox.FormattingEnabled = true;
            this.teamMembersListBox.ItemHeight = 25;
            this.teamMembersListBox.Location = new System.Drawing.Point(464, 95);
            this.teamMembersListBox.Name = "teamMembersListBox";
            this.teamMembersListBox.Size = new System.Drawing.Size(411, 454);
            this.teamMembersListBox.TabIndex = 32;
            // 
            // btnCreateTeam
            // 
            this.btnCreateTeam.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCreateTeam.FlatAppearance.BorderSize = 2;
            this.btnCreateTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnCreateTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCreateTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTeam.Location = new System.Drawing.Point(309, 595);
            this.btnCreateTeam.Name = "btnCreateTeam";
            this.btnCreateTeam.Size = new System.Drawing.Size(260, 43);
            this.btnCreateTeam.TabIndex = 33;
            this.btnCreateTeam.Text = "Create Team";
            this.btnCreateTeam.UseVisualStyleBackColor = true;
            this.btnCreateTeam.Click += new System.EventHandler(this.btnCreateTeam_Click);
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.Location = new System.Drawing.Point(913, 272);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(117, 97);
            this.btnRemoveSelected.TabIndex = 34;
            this.btnRemoveSelected.Text = "Remove Selected";
            this.btnRemoveSelected.UseVisualStyleBackColor = true;
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
            // 
            // CreateTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1079, 802);
            this.Controls.Add(this.btnRemoveSelected);
            this.Controls.Add(this.btnCreateTeam);
            this.Controls.Add(this.teamMembersListBox);
            this.Controls.Add(this.gbAddNewMember);
            this.Controls.Add(this.cbAddMember);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.lblAddMember);
            this.Controls.Add(this.tbTeamNAme);
            this.Controls.Add(this.lbTeamName);
            this.Controls.Add(this.TeamOneName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CreateTeam";
            this.Text = "Create Team";
            this.gbAddNewMember.ResumeLayout(false);
            this.gbAddNewMember.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTeamNAme;
        private System.Windows.Forms.Label lbTeamName;
        private System.Windows.Forms.Label TeamOneName;
        private System.Windows.Forms.Label lblAddMember;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.ComboBox cbAddMember;
        private System.Windows.Forms.GroupBox gbAddNewMember;
        private System.Windows.Forms.Button btnCreateMember;
        private System.Windows.Forms.TextBox txbCellphoneNumber;
        private System.Windows.Forms.Label lblCellphone;
        private System.Windows.Forms.TextBox txbEmailAddress;
        private System.Windows.Forms.Label lblEMail;
        private System.Windows.Forms.TextBox txbLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txbFirstName;
        private System.Windows.Forms.Label lblTeamOne;
        private System.Windows.Forms.ListBox teamMembersListBox;
        private System.Windows.Forms.Button btnCreateTeam;
        private System.Windows.Forms.Button btnRemoveSelected;
    }
}