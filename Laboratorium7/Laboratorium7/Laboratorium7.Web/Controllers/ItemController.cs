using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Laboratorium7.Models;

namespace Laboratorium7.Controllers
{
    [Route("api/item")]
    [ApiController]
    public class ItemController : ControllerBase
    {

        
        public static List<Item> items = new List<Item>()
            {
                new Item() { Id = 1, Imie = "Adam", Nazwisko = "Nowak", NrAlbumu = "w10050", Plec = "M"},
                new Item() { Id = 2, Imie = "Laura", Nazwisko = "Mazur", NrAlbumu = "w75002", Plec = "K"},
                new Item() { Id = 3, Imie = "Jan", Nazwisko = "Kowalski", NrAlbumu = "w15400", Plec = "M"},
                new Item() { Id = 4, Imie = "Andrzej", Nazwisko = "Kasperczak", NrAlbumu = "w60052", Plec = "M"}

            };


        // GET: api/item
        [HttpGet]
        public IEnumerable<Item> Get()
        {
            return items;
        }
        // GET: api/item/5
        [HttpGet("{id}", Name = "Get")]
        public Item Get(int id)
        {
            return items.FirstOrDefault(x => x.Id == id);
        }
        // POST: api/item
        [HttpPost]
        public void Post([FromBody] Item item)
        {
            items.Add(item);
            item.Id = items.IndexOf(item) + 1;
        }
        // PUT: api/item/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Item value)
        {
            var item = items.FirstOrDefault(x => x.Id == id);
            item.Imie = value.Imie;
            item.Nazwisko = value.Nazwisko;
            item.NrAlbumu = value.NrAlbumu;
            item.Plec = value.Plec;
        }
        // DELETE: api/item/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = items.FirstOrDefault(x => x.Id == id);
            items.Remove(item);
        }
    }
}
