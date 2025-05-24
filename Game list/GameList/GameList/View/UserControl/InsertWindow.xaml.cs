using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
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
using Npgsql;

namespace GameList.View.UserControl
{
    public partial class InsertWindow : Window
    {
        string _connectionString = LoadConnectionString();
        public InsertWindow()
        {
            InitializeComponent();
        }

        private async void InsertGame_Click(object sender, RoutedEventArgs e)
        {
           await InsertGame();
        }

        private async Task InsertGame()
        {
            string title = TitleInput.InputText;
            string genre = GenreInput.InputText;
            string platform = PlatformInput.InputText;
            string releaseDateText = DateInput.InputText;
            string completedText = CompletedInput.InputText;
            string ratingText = RatingInput.InputText;

            if (string.IsNullOrEmpty(title) ||
                string.IsNullOrEmpty(genre) ||
                string.IsNullOrEmpty(platform) ||
                string.IsNullOrEmpty(releaseDateText) ||
                string.IsNullOrEmpty(completedText) ||
                string.IsNullOrEmpty(ratingText))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }


            if (!DateTime.TryParse(releaseDateText, out DateTime releaseDate) ||
                !bool.TryParse(completedText, out bool completed) ||
                !int.TryParse(ratingText, out int rating))
            {
                MessageBox.Show("Invalid input format.");
                return;
            }

            using (NpgsqlConnection conn = new(_connectionString))
            {
                await conn.OpenAsync();

                string sql = "INSERT INTO games(title, genre, platform, releasedate, completed, rating)" +
                             "VALUES (@title, @genre, @platform, @releasedate, @completed, @rating)";

                using NpgsqlCommand cmd = new(sql, conn) ;

                cmd.Parameters.AddWithValue("title", title);
                cmd.Parameters.AddWithValue("genre", genre);
                cmd.Parameters.AddWithValue("platform", platform);
                cmd.Parameters.AddWithValue("releasedate", releaseDate);
                cmd.Parameters.AddWithValue("completed", completed);
                cmd.Parameters.AddWithValue("rating", rating);

                try
                {
                    await cmd.ExecuteNonQueryAsync();

                    MessageBox.Show("Game inserted successfully.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error inserting game: {ex.Message}");
                }

            }
            
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
