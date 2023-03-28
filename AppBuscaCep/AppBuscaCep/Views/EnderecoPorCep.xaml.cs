using AppBuscaCep.Model;
using AppBuscaCep.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBuscaCep.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EnderecoPorCep : ContentPage
    {
        public EnderecoPorCep()
        {
            InitializeComponent();
        }

        private async void btnBuscar_Clicked(object sender, EventArgs e)
        {
            btnBuscar.IsEnabled = false;
            carregando.IsRunning = true;
            try
            {
                Endereco end = await DataService.GetEnderecoByCep(txt_cep.Text);

                //lst_enderecos.ItemsSource = end;
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