using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;  
namespace inversiones
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            // Declara las variables
            double inversor1 = 0;
            double inversor2 = 0;
            double inversor3 = 0;

            double total = 0;

            double resultado1 = 0;
            double resultado2 = 0;
            double resultado3 = 0;

            // Obtén los valores de las entradas y realiza los cálculos
            inversor1 = double.Parse(inversion1.Text);
            inversor2 = double.Parse(inversion2.Text);
            inversor3 = double.Parse(inversion3.Text);

            total = inversor1 + inversor2 + inversor3;
            resultado1 = (inversor1 / total) * 100;
            resultado2 = (inversor2 / total) * 100;
            resultado3 = (inversor3 / total) * 100;

            // Crea una nueva página de resultados (Page1) y pasa los datos

            await Navigation.PushAsync(new Page1(total.ToString("N2"), resultado1.ToString("N2"), resultado2.ToString("N2"), resultado3.ToString("N2")));


        }
    }
}
