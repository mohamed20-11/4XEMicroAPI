using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Play.Catalog.Service.Dtos
{
    public class Dtos
    {
        public record ItemDto(Guid id , string Name , string Description , decimal Price , DateTimeOffset  CreatdDAte);
        public record CreateItemDto(string Name, string Description , decimal Pricde);        
        public record UpdateItemDto(string Name, string Description , decimal Pricde);        
    }
}