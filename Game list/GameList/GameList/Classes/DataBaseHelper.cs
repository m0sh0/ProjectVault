using GameList;
using GameList.Classes;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

public static class DataBaseHelper
{

    private static string _connectionstring = LoadConnectionString();

    public static async Task<ObservableCollection<Game>> LoadGamesAsync()
    {
        ObservableCollection<Game> games = new();

        // Open a connection to the database
        using (NpgsqlConnection conn = new(_connectionstring))
        {
            await conn.OpenAsync();

            using (NpgsqlCommand cmd = new("SELECT * FROM games ORDER BY id", conn))
            using (NpgsqlDataReader reader = cmd.ExecuteReader())
            {
                // Read the data from the database and populate the ObservableCollection
                while (reader.Read())
                {
                    games.Add(new Game
                    {
                        id = reader.GetInt32(0),
                        title = reader.GetString(1),
                        genre = reader.GetString(2),
                        platform = reader.GetString(3),
                        releasedate = reader.GetDateTime(4),
                        completed = reader.GetBoolean(5),
                        rating = reader.GetInt32(6)

                    });
                }

                return games;
            }
        }
    }

    public static string LoadConnectionString()
    {
        IConfigurationRoot config = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();

        return config["ConnectionString"];
    }
}