using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using AppBuscaCep.Views;

namespace AppBuscaCep
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void BtnInicio_Clicked(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void BtnEnderecoByCep_Clicked(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void BtnBairrosByCidade_Clicked(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void BtnLogradouroByBairroAndCidade_Clicked(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }

        private async void BtnCepByLogradouro_Clicked(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "OK");
            }
        }
    }
}
