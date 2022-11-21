using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace ProSales.Domain.Identity
{
    public class Role : IdentityRole<int>
    {
        public List<UserRole>? UserRoles { get; set; }
        public Guid ExternalId { get; set; } = Guid.NewGuid();

    }
}