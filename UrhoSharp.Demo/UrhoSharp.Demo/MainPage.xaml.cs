using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Urho;
using Xamarin.Forms;

namespace UrhoSharp.Demo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await HelloWorldUrhoSurface.Show<HelloWorld>(new Urho.ApplicationOptions(assetsFolder: null) { Orientation = ApplicationOptions.OrientationType.LandscapeAndPortrait });


        }
    }
}
