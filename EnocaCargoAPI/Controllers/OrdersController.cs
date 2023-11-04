using EnocaCargoAPI.Models;
using EnocaCargoAPI.Repositories.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EnocaCargoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrdersRepository _ordersRepository;
        private readonly ICarriersRepository _carriersRepository;
        private readonly ICarrierConfigurationsRepository _carrierConfigurationsRepository;

        public OrdersController(IOrdersRepository ordersRepository, ICarriersRepository carriersRepository, ICarrierConfigurationsRepository carrierConfigurationsRepository)
        {
            _ordersRepository = ordersRepository;
            _carriersRepository = carriersRepository;
            _carrierConfigurationsRepository = carrierConfigurationsRepository;
        }

        [HttpGet]
        public List<Orders>? GetAll()
        {
            return _ordersRepository.GetAll().ToList();
        }

        [HttpGet("{id}")]
        public Orders? GetById(int id)
        {
            return _ordersRepository.GetById(id);
        }

        [HttpPost("{desi}")]
        public string? Add(int desi)
        {
            var x = _carrierConfigurationsRepository.GetAll().Where(x => x.CarrierMaxDesi > desi && x.CarrierMinDesi < desi).ToList();
            Console.WriteLine(x[0].CarrierCost);

            //_ordersRepository.Add(orders);
            return "Sipariş bilgisi eklendi";
        }

        [HttpDelete("{id}")]
        public string? Remove(int id)
        {
            _ordersRepository.RemoveById(id);
            return (id + " numaralı sipariş bilgisi silindi");
        }
    }
}
