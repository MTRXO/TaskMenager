using DataAcces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.DbOperations
{
    public class DbOperations<T> : IDbOperations<T> where T : class
    {
        private readonly ApplicationDBContext _db;
        private readonly DbSet<T> _dbSet;
        public DbOperations(ApplicationDBContext db )
        {
            _db = db;
            _dbSet =  db.Set<T>();
        }
        public void Add(T entity)
        {
            _dbSet.Add( entity );   
        }

        public void Delete(T entity)
        {
           _dbSet.Remove( entity );
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = _dbSet;
            query = query.Where( filter );
            return query.FirstOrDefault();
        }

        public IEnumerable<T> GetAll()
        {
            IEnumerable<T> content = _dbSet;
            return content.ToList();
        }

        public void RemoveRange(IEnumerable<T> entity)
        {
            _dbSet.RemoveRange(entity);
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }
    }

}
