namespace Converso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular(object sender, EventArgs e)
        {
            int celsius = Convert.ToInt32(textBoxCelius.Text);

            int fahrenheit = Convert.ToInt32(textBoxFahrenheit.Text);

            int resultado =(32 °F − 32) × 5/9 = 0 °C;

            MessageBox.Show($"A idade é {resultado} anos!! ");
        }
    }
}