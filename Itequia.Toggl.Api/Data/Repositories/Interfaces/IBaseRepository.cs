using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Itequia.Toggl.Api.Data.Models;

namespace Itequia.Toggl.Api.Data.Repositories.Interfaces
{
    public interface IBaseRepository<T>
    {
        IQueryable<T> GetAll();
        T Get(int id);
        void Create(T item);
        void Update(T item);
        void Delete(int id);

        void Patch(int id, T item);
        
    }
}
