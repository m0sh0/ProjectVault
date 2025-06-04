using GameList.Classes;
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
    public partial class BckwrdsAlphabeticSortButton : System.Windows.Controls.UserControl
    {
        public BckwrdsAlphabeticSortButton()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SortBackwards();
        }

        private async void SortBackwards()
        {
            const string sql = "SELECT * FROM games ORDER BY title DESC";

            DataGrid grid = ((MainWindow)Application.Current.MainWindow).GamesDataGridPublic;
            ObservableCollection<Game> sortedGames = await DataBaseHelper.SortGamesAlphabetically(sql);
            grid.ItemsSource = sortedGames; // Refresh the DataGrid with updated data

            if (sortedGames.Count == 0)
            {
                MessageBox.Show("No games found in the database.");
            }
            else
            {
                MessageBox.Show($"{sortedGames.Count} games sorted alphabetically.");
            }
        }
    }
}