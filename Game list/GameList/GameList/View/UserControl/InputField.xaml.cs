using System.Windows;

namespace GameList.View.UserControl
{
    public partial class InputField : System.Windows.Controls.UserControl
    {
        public InputField()
        {
            InitializeComponent();
        }

        private string placeholder;

        public string Placeholder
        {
            get { return placeholder; }
            set
            {
                placeholder = value;
                PlaceHolder.Text = placeholder;
            }
        }

        public string InputText
        {
            get { return TxtInput.Text; }
            set { TxtInput.Text = value; }
        }

        public bool isReadOnly
        {
            get { return TxtInput.IsReadOnly; }
            set { TxtInput.IsReadOnly = value; }
        }

        public bool hideClearBtn
        {
            set { ClearBtn.Visibility = value ? Visibility.Hidden : Visibility.Visible; }
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            TxtInput.Clear();
            TxtInput.Focus();
        }

        private void TxtInput_TextChanged(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtInput.Text))
            {
                PlaceHolder.Visibility = Visibility.Visible;
            }
            else
            {
                PlaceHolder.Visibility = Visibility.Hidden;
            }
        }
    }
}