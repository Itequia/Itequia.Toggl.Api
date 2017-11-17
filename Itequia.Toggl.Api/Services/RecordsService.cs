using Itequia.Toggl.Api.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Itequia.Toggl.Api.Data.Models;
using Itequia.Toggl.Api.Data.Repositories.Interfaces;

namespace Itequia.Toggl.Api.Services
{
    public class RecordsService : IRecordsService
    {
        private readonly IBaseRepository<Record> _baseRepository;

        public RecordsService(IBaseRepository<Record> repository)
        {
            _baseRepository = repository;
        }

        public List<Record> Get()
        {
            return _baseRepository.GetAll().ToList();    
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
            _baseRepository.Create(record);
            return record;            
        }

        public void Put(int id, Record record)
        { 
            _baseRepository.Update(record);            
        }

        public void Patch(int id, Record record)
        {
            _baseRepository.Update(record);            
        }

    }
}
