using ASP.NetCoreWithAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NetCoreWithAPI.Services
{
    public class InventoryService : IInventoryServices
    {
        private readonly Dictionary<string, InventoryItems> _InventoryItems;

        public InventoryService()
        {
            _InventoryItems = new Dictionary<string, InventoryItems>();
        }
        public InventoryItems AddInventoryItems(InventoryItems items)
        {
            _InventoryItems.Add(items.ItemName, items);
            return items;
        }

        public Dictionary<string, InventoryItems> GetInventoryItems()
        {
            return _InventoryItems;
        }
    }
}
