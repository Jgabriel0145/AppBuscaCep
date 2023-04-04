using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AppBuscaCep.Model;
using AppBuscaCep.Services;
using System.Collections.ObjectModel;
using System.Linq;

namespace AppBuscaCep.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BairrosPorCidade : ContentPage
    {
        ObservableCollection<Cidade> lista_cidades = new ObservableCollection<Cidade>();
        ObservableCollection<Bairro> lista_bairros = new ObservableCollection<Bairro>();

        public BairrosPorCidade()
        {
            InitializeComponent();

            pck_cidade.ItemsSource = lista_cidades;
            lst_bairros.ItemsSource = lista_bairros;
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

            } finally
            {
                carregando.IsRunning = false;
            }
        }

        private async void pck_cidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Picker disparador = sender as Picker;
                Cidade cidade_selecionada = disparador.SelectedItem as Cidade;

                if (cidade_selecionada != null)
                {
                    List<Bairro> arr_bairros = await DataService.GetBairroByIdCidade(cidade_selecionada.id_cidade);
                    
                    lista_bairros.Clear();

                    arr_bairros.ForEach(i => lista_bairros.Add(i));                   
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }
    }
}