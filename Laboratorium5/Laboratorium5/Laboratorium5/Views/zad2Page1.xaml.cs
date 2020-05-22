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
    public partial class zad2Page1 : ContentPage
    {
        public zad2Page1()
        {
            InitializeComponent();
        }
        public bool B1Enabled { get; set; } = true;
        public bool B2Enabled { get; set; } = true;
        public bool B3Enabled { get; set; } = true;
        public bool B4Enabled { get; set; } = true;
        public bool B5Enabled { get; set; } = true;

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            var buttonClicked = (sender as Button);
            var numer = buttonClicked.CommandParameter;
            await Navigation.PushAsync(new zad2Page2(numer));
        }
    }
}