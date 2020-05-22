using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Laboratorium5.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class zad1Page1 : ContentPage
    {
        public zad1Page1()
        {
            InitializeComponent();
        }
        
        private async void OnButton1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new zad1Page2());
        }

        private async void OnButton2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new zad1Page3());
        }
    }
}