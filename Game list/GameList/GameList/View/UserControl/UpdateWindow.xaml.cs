using GameList.Classes;
using Microsoft.Extensions.Configuration;
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
using System.Windows.Shapes;

namespace GameList.View.UserControl
{

    public partial class UpdateWindow : Window
    {
        private string _connectionstring = LoadConnectionString();
        private Game _gameToEdit;

        public UpdateWindow(Game game)
        {
            InitializeComponent();

            _gameToEdit = game;
            PopulateFields();

            Id.hideClearBtn = true;
            
        }

        private async void UpdateGame_Click(object sender, RoutedEventArgs routedEventArgs)
        {
            await UpdateGame();
        }

        private async Task UpdateGame()
        {
            string title = TitleUpdate.InputText;
            string genre = GenreUpdate.InputText;
            string platform = PlatformUpdate.InputText;
            DateTime releaseDate = DateTime.Parse(DateUpdate.InputText);
            bool completed = bool.Parse(CompletedUpdate.InputText);
            int rating = int.Parse(RatingUpdate.InputText);
           
            using (NpgsqlConnection conn = new(_connectionstring))
            {
                await conn.OpenAsync();
                string sql = @"UPDATE games " +
                             "SET title = @title," +
                             "genre = @genre, " +
                             "platform = @platform, " +
                             "releasedate = @releasedate, " +
                             "completed = @completed, " +
                             "rating = @rating " +
                             "WHERE id = @id";

                using NpgsqlCommand cmd = new(sql, conn) ;
                

                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@genre", genre);
                cmd.Parameters.AddWithValue("@platform", platform);
                cmd.Parameters.AddWithValue("@releasedate", releaseDate);
                cmd.Parameters.AddWithValue("@completed", completed);
                cmd.Parameters.AddWithValue("@rating", rating);
                cmd.Parameters.AddWithValue("@id", _gameToEdit.id);

                try
                {
                    await cmd.ExecuteNonQueryAsync();

                    MessageBox.Show("Game updated successfully!");

                    this.Close();

                    DataGrid grid = ((MainWindow)Application.Current.MainWindow).GamesDataGridPublic;
                    ObservableCollection<Game> games = await DataBaseHelper.LoadGamesAsync();
                    grid.ItemsSource = games; // Refresh the DataGrid with updated data
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Error updating game : {e.Message}");
                }

            }
        }

        private void PopulateFields()
        {
            TitleUpdate.InputText = _gameToEdit.title;
            GenreUpdate.InputText = _gameToEdit.genre;
            PlatformUpdate.InputText = _gameToEdit.platform;
            DateUpdate.InputText = _gameToEdit.releasedate.ToString("yyyy-MM-dd");
            CompletedUpdate.InputText = _gameToEdit.completed.ToString();
            RatingUpdate.InputText = _gameToEdit.rating.ToString();
            Id.InputText = _gameToEdit.id.ToString();
        }

        private static string LoadConnectionString()
        {
            IConfigurationRoot config = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            return config["ConnectionString"];
        }
    }
}
