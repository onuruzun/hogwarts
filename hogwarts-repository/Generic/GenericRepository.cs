using System.Linq;
using System.Threading.Tasks;
using hogwarts_repository.Context;
using hogwarts_repository.Models.Base;
using Microsoft.EntityFrameworkCore;

namespace hogwarts_repository.Generic
{
    public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly ApplicationDbContext _dbContext;
        public GenericRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<bool> Create(TEntity entity)
        {
            await _dbContext.Set<TEntity>().AddAsync(entity);

            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> Delete(int id)
        {
            var result = await GetById(id);
            _dbContext.Set<TEntity>().Remove(result);

            return await _dbContext.SaveChangesAsync() > 0;
        }

        public IQueryable<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>().AsNoTracking();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _dbContext.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(q => q.Id == id);
        }

        public async Task<bool> Update(TEntity entity)
        {
            _dbContext.Update<TEntity>(entity);
            return await _dbContext.SaveChangesAsync() > 0;
        }
    }
}