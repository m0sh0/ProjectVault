using GameList.Classes;
using System.Windows;

namespace GameList.View.UserControl
{
    public partial class UpdateButton : System.Windows.Controls.UserControl
    {
        public MainWindow ParentWindow { get; set; }

        public UpdateButton()
        {
            InitializeComponent();
        }

        private void ButtonUpdate_Click(object sender, RoutedEventArgs e)
        {
            // Check if the parent window is set
            Game? selectedGame = ParentWindow?.GamesDataGrid.SelectedItem as Game;

            // Check if a game is selected
            if (selectedGame == null)
            {
                MessageBox.Show("Select a game from the table to update.");
                return;
            }

            // Show the update window
            UpdateWindow updateWindow = new(selectedGame);
            updateWindow.Show();
        }
    }
}