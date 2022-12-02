using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Shoess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shoess.IRepository;

namespace Shoess.IRepository
{
    public interface GenericRepository<T> : IRepository<T> where T : class
    {
        private ShoeDbContext _context;
        private DbSet<T> tables;
        public GenericRepository()
        {
            this._context = new ShoeDbContext<T>();
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
    }
}

