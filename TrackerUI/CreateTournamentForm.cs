using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary.Model;

namespace TrackerUI
{
    public partial class CreateTournament : Form, IPrizeRequester, ITeamRequester
    {
        List<TeamModel> avaialablerTeams = GlobalConfig.Connections.GetTeam_All();
        List<TeamModel> selectedTeam = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();
        public CreateTournament()
        {
            InitializeComponent();
            this.InitializeLists();
        }



        private void InitializeLists()
        {
            this.WireUpLists();

        }


        private void WireUpLists()
        {
            this.cmbSelectedTeam.DataSource = null;
            this.tournamentTeamList.DataSource = null;
            this.PrizesListBox.DataSource = null;
            this.cmbSelectedTeam.DataSource = this.avaialablerTeams;
            this.cmbSelectedTeam.DisplayMember = "TeamName";
            this.tournamentTeamList.DataSource = selectedTeam;
            this.tournamentTeamList.DisplayMember = "TeamName";
            this.PrizesListBox.DataSource = selectedPrizes;
            this.PrizesListBox.DisplayMember = "DisplayMemeber";
        }


        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            TeamModel p = (TeamModel)this.cmbSelectedTeam.SelectedItem;
            if (p == null) return;
            this.selectedTeam.Add(p);
            this.avaialablerTeams.Remove(p);
            this.WireUpLists();



        }

        private void btnCreatePrize_Click(object sender, EventArgs e)
        {
            //1.
            CreatePrize frm = new CreatePrize(this);
            frm.Show();
        }

        public void PrizeComplete(PrizeModel model)
        {
            this.selectedPrizes.Add(model);
            this.WireUpLists();
        }

        public void TeamComplete(TeamModel model)
        {
            this.selectedTeam.Add(model);
            this.WireUpLists();
        }

        private void llCreateNew_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeam team = new CreateTeam(this);
            team.Show();
        }

        private void btnDeleteSelectedPrizes_Click(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)this.PrizesListBox.SelectedItem;
            if (p == null) { return; }
            this.selectedPrizes.Remove(p);
            this.WireUpLists();

        }

        private void btnDeleteSelectedPlayers_Click(object sender, EventArgs e)
        {
            TeamModel p = (TeamModel)this.tournamentTeamList.SelectedItem;
            if (p == null) { return; }
            this.selectedTeam.Remove(p);
            this.avaialablerTeams.Add(p);
            this.WireUpLists();
        }

        private void btnCreateTournament_Click(object sender, EventArgs e)
        {
            // create tournament model;
            TournamentModel t = new TournamentModel();
            t.TournamentName = this.txbTNValue.Text;
            if (String.IsNullOrWhiteSpace(t.TournamentName)) { MessageBox.Show("Fill tournament name"); return; }
            if (!decimal.TryParse(this.txbEntryFee.Text, out decimal entryFeeValue))
            {
                MessageBox.Show("You need to enter a valid Entry fee.", "Invalid Fee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            t.EntryFee = entryFeeValue;
            t.Prizes = this.selectedPrizes;
            t.EnterdTeams = this.selectedTeam;


            //  Wire our matchup.
            // order our list randomly
            // check if it is big enough. if not add in byes
            //  2*2*2*2
            // create our first round of matchups
            // create everyround after that
            TournamentLogic.CreateRounds(t);

            // create tournament entry;
            // create all of the prizes entries
            // create all of the team entries
          //  GlobalConfig.Connections.CreateTournamenet(t);
            
        }
    }
}
