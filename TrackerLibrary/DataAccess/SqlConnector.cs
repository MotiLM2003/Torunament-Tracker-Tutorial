using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using TrackerLibrary.Model;
using System.Configuration;
using Dapper;

namespace TrackerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        private const string db = "Tournamant";
        public PersonModel CreatePerson(PersonModel model)
        {
            using (IDbConnection conneciton = new System.Data.SqlClient.SqlConnection(GlobalConfig.GetConnection(db)))
            {
                // var p = new DynamicParameters
                var p = new DynamicParameters();
                p.Add("@FirstName", model.FirstName);
                p.Add("@LastNAme", model.LastName);
                p.Add("@EmailAddress", model.EmailAddress);
                p.Add("@CellphoneNumber", model.CellphoneNumber);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                conneciton.Execute("dbo.spPepole_Insert", p, commandType: CommandType.StoredProcedure);
                model.Id = p.Get<int>("@id");
                return model;
            }
        }


        public PrizeModel CreatePrize(PrizeModel model)
        {
            using (IDbConnection conneciton = new System.Data.SqlClient.SqlConnection(GlobalConfig.GetConnection(db)))
            {
                // var p = new DynamicParameters
                var p = new DynamicParameters();
                p.Add("@placeNumber", model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.PrizeAmount);
                p.Add("@PrizePercentage", model.PrizePercentage);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                conneciton.Execute("dbo.spPrizes_insert", p, commandType: CommandType.StoredProcedure);
                model.id = p.Get<int>("@id");
                return model;
            }
        }

        public TeamModel CreateTeam(TeamModel model)
        {
            using (IDbConnection conneciton = new System.Data.SqlClient.SqlConnection(GlobalConfig.GetConnection(db)))
            {
                // var p = new DynamicParameters
                var p = new DynamicParameters();
                p.Add("@TeamName", model.TeamName);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                conneciton.Execute("dbo.spTeam_insert", p, commandType: CommandType.StoredProcedure);
                model.id = p.Get<int>("@id");

                foreach (PersonModel tm in model.TeamMembers)
                {
                    p = new DynamicParameters();
                    p.Add("@TeamID", model.id);
                    p.Add("@PersonID", tm.Id);
                    conneciton.Execute("dbo.spTeamMembers_Insert", p, commandType: CommandType.StoredProcedure);


                }

                return model;
            }
        }

        public void CreateTournamenet(TournamentModel model)
        {
            using (IDbConnection conneciton = new System.Data.SqlClient.SqlConnection(GlobalConfig.GetConnection(db)))
            {
                // var p = new DynamicParameters
                var p = new DynamicParameters();
                p.Add("@TournamentName", model.TournamentName);
                p.Add("@EntryFee", model.EntryFee);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                conneciton.Execute("dbo.spTournament_Insert", p, commandType: CommandType.StoredProcedure);
                foreach (PrizeModel pz in model.Prizes)
                {
                    p = new DynamicParameters();
                    p.Add("@TournamentId", model.Id);
                    p.Add("@PrizeId", pz.id);
                    conneciton.Execute("dbo.spTournamentPrizes_Insert", p, commandType: CommandType.StoredProcedure);

                }

                foreach (TeamModel team in model.EnterdTeams)
                {
                    p = new DynamicParameters();
                    p.Add("@TournamentId", model.Id);
                    p.Add("@TeamID", team.id);
                    conneciton.Execute("dbo.spTournamentEntries_Insert", p, commandType: CommandType.StoredProcedure);
                }
                   

            //    return model;
            }
        }

       

        public List<PersonModel> GetPerson_All()
        {
            List<PersonModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.GetConnection(db)))
            {
                output = connection.Query<PersonModel>("dbo.spPeople_GetAll").ToList();
            }

            return output;
        }

        public List<TeamModel> GetTeam_All()
        {
            List<TeamModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.GetConnection(db)))
            {
                output = connection.Query<TeamModel>("dbo.spTeam_GetAll").ToList();
                foreach (TeamModel team in output)
                {
                    var p = new DynamicParameters();
                    p.Add("@TeamId", team.id);
                    team.TeamMembers = connection.Query<PersonModel>("dbo.spTeamMembers_GetByTeam",p,commandType: CommandType.StoredProcedure).ToList();
                }
            }

            return output;
        }
    }
}
