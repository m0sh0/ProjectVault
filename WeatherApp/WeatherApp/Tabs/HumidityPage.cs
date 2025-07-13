using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherApp.Classes.Models;

namespace WeatherApp.Tabs
{
    public partial class HumidityPage : UserControl
    {
        public HumidityPage()
        {
            InitializeComponent();
        }

        public void UpdateStats(Response? response)
        {
            try
            {
                AirHumiStat.Text = $"{response.Weather.Humidity}%";
                PressureStat.Text = $"{response.Weather.Pressure} hPa";
                SeaLvlStat.Text = $"{response.Weather.SeaLevel} m";
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e);
                throw;
            }

        }
    }
}
