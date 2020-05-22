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
    public partial class zad2Page2 : ContentPage
    {
        private int nrButton;
        public zad2Page2(object o)
        {
            InitializeComponent();
            l1.Text = "Kliknięto przycisk " + o;
            nrButton = Convert.ToInt32(o);
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            var p = new zad2Page1();
           
            switch(nrButton)
            {
                case 1:
                    p.B1Enabled = false;
                    break;
                case 2:
                    p.B2Enabled = false;
                    break;
                case 3:
                    p.B3Enabled = false;
                    break;
                case 4:
                    p.B4Enabled = false;
                    break;
                case 5:
                    p.B5Enabled = false;
                    break;
            }
            await Navigation.PushAsync(p);
        }
    }
}