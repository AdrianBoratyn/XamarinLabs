using System;
using Xamarin.Forms;

namespace Laboratorium6.Models
{
    public class Student : BindableObject

    {
        private string id;
        public string Id
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
        private string firstName;
        public string Imie
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
                OnPropertyChanged();
            }
        }
        private string lastName;
        public string Nazwisko
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
                OnPropertyChanged();
            }
        }
        private string index;
        public string NrAlbumu
        {
            get
            {
                return index;
            }
            set
            {
                index = value;
                OnPropertyChanged();
            }
        }
        private string gender;
        public string Plec
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
                OnPropertyChanged();
            }
        }
    }
}