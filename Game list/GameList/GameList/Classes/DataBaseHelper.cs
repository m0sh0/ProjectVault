using GameList;
using GameList.Classes;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Collections.ObjectModel;
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

    public static async Task<ObservableCollection<Game>> SortGamesAlphabetically(string sql)
    {
        using (NpgsqlConnection conn = new(_connectionstring))
        {
            await conn.OpenAsync();

            using (NpgsqlCommand cmd = new(sql, conn))
            using (NpgsqlDataReader reader = cmd.ExecuteReader())
            {
                ObservableCollection<Game> sortedGames = new();
                while (reader.Read())
                {
                    // Adding each game to the ObservableCollection in a sorted manner
                    sortedGames.Add(new Game
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

                // Update the DataGrid with the sorted games
                return sortedGames;

                //DataGrid grid = ((MainWindow)Application.Current.MainWindow).GamesDataGridPublic;
                //grid.ItemsSource = sortedGames;
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