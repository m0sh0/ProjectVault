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
