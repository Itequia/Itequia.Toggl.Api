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

        int Delete(int id);
        Record Post(Record record);
        int Patch(int id, Record record);
    }
}
