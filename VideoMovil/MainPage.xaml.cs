using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoMovil.View;
using Xamarin.Forms;

namespace VideoMovil
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnAgregar_Clicked(object sender, EventArgs e)
        {
            var paginaCrear = new VideoView();

            await Navigation.PushAsync(paginaCrear);
        }

        private async void btnSwipe_Clicked(object sender, EventArgs e)
        {
            var paginaLista = new ListaVideos();

            await Navigation.PushAsync(paginaLista);
        }
    }
}
