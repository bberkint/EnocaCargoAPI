using EnocaCargoAPI.Models;
using EnocaCargoAPI.Repositories.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace EnocaCargoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarriersController : ControllerBase
    {
        private readonly ICarriersRepository _carriersRepository;

        public CarriersController(ICarriersRepository carriersRepository)
        {
            _carriersRepository = carriersRepository;
        }

        [HttpGet]
        public List<Carriers>? GetAll()
        {
            return _carriersRepository.GetAll().ToList();
        }

        [HttpGet("{id}")]
        public Carriers? GetById(int id)
        {
            return _carriersRepository.GetById(id);
        }

        [HttpPost]
        public string? Add(Carriers carriers)
        {
            _carriersRepository.Add(carriers);
            return "Kargo bilgisi eklendi";
        }

        [HttpPut]
        public string? Update(Carriers carriers)
        {
            _carriersRepository.Update(carriers);
            return (carriers.CarrierId + " numaralı kargo bilgisi güncellendi");
        }

        [HttpDelete("{id}")]
        public string? Remove(int id)
        {
            _carriersRepository.RemoveById(id);
            return (id + " numaralı kargo bilgisi silindi");
        }
    }
}
