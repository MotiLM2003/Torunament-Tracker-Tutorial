using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Model;
using System.IO;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess
{
    public class TextConnection : IDataConnection
    {

        private const string PrizesFile = "PrizeModels.csv";
        private const string PeopleFile = "PeopleModels.csv";
        private const string TeamFile = "TeamModels.csv";
        private const string TournamentFile = "TournamentModel.csv";


        public PersonModel CreatePerson(PersonModel model)
        {
            List<PersonModel> persons = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModel();
            int currentID = persons.Count > 0 ? persons.OrderByDescending(x => x.Id).First().Id + 1 : 1;
            model.Id = currentID;
            persons.Add(model);
            persons.SaveToPersonFile(PeopleFile);
            return model;
        }

        public PrizeModel CreatePrize(PrizeModel model)
        {
            List<PrizeModel> prizes =  PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            int currentID =  prizes.Count > 0 ? prizes.OrderByDescending(x => x.id).First().id + 1  : 1;
            model.id = currentID;
            prizes.Add(model);
            prizes.SaveToPrizeFile(PrizesFile);
            return model;
        }


        public TeamModel CreateTeam(TeamModel model)
        {
            List<TeamModel> teams = TeamFile.FullFilePath().LoadFile().ConvertToTeamModels(PeopleFile);
            int currentID = teams.Count > 0 ? teams.OrderByDescending(x => x.id).First().id + 1 : 1;
            model.id = currentID;
            teams.Add(model);
            teams.SaveToTeamFile(TeamFile);
            return model;
        }

        public void CreateTournamenet(TournamentModel model)
        {
            List<TournamentModel> tournaments = TournamentFile.FullFilePath().LoadFile().ConvertToTournamentModels(TeamFile, PeopleFile,  PrizesFile);

            int id = tournaments.Count > 0 ? tournaments.OrderByDescending(x => x.Id).First().Id + 1 : 0;
            model.Id = id;
            tournaments.Add(model);
            tournaments.SaveToTournamentFile(TournamentFile);


         //   return model;
        }

      

        public List<PersonModel> GetPerson_All()
        {
            List<PersonModel> lst = new List<PersonModel>();
         return   lst.LoadAllAvaialableTeam(PeopleFile);
        }

        public List<TeamModel> GetTeam_All()
        {
           return TeamFile.FullFilePath().LoadFile().ConvertToTeamModels(PeopleFile);
        }
    }
}
