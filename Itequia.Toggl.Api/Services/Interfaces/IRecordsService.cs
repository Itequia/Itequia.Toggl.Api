using Itequia.Toggl.Api.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Itequia.Toggl.Api.Services.Interfaces
{
    public interface IRecordsService
    {
        List<Record> Get();
        Record Get(int id);
        Record Post(Record record);
        void Put(int id, Record record);
        void Patch(int id, Record record);
        void Delete(int id);
    }
}
