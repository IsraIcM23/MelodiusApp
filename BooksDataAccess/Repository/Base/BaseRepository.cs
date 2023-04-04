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
        //public async Task<bool> CreateAsync(TEntity entity)
        //{
        //    await _dbSet.AddAsync(entity);
        //    var created = await _context.SaveChangesAsync();
        //    return created > 0;
        //}

        //public Task<bool> DeleteAsync(int id)
        //{
        //    var entity = _dbSet.Find(id);
        //    _dbSet.Remove(entity);
        //    var deleted = _context.SaveChanges();
        //    return Task.FromResult(deleted > 0);
        //}

        //public async Task<List<TEntity>> GetAllAsync()
        //{
        //    return await _dbSet.ToListAsync();
        //}

        //public async Task<TEntity> GetByIdAsync(int id)
        //{
        //    return await _dbSet.FindAsync(id);
        //}

        //public Task<bool> UpdateAsync(TEntity entity)
        //{
        //    _dbSet.Update(entity);
        //    var updated = _context.SaveChanges();
        //    return Task.FromResult(updated > 0);

        //}

        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            var createdEntity = await _dbSet.AddAsync(entity);
            var newEntity = createdEntity.Entity;

            await _context.SaveChangesAsync();

            return newEntity;
        }

        public async Task<TEntity> DeleteAsync(int id)
        {
            var entityToDelete = await _dbSet.FindAsync(id);

            if (entityToDelete == null)
                throw new Exception("Entity not found");

            _dbSet.Remove(entityToDelete);
            return entityToDelete;
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
           
        }

        public Task<TEntity> GetByIdAsync(int id)
        {
            var test = _dbSet.Where(x => x.Id == id);
            return _dbSet.Where(x => x.Id == id).FirstAsync();
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }


    }
}
