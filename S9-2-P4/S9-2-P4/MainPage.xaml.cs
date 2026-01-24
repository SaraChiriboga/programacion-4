namespace S9_2_P4
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            DisplayAlert("¡Hola!", "Has hecho clic en el botón.", "OK");
        }
    }
}