using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace LuisDelValle.WinningSolution.Abstractions
{
    public interface IDataService<T>
    {
        IEnumerable<T> GetAll();
        void Add(T item);
        T GetSingle(Expression<Func<T, bool>> predicate);
        IEnumerable<T> Query(Expression<Func<T, bool>> predicate);
    }
}
