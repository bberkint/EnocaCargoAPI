using System.Security.Principal;

namespace EnocaCargoAPI.Repositories.Abstract
{
    public interface IGenericRepository<T> where T : class
    {
        // CRUD Operations
        T? Add(T entity);
        IQueryable<T>? GetAll();
        T? GetById(int id);
        T? RemoveById(int id);
        T? Update(T entity);
    }
}
