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
    public partial class CepPorLogradouro : ContentPage
    {
        public CepPorLogradouro()
        {
            InitializeComponent();
        }

        private void btnBuscar_Clicked(object sender, EventArgs e)
        {

        }
    }
}