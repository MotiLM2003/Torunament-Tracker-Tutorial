using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            // Initialize the database connection
            TrackerLibrary.Model.GlobalConfig.InitializeConnections(TrackerLibrary.DatabaseType.SQL);
            Application.Run(new CreateTournament());
            //   Application.Run(new TournamentDashboard());
        }
    }
}
