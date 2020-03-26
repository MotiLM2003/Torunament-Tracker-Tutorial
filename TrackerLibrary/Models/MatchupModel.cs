using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Model
{
    public class MatchupModel
    {
        public int Id { set; get; }
        public List<MatchupEntryModel> Entries { get; set; }
        public TeamModel Winner { set; get; }
        public int MatchupRound { set; get; }
    }
}
