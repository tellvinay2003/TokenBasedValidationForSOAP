using System;
using System.Collections.Generic;

namespace OdlAuthService.Models
{
    public partial class VwAspnetProfiles
    {
        public Guid UserId { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public int? DataSize { get; set; }
    }
}
