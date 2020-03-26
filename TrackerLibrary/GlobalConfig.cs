using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary.Model
{
    public static class GlobalConfig
    {
        public static TrackerLibrary.DataAccess.IDataConnection Connections { get; private set; }  
        public static void InitializeConnections(DatabaseType connectionType)
        {


            switch (connectionType)
            {
                case DatabaseType.SQL:
                    Connections = new SqlConnector();
                    break;
                case DatabaseType.TEXT:
                    Connections = new TextConnection();
                    break;
                case DatabaseType.MySQL:
                    throw new AppDomainUnloadedException();
                    break;
                default:
                    break;
            }

            if (connectionType == DatabaseType.SQL)
            {
                Connections = new SqlConnector();
            }

            else if (connectionType ==   DatabaseType.TEXT) 
            {
                Connections = new TextConnection();
            }



        }
        public static string GetConnection(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }


    }
}
