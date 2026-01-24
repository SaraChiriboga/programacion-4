using S12_P4.ViewModels;

namespace S12_P4
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new SuperheroViewModel();

        }
    }
}
