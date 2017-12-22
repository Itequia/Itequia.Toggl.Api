using Itequia.Toggl.Api.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Itequia.Toggl.Api.Services.Interfaces
{
    public interface IRecordsService
    {
        List<Record> Get(string userId, string description = null, DateTime? end = null, DateTime? start = null, string projectName = null, string sort = null);
        Record Get(string userId, int id);
        Record Post(string userId, Record record);
        void Put(string userId, int id, Record record);
        void Patch(string userId, int id, Record record);
        void Delete(string userId, int id);
    }
}
