using GameList.Classes;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Extensions.Configuration;


namespace GameList.View.UserControl
{

    public partial class ShowTable : System.Windows.Controls.UserControl
    {
        string _connectionString = LoadConnectionString();

        public ShowTable()
        {
            InitializeComponent();

        }
        private async void ButtonShowTable_Click(object sender, RoutedEventArgs e)
        {
            await LoadGames();
        }

        // Load the connection string from .json file
        private static string LoadConnectionString()
        {
            IConfigurationRoot config = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            return config["ConnectionString"];
        }
        // Load games from the database and bind to DataGrid
        private async Task LoadGames()
        {
            ObservableCollection<Game> games = new();

            // Open a connection to the database
            using (NpgsqlConnection conn = new(_connectionString))
            {
                await conn.OpenAsync();
                using (NpgsqlCommand cmd = new("SELECT * FROM games", conn))
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
                    // Bind the ObservableCollection to the DataGrid
                    DataGrid grid = ((MainWindow)Application.Current.MainWindow).GamesDataGridPublic;
                    grid.ItemsSource = games;
                }

                
            }
            
        }

 

    }
}
