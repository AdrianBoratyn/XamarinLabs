using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laboratorium6.Models;

namespace Laboratorium6.Services
{
    public class MockDataStore : IDataStore<Student>
    {
        readonly List<Student> items;

        public MockDataStore()
        {
            items = new List<Student>()
            {
                new Student() { Id = Guid.NewGuid().ToString(), Imie = "Adam", Nazwisko = "Nowak", NrAlbumu = "w10050", Plec = "M"},
                new Student() { Id = Guid.NewGuid().ToString(), Imie = "Laura", Nazwisko = "Mazur", NrAlbumu = "w75002", Plec = "K"},
                new Student() { Id = Guid.NewGuid().ToString(), Imie = "Jan", Nazwisko = "Kowalski", NrAlbumu = "w15400", Plec = "M"},
                new Student() { Id = Guid.NewGuid().ToString(), Imie = "Andrzej", Nazwisko = "Kasperczak", NrAlbumu = "w60052", Plec = "M"}

            };
        }

        public async Task<bool> AddItemAsync(Student item)
        {
            items.Add(item);
            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Student item)
        {
            var oldItem = items.Where((Student arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);
            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Student arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Student> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Student>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}