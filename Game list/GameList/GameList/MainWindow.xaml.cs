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
using GameList.View.UserControl;
using Npgsql;

namespace GameList
{
    public partial class MainWindow : Window
    {
        
        public DataGrid GamesDataGridPublic => GamesDataGrid;
        public MainWindow()
        {
            InitializeComponent();
            UpdateButtonCtrl.ParentWindow = this;
            DeleteButtonCtrl.ParentWindow = this;
        }

        private async void WindowLoaded(object sender, RoutedEventArgs e)
        {
            GamesDataGrid.Items.Clear();

            var games = await DataBaseHelper.LoadGamesAsync();
            GamesDataGrid.ItemsSource = games;

        }

    }
}