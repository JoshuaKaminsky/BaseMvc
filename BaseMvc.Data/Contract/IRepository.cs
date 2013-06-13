using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using BaseMvc.Data.Entity;

namespace BaseMvc.Data.Contract
{
    internal interface IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();

        IEnumerable<T> GetAll(Expression<Func<T, bool>> filter, List<string> includes = null);

        T Get(Expression<Func<T, bool>> filter, List<string> includes = null);

        T GetById(int id);

        T Add(T entity);

        T Update(T entity);

        bool Delete(T entity);

        bool Delete(int id);

        T Get(Func<T, bool> func);
    }
}
