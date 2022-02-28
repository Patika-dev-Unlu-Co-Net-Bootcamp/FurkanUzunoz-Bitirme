using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnluCo.Bitirme.Entity.Entities;

namespace UnluCo.Bitirme.DataAcces.Interface
{
    public interface IRepository<TEntity> where TEntity:class 
    {
        Task<List<TEntity>> GetAll();
        Task<TEntity> GetbyId(int id);
        Task Create (TEntity model);
        Task Update(TEntity model);
        Task Delete(int id);
        
    }
}
