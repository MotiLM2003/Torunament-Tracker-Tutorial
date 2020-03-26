using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using TrackerLibrary.Model;


namespace TrackerLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {

        public static string FullFilePath(this string fileName)
        {
            return $"{ConfigurationManager.AppSettings["filePath"] }\\{fileName}";
        }


        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }
            return File.ReadAllLines(file).ToList();
        }

        public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                PrizeModel p = new PrizeModel();
                p.id = int.Parse(cols[0]);
                p.PlaceNumber = int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePercentage = double.Parse(cols[4]);
                output.Add(p);
            }

            return output;
        }


        public static List<TeamModel> ConvertToTeamModels(this List<string> lines, string peopleFileName)
        {
            List<PersonModel> people = peopleFileName.FullFilePath().LoadFile().ConvertToPersonModel();

            List<TeamModel> output = new List<TeamModel>();
            foreach (var line in lines)
            {
                string[] cols = line.Split(',');
                TeamModel t = new TeamModel();
                t.id = int.Parse(cols[0]);
                t.TeamName = cols[1];
                string[] personIds = cols[2].Split('|');
                foreach (string id in personIds)
                {
                    t.TeamMembers.Add(people.Where(x => x.Id == int.Parse(id)).First());
                }
                output.Add(t);
            }

            return output;
        }


        public static List<TournamentModel> ConvertToTournamentModels(this List<string> lines, string teamFileName, string peopleFileName, string PrizeFileName)
        {
            // id,tournamentname, entryFee,(id|id|id - enterd teams),(id|id|id - prize model), ( Rounds - id^id^id|id^id^id|id^id^id(
            List<TournamentModel> output = new List<TournamentModel>();
            List<TeamModel> teams = teamFileName.FullFilePath().LoadFile().ConvertToTeamModels(peopleFileName).ToList();
            List<PrizeModel> prizes= PrizeFileName.FullFilePath().LoadFile().ConvertToPrizeModels().ToList();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                TournamentModel tm = new TournamentModel();
                tm.Id = int.Parse(cols[0]);
                tm.TournamentName = cols[1];
                tm.EntryFee = decimal.Parse(cols[2]);
                string[] teamIds = cols[3].Split('|');
                foreach (string id in teamIds)
                {
                  tm.EnterdTeams.Add(teams.Where(x => x.id == int.Parse(id)).First());
                }

                string[] prizeIds = cols[4].Split('|');
                foreach (string id in prizeIds)
                {
                    tm.Prizes.Add(prizes.Where(x => x.id == int.Parse(id)).First());
                }


                // TODO -- Capture rounds information
                output.Add(tm);


            }
         
            return output;
        }



       public static  string ConvertTeamListToString(List<TeamModel> model)
        {
            string output = "";
            if(model.Count  == 0) { return String.Empty; }

            foreach (TeamModel team in model)
            {
                output = $"{team.id}|";
            }

            output = output.Substring(0, output.Length - 1);
            return output;
        }

        public static List<PersonModel> ConvertToPersonModel(this List<string> lines)
        {
            List<PersonModel> output = new List<PersonModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                PersonModel p = new PersonModel();
                p.Id = int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.EmailAddress = cols[3];
                p.CellphoneNumber = cols[4];
                output.Add(p);
            }

            return output;
        }


        public static List<PersonModel> LoadAllAvaialableTeam(this List<PersonModel> lines, string path)
        {
            List<PersonModel> lst = File.ReadAllLines(path.FullFilePath()).ToList().ConvertToPersonModel();
            return lst;
        }

        public static void SaveToPrizeFile(this List<PrizeModel> models, string filename)
        {
            List<string> lines = new List<string>();

            foreach (PrizeModel p in models)
            {
                string line = $"{p.id},{p.PlaceNumber},{p.PlaceName},{p.PrizeAmount},{p.PrizePercentage}";
                lines.Add(line);
            }

            string fullPath = filename.FullFilePath();
            File.WriteAllLines(fullPath, lines);
        }

        public static void SaveToPersonFile(this List<PersonModel> models, string filename)
        {
            List<string> lines = new List<string>();

            foreach (PersonModel p in models)
            {
                string line = $"{p.Id},{p.FirstName},{p.LastName},{p.EmailAddress},{p.CellphoneNumber}";
                lines.Add(line);
            }

            string fullPath = filename.FullFilePath();
            File.WriteAllLines(fullPath, lines);
        }

        public static void SaveToTeamFile(this List<TeamModel> models, string filename)
        {
            List<string> lines = new List<string>();

            foreach (TeamModel p in models)
            {
                string line = $"{p.id},{p.TeamName},{ConvertPeopleListToString(p.TeamMembers)}";
                lines.Add(line);
            }

            string fullPath = filename.FullFilePath();
            File.WriteAllLines(fullPath, lines);
        }


        public static  void  SaveToTournamentFile(this List<TournamentModel> models,string fileName)
        {


            List<string> lines = new List<string>();
            foreach(TournamentModel tm in models)
            {
                lines.Add($@"{tm.Id},
                             {tm.TournamentName},
                             {tm.EntryFee}, 
                             {ConvertTeamListToString(tm.EnterdTeams)},
                             {ConvertPrizeListToString(tm.Prizes)},
                             {ConvertRoundListToString(tm.Rounds)}");

              
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        private static string ConvertRoundListToString(List<List<MatchupModel>> rounds)
        {

            if (rounds.Count == 0) return string.Empty;

            System.Text.StringBuilder sb = new StringBuilder();
            foreach (List<MatchupModel>  r in rounds)
            {
                sb.AppendFormat($"{ConvertMatchupListToString(r)}|");
            }
            return sb.ToString().Substring(0, sb.Length - 1);
        }


        private static string ConvertMatchupListToString(List<MatchupModel> matchups)
        {
            if (matchups.Count == 0) return string.Empty;
            System.Text.StringBuilder sb = new StringBuilder();
            foreach (MatchupModel p in matchups)
            {
                sb.AppendFormat($"{p.Id}^");
            }

            return sb.ToString().Substring(0, sb.Length - 1);
        }


        private static string ConvertPrizeListToString(List<PrizeModel> prizes)
        {

            if (prizes.Count == 0) return string.Empty;

            System.Text.StringBuilder sb = new StringBuilder();
            foreach (PrizeModel p in prizes)
            {
                sb.AppendFormat($"{p.id}|");
            }

            return sb.ToString().Substring(0, sb.Length - 1);
        }

        private static string ConvertPeopleListToString(List<PersonModel> people)
        {

            if (people.Count == 0) return string.Empty;

            System.Text.StringBuilder sb = new StringBuilder();
            foreach (PersonModel p in people)
            {
                sb.AppendFormat($"{p.Id}|");
            }

            return sb.ToString().Substring(0, sb.Length - 1);
        }

        
    }
}
