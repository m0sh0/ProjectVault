using System.Windows;

namespace GameList.View.UserControl
{
    /// <summary>
    /// Interaction logic for SortButton.xaml
    /// </summary>
    public partial class SortButton : System.Windows.Controls.UserControl
    {
        public SortButton()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SortWindow sortWindow = new();
            sortWindow.Show();
        }
    }
}