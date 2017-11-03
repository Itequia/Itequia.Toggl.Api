using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Itequia.Toggl.Api.Data.Models
{
    public class Record : BaseModel
    {
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime? End { get; set; }

        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
