using System;
using Xamarin.Forms;

namespace Laboratorium7.Models
{
    public class Item : BindableObject
    {
        private int id;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                OnPropertyChanged();
            }
        }
        private string FirstName;
        public string Imie
        {
            get
            {
                return FirstName;
            }
            set
            {
                FirstName = value;
                OnPropertyChanged();
            }
        }
        private string LastName;
        public string Nazwisko
        {
            get
            {
                return LastName;
            }
            set
            {
                LastName = value;
                OnPropertyChanged();
            }
        }
        private string Index;
        public string NrAlbumu
        {
            get
            {
                return Index;
            }
            set
            {
                Index = value;
                OnPropertyChanged();
            }
        }
        private string Gender;
        public string Plec
        {
            get
            {
                return Gender;
            }
            set
            {
                Gender = value;
                OnPropertyChanged();
            }
        }
    }
}