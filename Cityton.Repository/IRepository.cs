using System;
using System.Collections.Generic;
using System.Text;
using Cityton.Data;

namespace Cityton.Repository
{
    public interface IRepository<T> where T : BaseEntities
    {

        IEnumerable<T> GetAll();
        T Get(long id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entity);
        void SaveChanges();

    }
}