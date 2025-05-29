using Microsoft.Extensions.Configuration;
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
using System.Windows.Shapes;

namespace GameList.View.UserControl
{

    public partial class UpdateWindow : Window
    {
        private string _connectionstring = LoadConnectionString();
        public UpdateWindow()
        {
            InitializeComponent();
            Id.hideClearBtn = true;
        }

        private async void UpdateGame_Click(object sender, RoutedEventArgs routedEventArgs)
        {

        }
        private static string LoadConnectionString()
        {
            IConfigurationRoot config = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            return config["ConnectionString"];
        }
    }
}
