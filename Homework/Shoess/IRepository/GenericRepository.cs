using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Shoess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shoess.IRepository;
using System.Linq.Expressions;

namespace Shoess.IRepository
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private ShoeDbContext _context;
        private DbSet<T> tables;

        public GenericRepository()
        {
            this._context = new ShoeDbContext();
            tables = _context.Set<T>();
        }
        public GenericRepository(ShoeDbContext _context)
        {
            this._context = _context;
            tables = _context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return tables.ToList();
        }
        public T GetById(object id)
        {
            return tables.Find(id);
        }
        public void Insert(T obj)
        {
            tables.Add(obj);
        }
        public void Update(T obj)
        {
            tables.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }
        public void Delete(object id)
        {
            T existing = tables.Find(id);
            tables.Remove(existing);
        }
        public void Save()
        {
            _context.SaveChanges();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> List()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> List(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(T entity)
        {
            throw new NotImplementedException();
        }
    }
}

