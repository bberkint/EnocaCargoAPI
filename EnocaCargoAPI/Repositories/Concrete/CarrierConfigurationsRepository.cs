using EnocaCargoAPI.Models;
using EnocaCargoAPI.Repositories.Abstract;

namespace EnocaCargoAPI.Repositories.Concrete
{
    public class CarrierConfigurationsRepository : GenericRepository<CarrierConfigurations>, ICarrierConfigurationsRepository
    {
        public CarrierConfigurationsRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
