using System.Diagnostics;

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

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string input = InputLbl.Text;
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
    }
}