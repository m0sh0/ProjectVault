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
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GameList.View.UserControl
{

    public partial class AlphabeticSortButton : System.Windows.Controls.UserControl
    {
        private static string _connectionString = DataBaseHelper.LoadConnectionString();
        public AlphabeticSortButton()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SortAlphabetically();
        }

        private async void SortAlphabetically()
        {
            using (NpgsqlConnection conn = new(_connectionString))
            {
                await conn.OpenAsync();

                const string sql = "SELECT * FROM games ORDER BY title";

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
                    DataGrid grid = ((MainWindow)Application.Current.MainWindow).GamesDataGridPublic;
                    grid.ItemsSource = sortedGames;
                }
            }
        }
    }
}
