using EnocaCargoAPI.Models;
using EnocaCargoAPI.Repositories.Abstract;

namespace EnocaCargoAPI.Repositories.Concrete
{
    public class CarriersRepository : GenericRepository<Carriers>, ICarriersRepository
    {
        public CarriersRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
