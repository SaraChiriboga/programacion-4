using S14_P4.Models;

namespace S14_P4;

public partial class RegistroPage : ContentPage
{
    private Medicamento medicamento;

    public RegistroPage(Medicamento med = null)
    {
        InitializeComponent();

        if (med != null)
        {
            medicamento = med;
            nombreEntry.Text = med.Nombre;
            precioEntry.Text = med.Precio.ToString();
            stockEntry.Text = med.Stock.ToString();
            btnGuardar.Text = "Actualizar";
        }
    }

    private async void OnGuardarClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(nombreEntry.Text) ||
            !double.TryParse(precioEntry.Text, out double precio) ||
            !int.TryParse(stockEntry.Text, out int stock))
        {
            await DisplayAlert("Error", "Ingrese datos válidos", "OK");
            return;
        }

        if (medicamento == null)
            medicamento = new Medicamento();

        medicamento.Nombre = nombreEntry.Text;
        medicamento.Precio = precio;
        medicamento.Stock = stock;

        await App.Database.SaveMedicamentoAsync(medicamento);
        await Navigation.PopAsync();
    }
}