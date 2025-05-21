using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GameList.Classes;
using Npgsql;

namespace GameList
{
    public partial class MainWindow : Window
    {

        private const string connectionString = "Host=192.168.0.114;" +
                                                "Port=5432;" +
                                                "Username=postgres;" +
                                                "Password=PostgreMishoSQL;" +
                                                "Database=games";

        public MainWindow()
        {
            InitializeComponent();
            LoadGames();
        }

        // Method to load games from the database
        private void LoadGames()
        {
            var games = new ObservableCollection<Game>();

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT * FROM games", conn))
                using (var reader = cmd.ExecuteReader())
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
                }
                GamesDataGrid.ItemsSource = games;




            }
        }
    }
}