using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Play.Catalog.Service.DTOs
{
    public record ItemDto(Guid Id, [Required] string Name, [Required] string Description, [Range(0, 1000)] decimal Price, DateTimeOffset CreatedDate);

    public record CreateItemDto([Required] string Name, [Required] string Description, [Range(0, 1000)] decimal Price);
    
    public record UpdateItemDto([Required] string Name, [Required] string Description, [Range(0, 1000)] decimal Price);
}