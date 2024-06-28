using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.DbOperations
{
    public interface IDbOperations<T> where T : class
    {
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Updater(T entity);
        void Delete(T entity);
        void RemoveRange (IEnumerable<T> entity);
        
    }
}
