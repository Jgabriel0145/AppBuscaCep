using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AppBuscaCep.Model;
using AppBuscaCep.Services;

namespace AppBuscaCep.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BairrosPorCidade : ContentPage
    {
        public BairrosPorCidade()
        {
            InitializeComponent();
        }

        private async void btnBuscar_Clicked(object sender, EventArgs e)
        {
            btnBuscar.IsEnabled = false;
            carregando.IsRunning = true;
            try
            {
                List<Cep> arr_ceps = await DataService.GetBairroByIdCidade(txt_cidade.Text);

                lst_ceps.ItemsSource = arr_ceps;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
            finally
            {
                carregando.IsRunning = false;
                btnBuscar.IsEnabled = true;
            }
        }
    }
}