
using System;

namespace Core.Entities.Concrete
{
    public class OperationClaim : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public string Description { get; set; }

    }
}
