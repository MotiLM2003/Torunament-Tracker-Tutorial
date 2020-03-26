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
    public partial class CreateTeam : Form
    {



        private List<PersonModel> availableTeamMembers = new List<PersonModel>();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        private ITeamRequester callerForm;

        public CreateTeam(ITeamRequester caller)
        {
            InitializeComponent();
            this.callerForm = caller;
            this.LoadListData();
            this.WireUpLists();
        }

        private void LoadListData()
        {
            availableTeamMembers = GlobalConfig.Connections.GetPerson_All();

        }

        private void WireUpLists()
        {
            this.cbAddMember.DataSource = null;
            this.cbAddMember.DataSource = this.availableTeamMembers;
            this.cbAddMember.DisplayMember = "FullName";
            this.teamMembersListBox.DataSource = null;
            this.teamMembersListBox.DataSource = selectedTeamMembers;
            this.teamMembersListBox.DisplayMember = "FullName";
        }
        private void btnCreateMember_Click(object sender, EventArgs e)
        {

            if (this.ValidateForm())
            {
                PersonModel p = new PersonModel();
                p.FirstName = txbFirstName.Text;
                p.LastName = txbLastName.Text;
                p.EmailAddress = txbEmailAddress.Text;
                p.CellphoneNumber = txbCellphoneNumber.Text;
                p = GlobalConfig.Connections.CreatePerson(p);
                this.selectedTeamMembers.Add(p);
                this.WireUpLists();
            }
            else
            {
                MessageBox.Show("You need to fill all fields.");
            }

        }


        private bool ValidateForm()
        {
            bool output = false;

            // TODO - Add validation to the form
            if (this.txbFirstName.Text.Length == 0)
            {
                return false;
            }
            if (this.txbLastName.Text.Length == 0)
            {
                return false;
            }
            if (this.txbEmailAddress.Text.Length == 0)
            {
                return false;
            }
            if (this.txbCellphoneNumber.Text.Length == 0)
            {
                return false;
            }

            return true;
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)cbAddMember.SelectedItem;
            if (p == null) return;
            this.availableTeamMembers.Remove(p);
            this.selectedTeamMembers.Add(p);
            this.WireUpLists();

        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;
            if (p == null) return;
            this.selectedTeamMembers.Remove(p);
            this.availableTeamMembers.Add(p);
            this.WireUpLists();
        }

        private void btnCreateTeam_Click(object sender, EventArgs e)
        {
            TeamModel model = new TeamModel();
            model.TeamName = this.tbTeamNAme.Text;
            // if team name is empty display message and quit
            if (String.IsNullOrWhiteSpace(model.TeamName)) { MessageBox.Show("You must select team name!"); tbTeamNAme.Focus(); return; }
            model.TeamMembers = this.selectedTeamMembers;
            GlobalConfig.Connections.CreateTeam(model);
            this.callerForm.TeamComplete(model);
            this.Close();
        }
    }
}
