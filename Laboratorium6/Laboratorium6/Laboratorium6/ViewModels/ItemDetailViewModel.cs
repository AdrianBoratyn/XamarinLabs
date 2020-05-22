using System;

using Laboratorium6.Models;

namespace Laboratorium6.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Student Item { get; set; }
        public ItemDetailViewModel(Student item = null)
        {
            Title = item?.Imie + " " + item?.Nazwisko;
            Item = item;
        }
    }
}
