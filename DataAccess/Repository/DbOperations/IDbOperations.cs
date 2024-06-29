using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.DbOperations
{
    public interface IDbOperations<T> where T : class
    {
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void RemoveRange (IEnumerable<T> entity);
        T Get(Expression<Func<T, bool>> filter);
        
        
    }
}
