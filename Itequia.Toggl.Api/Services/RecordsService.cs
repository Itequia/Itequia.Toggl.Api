using Itequia.Toggl.Api.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Itequia.Toggl.Api.Data.Models;
using Itequia.Toggl.Api.Data.Repositories.Interfaces;
using Itequia.Toggl.Api.Extensions;

namespace Itequia.Toggl.Api.Services
{
    public class RecordsService : IRecordsService
    {
        private readonly IBaseRepository<Record> _baseRepository;

        public RecordsService(IBaseRepository<Record> repository)
        {
            _baseRepository = repository;
        }

        public List<Record> Get(string userId, string description = null, DateTime? end = null, DateTime? start = null, string projectName = null, string sort = null)
        {
            IQueryable<Record> result = _baseRepository.GetAll().Where(r => r.ApplicationUserId == userId);
            if (!string.IsNullOrEmpty(description))
            {                
                result = result.Where(r => r.Description.Contains(description));
            }
            if(end.HasValue)
            {
                result = result.Where(r => r.End.Value.Date == end.Value.Date);
            }
            if (start.HasValue)
            {
                result = result.Where(r => r.Start.Date == start.Value.Date);
            }
            if (!string.IsNullOrEmpty(projectName))
            {
                result = result.Where(r => r.Project.Name.Contains(projectName));
            }
            if (sort != null)
            {
                result.ApplySort<Record>(sort);
            }

            return result.ToList();    
        }

        public Record Get(string userId, int id)
        {
            Record record = _baseRepository.Get(id);
            if (record.ApplicationUserId != userId)
                throw new Exception("Requested record doesn't belong to logged user.");

            return record;
        }

        public void Delete(string userId, int id)
        {
            Record record = _baseRepository.Get(id);
            if (record == null)
                throw new Exception("Record not found");
            if (record.ApplicationUserId != userId)
                throw new Exception("Requested record doesn't belong to logged user.");

            _baseRepository.Delete(id);         
        }

        public Record Post(string userId, Record record)
        {
            if (record.Id != 0)
                throw new Exception("Can't create record with explicit id");

            record.ApplicationUserId = userId;
            _baseRepository.Create(record);
            return record;            
        }

        public void Put(string userId, int id, Record record)
        {
            Record dbRecord = _baseRepository.Get(id);
            if (dbRecord == null)
                throw new Exception("Record not found");
            if (dbRecord.ApplicationUserId != userId)
                throw new Exception("Requested record doesn't belong to logged user.");

            dbRecord.Description = record.Description;
            dbRecord.Start = record.Start;
            dbRecord.End = record.End;
            dbRecord.ProjectId = record.ProjectId;

            _baseRepository.Update(dbRecord);            
        }

        public void Patch(string userId, int id, Record record)
        {
            Record dbRecord = _baseRepository.Get(id);
            if (dbRecord == null)
                throw new Exception("Record not found");
            if (dbRecord.ApplicationUserId != userId)
                throw new Exception("Requested record doesn't belong to logged user.");

            _baseRepository.Patch(id, record);            
        }

    }
}
