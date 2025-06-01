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
    public partial class DeleteButton : System.Windows.Controls.UserControl
    {
        public MainWindow ParentWindow { get; set; }

        private string _connectionstring = DataBaseHelper.LoadConnectionString();


        public DeleteButton()
        {
            InitializeComponent();
        }

        private async void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            // Check if selected game is null
            Game? selectedGame = ParentWindow?.GamesDataGrid.SelectedItem as Game;

            if (selectedGame == null)
            {
                MessageBox.Show("Select a game from the table to delete.");
                return;
            }

            // Confirm deletion
            MessageBoxResult result = MessageBox.Show("Are you sure you want to delete this game?", "Game list", MessageBoxButton.YesNo);

            switch (result)
            {
                case MessageBoxResult.Yes:
                    await DeleteGame(selectedGame.id);

                    DataGrid grid = ((MainWindow)Application.Current.MainWindow).GamesDataGridPublic;
                    ObservableCollection<Game> games = await DataBaseHelper.LoadGamesAsync();
                    grid.ItemsSource = games;

                    MessageBox.Show("Game deleted successfully.");
                    break;

                case MessageBoxResult.No:
                    return;

                default:
                    return;
            }

        }

        private async Task DeleteGame(int id)
        {
            using (NpgsqlConnection conn = new(_connectionstring))
            {
                await conn.OpenAsync();

                string sql = "DELETE FROM games WHERE id = @id";

                using NpgsqlCommand cmd = new(sql, conn);

                cmd.Parameters.AddWithValue("@id", id);

                try
                {
                    await cmd.ExecuteNonQueryAsync();

                    MessageBox.Show("Game deleted successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting game: " + ex.Message);
                }
            }
        }
    }
}
