using AppBuscaCep.Model;
using AppBuscaCep.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppBuscaCep.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CidadePorEstado : ContentPage
    {
        ObservableCollection<Cidade> lista_cidades = new ObservableCollection<Cidade>();

        public CidadePorEstado()
        {
            InitializeComponent();

            pck_estado.ItemsSource = lista_cidades;
        }

        private async void pck_estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Picker disparador = sender as Picker;
                string estado_selecionado = disparador.SelectedItem as string;

                if (estado_selecionado != null)
                {
                    carregando.IsRunning = true;

                    List<Cidade> arr_cidades = await DataService.GetCidadeByEstado(estado_selecionado);
                    lista_cidades.Clear();

                    arr_cidades.ForEach(i => lista_cidades.Add(i));

                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");

            }
            finally
            {
                carregando.IsRunning = false;
            }
        }
    }
}