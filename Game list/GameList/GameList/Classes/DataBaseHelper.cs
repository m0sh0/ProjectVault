using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using GameList.Classes;

public static class DataBaseHelper
{

    private static string _connectionstring = LoadConnectionString();




    private static string LoadConnectionString()
    {
        IConfigurationRoot config = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();

        return config["ConnectionString"];
    }
}


    
