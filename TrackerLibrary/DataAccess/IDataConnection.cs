﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Model;

namespace TrackerLibrary.DataAccess
{
    public interface IDataConnection
    {
        PrizeModel CreatePrize(PrizeModel model);
        PersonModel CreatePerson(PersonModel model);

        List<TeamModel> GetTeam_All();
        List<PersonModel> GetPerson_All();

        TeamModel CreateTeam(TeamModel model);


        void CreateTournamenet(TournamentModel Tournament);
      
    }
}
