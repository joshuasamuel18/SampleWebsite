using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Data.Objects;

namespace Sample.Data.IRepository
{
  public  interface IRepository<T>:IDisposable where T:class
    {
        IQueryable<T> Fetch();

        IEnumerable<T> GetAll();

        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);

        T Single(Expression<Func<T, bool>> predicate);

        T First(Expression<Func<T, bool>> predicate);

        void Add(T entity);

        void Delete(T entity);

        void Attach(T entity);

        void SaveChanges();

        void SaveChanges(SaveOptions options);
    }
}
