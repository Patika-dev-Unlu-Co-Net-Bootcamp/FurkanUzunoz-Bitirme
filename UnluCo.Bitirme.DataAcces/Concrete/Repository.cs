using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Bitirme.DataAcces.Interface;
using UnluCo.Bitirme.Entity.Entities;

namespace UnluCo.Bitirme.DataAcces.Concrete
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly DbContextOperation _DbContext;
        public Repository(DbContextOperation dbcontext)
        {
            _DbContext = dbcontext;
        }
        public async Task Create(TEntity model)
        {
            await _DbContext.Set<TEntity>().AddAsync(model);
        }

        public async Task Delete(int id)
        {
            var entity = await GetbyId(id) ;
            await Task.Run(() => { _DbContext.Set<TEntity>().Remove(entity); }); 
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await _DbContext.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetbyId(int id)
        {
            var result= await _DbContext.Set<TEntity>().FindAsync(id) ;
            return result;
        }

        public async Task Update(TEntity model)
        {
            await Task.Run(() => { _DbContext.Set<TEntity>().Update(model); });
            
        }
    }
}
