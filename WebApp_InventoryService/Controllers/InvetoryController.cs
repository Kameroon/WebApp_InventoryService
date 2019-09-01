using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp_InventoryService.Models;
using WebApp_InventoryService.Services.Interfaces;

namespace WebApp_InventoryService.Controllers
{
    //[Route("api/[controller]")]
    [Route("v1/")]
    [ApiController]
    public class InvetoryController : ControllerBase
    {
        private readonly IInventoryServices _service;

        [HttpPost]
        [Route("AddInventoryItems")]
        public ActionResult<InventoryItems> AddInventoryItems(InventoryItems items)
        {
            var inventoryItems = _service.AddInventoryItems(items);
            if (inventoryItems == null)
            {
                return NotFound();
            }

            return inventoryItems;
        }

        [HttpGet]
        [Route("GetInventoryItems")]
        public ActionResult<Dictionary<string, InventoryItems>> GetIneventoryItems()
        {
            var inventoryItems = _service.GetInventoryItems();

            if (inventoryItems.Count == 0)
            {
                return NotFound();
            }

            return inventoryItems;
        }
    }
}