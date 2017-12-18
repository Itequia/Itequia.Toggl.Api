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

        public List<Record> Get(string description = null, DateTime? end = null, DateTime? start = null, string projectName = null, string sort = null)
        {
            IQueryable<Record> result = _baseRepository.GetAll();
            if (!String.IsNullOrEmpty(description))
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
            if (!String.IsNullOrEmpty(projectName))
            {
                result = result.Where(r => r.Project.Name.Contains(projectName));
            }
            if (sort != null)
            {
                result.ApplySort<Record>(sort);
            }

            return result.ToList();    
        }

        public Record Get(int id)
        {
            return _baseRepository.Get(id);  
        }

        public void Delete(int id)
        {            
             _baseRepository.Delete(id);         
        }

        public Record Post(Record record)
        {
            if (record.Id != 0) throw new Exception("Can't create record with explicit id"); 
            _baseRepository.Create(record);
            return record;            
        }

        public void Put(int id, Record record)
        { 
            _baseRepository.Update(record);            
        }

        public void Patch(int id, Record record)
        {
            _baseRepository.Patch(id, record);            
        }

    }
}
