using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NetCoreWithAPI.Models
{
    public class InventoryItems
    {
        public long Id { get; set; }
        public string ItemName { get; set; }
        public double Price { get; set; }
    }
}
