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
            const string sql = "SELECT * FROM games ORDER BY title";

            DataGrid grid = ((MainWindow)Application.Current.MainWindow).GamesDataGridPublic;
            ObservableCollection<Game> games = await DataBaseHelper.SortGamesAlphabetically(sql);
            grid.ItemsSource = games; // Refresh the DataGrid with updated data
        }
    }
}