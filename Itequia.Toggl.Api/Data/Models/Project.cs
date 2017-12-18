using Itequia.Toggl.Api.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Itequia.Toggl.Api.Data.Models
{
    public class Project : BaseModel
    {
        public string Name { get; set; }
        public Status Status { get; set; }
    }

    
}
