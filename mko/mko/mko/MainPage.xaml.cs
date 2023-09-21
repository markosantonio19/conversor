using System;
using Xamarin.Forms;

namespace mko
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ConvertirPeso(object sender, EventArgs e)
        {
            if (double.TryParse(librasEntry.Text, out double libras))
            {
                double kilogramos = libras * 0.453592;
                resultadoPesoLabel.Text = $"{libras} libras son {kilogramos} kilogramos";
            }
            else
            {
                resultadoPesoLabel.Text = "Ingresa un valor válido";
            }
        }

        private void ConvertirVolumen(object sender, EventArgs e)
        {
            if (double.TryParse(litrosEntry.Text, out double litros))
            {
                double galones = litros * 0.264172;
                resultadoVolumenLabel.Text = $"{litros} litros son {galones} galones";
            }
            else
            {
                resultadoVolumenLabel.Text = "Ingresa un valor válido";
            }
        }

        private void ConvertirTemperatura(object sender, EventArgs e)
        {
            if (double.TryParse(celsiusEntry.Text, out double celsius))
            {
                double fahrenheit = (celsius * 9 / 5) + 32;
                resultadoTemperaturaLabel.Text = $"{celsius} grados Celsius son {fahrenheit} grados Fahrenheit";
            }
            else
            {
                resultadoTemperaturaLabel.Text = "Ingresa un valor válido";
            }
        }
    }
}
