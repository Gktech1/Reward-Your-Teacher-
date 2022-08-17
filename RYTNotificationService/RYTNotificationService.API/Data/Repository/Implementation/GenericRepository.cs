using Microsoft.EntityFrameworkCore;
using RYTNotificationService.API.Data.Repository.Interfaces;

namespace RYTNotificationService.API.Data.Repository.Implementation
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DataContext _dbContext;
        private readonly DbSet<T> _table;
        public GenericRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
            _table = _dbContext.Set<T>();
        }
        public async Task AddAsync(T data)
        {
            await _table.AddAsync(data);
        }
        public void Attach(T data)
        {
            _table.Attach(data);
            _dbContext.Entry(data).State = EntityState.Modified;
        }
        public void AddRange(ICollection<T> data)
        {
            _table.AddRange(data);
        }
        public void Delete(T data)
        {
            _table.Remove(data);
        }
        public void Update(T data)
        {
            _table.Update(data);
        }

    }
}
