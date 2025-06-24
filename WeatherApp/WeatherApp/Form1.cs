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

            TempBox.Text = $"Max temp {input} \n\nMin temp {input} \n\nFeels like {input}";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}