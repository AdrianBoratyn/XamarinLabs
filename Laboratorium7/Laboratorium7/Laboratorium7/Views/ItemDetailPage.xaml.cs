using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Laboratorium7.Models;
using Laboratorium7.ViewModels;

namespace Laboratorium7.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new Item
            {
                Imie = "",
                Nazwisko = "",
                NrAlbumu = "",
                Plec = ""
            };

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }

        private async void edytujClicked(object sender, EventArgs e)
        {
            await viewModel.DataStore.UpdateItemAsync(viewModel.Item);
            await Navigation.PopToRootAsync();

        }
    }
}