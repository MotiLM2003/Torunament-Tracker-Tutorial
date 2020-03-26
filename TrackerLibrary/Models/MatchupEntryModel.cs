using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Model
{ 
    public class MatchupEntryModel
    {
        public int Id { set; get; }
        public TeamModel TeamCompeting { get; set; }
        public double Score { set; get; }
        public MatchupModel ParentMatchup { get; set; }



    }
}
