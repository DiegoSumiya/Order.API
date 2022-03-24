using System;

namespace Order.Domain.Models
{
    public abstract class EntityBase
    {
        public string Id { get; set; }
        public DateTime Created { get; set; }
    }
}
