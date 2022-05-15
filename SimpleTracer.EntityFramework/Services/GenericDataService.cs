using Microsoft.EntityFrameworkCore;
using SimpleTrader.Domain.Models;
using SimpleTrader.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTracer.EntityFramework.Services
{
    public class GenericDataService<T> : IDataService<T> where T : DomanObject
    {
        private readonly DesignDbContextFactory factpry;

        public GenericDataService(DesignDbContextFactory factpry)
        {
            this.factpry = factpry;
        }
        public async Task<T> Create(T entity)
        {
            using (var context = factpry.CreateDbContext())
            {
                var createEntity = await context.Set<T>().AddAsync(entity);
                await context.SaveChangesAsync();
                return createEntity.Entity;
            }
        }

        public async Task<bool> Delete(int id)
        {
           using(var context = factpry.CreateDbContext())
            {
                var enty = await context.Set<T>().FirstOrDefaultAsync(e=>e.ID == id);
                context.Set<T>().Remove(enty);
                await context.SaveChangesAsync();
                return true;
            }
        }

        public async IAsyncEnumerable<T> GetAll()
        {
            using (var context = factpry.CreateDbContext())
            {
                var enty = from T in context.Set<T>() select T;
                foreach(var e in enty)
                {
                    yield return e;
                }
            }
        }

        public async Task<T> GetById(int id)
        {
            using(var context = factpry.CreateDbContext())
            {
                return await context.Set<T>().FirstOrDefaultAsync(e => e.ID == id);
            }
        }

        public Task<T> Update(int id, T entity)
        {
            throw new NotImplementedException();
        }
    }
}
