namespace S8_P4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Sumar_Clicked(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumero1.Text, out double numero1) &&
                double.TryParse(txtNumero2.Text, out double numero2))
            {
                double resultado = numero1 + numero2;
                lblResultado.Text = $"Resultado: {resultado}";
            }
            else
            {
                lblResultado.Text = "Por favor, ingresa números válidos.";
            }
        }
    }
}