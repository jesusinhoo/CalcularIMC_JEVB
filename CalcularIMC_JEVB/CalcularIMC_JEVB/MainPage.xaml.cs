using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalcularIMC_JEVB
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var altura = double.Parse(Altura.Text);
            var peso = double.Parse(Peso.Text);
            var imc = peso/(altura*altura);

            IMC.Text = imc.ToString();

            if (imc < 18)
            {
                DisplayAlert("Bajo peso","Tienes bajo peso come mas","CERRAR");
            }
            else if (imc > 18 && imc <24.5)
            {
                DisplayAlert("Peso normal", "Estas en forma", "CERRAR");
            }
            else if (imc > 24.5 && imc < 29.5)
            {
                DisplayAlert("Sobre peso", "Tienes sobre peso", "CERRAR");
            }
            else if (imc > 29.5)
            {
                DisplayAlert("Obecidad", "Tienes obecidad", "CERRAR");
            }
        }
    }
}
