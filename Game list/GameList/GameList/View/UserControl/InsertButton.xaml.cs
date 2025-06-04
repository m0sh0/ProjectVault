using System.Windows;

namespace GameList.View.UserControl
{
    public partial class InsertButton : System.Windows.Controls.UserControl
    {
        public InsertButton()
        {
            InitializeComponent();
        }

        private void ButtonInsert_Click(object sender, RoutedEventArgs e)
        {
            InsertWindow insertWindow = new InsertWindow();
            insertWindow.Show();
        }
    }
}