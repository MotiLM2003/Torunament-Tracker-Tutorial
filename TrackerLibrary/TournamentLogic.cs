using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Model
{
    public static class TournamentLogic
    {

        public static void CreateRounds(TournamentModel model)
        {
            List<TeamModel> rndTeams = RandomizeTeamOrdeR(model.EnterdTeams);
            int rounds = FoudNumberOfRounds(rndTeams.Count);
            int bays = NumberOfByes(rounds, rndTeams.Count); ;
        }
 



        private static List<MatchupModel> CreateFirstRound(int numberOfBays, List<TeamModel> teams)
        {
            List<MatchupModel> output = new List<MatchupModel>();
            MatchupModel curr = new MatchupModel();
            foreach (TeamModel team in teams)
            {
                curr.Entries.Add(new MatchupEntryModel() { TeamCompeting = team });

                if(numberOfBays > 0 || curr.Entries.Count > 1)
                {
                    curr.MatchupRound = 1;
                    output.Add(curr);
                    curr = new MatchupModel();
                    if(numberOfBays > 0 ) { numberOfBays -= 1; }
                }
            }

            return output;
        }

        private static int NumberOfByes(int rounds, int numberOfTeams)
        {
            int output = 0;
            int totalTeams = 1;
            int t = rounds * 2;
            for (int i = 1; i <= rounds; i++)
            {
                totalTeams *= 2;
            }
            return totalTeams - numberOfTeams; ;
        }
        private static int FoudNumberOfRounds(int teamCount)
        {
            int output = 1;
            int val = 2;


            while (val < teamCount)
            {
                output++;
                val *= 2;
            }
            return output;
        }
        private static List<TeamModel> RandomizeTeamOrdeR(List<TeamModel> teams)
        {
            return teams.OrderBy(x => Guid.NewGuid()).ToList();

        }
    }
}
