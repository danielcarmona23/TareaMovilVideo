//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("VideoMovil.View.VisualizarVideo.xaml", "View/VisualizarVideo.xaml", typeof(global::VideoMovil.View.VisualizarVideo))]

namespace VideoMovil.View {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("View\\VisualizarVideo.xaml")]
    public partial class VisualizarVideo : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xam.Forms.VideoPlayer.VideoPlayer videoPlayer;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Button CloseButton;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(VisualizarVideo));
            videoPlayer = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xam.Forms.VideoPlayer.VideoPlayer>(this, "videoPlayer");
            CloseButton = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Button>(this, "CloseButton");
        }
    }
}