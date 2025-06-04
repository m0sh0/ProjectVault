using System.Windows;
using System.Windows.Controls;

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