using System.Diagnostics;
using WeatherApp.Classes.Models;
using WeatherApp.Classes.Services;
using WeatherApp.Tabs;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public bool IsHumiOpen { get; set; }
        public HumidityPage HumidityPage { get; set; }

        public Form1()
        {
            InitializeComponent();
            HumidityPage = new();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            InputLbl.Text = string.Empty;
        }

        private async void SearchBtn_Click(object sender, EventArgs e)
        {
            string input = InputLbl.Text;

            if (input == string.Empty)
            {
                MessageBox.Show("Please enter a city name.");
                return;
            }

            Response? response = await WeatherService.GetWeatherAsync(input);

            PrintInfo(response, input);
            HumidityPage.UpdateStats(response);
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CelsiusCheck.CheckState = CheckState.Unchecked;
            WeatherService.Fahrenheit = true;

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            FahrenheitCheck.CheckState = CheckState.Unchecked;
            WeatherService.Fahrenheit = false;
        }

        //TODO: Localize
        public void PrintInfo(Response? response, string input)
        {

            try
            {
                if (!WeatherService.Fahrenheit)
                {
                    CurrentTempStat.Text = $"{response.Weather?.CurrentTemp.ToString()}°C";
                    FeelsLikeStat.Text = $"{response.Weather?.FeelsLikeTemp.ToString()}°C";
                    MaxTempStat.Text = $"{response.Weather?.MaxTemp.ToString()}°C";
                    MinTempStat.Text = $"{response.Weather?.MinTemp.ToString()}°C";
                }
                else
                {
                    CurrentTempStat.Text = $"{response.Weather?.CurrentTemp.ToString()}°F";
                    FeelsLikeStat.Text = $"{response.Weather?.FeelsLikeTemp.ToString()}°F";
                    MaxTempStat.Text = $"{response.Weather?.MaxTemp.ToString()}°F";
                    MinTempStat.Text = $"{response.Weather?.MinTemp.ToString()}°F";
                }

                WindSpeedStat.Text = $"{response.Wind?.WindSpeed.ToString()}m/s";

                NameLbl.Text = input;

                CountryStat.Text = response.Country?.Name;
            }
            // Catch any exceptions that occur during the data retrieval or processing
            catch (NullReferenceException e)
            {
                MessageBox.Show(e.Message);
                throw;
            }

        }

        private void InputLbl_TextChanged(object sender, EventArgs e)
        {

        }

        private void HumiPageButton_Click(object sender, EventArgs e)
        {
            if (IsHumiOpen)
            {
                Controls.Remove(HumidityPage);
                IsHumiOpen = false;
                return;
            }

            Controls.Add(HumidityPage);
            HumidityPage.BringToFront();
            IsHumiOpen = true;
        }
    }
}
