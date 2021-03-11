using System;
using System.Collections.Generic;

namespace OdlAuthService.Models
{
    public partial class VwAspnetUsersInRoles
    {
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }
    }
}
