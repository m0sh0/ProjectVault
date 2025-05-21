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

namespace GameList.View.UserControl
{

    public partial class ShowTable : System.Windows.Controls.UserControl
    {
        private const string ConnectionString = "Host=192.168.0.114;" +
                                                "Port=5432;" +
                                                "Username=postgres;" +
                                                "Password=PostgreMishoSQL;" +
                                                "Database=games";

        public ShowTable()
        {
            InitializeComponent();


        }
        private async void ButtonShowTable_Click(object sender, RoutedEventArgs e)
        {
            await LoadGames();
        }

        private async Task LoadGames()
        {
            ObservableCollection<Game> games = new();

            using (NpgsqlConnection conn = new(ConnectionString))
            {
                await conn.OpenAsync();
                using (NpgsqlCommand cmd = new("SELECT * FROM games", conn))
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
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
                    DataGrid grid = ((MainWindow)Application.Current.MainWindow).GamesDataGridPublic;
                    grid.ItemsSource = games;
                }

                
            }
        }

    }
}
