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
using System.Windows.Navigation;
using System.Windows.Shapes;
using GameList.Classes;

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
