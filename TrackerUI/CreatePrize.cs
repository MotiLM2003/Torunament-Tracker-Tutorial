using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Model;

namespace TrackerUI
{
    public partial class CreatePrize : Form
    {

        IPrizeRequester callingForm;
        public CreatePrize(IPrizeRequester caller)
        {
            InitializeComponent();
            this.callingForm = caller;
        }

        private void btnCreatePrize_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(txbPlaceName.Text,
                                                 txbPlaceNumber.Text,
                                                 txbPrizeAmount.Text,
                                                 txbPrizePercentage.Text);

                try
                {

                 GlobalConfig.Connections.CreatePrize(model);
                    this.callingForm.PrizeComplete(model);
                    this.Close();
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Invalid information. Please try again.");
            }
        }

        private bool ValidateForm()
        {
            bool result = true;
            if (txbPlaceName.Text.Length == 0 || !int.TryParse(txbPlaceNumber.Text, out int placeNumber) || placeNumber < 1)
            {
                result = false;
            }

            if (!decimal.TryParse(txbPrizeAmount.Text, out decimal prizeAmount)
                 || !int.TryParse(txbPrizePercentage.Text, out int prizePercentage)
                 || (prizeAmount <= 0 && prizePercentage <= 0) ||
                 (prizePercentage < 0 || prizePercentage > 100))
            {
                result = false;
            }



            return result;
        }

        private void ClearForm()
        {
            txbPlaceName.Text = "Temp place";
            txbPlaceNumber.Text = "3";
            txbPrizeAmount.Text = "10";
            txbPrizePercentage.Text = "0";
        }
    }
}
