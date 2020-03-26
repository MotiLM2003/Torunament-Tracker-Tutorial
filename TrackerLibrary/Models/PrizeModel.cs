using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Model
{
    public class PrizeModel
    {


        #region Constructors
        public PrizeModel()
        {

        }



        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            this.PlaceName = placeName;
            int.TryParse(placeNumber, out int placeNumberValue);
            decimal.TryParse(prizeAmount, out decimal prizeAmountValue);
            double.TryParse(prizePercentage, out double prizePercentageValue);
            this.PlaceNumber = placeNumberValue;
            this.PrizeAmount = prizeAmountValue;
            this.PrizePercentage = prizePercentageValue;

        }
        #endregion



        #region Properties

        public int id { get; set; }
        public int PlaceNumber { get; set; }
        public string PlaceName { get; set; }
        public decimal PrizeAmount { get; set; }
        public double PrizePercentage { get; set; }

        public string DisplayMemeber { get { return $"{this.PlaceNumber} - {this.PlaceName}"; } }

        #endregion



            }
}
