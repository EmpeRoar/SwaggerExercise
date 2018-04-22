using System;

namespace Swag.Api.Models
{
    public class Entity : IEntity
    {
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public DateTime Deleted { get; set ;}
        
    }
}