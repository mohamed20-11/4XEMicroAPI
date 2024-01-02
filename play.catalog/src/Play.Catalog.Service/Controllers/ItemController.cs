using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Play.Catalog.Service.Dtos;
using static Play.Catalog.Service.Dtos.Dtos;

namespace Play.Catalog.Service.Controllers
{

    [ApiController]
    [Route("items")]
    public class ItemController : ControllerBase
    {
        
        private static readonly List<ItemDto> items = new()
        {
            new ItemDto(Guid.NewGuid(),"Potion" , "Restores a samll amount of HP",5,DateTimeOffset.UtcNow),
            new ItemDto(Guid.NewGuid(),"Antitide" , "Curses a Poison",7,DateTimeOffset.UtcNow),
            new ItemDto(Guid.NewGuid(),"Bronze Sword" , "Deals a samll amount of damage",20,DateTimeOffset.UtcNow)
        };
 
        [HttpGet]
        public IEnumerable<ItemDto> Get()
        {
            return items;
        }


        [HttpGet("{id}")]
        public ItemDto GetById(Guid id)
        {
            var item = items.Where(item => item.id == id).SingleOrDefault();
            return item;
        }
    }
}