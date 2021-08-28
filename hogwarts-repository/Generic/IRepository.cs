using System.Linq;
using System.Threading.Tasks;
using hogwarts_repository.Models.Base;

namespace hogwarts_repository.Generic
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        IQueryable<TEntity> GetAll();
        Task<TEntity> GetById(int id);
        Task<bool> Create(TEntity entity);
        Task<bool> Update(TEntity entity);
        Task<bool> Delete(int id);
    }
}