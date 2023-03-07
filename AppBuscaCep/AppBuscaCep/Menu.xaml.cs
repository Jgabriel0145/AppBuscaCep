using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AppBuscaCep.Views;

namespace AppBuscaCep
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void BtnInicio_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Inicial());
        }

        private void BtnEnderecoByCep_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EnderecoPorCep());
        }

        private void BtnBairrosByCidade_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BairrosPorCidade());
        }

        private void BtnLogradouroByBairroAndCidade_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LogradourosByBairroAndCidade());
        }

        private void BtnCepByLogradouro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CepPorLogradouro());
        }

        private void BtnCidadeByEstado_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CidadePorEstado());
        }
    }
}