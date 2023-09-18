using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly ApiFarmaciaContext _context;

        public GenericRepository(ApiFarmaciaContext context){
            _context = context;
        }
        
        
            public virtual void Add(T entity)
            {
                _context.Set<T>().Add(entity);
            }
        
            public virtual void AddRange(IEnumerable<T> entities)
            {
                _context.Set<T>().AddRange(entities);
            }
        
            public virtual IEnumerable<T> Find(Expression<Func<T, bool>> expression)
            {
                return _context.Set<T>().Where(expression);
            }
        
            public virtual async Task<IEnumerable<T>> GetAllAsync()
            {
                return await _context.Set<T>().ToListAsync();
            }
        
            public Task<T> GetAsync(int id)
            {
                throw new NotImplementedException();
            }
        
            public virtual async Task<T> GetByIdAsync(int id)
            {
                return await _context.Set<T>().FindAsync(id);
            }
        
            public virtual Task<T> GetByIdAsync(string id)
            {
                throw new NotImplementedException();
            }
        
            public virtual void Remove(T entity)
            {
                _context.Set<T>().Remove(entity);
            }
        
            public virtual void RemoveRange(IEnumerable<T> entities)
            {
                _context.Set<T>().RemoveRange(entities);
            }
        
            public virtual void Update(T entity)
            {
                _context.Set<T>()
                    .Update(entity);
            }
    }
}