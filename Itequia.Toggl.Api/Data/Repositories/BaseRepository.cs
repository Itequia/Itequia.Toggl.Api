using Itequia.Toggl.Api.Data.Models;
using Itequia.Toggl.Api.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;



namespace Itequia.Toggl.Api.Data.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseModel
    {
        private readonly ApplicationDbContext _db;

        public BaseRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public void Create(T item)
        {
            _db.Set<T>().Add(item);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            T item = _db.Set<T>().Find(id);
            if (item == null) throw new Exception("Object not found");
            _db.Set<T>().Remove(item);
            _db.SaveChanges();
        }

        public T Get(int id)
        {
            return _db.Set<T>().Find(id);
        }

        public void Update(T item)
        {
            _db.Set<T>().Update(item);
            _db.SaveChanges();
        }

        public void Patch (int id, T item)
        {
            T entity = _db.Set<T>().Find(id);
            foreach (PropertyInfo propertyInfo in entity.GetType().GetProperties())
            {
                if (propertyInfo.PropertyType == typeof(string))
                {
                    if (!string.IsNullOrEmpty((string)item.GetType().GetProperty(propertyInfo.Name).GetValue(item, null))) {
                        entity.GetType().GetProperty(propertyInfo.Name).SetValue(entity, item.GetType().GetProperty(propertyInfo.Name).GetValue(item, null));
                    }
                }
                else if (propertyInfo.PropertyType == typeof(int))
                {
                    if ((int)item.GetType().GetProperty(propertyInfo.Name).GetValue(item, null) != 0)
                    {
                        entity.GetType().GetProperty(propertyInfo.Name).SetValue(entity, item.GetType().GetProperty(propertyInfo.Name).GetValue(item, null));
                    }
                }
                else  if (propertyInfo.PropertyType == typeof(DateTime))
                {
                    if ((DateTime)item.GetType().GetProperty(propertyInfo.Name).GetValue(item, null) != DateTime.MinValue)
                    {
                        entity.GetType().GetProperty(propertyInfo.Name).SetValue(entity, item.GetType().GetProperty(propertyInfo.Name).GetValue(item, null));
                    }
                }
                else if (propertyInfo.PropertyType == typeof(DateTime?))
                {
                    if ((DateTime?)item.GetType().GetProperty(propertyInfo.Name).GetValue(item, null) != null)
                    {
                        entity.GetType().GetProperty(propertyInfo.Name).SetValue(entity, item.GetType().GetProperty(propertyInfo.Name).GetValue(item, null));
                    }
                }
                _db.Entry(entity).State = EntityState.Modified;
                _db.SaveChanges();

            }
        }



        public IQueryable<T> GetAll()
        {

            return _db.Set<T>();
            
        }

        
    }
}
