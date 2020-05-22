using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Laboratorium4.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class zad4 : ContentPage
    {
        public zad4()
        {
            InitializeComponent();
        }
        private void Switch_Toggled(Object sender, ToggledEventArgs e)
        {
            if (e.Value)
            {
                sView.Orientation = ScrollOrientation.Horizontal;
                sLayout.Orientation = StackOrientation.Horizontal;
                l1.Text = "Zmień orientacje, obecna: Horyzontalna";
            }
            else
            {
                sView.Orientation = ScrollOrientation.Vertical;
                sLayout.Orientation = StackOrientation.Vertical;
                l1.Text = "Zmień orientacje, obecna: Vertical";
            }
        }
    }
}