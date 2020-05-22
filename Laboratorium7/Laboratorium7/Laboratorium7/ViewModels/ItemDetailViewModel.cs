using System;

using Laboratorium7.Models;

namespace Laboratorium7.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Imie + " " + item?.Nazwisko;
            Item = item;
        }
    }
}
