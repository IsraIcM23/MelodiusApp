using BooksDataAccess.Persistence;
using MelodiusModels.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiusDataAccess.Repository.Base
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly MelodiusContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public BaseRepository(MelodiusContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }
        public async Task<bool> CreateAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
            var created = await _context.SaveChangesAsync();
            return created > 0;
        }

        public Task<bool> DeleteAsync(int id)
        {
            var entity = _dbSet.Find(id);
            _dbSet.Remove(entity);
            var deleted = _context.SaveChanges();
            return Task.FromResult(deleted > 0);
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public Task<bool> UpdateAsync(TEntity entity)
        {
            _dbSet.Update(entity);
            var updated = _context.SaveChanges();
            return Task.FromResult(updated > 0);

        }
    }
}