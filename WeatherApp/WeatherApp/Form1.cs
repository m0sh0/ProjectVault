using System.Diagnostics;
using WeatherApp.Classes.Models;
using WeatherApp.Classes.Services;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

           Response? response = await WeatherService.GetWeatherAsync(input);

            PrintInfo(response, input);
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CelsiusCheck.CheckState = CheckState.Unchecked;
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            FahrenheitCheck.CheckState = CheckState.Unchecked;
        }

        //TODO: Localize
        public void PrintInfo(Response? response, string input)
        {
            if (response != null)
            {
                CurrentTempStat.Text = response.Weather?.CurrentTemp.ToString();
                FeelsLikeStat.Text = response.Weather?.FeelsLikeTemp.ToString();
                MaxTempStat.Text = response.Weather?.MaxTemp.ToString();
                MinTempStat.Text = response.Weather?.MinTemp.ToString();

                WindSpeedStat.Text = response.Wind?.WindSpeed.ToString();

                CityStat.Text = input;
                CountryStat.Text = response.Country?.Name;
                return;
            }

            Console.WriteLine("Empty data");
        }
    }
}