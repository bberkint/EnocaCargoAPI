using EnocaCargoAPI.Models;
using EnocaCargoAPI.Repositories.Abstract;

namespace EnocaCargoAPI.Repositories.Concrete
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly AppDbContext _appDbContext;

        public GenericRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public T? Add(T entity)
        {
            _appDbContext.Set<T>().Add(entity);
            _appDbContext.SaveChanges();
            return entity;
        }

        public IQueryable<T>? GetAll()
        {
            return _appDbContext.Set<T>().AsQueryable();
        }

        public T? GetById(int id)
        {
            return _appDbContext.Set<T>().Find(id);
        }

        public T? RemoveById(int id)
        {
            var _entity = _appDbContext.Set<T>().Find(id);

            if (_entity == null)
                return null;

            _appDbContext.Set<T>().Remove(_entity);
            _appDbContext.SaveChanges();

            return _entity;
        }

        public T? Update(T entity)
        {
            _appDbContext.Update(entity);
            _appDbContext.SaveChanges();

            return entity;
        }
    }
}
