using System;
using System.Collections.Generic;
using System.Linq;
using VideoMovil.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VideoMovil.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaVideos : ContentPage
    {
        public List<Video> AllVideos { get; set; }
        public string pathSelectedVideo;
        public ListaVideos()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            CargarDatos();
        }

        private async void CargarDatos()
        {
            AllVideos = await App.BaseDatos.ObtenerListaVideos();
            ListVideos.ItemsSource = AllVideos;
        }


        private async void SwipeItem_Invoked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new VisualizarVideo(pathSelectedVideo));
            pathSelectedVideo = null;
        }

        private void ListVideos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateSelectionData(e.PreviousSelection, e.CurrentSelection);
        }


        private void UpdateSelectionData(IEnumerable<object> previousSelectedContact, IEnumerable<object> currentSelectedContact)
        {
            var selectedContact = currentSelectedContact.FirstOrDefault() as Video;
            // await DisplayAlert("Titulo", "Ruta Seleccionada:" + selectedContact.pathFile, "OK");
            pathSelectedVideo = selectedContact.ruta;
            Console.WriteLine(pathSelectedVideo);
        }
    }
}