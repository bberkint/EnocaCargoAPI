using EnocaCargoAPI.Models;
using EnocaCargoAPI.Repositories.Abstract;

namespace EnocaCargoAPI.Repositories.Concrete
{
    public class OrdersRepository : GenericRepository<Orders>, IOrdersRepository
    {
        public OrdersRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
