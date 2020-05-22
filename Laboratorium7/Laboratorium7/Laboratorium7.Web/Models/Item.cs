using System;
using System.ComponentModel.DataAnnotations;

namespace Laboratorium7.Models
{
    public class Item
    {
        public int Id { get; set; }

        [Required]
        public string Imie { get; set; }

        [Required]
        public string Nazwisko { get; set; }

        [Required]
        public string NrAlbumu { get; set; }

        [Required]
        public string Plec { get; set; }

    }
}
