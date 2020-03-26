using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TrackerLibrary.Model
{
   public class TournamentModel
    {

        public int Id { set; get; }
        public string TournamentName { get; set; }
        public decimal EntryFee{ get; set; }
        public List<TeamModel> EnterdTeams { get; set; }
        public List<PrizeModel>  Prizes { get; set; }
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();



    }
}
