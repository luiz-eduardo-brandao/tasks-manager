using TasksManager.API.Models.Base;

namespace TasksManager.API.Repositories.Interfaces.Base
{
    public interface IRepositoryBase<TEntity> where TEntity : BaseEntity
    {
        public Task<List<TEntity>> GetAllAsync();
        public Task<TEntity?> GetByIdAsync(Guid id);
        public Task<TEntity?> AddAsync(TEntity entity);
        public Task<TEntity?> UpdateAsync(TEntity entity);
        public Task DeleteAsync(TEntity entity);
    }
}
