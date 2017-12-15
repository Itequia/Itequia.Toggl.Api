using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Itequia.Toggl.Api.Data.DTO
{
    public class RecordDTO
    {
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime? End { get; set; }
        public int ProjectId { get; set; }
        public int UserId { get; set; }
    }
}
