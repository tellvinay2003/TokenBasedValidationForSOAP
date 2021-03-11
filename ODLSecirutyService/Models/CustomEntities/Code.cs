using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ODLSecirutyService.Models.CustomEntities
{
    public enum Code
    {
        success = 1,
        validationError = 2,
        dataNotFound = 3,
        exceptionError = 4
    }
}
