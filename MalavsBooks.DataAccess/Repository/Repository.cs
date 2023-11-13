using MalavsBooks.DataAccess.Repository.IRepository;
using MalavsBookStore.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MalavsBooks.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        // modify the database w/ the db context
        private readonly ApplicationDbContext _db; // Get the db instance using the constructor and DI
        internal DbSet<T> dbSet;

        public Repository(ApplicationDbContext db) // use hot key C-T-O-R to build  the Constructor
        {
            _db = db;
            this.dbSet = db.Set<T>();
        }
        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<T> entity)
        {
            throw new NotImplementedException();
        }
    }
}
