using System;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace Laboratorium7.Models
{
    public class ItemRepository : IItemRepository
    {
        private static ConcurrentDictionary<string, Item> items =
            new ConcurrentDictionary<string, Item>();

        public ItemRepository()
        {
            //Add(new Item { Id = 1, FirstName = "Item 1", LastName = "This is an item description." });
            //Add(new Item { Id = 2, FirstName = "Item 2", LastName = "This is an item description." });
            //Add(new Item { Id = 3, FirstName = "Item 3", LastName = "This is an item description." });
        }

        public IEnumerable<Item> GetAll()
        {
            return items.Values;
        }

        public void Add(Item item)
        {
            item.Id = Convert.ToInt32(Guid.NewGuid());
            //items[item.Id] = item;
        }

        public Item Get(string id)
        {
            items.TryGetValue(id, out Item item);
            return item;
        }

        public Item Remove(string id)
        {
            items.TryRemove(id, out Item item);
            return item;
        }

        public void Update(Item item)
        {
            //items[item.Id] = item;
        }
    }
}
