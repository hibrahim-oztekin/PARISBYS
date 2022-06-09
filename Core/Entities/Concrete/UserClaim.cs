
using System;

namespace Core.Entities.Concrete
{
    public class UserClaim : IEntity
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid ClaimId { get; set; }
    }
}
