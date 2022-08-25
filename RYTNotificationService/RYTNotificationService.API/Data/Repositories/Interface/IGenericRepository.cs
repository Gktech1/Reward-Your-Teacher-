namespace RYTNotificationService.API.Data.Repositories.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        Task AddAsync(T data);
        void AddRange(ICollection<T> data);
        void Attach(T data);
        void Delete(T data);
        void Update(T data);
    }
}
