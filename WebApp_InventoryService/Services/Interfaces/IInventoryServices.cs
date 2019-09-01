using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp_InventoryService.Models;

namespace WebApp_InventoryService.Services.Interfaces
{
    public interface IInventoryServices
    {
        InventoryItems AddInventoryItems(InventoryItems items);
        Dictionary<string, InventoryItems> GetInventoryItems();
    }
}
